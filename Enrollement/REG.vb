Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data.DataTable

Delegate Sub FunctionCall2(ByVal param)


Public Class REG


    Dim template2 As DPFP.Template
    Dim myDB As MySqlConnection

    Private Sub EnrollButton_Click(sender As Object, e As EventArgs) Handles EnrollButton.Click
        Dim Enroller As New EnrollmentForm()
        AddHandler Enroller.OnTemplate, AddressOf OnTemplate
        Enroller.ShowDialog()
    End Sub




    Private Sub OnTemplate(ByVal template)
        Invoke(New FunctionCall(AddressOf _OnTemplate), template)
    End Sub

    Private Sub _OnTemplate(ByVal template)

        Dim num As Integer
        Dim start As Integer = 1
        Dim stop1 As Integer = 3

        For num = start To stop1

            Me.Template = template
            'VerifyButton.Enabled = (Not template Is Nothing)
            ' SaveButton.Enabled = (Not template Is Nothing)
            'savedb.Enabled = (Not template Is Nothing)
            ' verifydb.Enabled = (Not template Is Nothing)


        Next num
        ' If Not template Is Nothing Then
        'MessageBox.Show("The fingerprint template is ready for fingerprint verification.", "Fingerprint Enrollment")
        ' Else
        'MessageBox.Show("The fingerprint template is not valid. Repeat fingerprint enrollment.", "Fingerprint Enrollment")
        'End If
    End Sub


    Private Template As DPFP.Template

    Private Sub REG_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        myDB = New MySqlConnection
        myDB.ConnectionString = "server=127.0.0.1;user id=root;password=;database=hosms0"
        myDB.Open()



        Dim sqlCommand As New MySqlCommand
        ' Dim fileStream As New System.IO.MemoryStream()
        '  voterPhotoBox.Image.Save(fileStream, System.Drawing.Imaging.ImageFormat.Jpeg)
        ' Dim arrImage() As Byte = fileStream.GetBuffer()
        ' fileStream.Close()
        sqlCommand.Connection = myDB
        ' sqlCommand.CommandType = CommandType.Text


        ' insert into votertb where surname=PatientSurname.Text
        ' that's the way it will be henceforth
        sqlCommand.CommandText = "SELECT patient_id,name, birth_date, fingerPrintTemplate FROM patient where patient_id <30 order by patient_id  "
        ' sqlCommand.Parameters.AddWithValue("@voterPhotoData", arrImage)


        Dim rdr As MySqlDataReader = sqlCommand.ExecuteReader()
        ' Dim MemStream As IO.MemoryStream
        Dim MemStream As IO.MemoryStream

        ' Dim fpUInt As UInt64()

        ' Dim uintsix4 As UInt64()


        Dim fpBytes() As Byte


        'Dim fpBytes() As Byte = BitConverter.GetBytes(fingerPrintTemplate)
        While rdr.Read()


            '  uintsix4 = rdr("fingerPrintTemplate")
            ' fpBytes = rdr("fingerPrintTemplate") = (rdr.GetString(0), rdr.GetString(1), rdr.GetString(13), "3197B988220A34AF3008425D6A835A47")
            Dim first As Integer = 1
            Dim last As Integer = 3

            'Dim fpBytes() As Byte
            Dim pat_id As Integer = rdr("patient_id")
            For pat_id = first To last



                fpBytes = rdr("fingerPrintTemplate")


                ' Dim patname As String = rdr("birth_date")
                ' patname.Text = rdr("name").ToString()
                ' blood.Text = rdr("blood_group")
                '  allergy.Text = rdr("birth_date").ToString()

                ' Template0.Bytes(rdr.GetString(0), rdr.GetString(1), rdr.GetString(13), "fingerPrintTemplate")

                'fpBytes = (rdr.GetString(0), rdr.GetString(1), rdr.GetString(13), "fingerPrintTemplate")

                'readDB = sqlCommand.ExecuteReader
                ' While readDB.Read
                'fpVer.FPLoad(readDB.GetString(0), readDB.GetString(1), readDB.GetString(13), "3197B988220A34AF3008425D6A835A47")
                ' End While



                'MemStream = New IO.MemoryStream(uintsix4)
                MemStream = New IO.MemoryStream(fpBytes)
                Dim template As New DPFP.Template(MemStream)




                ' template.DeSerialize(MemStream)
                OnTemplate(template)
            Next pat_id
            '   If template2 = Template Then

            'myDB.Close()
            ' End If
            ' Dim Verifier2 As New VerificationForm()
            ' Verifier2.Verify(template2)

            '   Dim dt As New DataTable
            '  Dim str As String = "Select name as [Patient Name], residenceID as [Blood Group], sex as [Allergies] from voterdb ORDER BY id "
            '  Dim da As New MySqlDataAdapter(str, myDB)

            '  da.Fill(dt)
            '    da.Dispose()
            '     source1.DataSource = dt
            '    DataGridView1.DataSource = dt
            '    DataGridView1.Refresh()
            '   DataGridView1.Columns(4).Width = 150







        End While








        rdr.Close()



        myDB.Close()


    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If OpenFileDialog1.ShowDialog = 1 Then
            PictureBox1.Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub
End Class