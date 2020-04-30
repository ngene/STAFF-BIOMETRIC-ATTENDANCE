Imports MySql.Data.MySqlClient
Public Class Login


    Dim myDB As MySqlConnection

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click

        If user.Text = "" Then
            MsgBox("Username Field Cannot Be Blank")
        Else

            'myDB.Open()
            Dim sqlCommand As New MySqlCommand
            ' Dim fileStream As New System.IO.MemoryStream()
            '  voterPhotoBox.Image.Save(fileStream, System.Drawing.Imaging.ImageFormat.Jpeg)
            ' Dim arrImage() As Byte = fileStream.GetBuffer()
            ' fileStream.Close()
            sqlCommand.Connection = myDB

            sqlCommand.CommandText = "SELECT * FROM admin WHERE username ='" & user.Text & "'  AND password ='" & pass.Text & "'"
            ' sqlCommand.Parameters.AddWithValue("@voterPhotoData", arrImage)


            Dim rdr As MySqlDataReader = sqlCommand.ExecuteReader()
            ' Dim MemStream As IO.MemoryStream

            ' Dim fpUInt As UInt64()


            'Dim fpBytes() As Byte = BitConverter.GetBytes(fingerPrintTemplate)
            ' While rdr.Read()


            'MainForm.ShowDialog()

            ' While


            ' Dim sqlRead As MySqlDataReader = sqlCommand.ExecuteReader
            ' If rdr.HasRows Then
            If rdr.Read = True Then

                GEN.ShowDialog()

                rdr.Close()
            Else
                MessageBox.Show("Incorrect Username or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                user.Text = ""
                pass.Text = ""


            End If
            rdr.Close()
            'End If







        End If



    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myDB = New MySqlConnection
        myDB.ConnectionString = "server=127.0.0.1;user id=root;password=;database=hosms0"
        myDB.Open()
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub
End Class