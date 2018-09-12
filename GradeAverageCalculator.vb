Public Class Grade_Average_Calculator
    Dim ArrSizeInteger As Integer
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

                GradesTextBox.Clear()
            Catch ex As Exception
                MessageBox.Show("You must enter a number into the text box",
                                "Data entry error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
            End Try
        End If

        ' Always will clear and set focus regardless if action is successful or not
        With GradesTextBox
            .Focus()
            .SelectAll()
        End With
    End Sub

    Private Sub CalculateAverageButton_Click(sender As Object, e As EventArgs) Handles CalculateAverageButton.Click
        Dim CounterInteger As Integer
        Dim GradeAccumulatorDecimal As Decimal

        'Do While CounterInteger < GradesListBox.Items.Count
        'GradeAccumulatorDecimal += GradesListBox.Items(CounterInteger)
        'CounterInteger += 1
        'Loop

        Do Until CounterInteger = GradesListBox.Items.Count
            GradeAccumulatorDecimal += GradesListBox.Items(CounterInteger)
            CounterInteger += 1
        Loop

        'ResultsTextAreaLabel.Text = "The average grade of " & GradesListBox.Items.Count.ToString & " grades," &
        '                           ControlChars.NewLine & "a total of " & GradeAccumulatorDecimal.ToString & " points is" &
        '                           ControlChars.NewLine & (GradeAccumulatorDecimal / GradesListBox.Items.Count).ToString("n1")

        ResultsTextAreaLabel.Text = _
            String.Format("The total of the {0} grade(s) is {1}.{2}" & "Class average grade is: {3:n1}",
                          GradesListBox.Items.Count,
                          GradeAccumulatorDecimal,
                          Environment.NewLine,
                          GradeAccumulatorDecimal / GradesListBox.Items.Count)
    End Sub

    Private Sub ClearGradesButton_Click(sender As Object, e As EventArgs) Handles ClearGradesButton.Click
        GradesTextBox.Clear()
        GradesListBox.Items.Clear()
        ResultsTextAreaLabel.Text = String.Empty
    End Sub
End Class
