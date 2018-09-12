Public Class Form1

    Private Sub SubmitGradeButton_Click(sender As Object, e As EventArgs) Handles SubmitGradeButton.Click
        Dim TempGradeDecmial As Decimal

        If GradesTextBox.Text Is String.Empty Then
            MessageBox.Show("You must enter a number into the text box",
                            "Data entry error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        Else
            ' Grade entered, .text is not blank, need to test for number
            Try
                TempGradeDecmial = Decimal.Parse(GradesTextBox.Text)

                GradesListBox.Items.Add(TempGradeDecmial.ToString)
            Catch ex As Exception
                MessageBox.Show("You must enter a number into the text box",
                                "Data entry error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
            End Try
        End If

        ' Always will clear and set focus regardless if action is successful or not
        GradesTextBox.Clear()
        GradesTextBox.Focus()
    End Sub
End Class
