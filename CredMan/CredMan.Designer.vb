﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CredMan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CredMan))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpCreds = New System.Windows.Forms.GroupBox()
        Me.btnShowPass = New System.Windows.Forms.Button()
        Me.lblSaved = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.timerKeyChecker = New System.Windows.Forms.Timer(Me.components)
        Me.grpCreds.SuspendLayout
        Me.SuspendLayout
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(336, 71)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(78, 23)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Close"
        Me.btnExit.UseVisualStyleBackColor = true
        AddHandler Me.btnExit.Click, AddressOf Me.btnExit_Click
        '
        'grpCreds
        '
        Me.grpCreds.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
                        Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.grpCreds.Controls.Add(Me.btnExit)
        Me.grpCreds.Controls.Add(Me.btnShowPass)
        Me.grpCreds.Controls.Add(Me.lblSaved)
        Me.grpCreds.Controls.Add(Me.btnSave)
        Me.grpCreds.Controls.Add(Me.txtPassword)
        Me.grpCreds.Controls.Add(Me.txtUsername)
        Me.grpCreds.Controls.Add(Me.lblPassword)
        Me.grpCreds.Controls.Add(Me.lblUsername)
        Me.grpCreds.Location = New System.Drawing.Point(12, 12)
        Me.grpCreds.Name = "grpCreds"
        Me.grpCreds.Size = New System.Drawing.Size(420, 100)
        Me.grpCreds.TabIndex = 26
        Me.grpCreds.TabStop = false
        Me.grpCreds.Text = "Credentials Management"
        '
        'btnShowPass
        '
        Me.btnShowPass.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnShowPass.BackColor = System.Drawing.Color.White
        Me.btnShowPass.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnShowPass.FlatAppearance.BorderSize = 0
        Me.btnShowPass.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnShowPass.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.btnShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowPass.ForeColor = System.Drawing.Color.Transparent
        Me.btnShowPass.Image = CType(resources.GetObject("btnShowPass.Image"),System.Drawing.Image)
        Me.btnShowPass.Location = New System.Drawing.Point(392, 47)
        Me.btnShowPass.Name = "btnShowPass"
        Me.btnShowPass.Size = New System.Drawing.Size(20, 16)
        Me.btnShowPass.TabIndex = 27
        Me.btnShowPass.UseVisualStyleBackColor = false
        AddHandler Me.btnShowPass.MouseDown, AddressOf Me.btnShowPass_MouseDown
        AddHandler Me.btnShowPass.MouseUp, AddressOf Me.btnShowPass_MouseUp
        '
        'lblSaved
        '
        Me.lblSaved.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblSaved.AutoSize = true
        Me.lblSaved.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblSaved.ForeColor = System.Drawing.Color.Green
        Me.lblSaved.Location = New System.Drawing.Point(199, 76)
        Me.lblSaved.Name = "lblSaved"
        Me.lblSaved.Size = New System.Drawing.Size(47, 13)
        Me.lblSaved.TabIndex = 5
        Me.lblSaved.Text = "Saved!"
        Me.lblSaved.Visible = false
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(252, 71)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(78, 23)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = true
        AddHandler Me.btnSave.Click, AddressOf Me.BtnSave_Click
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtPassword.Location = New System.Drawing.Point(70, 45)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPassword.Size = New System.Drawing.Size(344, 20)
        Me.txtPassword.TabIndex = 3
        '
        'txtUsername
        '
        Me.txtUsername.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtUsername.Location = New System.Drawing.Point(70, 19)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(344, 20)
        Me.txtUsername.TabIndex = 2
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = true
        Me.lblPassword.Location = New System.Drawing.Point(6, 48)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(56, 13)
        Me.lblPassword.TabIndex = 1
        Me.lblPassword.Text = "Password:"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = true
        Me.lblUsername.Location = New System.Drawing.Point(6, 22)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(58, 13)
        Me.lblUsername.TabIndex = 0
        Me.lblUsername.Text = "Username:"
        '
        'timerKeyChecker
        '
        AddHandler Me.timerKeyChecker.Tick, AddressOf Me.TimerKeyChecker_Tick
        '
        'CredMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(444, 124)
        Me.Controls.Add(Me.grpCreds)
        Me.HelpButton = true
        Me.Name = "CredMan"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Credentials Management"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        AddHandler Load, AddressOf Me.CredMan_Load
        Me.grpCreds.ResumeLayout(false)
        Me.grpCreds.PerformLayout
        Me.ResumeLayout(false)
    End Sub
    Private btnShowPass As System.Windows.Forms.Button
    Private timerKeyChecker As System.Windows.Forms.Timer
    Private lblUsername As System.Windows.Forms.Label
    Private lblPassword As System.Windows.Forms.Label
    Private txtUsername As System.Windows.Forms.TextBox
    Private txtPassword As System.Windows.Forms.TextBox
    Private btnSave As System.Windows.Forms.Button
    Private lblSaved As System.Windows.Forms.Label
    Private grpCreds As System.Windows.Forms.GroupBox
    Private btnExit As System.Windows.Forms.Button
End Class