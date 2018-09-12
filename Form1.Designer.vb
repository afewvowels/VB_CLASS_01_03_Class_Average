<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GradesListBox = New System.Windows.Forms.ListBox()
        Me.GradesLabel = New System.Windows.Forms.Label()
        Me.EnterLabel = New System.Windows.Forms.Label()
        Me.GradesTextBox = New System.Windows.Forms.TextBox()
        Me.SubmitGradeButton = New System.Windows.Forms.Button()
        Me.CalculateAverageButton = New System.Windows.Forms.Button()
        Me.ClearGradesButton = New System.Windows.Forms.Button()
        Me.ResultsLabel = New System.Windows.Forms.Label()
        Me.ResultsTextAreaLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'GradesListBox
        '
        Me.GradesListBox.FormattingEnabled = True
        Me.GradesListBox.Location = New System.Drawing.Point(12, 28)
        Me.GradesListBox.Name = "GradesListBox"
        Me.GradesListBox.Size = New System.Drawing.Size(56, 199)
        Me.GradesListBox.TabIndex = 0
        '
        'GradesLabel
        '
        Me.GradesLabel.AutoSize = True
        Me.GradesLabel.Location = New System.Drawing.Point(12, 9)
        Me.GradesLabel.Name = "GradesLabel"
        Me.GradesLabel.Size = New System.Drawing.Size(41, 13)
        Me.GradesLabel.TabIndex = 1
        Me.GradesLabel.Text = "Grades"
        '
        'EnterLabel
        '
        Me.EnterLabel.AutoSize = True
        Me.EnterLabel.Location = New System.Drawing.Point(78, 12)
        Me.EnterLabel.Name = "EnterLabel"
        Me.EnterLabel.Size = New System.Drawing.Size(65, 13)
        Me.EnterLabel.TabIndex = 2
        Me.EnterLabel.Text = "Enter grade:"
        '
        'GradesTextBox
        '
        Me.GradesTextBox.Location = New System.Drawing.Point(149, 9)
        Me.GradesTextBox.Name = "GradesTextBox"
        Me.GradesTextBox.Size = New System.Drawing.Size(100, 20)
        Me.GradesTextBox.TabIndex = 3
        '
        'SubmitGradeButton
        '
        Me.SubmitGradeButton.Location = New System.Drawing.Point(74, 46)
        Me.SubmitGradeButton.Name = "SubmitGradeButton"
        Me.SubmitGradeButton.Size = New System.Drawing.Size(174, 23)
        Me.SubmitGradeButton.TabIndex = 4
        Me.SubmitGradeButton.Text = "Submit Grade"
        Me.SubmitGradeButton.UseVisualStyleBackColor = True
        '
        'CalculateAverageButton
        '
        Me.CalculateAverageButton.Location = New System.Drawing.Point(74, 75)
        Me.CalculateAverageButton.Name = "CalculateAverageButton"
        Me.CalculateAverageButton.Size = New System.Drawing.Size(174, 23)
        Me.CalculateAverageButton.TabIndex = 5
        Me.CalculateAverageButton.Text = "Calculate Average"
        Me.CalculateAverageButton.UseVisualStyleBackColor = True
        '
        'ClearGradesButton
        '
        Me.ClearGradesButton.Location = New System.Drawing.Point(74, 204)
        Me.ClearGradesButton.Name = "ClearGradesButton"
        Me.ClearGradesButton.Size = New System.Drawing.Size(174, 23)
        Me.ClearGradesButton.TabIndex = 6
        Me.ClearGradesButton.Text = "Clear Grades"
        Me.ClearGradesButton.UseVisualStyleBackColor = True
        '
        'ResultsLabel
        '
        Me.ResultsLabel.AutoSize = True
        Me.ResultsLabel.Location = New System.Drawing.Point(75, 105)
        Me.ResultsLabel.Name = "ResultsLabel"
        Me.ResultsLabel.Size = New System.Drawing.Size(42, 13)
        Me.ResultsLabel.TabIndex = 7
        Me.ResultsLabel.Text = "Results"
        '
        'ResultsTextAreaLabel
        '
        Me.ResultsTextAreaLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ResultsTextAreaLabel.Location = New System.Drawing.Point(75, 122)
        Me.ResultsTextAreaLabel.Name = "ResultsTextAreaLabel"
        Me.ResultsTextAreaLabel.Size = New System.Drawing.Size(173, 79)
        Me.ResultsTextAreaLabel.TabIndex = 8
        Me.ResultsTextAreaLabel.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(264, 243)
        Me.Controls.Add(Me.ResultsTextAreaLabel)
        Me.Controls.Add(Me.ResultsLabel)
        Me.Controls.Add(Me.ClearGradesButton)
        Me.Controls.Add(Me.CalculateAverageButton)
        Me.Controls.Add(Me.SubmitGradeButton)
        Me.Controls.Add(Me.GradesTextBox)
        Me.Controls.Add(Me.EnterLabel)
        Me.Controls.Add(Me.GradesLabel)
        Me.Controls.Add(Me.GradesListBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GradesListBox As System.Windows.Forms.ListBox
    Friend WithEvents GradesLabel As System.Windows.Forms.Label
    Friend WithEvents EnterLabel As System.Windows.Forms.Label
    Friend WithEvents GradesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SubmitGradeButton As System.Windows.Forms.Button
    Friend WithEvents CalculateAverageButton As System.Windows.Forms.Button
    Friend WithEvents ClearGradesButton As System.Windows.Forms.Button
    Friend WithEvents ResultsLabel As System.Windows.Forms.Label
    Friend WithEvents ResultsTextAreaLabel As System.Windows.Forms.Label

End Class
