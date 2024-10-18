<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IISAutomationTool
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IISAutomationTool))
        UpdateConfiguration = New Button()
        RefreshPool = New Button()
        GetEnvironment = New ComboBox()
        GetProject = New ComboBox()
        CRMPath = New TextBox()
        HDAPath = New TextBox()
        SetPath = New Button()
        CRMPathLabel = New Label()
        HDAPathLabel = New Label()
        Environment = New Label()
        Project = New Label()
        Info = New Label()
        OpenPortalLogs = New Button()
        OpenWSCLogs = New Button()
        ErrorLabel = New Label()
        SuspendLayout()
        ' 
        ' UpdateConfiguration
        ' 
        UpdateConfiguration.Enabled = False
        UpdateConfiguration.Location = New Point(239, 161)
        UpdateConfiguration.Margin = New Padding(3, 4, 3, 4)
        UpdateConfiguration.Name = "UpdateConfiguration"
        UpdateConfiguration.Size = New Size(175, 65)
        UpdateConfiguration.TabIndex = 0
        UpdateConfiguration.Text = "Update Configuration"
        UpdateConfiguration.UseVisualStyleBackColor = True
        ' 
        ' RefreshPool
        ' 
        RefreshPool.BackColor = SystemColors.ActiveCaptionText
        RefreshPool.Enabled = False
        RefreshPool.ForeColor = SystemColors.ButtonFace
        RefreshPool.Location = New Point(14, 280)
        RefreshPool.Margin = New Padding(3, 4, 3, 4)
        RefreshPool.Name = "RefreshPool"
        RefreshPool.Size = New Size(400, 65)
        RefreshPool.TabIndex = 1
        RefreshPool.Text = "REFRESH POOL"
        RefreshPool.UseVisualStyleBackColor = False
        ' 
        ' GetEnvironment
        ' 
        GetEnvironment.Enabled = False
        GetEnvironment.FormattingEnabled = True
        GetEnvironment.Items.AddRange(New Object() {"ICRM", "HDA"})
        GetEnvironment.Location = New Point(239, 36)
        GetEnvironment.Margin = New Padding(3, 4, 3, 4)
        GetEnvironment.Name = "GetEnvironment"
        GetEnvironment.Size = New Size(174, 28)
        GetEnvironment.TabIndex = 2
        ' 
        ' GetProject
        ' 
        GetProject.Enabled = False
        GetProject.FormattingEnabled = True
        GetProject.Location = New Point(239, 107)
        GetProject.Margin = New Padding(3, 4, 3, 4)
        GetProject.Name = "GetProject"
        GetProject.Size = New Size(174, 28)
        GetProject.TabIndex = 3
        ' 
        ' CRMPath
        ' 
        CRMPath.Enabled = False
        CRMPath.Location = New Point(14, 36)
        CRMPath.Margin = New Padding(3, 4, 3, 4)
        CRMPath.Name = "CRMPath"
        CRMPath.Size = New Size(174, 27)
        CRMPath.TabIndex = 4
        ' 
        ' HDAPath
        ' 
        HDAPath.Enabled = False
        HDAPath.Location = New Point(14, 107)
        HDAPath.Margin = New Padding(3, 4, 3, 4)
        HDAPath.Name = "HDAPath"
        HDAPath.Size = New Size(174, 27)
        HDAPath.TabIndex = 5
        ' 
        ' SetPath
        ' 
        SetPath.Enabled = False
        SetPath.Location = New Point(14, 161)
        SetPath.Margin = New Padding(3, 4, 3, 4)
        SetPath.Name = "SetPath"
        SetPath.Size = New Size(175, 65)
        SetPath.TabIndex = 6
        SetPath.Text = "Set path"
        SetPath.UseVisualStyleBackColor = True
        ' 
        ' CRMPathLabel
        ' 
        CRMPathLabel.AutoSize = True
        CRMPathLabel.Location = New Point(14, 12)
        CRMPathLabel.Name = "CRMPathLabel"
        CRMPathLabel.Size = New Size(72, 20)
        CRMPathLabel.TabIndex = 7
        CRMPathLabel.Text = "CRM Path"
        ' 
        ' HDAPathLabel
        ' 
        HDAPathLabel.AutoSize = True
        HDAPathLabel.Location = New Point(14, 83)
        HDAPathLabel.Name = "HDAPathLabel"
        HDAPathLabel.Size = New Size(73, 20)
        HDAPathLabel.TabIndex = 8
        HDAPathLabel.Text = "HDA Path"
        ' 
        ' Environment
        ' 
        Environment.AutoSize = True
        Environment.Location = New Point(239, 12)
        Environment.Name = "Environment"
        Environment.Size = New Size(92, 20)
        Environment.TabIndex = 9
        Environment.Text = "Environment"
        ' 
        ' Project
        ' 
        Project.AutoSize = True
        Project.Location = New Point(239, 83)
        Project.Name = "Project"
        Project.Size = New Size(55, 20)
        Project.TabIndex = 10
        Project.Text = "Project"
        ' 
        ' Info
        ' 
        Info.AutoSize = True
        Info.Location = New Point(114, 433)
        Info.Name = "Info"
        Info.Size = New Size(213, 20)
        Info.TabIndex = 11
        Info.Text = "Created by Manuel Tonello | v. "
        ' 
        ' OpenPortalLogs
        ' 
        OpenPortalLogs.Enabled = False
        OpenPortalLogs.Location = New Point(14, 353)
        OpenPortalLogs.Margin = New Padding(3, 4, 3, 4)
        OpenPortalLogs.Name = "OpenPortalLogs"
        OpenPortalLogs.Size = New Size(175, 65)
        OpenPortalLogs.TabIndex = 12
        OpenPortalLogs.Text = "Open Portal Logs"
        OpenPortalLogs.UseVisualStyleBackColor = True
        ' 
        ' OpenWSCLogs
        ' 
        OpenWSCLogs.Enabled = False
        OpenWSCLogs.Location = New Point(239, 353)
        OpenWSCLogs.Margin = New Padding(3, 4, 3, 4)
        OpenWSCLogs.Name = "OpenWSCLogs"
        OpenWSCLogs.Size = New Size(175, 65)
        OpenWSCLogs.TabIndex = 13
        OpenWSCLogs.Text = "Open WSC4 Logs"
        OpenWSCLogs.UseVisualStyleBackColor = True
        ' 
        ' ErrorLabel
        ' 
        ErrorLabel.AutoSize = True
        ErrorLabel.ForeColor = Color.Red
        ErrorLabel.Location = New Point(14, 243)
        ErrorLabel.Name = "ErrorLabel"
        ErrorLabel.Size = New Size(0, 20)
        ErrorLabel.TabIndex = 14
        ' 
        ' IISAutomationTool
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(434, 468)
        Controls.Add(ErrorLabel)
        Controls.Add(OpenWSCLogs)
        Controls.Add(OpenPortalLogs)
        Controls.Add(Info)
        Controls.Add(Project)
        Controls.Add(Environment)
        Controls.Add(HDAPathLabel)
        Controls.Add(CRMPathLabel)
        Controls.Add(SetPath)
        Controls.Add(HDAPath)
        Controls.Add(CRMPath)
        Controls.Add(GetProject)
        Controls.Add(GetEnvironment)
        Controls.Add(RefreshPool)
        Controls.Add(UpdateConfiguration)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        Name = "IISAutomationTool"
        Text = "IIS Automation Tool"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents UpdateConfiguration As Button
    Friend WithEvents RefreshPool As Button
    Friend WithEvents GetEnvironment As ComboBox
    Friend WithEvents GetProject As ComboBox
    Friend WithEvents CRMPath As TextBox
    Friend WithEvents HDAPath As TextBox
    Friend WithEvents SetPath As Button
    Friend WithEvents CRMPathLabel As Label
    Friend WithEvents HDAPathLabel As Label
    Friend WithEvents Environment As Label
    Friend WithEvents Project As Label
    Friend WithEvents Info As Label
    Friend WithEvents OpenPortalLogs As Button
    Friend WithEvents OpenWSCLogs As Button
    Friend WithEvents ErrorLabel As Label

End Class
