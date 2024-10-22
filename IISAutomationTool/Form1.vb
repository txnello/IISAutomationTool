Imports System.IO
Imports System.Net
Imports System.Xml
Imports Newtonsoft.Json

Public Class IISAutomationTool

    Dim toolVersion As Integer

    Public Sub New()
        InitializeComponent()

        toolVersion = 2
        Info.Text += "1.1"

        Dim webClient As New System.Net.WebClient
        Dim result As String = webClient.DownloadString("https://raw.githubusercontent.com/txnello/IISAutomationTool/refs/heads/master/IISAutomationToolSettings/_settings.json")
        Dim json = JsonConvert.DeserializeObject(result)

        If json("programAvailability") Then
            If json("updateVersion").value > toolVersion Then
                If (MessageBox.Show("A new version (v" + json("updateExtendedVersion").ToString() + ") is now available. Do you want to download it?", "Visit", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) = DialogResult.Yes) Then
                    Dim updateUrl As String = json("updateUrl").ToString()
                    LaunchUrl(updateUrl)
                End If
            End If

            GetEnvironment.Enabled = My.Settings.CRMPath.Count > 0 AndAlso My.Settings.CRMPath.Count > 0

            CRMPath.Text = If(My.Settings.CRMPath, "")
            HDAPath.Text = If(My.Settings.HDAPath, "")

            CRMPath.Enabled = True
            HDAPath.Enabled = True
            SetPath.Enabled = True
            RefreshPool.Enabled = True
        End If
    End Sub

    Private Sub LaunchUrl(url As String)
        If Not url.StartsWith("http://") And Not url.StartsWith("https://") Then
            url = "https://" & url
        End If

        Dim psi As New ProcessStartInfo()
        psi.FileName = url
        psi.UseShellExecute = True

        Process.Start(psi)
    End Sub

    Private Sub GetEnvironment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GetEnvironment.SelectedIndexChanged
        ' load CRM configuration
        Dim envPath As String = CRMPath.Text
        GetProject.Items.Clear()

        ' change if HDA is selected
        If GetEnvironment.Text = "HDA" Then
            envPath = HDAPath.Text
        End If

        ' add Trunk as default
        GetProject.Items.Add("Trunk")

        ' read project folders
        Dim path As String = envPath + "\Tags_" + GetEnvironment.Text
        If Directory.Exists(path) Then
            For Each Dir As String In Directory.GetDirectories(path)
                GetProject.Items.Add(Dir.Substring(Dir.LastIndexOf("\") + 1))
            Next
        End If

        ' enable the other combo
        GetProject.Text = ""
        GetProject.Enabled = True
    End Sub

    Private Sub GetProject_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GetProject.SelectedIndexChanged
        UpdateConfiguration.Enabled = True
    End Sub

    Private Function UpdateXML(configuration As XDocument, env As String, proj As String, application As String) As XDocument
        ' load Portal configuration
        Dim tagName As String = "/PortalAuto"
        Dim suffix As String = "\PAT.CRM.Portal\PAT.CRM.Portal"
        My.Settings.PortalPath = env + proj + suffix

        ' change if WSC4 is selected
        If application = "wsc4" Then
            tagName = "/WSC4Auto"
            suffix = "\PAT.CRM.WSC4\PAT.CRM.WSC4"
            My.Settings.WSC4Path = env + proj + suffix
        End If

        ' edit XML file
        Dim applicationElement As XElement = configuration.Descendants("application").
            Where(Function(ex) ex.Attribute("path")?.Value = tagName).FirstOrDefault()

        If applicationElement IsNot Nothing Then
            Dim virtualDirectoryElement As XElement = applicationElement.Element("virtualDirectory")
            If virtualDirectoryElement IsNot Nothing Then
                virtualDirectoryElement.SetAttributeValue("physicalPath", env + proj + suffix)
            End If
        End If

        Return configuration
    End Function

    Private Sub UpdateConfiguration_Click(sender As Object, e As EventArgs) Handles UpdateConfiguration.Click
        Try
            ' select environment path
            Dim env = My.Settings.CRMPath
            If GetEnvironment.Text = "HDA" Then
                env = My.Settings.HDAPath
            End If

            ' select project path
            Dim proj = GetProject.Text
            If proj = "Trunk" Then
                proj = "\" + proj + "11"
            Else
                proj = "\Tags_" + GetEnvironment.Text + "\" + proj
            End If

            ' read XML
            Dim configuration = XDocument.Load("C:\Windows\System32\inetsrv\config\applicationHost.config")

            ' edit Portal and WSC4 configurations
            configuration = UpdateXML(configuration, env, proj, "portal")
            configuration = UpdateXML(configuration, env, proj, "wsc4")

            ' save XML
            configuration.Save("C:\Windows\System32\inetsrv\config\applicationHost.config")

            MessageBox.Show("Successfully updated!")

            OpenPortalLogs.Enabled = True
            OpenWSCLogs.Enabled = True

            OpenPortal.Enabled = True
            OpenWSC4.Enabled = True

            OpenPortalErrorLogTail.Enabled = True
            OpenWSC4ErrorLogTail.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Error saving configuration.")
        End Try
    End Sub

    Private Sub RefreshPool_Click(sender As Object, e As EventArgs) Handles RefreshPool.Click
        Try
            System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() & "\..\..\..\refreshPool.bat")
        Catch ex As Exception
            MessageBox.Show("Cannot find batch file.")
        End Try
    End Sub

    Private Sub SetPath_Click(sender As Object, e As EventArgs) Handles SetPath.Click
        If CRMPath.Text.Count > 0 AndAlso HDAPath.Text.Count > 0 Then
            My.Settings.CRMPath = CRMPath.Text
            My.Settings.HDAPath = HDAPath.Text
            My.Settings.Save()

            MessageBox.Show("Successfully set!")

            GetEnvironment.Enabled = True
        Else
            MessageBox.Show("Insert correct paths.")
        End If
    End Sub

    Private Sub OpenPortalLogs_Click(sender As Object, e As EventArgs) Handles OpenPortalLogs.Click
        Try
            Shell("explorer " + My.Settings.PortalPath + "\Logs", AppWinStyle.NormalFocus)
        Catch ex As Exception
            MessageBox.Show("Cannot open Portal logs for some reasons. Try later or pray your own god.")
        End Try
    End Sub

    Private Sub OpenWSCLogs_Click(sender As Object, e As EventArgs) Handles OpenWSCLogs.Click
        Try
            Shell("explorer " + My.Settings.WSC4Path + "\Logs", AppWinStyle.NormalFocus)
        Catch ex As Exception
            MessageBox.Show("Cannot open WSC4 logs for some reasons. Try later or pray your own god.")
        End Try
    End Sub

    Private Sub OpenPowershell(scriptPath As String, pathParameter As String)
        Dim startInfo As New ProcessStartInfo()
        startInfo.FileName = "cmd.exe"
        startInfo.Arguments = $"/c start powershell.exe -NoProfile -ExecutionPolicy Bypass -File ""{scriptPath}"" -Path ""{pathParameter}"""
        startInfo.UseShellExecute = False
        startInfo.CreateNoWindow = False

        Dim process As New Process()
        process.StartInfo = startInfo
        process.Start()
    End Sub

    Private Sub OpenPortalErrorLogTail_Click(sender As Object, e As EventArgs) Handles OpenPortalErrorLogTail.Click
        Try
            Dim combinedPath As String = Path.Combine(Directory.GetCurrentDirectory(), "..\..\..\LogTailIISAutomationTool.ps1")
            Dim absolutePath As String = Path.GetFullPath(combinedPath)

            OpenPowershell(absolutePath, My.Settings.PortalPath & "\Logs\error-log.txt")
        Catch ex As Exception
            MessageBox.Show("Cannot open Portal log tail for some reasons. Try later or pray your own god.")
        End Try
    End Sub

    Private Sub OpenWSC4ErrorLogTail_Click(sender As Object, e As EventArgs) Handles OpenWSC4ErrorLogTail.Click
        Try
            Dim combinedPath As String = Path.Combine(Directory.GetCurrentDirectory(), "..\..\..\LogTailIISAutomationTool.ps1")
            Dim absolutePath As String = Path.GetFullPath(combinedPath)

            OpenPowershell(absolutePath, My.Settings.WSC4Path & "\Logs\error-log.txt")
        Catch ex As Exception
            MessageBox.Show("Cannot open WSC4 log tail for some reasons. Try later or pray your own god.")
        End Try
    End Sub

    Public Sub OpenApplication(env As String)
        Dim appName As String = "/PortalAuto"

        If env = "wsc4" Then
            appName = "/WSC4Auto/WSConnector.svc"
        End If

        Dim xmlDoc As New XmlDocument()
        xmlDoc.Load("C:\Windows\System32\inetsrv\config\applicationHost.config")

        Dim xpath As String = "//site/application[@path='/PortalAuto']/parent::site/bindings/binding"
        Dim nodeList As XmlNodeList = xmlDoc.SelectNodes(xpath)

        For Each node As XmlNode In nodeList
            Dim protocol As String = node.Attributes("protocol").Value
            Dim bindingInformation As String = node.Attributes("bindingInformation").Value
            Dim port As String = bindingInformation.Split(":"c)(1)
            Console.WriteLine($"Protocollo: {protocol}, Porta: {port}")

            LaunchUrl(protocol & "://localhost:" & port & appName)
        Next
    End Sub

    Private Sub OpenPortal_Click(sender As Object, e As EventArgs) Handles OpenPortal.Click
        OpenApplication("portal")
    End Sub

    Private Sub OpenWSC4_Click(sender As Object, e As EventArgs) Handles OpenWSC4.Click
        OpenApplication("wsc4")
    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            Me.ShowInTaskbar = False
            NotifyIcon1.Visible = True
        End If
    End Sub

    Private Sub NotifyIcon1_Click(sender As Object, e As System.EventArgs) Handles NotifyIcon1.Click
        Me.WindowState = FormWindowState.Normal
        Me.ShowInTaskbar = True
        NotifyIcon1.Visible = False
    End Sub
End Class
