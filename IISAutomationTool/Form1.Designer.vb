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
        RefreshPool.BackColor = SystemColors.ActiveCaption
        RefreshPool.Location = New Point(12, 193)
        RefreshPool.Name = "RefreshPool"
        RefreshPool.Size = New Size(350, 49)
        RefreshPool.TabIndex = 1
        RefreshPool.Text = "REFRESH POOL"
        RefreshPool.UseVisualStyleBackColor = False
        ' 
        ' GetEnvironment
        ' 
        GetEnvironment.Enabled = My.Settings.CRMPath.Count > 0 AndAlso My.Settings.HDAPath.Count > 0
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
        GetProject.Items.AddRange(New Object() {"Trunk", "11.11.05"})
        GetProject.Location = New Point(209, 80)
        GetProject.Name = "GetProject"
        GetProject.Size = New Size(153, 23)
        GetProject.TabIndex = 3
        ' 
        ' CRMPath
        ' 
        CRMPath.Location = New Point(12, 27)
        CRMPath.Name = "CRMPath"
        CRMPath.Size = New Size(153, 23)
        CRMPath.TabIndex = 4
        CRMPath.Text = My.Settings.CRMPath
        ' 
        ' HDAPath
        ' 
        HDAPath.Location = New Point(12, 80)
        HDAPath.Name = "HDAPath"
        HDAPath.Size = New Size(153, 23)
        HDAPath.TabIndex = 5
        HDAPath.Text = My.Settings.HDAPath
        ' 
        ' SetPath
        ' 
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
        ' IISAutomationTool
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(374, 257)
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

End Class
