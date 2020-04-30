<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class REG
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
        Dim Bevel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(REG))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.id = New System.Windows.Forms.TextBox()
        Me.vname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.verifydb = New System.Windows.Forms.Button()
        Me.savedb = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.VerifyButton = New System.Windows.Forms.Button()
        Me.EnrollButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Bevel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(15, 145)
        Me.Button2.Margin = New System.Windows.Forms.Padding(6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(272, 37)
        Me.Button2.TabIndex = 40
        Me.Button2.UseVisualStyleBackColor = True
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
        Me.GroupBox1.Location = New System.Drawing.Point(-340, -3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(273, 244)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INSTRUCTIONS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(342, 61)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Staff ID:"
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(429, 58)
        Me.id.Margin = New System.Windows.Forms.Padding(6)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(304, 20)
        Me.id.TabIndex = 34
        '
        'vname
        '
        Me.vname.Location = New System.Drawing.Point(429, 4)
        Me.vname.Margin = New System.Windows.Forms.Padding(6)
        Me.vname.Name = "vname"
        Me.vname.Size = New System.Drawing.Size(304, 20)
        Me.vname.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(336, 4)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Staff Name:"
        '
        'verifydb
        '
        Me.verifydb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.verifydb.Location = New System.Drawing.Point(341, 231)
        Me.verifydb.Margin = New System.Windows.Forms.Padding(6)
        Me.verifydb.Name = "verifydb"
        Me.verifydb.Size = New System.Drawing.Size(264, 38)
        Me.verifydb.TabIndex = 31
        Me.verifydb.Text = "SAVE Staff Detail"
        Me.verifydb.UseVisualStyleBackColor = True
        '
        'savedb
        '
        Me.savedb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.savedb.Enabled = False
        Me.savedb.Location = New System.Drawing.Point(15, 96)
        Me.savedb.Margin = New System.Windows.Forms.Padding(6)
        Me.savedb.Name = "savedb"
        Me.savedb.Size = New System.Drawing.Size(272, 37)
        Me.savedb.TabIndex = 30
        Me.savedb.Text = "SAVE Staff Fingerprint"
        Me.savedb.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CloseButton.Location = New System.Drawing.Point(626, 231)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(6)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(150, 38)
        Me.CloseButton.TabIndex = 29
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'Bevel
        '
        Bevel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Bevel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Bevel.Location = New System.Drawing.Point(-349, 151)
        Bevel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Bevel.Name = "Bevel"
        Bevel.Size = New System.Drawing.Size(1546, 6)
        Bevel.TabIndex = 28
        '
        'VerifyButton
        '
        Me.VerifyButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VerifyButton.Enabled = False
        Me.VerifyButton.Location = New System.Drawing.Point(15, 53)
        Me.VerifyButton.Margin = New System.Windows.Forms.Padding(6)
        Me.VerifyButton.Name = "VerifyButton"
        Me.VerifyButton.Size = New System.Drawing.Size(272, 31)
        Me.VerifyButton.TabIndex = 27
        Me.VerifyButton.Text = "Fingerprint Verification"
        Me.VerifyButton.UseVisualStyleBackColor = True
        '
        'EnrollButton
        '
        Me.EnrollButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EnrollButton.Location = New System.Drawing.Point(15, 2)
        Me.EnrollButton.Margin = New System.Windows.Forms.Padding(6)
        Me.EnrollButton.Name = "EnrollButton"
        Me.EnrollButton.Size = New System.Drawing.Size(272, 39)
        Me.EnrollButton.TabIndex = 26
        Me.EnrollButton.Text = "Fingerprint Enrollment"
        Me.EnrollButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(632, 87)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(101, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 41
        Me.PictureBox1.TabStop = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(529, 144)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(97, 23)
        Me.Button4.TabIndex = 42
        Me.Button4.Text = "Upload Photo"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'REG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(855, 339)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
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
        Me.Name = "REG"
        Me.Text = "STAFF  REGISTRATION"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents id As System.Windows.Forms.TextBox
    Friend WithEvents vname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents verifydb As System.Windows.Forms.Button
    Private WithEvents savedb As System.Windows.Forms.Button
    Private WithEvents CloseButton As System.Windows.Forms.Button
    Private WithEvents VerifyButton As System.Windows.Forms.Button
    Private WithEvents EnrollButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
