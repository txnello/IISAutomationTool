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
        components = New ComponentModel.Container()
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
        OpenWSC4ErrorLogTail = New Button()
        OpenPortalErrorLogTail = New Button()
        OpenWSC4 = New Button()
        OpenPortal = New Button()
        SeparatorLabel = New Label()
        NotifyIcon1 = New NotifyIcon(components)
        SuspendLayout()
        ' 
        ' UpdateConfiguration
        ' 
        UpdateConfiguration.Enabled = False
        UpdateConfiguration.Location = New Point(209, 121)
        UpdateConfiguration.Name = "UpdateConfiguration"
        UpdateConfiguration.Size = New Size(153, 49)
        UpdateConfiguration.TabIndex = 0
        UpdateConfiguration.Text = "Update Configuration"
        UpdateConfiguration.UseVisualStyleBackColor = True
        ' 
        ' RefreshPool
        ' 
        RefreshPool.BackColor = SystemColors.ActiveCaptionText
        RefreshPool.Enabled = False
        RefreshPool.ForeColor = SystemColors.ButtonFace
        RefreshPool.Location = New Point(12, 210)
        RefreshPool.Name = "RefreshPool"
        RefreshPool.Size = New Size(350, 49)
        RefreshPool.TabIndex = 1
        RefreshPool.Text = "REFRESH POOL"
        RefreshPool.UseVisualStyleBackColor = False
        ' 
        ' GetEnvironment
        ' 
        GetEnvironment.Enabled = False
        GetEnvironment.FormattingEnabled = True
        GetEnvironment.Items.AddRange(New Object() {"ICRM", "HDA"})
        GetEnvironment.Location = New Point(209, 27)
        GetEnvironment.Name = "GetEnvironment"
        GetEnvironment.Size = New Size(153, 23)
        GetEnvironment.TabIndex = 2
        ' 
        ' GetProject
        ' 
        GetProject.Enabled = False
        GetProject.FormattingEnabled = True
        GetProject.Location = New Point(209, 80)
        GetProject.Name = "GetProject"
        GetProject.Size = New Size(153, 23)
        GetProject.TabIndex = 3
        ' 
        ' CRMPath
        ' 
        CRMPath.Enabled = False
        CRMPath.Location = New Point(12, 27)
        CRMPath.Name = "CRMPath"
        CRMPath.Size = New Size(153, 23)
        CRMPath.TabIndex = 4
        ' 
        ' HDAPath
        ' 
        HDAPath.Enabled = False
        HDAPath.Location = New Point(12, 80)
        HDAPath.Name = "HDAPath"
        HDAPath.Size = New Size(153, 23)
        HDAPath.TabIndex = 5
        ' 
        ' SetPath
        ' 
        SetPath.Enabled = False
        SetPath.Location = New Point(12, 121)
        SetPath.Name = "SetPath"
        SetPath.Size = New Size(153, 49)
        SetPath.TabIndex = 6
        SetPath.Text = "Set path"
        SetPath.UseVisualStyleBackColor = True
        ' 
        ' CRMPathLabel
        ' 
        CRMPathLabel.AutoSize = True
        CRMPathLabel.Location = New Point(12, 9)
        CRMPathLabel.Name = "CRMPathLabel"
        CRMPathLabel.Size = New Size(60, 15)
        CRMPathLabel.TabIndex = 7
        CRMPathLabel.Text = "CRM Path"
        ' 
        ' HDAPathLabel
        ' 
        HDAPathLabel.AutoSize = True
        HDAPathLabel.Location = New Point(12, 62)
        HDAPathLabel.Name = "HDAPathLabel"
        HDAPathLabel.Size = New Size(59, 15)
        HDAPathLabel.TabIndex = 8
        HDAPathLabel.Text = "HDA Path"
        ' 
        ' Environment
        ' 
        Environment.AutoSize = True
        Environment.Location = New Point(209, 9)
        Environment.Name = "Environment"
        Environment.Size = New Size(75, 15)
        Environment.TabIndex = 9
        Environment.Text = "Environment"
        ' 
        ' Project
        ' 
        Project.AutoSize = True
        Project.Location = New Point(209, 62)
        Project.Name = "Project"
        Project.Size = New Size(44, 15)
        Project.TabIndex = 10
        Project.Text = "Project"
        ' 
        ' Info
        ' 
        Info.AutoSize = True
        Info.Location = New Point(103, 435)
        Info.Name = "Info"
        Info.Size = New Size(169, 15)
        Info.TabIndex = 11
        Info.Text = "Created by Manuel Tonello | v. "
        ' 
        ' OpenPortalLogs
        ' 
        OpenPortalLogs.Enabled = False
        OpenPortalLogs.Location = New Point(12, 265)
        OpenPortalLogs.Name = "OpenPortalLogs"
        OpenPortalLogs.Size = New Size(153, 49)
        OpenPortalLogs.TabIndex = 12
        OpenPortalLogs.Text = "Open Portal Logs"
        OpenPortalLogs.UseVisualStyleBackColor = True
        ' 
        ' OpenWSCLogs
        ' 
        OpenWSCLogs.Enabled = False
        OpenWSCLogs.Location = New Point(209, 265)
        OpenWSCLogs.Name = "OpenWSCLogs"
        OpenWSCLogs.Size = New Size(153, 49)
        OpenWSCLogs.TabIndex = 13
        OpenWSCLogs.Text = "Open WSC4 Logs"
        OpenWSCLogs.UseVisualStyleBackColor = True
        ' 
        ' ErrorLabel
        ' 
        ErrorLabel.Location = New Point(0, 0)
        ErrorLabel.Name = "ErrorLabel"
        ErrorLabel.Size = New Size(100, 23)
        ErrorLabel.TabIndex = 19
        ' 
        ' OpenWSC4ErrorLogTail
        ' 
        OpenWSC4ErrorLogTail.Enabled = False
        OpenWSC4ErrorLogTail.Location = New Point(209, 320)
        OpenWSC4ErrorLogTail.Name = "OpenWSC4ErrorLogTail"
        OpenWSC4ErrorLogTail.Size = New Size(153, 49)
        OpenWSC4ErrorLogTail.TabIndex = 16
        OpenWSC4ErrorLogTail.Text = "Open WSC4 Error Log Tail"
        OpenWSC4ErrorLogTail.UseVisualStyleBackColor = True
        ' 
        ' OpenPortalErrorLogTail
        ' 
        OpenPortalErrorLogTail.Enabled = False
        OpenPortalErrorLogTail.Location = New Point(12, 320)
        OpenPortalErrorLogTail.Name = "OpenPortalErrorLogTail"
        OpenPortalErrorLogTail.Size = New Size(153, 49)
        OpenPortalErrorLogTail.TabIndex = 15
        OpenPortalErrorLogTail.Text = "Open Portal Error Log Tail"
        OpenPortalErrorLogTail.UseVisualStyleBackColor = True
        ' 
        ' OpenWSC4
        ' 
        OpenWSC4.Enabled = False
        OpenWSC4.Location = New Point(209, 375)
        OpenWSC4.Name = "OpenWSC4"
        OpenWSC4.Size = New Size(153, 49)
        OpenWSC4.TabIndex = 18
        OpenWSC4.Text = "Open WSC4"
        OpenWSC4.UseVisualStyleBackColor = True
        ' 
        ' OpenPortal
        ' 
        OpenPortal.Enabled = False
        OpenPortal.Location = New Point(12, 375)
        OpenPortal.Name = "OpenPortal"
        OpenPortal.Size = New Size(153, 49)
        OpenPortal.TabIndex = 17
        OpenPortal.Text = "Open Portal"
        OpenPortal.UseVisualStyleBackColor = True
        ' 
        ' SeparatorLabel
        ' 
        SeparatorLabel.AutoSize = True
        SeparatorLabel.Location = New Point(12, 182)
        SeparatorLabel.Name = "SeparatorLabel"
        SeparatorLabel.Size = New Size(352, 15)
        SeparatorLabel.TabIndex = 20
        SeparatorLabel.Text = "---------------------------------------------------------------------"
        ' 
        ' NotifyIcon1
        ' 
        NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), Icon)
        NotifyIcon1.Text = "IIS Automation Tool"
        NotifyIcon1.Visible = True
        ' 
        ' IISAutomationTool
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(380, 462)
        Controls.Add(SeparatorLabel)
        Controls.Add(OpenWSC4)
        Controls.Add(OpenPortal)
        Controls.Add(OpenWSC4ErrorLogTail)
        Controls.Add(OpenPortalErrorLogTail)
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
    Friend WithEvents OpenWSC4ErrorLogTail As Button
    Friend WithEvents OpenPortalErrorLogTail As Button
    Friend WithEvents OpenWSC4 As Button
    Friend WithEvents OpenPortal As Button
    Friend WithEvents SeparatorLabel As Label
    Friend WithEvents NotifyIcon1 As NotifyIcon

End Class
