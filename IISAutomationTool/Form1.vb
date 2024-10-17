Imports System.IO

Public Class IISAutomationTool
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
        GetProject.Enabled = True
    End Sub

    Private Sub GetProject_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GetProject.SelectedIndexChanged
        UpdateConfiguration.Enabled = True
    End Sub

    Private Function UpdateXML(configuration As XDocument, env As String, proj As String, application As String) As XDocument
        ' load Portal configuration
        Dim tagName As String = "/PortalAuto"
        Dim suffix As String = "\PAT.CRM.Portal\PAT.CRM.Portal"

        ' change if WSC4 is selected
        If application = "wsc4" Then
            tagName = "/WSC4Auto"
            suffix = "\PAT.CRM.WSC4\PAT.CRM.WSC4"
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
        ' select environment path
        Dim env As String = My.Settings.CRMPath
        If GetEnvironment.Text = "HDA" Then
            env = My.Settings.HDAPath
        End If

        ' select project path
        Dim proj As String = GetProject.Text
        If proj = "Trunk" Then
            proj = "\" + proj + "11"
        Else
            proj = "\Tags_" + GetEnvironment.Text + "\" + proj
        End If

        ' read XML
        Dim configuration As XDocument = XDocument.Load("C:\Windows\System32\inetsrv\config\applicationHost.config")

        ' edit Portal and WSC4 configurations
        configuration = UpdateXML(configuration, env, proj, "portal")
        configuration = UpdateXML(configuration, env, proj, "wsc4")

        ' save XML
        configuration.Save("C:\Windows\System32\inetsrv\config\applicationHost.config")
    End Sub

    Private Sub RefreshPool_Click(sender As Object, e As EventArgs) Handles RefreshPool.Click
        System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() & "\..\..\..\refreshPool.bat")
    End Sub

    Private Sub SetPath_Click(sender As Object, e As EventArgs) Handles SetPath.Click
        If (CRMPath.Text.Count > 0 AndAlso HDAPath.Text.Count > 0) Then
            My.Settings.CRMPath = CRMPath.Text
            My.Settings.HDAPath = HDAPath.Text
            My.Settings.Save()

            GetEnvironment.Enabled = True
        End If
    End Sub
End Class
