Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Select Operator ")
        ComboBox1.Items.Add("Airtel")
        ComboBox1.Items.Add("Aircel")
        ComboBox1.Items.Add("BSNL")


        ComboBox1.Items.Add("Idea")
        ComboBox1.Items.Add("Vodafone")
        ComboBox1.SelectedIndex = 0
        ComboBox2.Items.Add("Select Help Topics")
        ComboBox2.Items.Add("All USSD Codes")
        ComboBox2.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Select Case ComboBox1.SelectedIndex
            Case 1
                Select Case ComboBox2.SelectedIndex
                    Case 1

                        Form7.Show()
                End Select
            Case 2
                Select Case ComboBox2.SelectedIndex
                    Case 1

                        Form11.Show()
                End Select
            Case 3
                Select Case ComboBox2.SelectedIndex
                    Case 1

                        Form20.Show()
                End Select
            Case 4
                Select Case ComboBox2.SelectedIndex
                    Case 1

                        Form21.Show()
                End Select
            Case 5
                Select Case ComboBox2.SelectedIndex
                    Case 1

                        Form22.Show()
                End Select
        End Select
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form8.Show()
    End Sub
End Class