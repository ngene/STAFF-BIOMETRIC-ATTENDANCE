<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MultiForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Bevel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MultiForm))
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.VerifyButton = New System.Windows.Forms.Button()
        Me.EnrollButton = New System.Windows.Forms.Button()
        Me.savedb = New System.Windows.Forms.Button()
        Me.verifydb = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.vname = New System.Windows.Forms.TextBox()
        Me.id = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.sex = New System.Windows.Forms.TextBox()
        Me.position = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.allergy = New System.Windows.Forms.Label()
        Me.sex2 = New System.Windows.Forms.Label()
        Me.patname = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Bevel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Bevel
        '
        Bevel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Bevel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Bevel.Location = New System.Drawing.Point(3, 156)
        Bevel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Bevel.Name = "Bevel"
        Bevel.Size = New System.Drawing.Size(1546, 6)
        Bevel.TabIndex = 9
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CloseButton.Location = New System.Drawing.Point(1070, 176)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(6)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(150, 38)
        Me.CloseButton.TabIndex = 13
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'VerifyButton
        '
        Me.VerifyButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VerifyButton.Enabled = False
        Me.VerifyButton.Location = New System.Drawing.Point(294, 53)
        Me.VerifyButton.Margin = New System.Windows.Forms.Padding(6)
        Me.VerifyButton.Name = "VerifyButton"
        Me.VerifyButton.Size = New System.Drawing.Size(272, 31)
        Me.VerifyButton.TabIndex = 8
        Me.VerifyButton.Text = "Fingerprint Verification"
        Me.VerifyButton.UseVisualStyleBackColor = True
        '
        'EnrollButton
        '
        Me.EnrollButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EnrollButton.Location = New System.Drawing.Point(294, 2)
        Me.EnrollButton.Margin = New System.Windows.Forms.Padding(6)
        Me.EnrollButton.Name = "EnrollButton"
        Me.EnrollButton.Size = New System.Drawing.Size(272, 39)
        Me.EnrollButton.TabIndex = 7
        Me.EnrollButton.Text = "Fingerprint Enrollment"
        Me.EnrollButton.UseVisualStyleBackColor = True
        '
        'savedb
        '
        Me.savedb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.savedb.Enabled = False
        Me.savedb.Location = New System.Drawing.Point(294, 96)
        Me.savedb.Margin = New System.Windows.Forms.Padding(6)
        Me.savedb.Name = "savedb"
        Me.savedb.Size = New System.Drawing.Size(272, 37)
        Me.savedb.TabIndex = 14
        Me.savedb.Text = "SAVE Staff Fingerprint"
        Me.savedb.UseVisualStyleBackColor = True
        '
        'verifydb
        '
        Me.verifydb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.verifydb.Location = New System.Drawing.Point(767, 176)
        Me.verifydb.Margin = New System.Windows.Forms.Padding(6)
        Me.verifydb.Name = "verifydb"
        Me.verifydb.Size = New System.Drawing.Size(264, 38)
        Me.verifydb.TabIndex = 15
        Me.verifydb.Text = "CONFIRM Staff Detail"
        Me.verifydb.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(688, 9)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 24)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Staff Name:"
        '
        'vname
        '
        Me.vname.Location = New System.Drawing.Point(916, 17)
        Me.vname.Margin = New System.Windows.Forms.Padding(6)
        Me.vname.Name = "vname"
        Me.vname.Size = New System.Drawing.Size(304, 29)
        Me.vname.TabIndex = 17
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(916, 66)
        Me.id.Margin = New System.Windows.Forms.Padding(6)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(304, 29)
        Me.id.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(694, 66)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 24)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Staff ID:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"MORNING(CLOCK-IN)", "EVENING(CLOCK-OUT)"})
        Me.ComboBox1.Location = New System.Drawing.Point(916, 121)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(304, 32)
        Me.ComboBox1.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(688, 132)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 24)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Attendance Period"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(14, 28)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(253, 174)
        Me.RichTextBox1.TabIndex = 22
        Me.RichTextBox1.Text = "1. YOU MUST PUT ONE OF YOUR FINGER FOUR TIMES BEFORE  ENROLLMENT OR VERIFICATION " & _
    "                     2. ALWAYS QUERY STAFF  DETAIL BEFORE CLICKING ON FINGERPRIN" & _
    "T VERFIFICATION"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RichTextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(273, 244)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INSTRUCTIONS"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.ComboBox2)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.sex)
        Me.GroupBox2.Controls.Add(Me.position)
        Me.GroupBox2.Controls.Add(Me.txtname)
        Me.GroupBox2.Controls.Add(Me.allergy)
        Me.GroupBox2.Controls.Add(Me.sex2)
        Me.GroupBox2.Controls.Add(Me.patname)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(660, 281)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(447, 264)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "VERIFIED STAFF DETAILS"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 186)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 24)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "DATE:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(79, 219)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(319, 39)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "SUBMIT STAFF ATTENDANCE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"MORNING ATTENDANCE", "EVENING ATTENDANCE"})
        Me.ComboBox2.Location = New System.Drawing.Point(281, 150)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(100, 32)
        Me.ComboBox2.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(156, 24)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "ATTENDANCE:"
        '
        'sex
        '
        Me.sex.Location = New System.Drawing.Point(281, 115)
        Me.sex.Name = "sex"
        Me.sex.Size = New System.Drawing.Size(100, 29)
        Me.sex.TabIndex = 8
        '
        'position
        '
        Me.position.Location = New System.Drawing.Point(281, 69)
        Me.position.Name = "position"
        Me.position.Size = New System.Drawing.Size(100, 29)
        Me.position.TabIndex = 7
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(271, 183)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(100, 29)
        Me.txtname.TabIndex = 6
        '
        'allergy
        '
        Me.allergy.AutoSize = True
        Me.allergy.Location = New System.Drawing.Point(208, 69)
        Me.allergy.Name = "allergy"
        Me.allergy.Size = New System.Drawing.Size(28, 24)
        Me.allergy.TabIndex = 5
        Me.allergy.Text = "..."
        '
        'sex2
        '
        Me.sex2.AutoSize = True
        Me.sex2.Location = New System.Drawing.Point(202, 115)
        Me.sex2.Name = "sex2"
        Me.sex2.Size = New System.Drawing.Size(34, 24)
        Me.sex2.TabIndex = 4
        Me.sex2.Text = "...."
        '
        'patname
        '
        Me.patname.AutoSize = True
        Me.patname.Location = New System.Drawing.Point(208, 25)
        Me.patname.Name = "patname"
        Me.patname.Size = New System.Drawing.Size(34, 24)
        Me.patname.TabIndex = 3
        Me.patname.Text = "...."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 24)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "GENDER:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(178, 24)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "STAFF POSITION"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 24)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "STAFF NAME:"
        '
        'Button2
        '
        Me.Button2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(288, 156)
        Me.Button2.Margin = New System.Windows.Forms.Padding(6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(272, 37)
        Me.Button2.TabIndex = 25
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MultiForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.CancelButton = Me.CloseButton
        Me.ClientSize = New System.Drawing.Size(1292, 628)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.vname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.verifydb)
        Me.Controls.Add(Me.savedb)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Bevel)
        Me.Controls.Add(Me.VerifyButton)
        Me.Controls.Add(Me.EnrollButton)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.OrangeRed
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MultiForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "STAFF BIOMETRICS ATTENDANCE"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents CloseButton As System.Windows.Forms.Button
    Private WithEvents VerifyButton As System.Windows.Forms.Button
    Private WithEvents EnrollButton As System.Windows.Forms.Button
    Private WithEvents savedb As System.Windows.Forms.Button
    Private WithEvents verifydb As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents vname As System.Windows.Forms.TextBox
    Friend WithEvents id As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents allergy As System.Windows.Forms.Label
    Friend WithEvents sex2 As System.Windows.Forms.Label
    Friend WithEvents patname As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents sex As System.Windows.Forms.TextBox
    Friend WithEvents position As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents Button2 As System.Windows.Forms.Button

End Class
