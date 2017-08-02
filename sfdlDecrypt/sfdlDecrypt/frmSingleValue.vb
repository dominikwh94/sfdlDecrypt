Public Class frmSingleValue
    Private Sub frmSingleValue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Decrypt Single Value"

        lblValue.Text = "Value"
        lblPassword.Text = "Password"

        btnDecrypt.Text = "Decrypt"
    End Sub

    Private Sub btnDecrypt_Click(sender As Object, e As EventArgs) Handles btnDecrypt.Click
        txtResult.Text = Form1.DecryptString(txtValue.Text, txtPassword.Text)
    End Sub
End Class