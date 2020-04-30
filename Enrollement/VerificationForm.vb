' NOTE: This form is inherited from the CaptureForm,
' so the VisualStudio Form Designer may not load this properly
' (at least until you build the project).
' If you want to make changes in the form layout - do it in the base CaptureForm.
' All changes in the CaptureForm will be reflected in all derived forms 
' (i.e. in the EnrollmentForm and in the VerificationForm)
Imports MySql.Data.MySqlClient

Public Class VerificationForm
    Inherits CaptureForm
    Dim myDB As MySqlConnection

    Private Template As DPFP.Template
    Friend WithEvents btnverify As System.Windows.Forms.Button
    Private Verificator As DPFP.Verification.Verification




    Private Sub OnTemplate(ByVal template)
        Invoke(New FunctionCall(AddressOf _OnTemplate), template)
    End Sub


    Private Sub _OnTemplate(ByVal template)

        Me.Template = template
        btnverify.Enabled = (Not template Is Nothing)
        ' SaveButton.Enabled = (Not template Is Nothing)
        ' savedb.Enabled = (Not template Is Nothing)
        'verifydb.Enabled = (Not template Is Nothing)
        If Not template Is Nothing Then
            MessageBox.Show("The fingerprint template is ready for fingerprint verification.", "Fingerprint Enrollment")
        Else
            MessageBox.Show("The fingerprint template is not valid. Repeat fingerprint enrollment.", "Fingerprint Enrollment")
        End If
    End Sub




    Public Sub Verify(ByVal template As DPFP.Template)
        Me.Template = template
        ShowDialog()
    End Sub

    Protected Overrides Sub Init()
        MyBase.Init()
        MyBase.Text = "Fingerprint Verification"
        Verificator = New DPFP.Verification.Verification()
        UpdateStatus(0)
    End Sub




    Protected Overrides Sub Process(ByVal Sample As DPFP.Sample)

        myDB = New MySqlConnection
        myDB.ConnectionString = "server=127.0.0.1;user id=root;password=;database=hosms0"
        myDB.Open()
        Dim sqlCommand0 As New MySqlCommand
        ' Dim sqlCommand As New MySqlCommand
        ' Dim fileStream As New System.IO.MemoryStream()
        '  voterPhotoBox.Image.Save(fileStream, System.Drawing.Imaging.ImageFormat.Jpeg)
        ' Dim arrImage() As Byte = fileStream.GetBuffer()
        ' fileStream.Close()
        sqlCommand0.Connection = myDB
        ' sqlCommand.CommandType = CommandType.Text

        sqlCommand0.CommandText = "SELECT  * FROM patient "
        ' sqlCommand.Parameters.AddWithValue("@voterPhotoData", arrImage)



        Dim fpBytes() As Byte
        Dim rdr0 As MySqlDataReader = sqlCommand0.ExecuteReader()
        While rdr0.Read()


            fpBytes = rdr0("fingerPrintTemplate")


            ' Dim patname As String = rdr("birth_date")
            '   MainForm.patname.Text = rdr0("name").ToString()
            '   MainForm.blood.Text = rdr0("blood_group")
            '   MainForm.allergy.Text = rdr0("birth_date").ToString()


            Dim MemStream As IO.MemoryStream

            'MemStream = New IO.MemoryStream(uintsix4)
            MemStream = New IO.MemoryStream(fpBytes)
            Dim template As New DPFP.Template(MemStream)




            ' template.DeSerialize(MemStream)
            'OnTemplate(template)

            ' Me.Template(template)



            MyBase.Process(Sample)

            'UpdateStatus(0)
            ' Process the sample and create a feature set for the enrollment purpose.
            Dim features As DPFP.FeatureSet = ExtractFeatures(sample, DPFP.Processing.DataPurpose.Verification)

            ' Check quality of the sample and start verification if it's good
            If Not features Is Nothing Then

                Dim result As DPFP.Verification.Verification.Result = New DPFP.Verification.Verification.Result()

                Verificator = New DPFP.Verification.Verification
                ' Verificator = (Not Template Is Nothing)

                Verificator.Verify(features, template, result)
                UpdateStatus(result.FARAchieved)
                If result.Verified Then
                    MakeReport("The fingerprint was VERIFIED.")
                    MultiForm.ShowDialog()
                    'Me.Hide()
                    MultiForm.GroupBox2.Enabled = True

                    MultiForm.txtname.Text = rdr0("name").ToString()
                    MultiForm.sex2.Text = rdr0("sex")
                    MultiForm.position.Text = rdr0("position").ToString()


                    ' i intend for the next to control what happes around here....

                Else
                    MakeReport("The fingerprint was NOT VERIFIED.")
                    MakeReport("PLEASE DO WELL to ENROL Ur Fingerprint.")


                End If
                ' Next pat_id

            End If




        End While


    End Sub

    Protected Sub UpdateStatus(ByVal FAR As Integer)
        ' Show "False accept rate" value
        SetStatus(String.Format("False Accept Rate (FAR) = {0}", FAR))
    End Sub


    Private Sub InitializeComponent()
        Me.btnverify = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnverify
        '
        Me.btnverify.Location = New System.Drawing.Point(319, 54)
        Me.btnverify.Name = "btnverify"
        Me.btnverify.Size = New System.Drawing.Size(75, 23)
        Me.btnverify.TabIndex = 14
        Me.btnverify.Text = "Verify"
        Me.btnverify.UseVisualStyleBackColor = True
        '
        'VerificationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(581, 354)
        Me.Controls.Add(Me.btnverify)
        Me.Name = "VerificationForm"
        Me.Controls.SetChildIndex(Me.btnverify, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Sub VerificationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myDB = New MySqlConnection
        myDB.ConnectionString = "server=127.0.0.1;user id=root;password=;database=hosms0"
        myDB.Open()

        Dim sqlCommand0 As New MySqlCommand
        ' Dim sqlCommand As New MySqlCommand
        ' Dim fileStream As New System.IO.MemoryStream()
        '  voterPhotoBox.Image.Save(fileStream, System.Drawing.Imaging.ImageFormat.Jpeg)
        ' Dim arrImage() As Byte = fileStream.GetBuffer()
        ' fileStream.Close()
        sqlCommand0.Connection = myDB
        ' sqlCommand.CommandType = CommandType.Text

        sqlCommand0.CommandText = "SELECT * FROM patient "
        ' sqlCommand.Parameters.AddWithValue("@voterPhotoData", arrImage)



        Dim rdr0 As MySqlDataReader = sqlCommand0.ExecuteReader()


        While rdr0.Read()

            ' Dim sqlCommand As New MySqlCommand


            ' sqlCommand.Connection = myDB
            ' sqlCommand.CommandText = "SELECT fingerPrintTemplate FROM patient "


            Dim fpBytes() As Byte
            fpBytes = rdr0("fingerPrintTemplate")
            'Dim fpBytes() As Byte = BitConverter.GetBytes(fingerPrintTemplate)


            ' rdr0.Read()


            Dim MemStream As IO.MemoryStream
            ' lets use id to mark each of the fingerprint template
            MemStream = New IO.MemoryStream(fpBytes)
            Dim template As New DPFP.Template(MemStream)






        End While


        myDB.Close()
    End Sub

    Private Sub btnverify_Click(sender As Object, e As EventArgs) Handles btnverify.Click
        'VerificationForm.ShowDialog()
        Me.ShowDialog()
    End Sub
End Class


