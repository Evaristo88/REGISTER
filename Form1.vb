Public Class Form1
    Private Sub lblRegister_Click(sender As Object, e As EventArgs) Handles lblRegister.Click
        Dim fname, dob, course, gender, computer, mathematics, library As String
        fname = txtFName.Text
        dob = DateTimePicker1.Value
        course = ComboBox1.SelectedText
        If rdbMale.Checked Then
            gender = "MALE"

        Else
            gender = "FEMALE"
        End If


        If chkComp.Checked And chkLib.Checked And chkMath.Checked Then


            computer = "Computer Society of CUEA"
            mathematics = "Mathematic's Club"
            library = "Librariain's Club"
        End If

        If chkMath.Checked And chkComp.Checked Then
            mathematics = "Mathematic's Club"
            computer = "Computer Society of CUEA"
            library = ""

        ElseIf chkLib.Checked And chkMath.Checked Then
            library = "Librariain's Club"
            computer = ""
            mathematics = "Mathematic's Club"

        ElseIf chkComp.Checked And chkLib.Checked Then
            computer = "Computer Society of CUEA"
            library = "Librariain's Club"
            mathematics = ""

        ElseIf chkComp.Checked Then
            computer = "Computer Society of CUEA"
            library = ""
            mathematics = ""

        ElseIf chkMath.Checked Then
            mathematics = "Mathematic's Club"
            computer = ""
            library = ""

        ElseIf chkLib.Checked Then
            library = "Librariain's Club"
            computer = ""
            mathematics = ""
        End If

        lstRegister.Items.Add(fname)
        lstRegister.Items.Add(dob)
        lstRegister.Items.Add(course)
        lstRegister.Items.Add(gender)
        lstRegister.Items.Add(computer)
        lstRegister.Items.Add(mathematics)
        lstRegister.Items.Add(library)

    End Sub
End Class
