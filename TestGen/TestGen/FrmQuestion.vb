'Reed Kemp'
'10/14/2015'
'CRN: 1588'
Option Explicit On
Option Strict On

Public Class FrmQuestion
    Public Sub ShowQuestion()
        Dim Index As Integer = 1
        lblQuestion.Text = test(Index).question
        Index = Index + 1
    End Sub
    Private Sub FrmQuestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblQuestion.Text = test(0).question
    End Sub

    Private Sub btnNextQuestion_Click(sender As Object, e As EventArgs) Handles btnNextQuestion.Click
        ShowQuestion()
    End Sub
End Class