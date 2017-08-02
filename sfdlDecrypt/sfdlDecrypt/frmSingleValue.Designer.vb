<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSingleValue
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
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.btnDecrypt = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblValue = New System.Windows.Forms.Label()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(15, 119)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(260, 20)
        Me.txtResult.TabIndex = 17
        '
        'btnDecrypt
        '
        Me.btnDecrypt.Location = New System.Drawing.Point(15, 90)
        Me.btnDecrypt.Name = "btnDecrypt"
        Me.btnDecrypt.Size = New System.Drawing.Size(75, 23)
        Me.btnDecrypt.TabIndex = 16
        Me.btnDecrypt.Text = "Button1"
        Me.btnDecrypt.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(15, 64)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(260, 20)
        Me.txtPassword.TabIndex = 15
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(12, 48)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(39, 13)
        Me.lblPassword.TabIndex = 14
        Me.lblPassword.Text = "Label2"
        '
        'lblValue
        '
        Me.lblValue.AutoSize = True
        Me.lblValue.Location = New System.Drawing.Point(12, 9)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(39, 13)
        Me.lblValue.TabIndex = 13
        Me.lblValue.Text = "Label1"
        '
        'txtValue
        '
        Me.txtValue.Location = New System.Drawing.Point(15, 25)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(260, 20)
        Me.txtValue.TabIndex = 12
        '
        'frmSingleValue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 148)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.btnDecrypt)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblValue)
        Me.Controls.Add(Me.txtValue)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(300, 187)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(300, 187)
        Me.Name = "frmSingleValue"
        Me.Text = "frmSingleValue"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtResult As TextBox
    Friend WithEvents btnDecrypt As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblValue As Label
    Friend WithEvents txtValue As TextBox
End Class
