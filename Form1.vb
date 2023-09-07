Imports System.Diagnostics.Eventing.Reader

Public Class Form1
    Private Sub btnResults_Click(sender As Object, e As EventArgs) Handles btnResults.Click


        Dim Score As Integer
        Score = txtScore.Text

        If IsNumeric(txtScore.Text) Then
            Score = Integer.Parse(txtScore.Text)
        Else
            MessageBox.Show("Not a number")
            Exit Sub
        End If

        If (Score < 0 Or Score > 100) Then
            MessageBox.Show("Invalid score")
        ElseIf Score < 50 Then
            MessageBox.Show("Failed")
        ElseIf Score >= 50 Then
            MessageBox.Show("Pass")
        End If
    End Sub
End Class
