Imports System.IO

Public Class IISAutomationTool
    Private Sub GetEnvironment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GetEnvironment.SelectedIndexChanged
        Dim envPath As String = CRMPath.Text
        GetProject.Items.Clear()

        If GetEnvironment.Text = "HDA" Then
            envPath = HDAPath.Text
        End If

        GetProject.Items.Add("Trunk")

        Dim path As String = envPath + "\Tags_" + GetEnvironment.Text
        If Directory.Exists(path) Then
            For Each Dir As String In Directory.GetDirectories(path)
                GetProject.Items.Add(Dir.Substring(Dir.LastIndexOf("\") + 1))
            Next
        End If

        GetProject.Enabled = True
    End Sub

    Private Sub GetProject_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GetProject.SelectedIndexChanged
        UpdateConfiguration.Enabled = True
    End Sub

    Private Function UpdateXML(configuration As XDocument, env As String, proj As String, application As String) As XDocument
        Dim tagName As String = "/PortalAuto"
        Dim suffix As String = "\PAT.CRM.Portal\PAT.CRM.Portal"

        If application = "wsc4" Then
            tagName = "/WSC4Auto"
            suffix = "\PAT.CRM.WSC4\PAT.CRM.WSC4"
        End If

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
        Dim env As String = My.Settings.CRMPath
        If GetEnvironment.Text = "HDA" Then
            env = My.Settings.HDAPath
        End If

        Dim proj As String = GetProject.Text
        If proj = "Trunk" Then
            proj = "\" + proj + "11"
        Else
            proj = "\Tags_" + GetEnvironment.Text + "\" + proj
        End If

        Dim configuration As XDocument = XDocument.Load("C:\Windows\System32\inetsrv\config\applicationHost.config")

        configuration = UpdateXML(configuration, env, proj, "portal")
        configuration = UpdateXML(configuration, env, proj, "wsc4")

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
