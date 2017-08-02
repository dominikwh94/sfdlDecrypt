Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "sfdlDecrypt"

        btnLoadFile.Text = "Load SFDL File"
        btnDecrypt.Text = "Decrypt"
        btnSingleDecrypt.Text = "Decrypt Single Value"

        lblHost.Text = "Host"
        lblPort.Text = "Port"
        lblUsername.Text = "Username"
        lblPassword.Text = "Password"

        lblFullUrl.Text = "Full URL"

        lblFilePassword.Text = "Passwort"

        lblFolderPath.Text = "Folder Path"

        lblFilePath.Text = "Dateipfad"
    End Sub
End Class
