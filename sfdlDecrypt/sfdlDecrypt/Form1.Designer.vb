<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnSingleDecrypt = New System.Windows.Forms.Button()
        Me.dlgLoadFile = New System.Windows.Forms.OpenFileDialog()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblFilePassword = New System.Windows.Forms.Label()
        Me.btnDecrypt = New System.Windows.Forms.Button()
        Me.lblFilePath = New System.Windows.Forms.Label()
        Me.txtFolderPath = New System.Windows.Forms.TextBox()
        Me.lblFolderPath = New System.Windows.Forms.Label()
        Me.txtFullUrl = New System.Windows.Forms.TextBox()
        Me.lblFullUrl = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.txtHost = New System.Windows.Forms.TextBox()
        Me.lblHost = New System.Windows.Forms.Label()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.btnLoadFile = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSingleDecrypt
        '
        Me.btnSingleDecrypt.Location = New System.Drawing.Point(346, 360)
        Me.btnSingleDecrypt.Name = "btnSingleDecrypt"
        Me.btnSingleDecrypt.Size = New System.Drawing.Size(155, 23)
        Me.btnSingleDecrypt.TabIndex = 58
        Me.btnSingleDecrypt.Text = "Button1"
        Me.btnSingleDecrypt.UseVisualStyleBackColor = True
        '
        'dlgLoadFile
        '
        Me.dlgLoadFile.FileName = "OpenFileDialog1"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(12, 59)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(409, 20)
        Me.txtPassword.TabIndex = 57
        '
        'lblFilePassword
        '
        Me.lblFilePassword.AutoSize = True
        Me.lblFilePassword.Location = New System.Drawing.Point(12, 43)
        Me.lblFilePassword.Name = "lblFilePassword"
        Me.lblFilePassword.Size = New System.Drawing.Size(39, 13)
        Me.lblFilePassword.TabIndex = 56
        Me.lblFilePassword.Text = "Label6"
        '
        'btnDecrypt
        '
        Me.btnDecrypt.Location = New System.Drawing.Point(427, 57)
        Me.btnDecrypt.Name = "btnDecrypt"
        Me.btnDecrypt.Size = New System.Drawing.Size(75, 23)
        Me.btnDecrypt.TabIndex = 55
        Me.btnDecrypt.Text = "Button2"
        Me.btnDecrypt.UseVisualStyleBackColor = True
        '
        'lblFilePath
        '
        Me.lblFilePath.AutoSize = True
        Me.lblFilePath.Location = New System.Drawing.Point(12, 4)
        Me.lblFilePath.Name = "lblFilePath"
        Me.lblFilePath.Size = New System.Drawing.Size(39, 13)
        Me.lblFilePath.TabIndex = 54
        Me.lblFilePath.Text = "Label8"
        '
        'txtFolderPath
        '
        Me.txtFolderPath.Location = New System.Drawing.Point(12, 286)
        Me.txtFolderPath.Name = "txtFolderPath"
        Me.txtFolderPath.Size = New System.Drawing.Size(209, 20)
        Me.txtFolderPath.TabIndex = 53
        '
        'lblFolderPath
        '
        Me.lblFolderPath.AutoSize = True
        Me.lblFolderPath.Location = New System.Drawing.Point(12, 270)
        Me.lblFolderPath.Name = "lblFolderPath"
        Me.lblFolderPath.Size = New System.Drawing.Size(39, 13)
        Me.lblFolderPath.TabIndex = 52
        Me.lblFolderPath.Text = "Label7"
        '
        'txtFullUrl
        '
        Me.txtFullUrl.Location = New System.Drawing.Point(12, 333)
        Me.txtFullUrl.Name = "txtFullUrl"
        Me.txtFullUrl.Size = New System.Drawing.Size(490, 20)
        Me.txtFullUrl.TabIndex = 51
        '
        'lblFullUrl
        '
        Me.lblFullUrl.AutoSize = True
        Me.lblFullUrl.Location = New System.Drawing.Point(12, 317)
        Me.lblFullUrl.Name = "lblFullUrl"
        Me.lblFullUrl.Size = New System.Drawing.Size(39, 13)
        Me.lblFullUrl.TabIndex = 50
        Me.lblFullUrl.Text = "Label5"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(12, 247)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(209, 20)
        Me.txtPass.TabIndex = 49
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(12, 231)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(39, 13)
        Me.lblPassword.TabIndex = 48
        Me.lblPassword.Text = "Label4"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(12, 208)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(209, 20)
        Me.txtUsername.TabIndex = 47
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(12, 192)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(39, 13)
        Me.lblUsername.TabIndex = 46
        Me.lblUsername.Text = "Label3"
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(12, 169)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(209, 20)
        Me.txtPort.TabIndex = 45
        '
        'lblPort
        '
        Me.lblPort.AutoSize = True
        Me.lblPort.Location = New System.Drawing.Point(12, 153)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(39, 13)
        Me.lblPort.TabIndex = 44
        Me.lblPort.Text = "Label2"
        '
        'txtHost
        '
        Me.txtHost.Location = New System.Drawing.Point(12, 130)
        Me.txtHost.Name = "txtHost"
        Me.txtHost.Size = New System.Drawing.Size(209, 20)
        Me.txtHost.TabIndex = 43
        '
        'lblHost
        '
        Me.lblHost.AutoSize = True
        Me.lblHost.Location = New System.Drawing.Point(12, 114)
        Me.lblHost.Name = "lblHost"
        Me.lblHost.Size = New System.Drawing.Size(39, 13)
        Me.lblHost.TabIndex = 42
        Me.lblHost.Text = "Label1"
        '
        'txtFilePath
        '
        Me.txtFilePath.Location = New System.Drawing.Point(12, 20)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.Size = New System.Drawing.Size(409, 20)
        Me.txtFilePath.TabIndex = 41
        '
        'btnLoadFile
        '
        Me.btnLoadFile.Location = New System.Drawing.Point(427, 18)
        Me.btnLoadFile.Name = "btnLoadFile"
        Me.btnLoadFile.Size = New System.Drawing.Size(75, 23)
        Me.btnLoadFile.TabIndex = 40
        Me.btnLoadFile.Text = "Button1"
        Me.btnLoadFile.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 395)
        Me.Controls.Add(Me.btnSingleDecrypt)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblFilePassword)
        Me.Controls.Add(Me.btnDecrypt)
        Me.Controls.Add(Me.lblFilePath)
        Me.Controls.Add(Me.txtFolderPath)
        Me.Controls.Add(Me.lblFolderPath)
        Me.Controls.Add(Me.txtFullUrl)
        Me.Controls.Add(Me.lblFullUrl)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.txtPort)
        Me.Controls.Add(Me.lblPort)
        Me.Controls.Add(Me.txtHost)
        Me.Controls.Add(Me.lblHost)
        Me.Controls.Add(Me.txtFilePath)
        Me.Controls.Add(Me.btnLoadFile)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(531, 434)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(531, 434)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSingleDecrypt As Button
    Friend WithEvents dlgLoadFile As OpenFileDialog
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblFilePassword As Label
    Friend WithEvents btnDecrypt As Button
    Friend WithEvents lblFilePath As Label
    Friend WithEvents txtFolderPath As TextBox
    Friend WithEvents lblFolderPath As Label
    Friend WithEvents txtFullUrl As TextBox
    Friend WithEvents lblFullUrl As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtPort As TextBox
    Friend WithEvents lblPort As Label
    Friend WithEvents txtHost As TextBox
    Friend WithEvents lblHost As Label
    Friend WithEvents txtFilePath As TextBox
    Friend WithEvents btnLoadFile As Button
End Class
