Imports System.IO
Imports System.Security.Cryptography

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

        lblFilePassword.Text = "Password"

        lblFolderPath.Text = "Folder Path"

        lblFilePath.Text = "File Path"
    End Sub

    Function ParseXML(ByVal path As String)

        Dim file = XDocument.Load(txtFilePath.Text)

        Dim result = file.Element("SFDLFile").Element("ConnectionInfo").Descendants()

        Dim host = file.Element("SFDLFile").Element("ConnectionInfo").Element("Host")
        Dim port = file.Element("SFDLFile").Element("ConnectionInfo").Element("Port")
        Dim user = file.Element("SFDLFile").Element("ConnectionInfo").Element("Username")
        Dim pass = file.Element("SFDLFile").Element("ConnectionInfo").Element("Password")

        Dim folderPath = file.Element("SFDLFile").Element("Packages").Element("SFDLPackage").Element("BulkFolderList").Element("BulkFolder").Element("BulkFolderPath")

        txtHost.Text = DecryptString(host, txtPassword.Text)
        txtPort.Text = port
        txtUsername.Text = DecryptString(user, txtPassword.Text)
        txtPass.Text = DecryptString(pass, txtPassword.Text)
        txtFolderPath.Text = DecryptString(folderPath, txtPassword.Text)


        txtFullUrl.Text = "ftp://"
        txtFullUrl.AppendText(txtUsername.Text)
        txtFullUrl.AppendText(":")
        txtFullUrl.AppendText(txtPass.Text)
        txtFullUrl.AppendText("@")
        txtFullUrl.AppendText(txtHost.Text)
        txtFullUrl.AppendText(":")
        txtFullUrl.AppendText(txtPort.Text)
        txtFullUrl.AppendText(txtFolderPath.Text)


    End Function

    Function DecryptString(ByVal Value As String, ByVal _password As String) As String

        Try

            If Not String.IsNullOrWhiteSpace(Value) Then

                Dim AES As New RijndaelManaged

                Dim rijndaelIvLength As Integer = 16
                Dim md5 As New MD5CryptoServiceProvider
                Dim key() As Byte = md5.ComputeHash(System.Text.Encoding.UTF8.GetBytes(_password))

                md5.Clear()

                Dim encdata() As Byte = Convert.FromBase64String(Value)
                Dim ms As New MemoryStream(encdata)
                Dim iv(15) As Byte

                ms.Read(iv, 0, rijndaelIvLength)
                AES.IV = iv
                AES.Key = key

                Dim cs As New CryptoStream(ms, AES.CreateDecryptor, CryptoStreamMode.Read)

                Dim data(Integer.Parse(ms.Length.ToString) - rijndaelIvLength) As Byte
                Dim i As Integer = cs.Read(data, 0, data.Length)
                cs.Close()
                Return (System.Text.Encoding.UTF8.GetString(data, 0, i))

                AES.Clear()

            Else
                Return String.Empty
            End If

        Catch ex As Exception
            '
        End Try

    End Function

    Private Sub btnLoadFile_Click(sender As Object, e As EventArgs) Handles btnLoadFile.Click
        dlgLoadFile.ShowDialog()

        txtFilePath.Text = dlgLoadFile.FileName
    End Sub

    Private Sub btnDecrypt_Click(sender As Object, e As EventArgs) Handles btnDecrypt.Click
        ParseXML(txtFilePath.Text)
    End Sub

    Private Sub btnSingleDecrypt_Click(sender As Object, e As EventArgs) Handles btnSingleDecrypt.Click
        'frmSingleValue.ShowDialog()

    End Sub
End Class
