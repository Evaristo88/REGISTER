<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblFName = New Label()
        lblDOB = New Label()
        lblCYP = New Label()
        lblGender = New Label()
        lblClubs = New Label()
        txtFName = New TextBox()
        rdbMale = New RadioButton()
        rdbFemale = New RadioButton()
        lblRegister = New Button()
        lstRegister = New ListBox()
        DateTimePicker1 = New DateTimePicker()
        chkComp = New CheckBox()
        chkMath = New CheckBox()
        chkLib = New CheckBox()
        ComboBox1 = New ComboBox()
        SuspendLayout()
        ' 
        ' lblFName
        ' 
        lblFName.AutoSize = True
        lblFName.Location = New Point(175, 20)
        lblFName.Name = "lblFName"
        lblFName.Size = New Size(91, 25)
        lblFName.TabIndex = 0
        lblFName.Text = "Full Name"
        ' 
        ' lblDOB
        ' 
        lblDOB.AutoSize = True
        lblDOB.Location = New Point(175, 88)
        lblDOB.Name = "lblDOB"
        lblDOB.Size = New Size(115, 25)
        lblDOB.TabIndex = 1
        lblDOB.Text = "Date Of Birth"
        ' 
        ' lblCYP
        ' 
        lblCYP.AutoSize = True
        lblCYP.Location = New Point(175, 153)
        lblCYP.Name = "lblCYP"
        lblCYP.Size = New Size(206, 25)
        lblCYP.TabIndex = 2
        lblCYP.Text = "Course you are pursuing"
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.Location = New Point(175, 242)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(69, 25)
        lblGender.TabIndex = 3
        lblGender.Text = "Gender"
        ' 
        ' lblClubs
        ' 
        lblClubs.AutoSize = True
        lblClubs.Location = New Point(175, 326)
        lblClubs.Name = "lblClubs"
        lblClubs.Size = New Size(178, 25)
        lblClubs.TabIndex = 6
        lblClubs.Text = "Clubs you belong to:"
        ' 
        ' txtFName
        ' 
        txtFName.Location = New Point(418, 20)
        txtFName.Name = "txtFName"
        txtFName.Size = New Size(347, 31)
        txtFName.TabIndex = 10
        ' 
        ' rdbMale
        ' 
        rdbMale.AutoSize = True
        rdbMale.Location = New Point(373, 242)
        rdbMale.Name = "rdbMale"
        rdbMale.Size = New Size(75, 29)
        rdbMale.TabIndex = 13
        rdbMale.TabStop = True
        rdbMale.Text = "Male"
        rdbMale.UseVisualStyleBackColor = True
        ' 
        ' rdbFemale
        ' 
        rdbFemale.AutoSize = True
        rdbFemale.Location = New Point(554, 242)
        rdbFemale.Name = "rdbFemale"
        rdbFemale.Size = New Size(93, 29)
        rdbFemale.TabIndex = 14
        rdbFemale.TabStop = True
        rdbFemale.Text = "Female"
        rdbFemale.UseVisualStyleBackColor = True
        ' 
        ' lblRegister
        ' 
        lblRegister.Location = New Point(322, 593)
        lblRegister.Name = "lblRegister"
        lblRegister.Size = New Size(164, 57)
        lblRegister.TabIndex = 18
        lblRegister.Text = "REGISTER"
        lblRegister.UseVisualStyleBackColor = True
        ' 
        ' lstRegister
        ' 
        lstRegister.FormattingEnabled = True
        lstRegister.ItemHeight = 25
        lstRegister.Location = New Point(661, 532)
        lstRegister.Name = "lstRegister"
        lstRegister.Size = New Size(250, 204)
        lstRegister.TabIndex = 19
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(418, 88)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(347, 31)
        DateTimePicker1.TabIndex = 20
        ' 
        ' chkComp
        ' 
        chkComp.AutoSize = True
        chkComp.Location = New Point(319, 378)
        chkComp.Name = "chkComp"
        chkComp.Size = New Size(251, 29)
        chkComp.TabIndex = 21
        chkComp.Text = "Computer Society of CUEA"
        chkComp.UseVisualStyleBackColor = True
        ' 
        ' chkMath
        ' 
        chkMath.AutoSize = True
        chkMath.Location = New Point(319, 439)
        chkMath.Name = "chkMath"
        chkMath.Size = New Size(184, 29)
        chkMath.TabIndex = 22
        chkMath.Text = "Mathematic's Club"
        chkMath.UseVisualStyleBackColor = True
        ' 
        ' chkLib
        ' 
        chkLib.AutoSize = True
        chkLib.Location = New Point(319, 502)
        chkLib.Name = "chkLib"
        chkLib.Size = New Size(167, 29)
        chkLib.TabIndex = 23
        chkLib.Text = "Librearian's Club"
        chkLib.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Computer Science", "Information Technology", "Actuarial Science", "Software Engineering", "Data Science", "Graphics Design", "Full Stack Web Development"})
        ComboBox1.Location = New Point(418, 153)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(347, 33)
        ComboBox1.TabIndex = 24
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1269, 782)
        Controls.Add(ComboBox1)
        Controls.Add(chkLib)
        Controls.Add(chkMath)
        Controls.Add(chkComp)
        Controls.Add(DateTimePicker1)
        Controls.Add(lstRegister)
        Controls.Add(lblRegister)
        Controls.Add(rdbFemale)
        Controls.Add(rdbMale)
        Controls.Add(txtFName)
        Controls.Add(lblClubs)
        Controls.Add(lblGender)
        Controls.Add(lblCYP)
        Controls.Add(lblDOB)
        Controls.Add(lblFName)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblFName As Label
    Friend WithEvents lblDOB As Label
    Friend WithEvents lblCYP As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblClubs As Label
    Friend WithEvents txtFName As TextBox
    Friend WithEvents rdbMale As RadioButton
    Friend WithEvents rdbFemale As RadioButton
    Friend WithEvents lblRegister As Button
    Friend WithEvents lstRegister As ListBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents chkComp As CheckBox
    Friend WithEvents chkMath As CheckBox
    Friend WithEvents chkLib As CheckBox
    Friend WithEvents ComboBox1 As ComboBox

End Class
