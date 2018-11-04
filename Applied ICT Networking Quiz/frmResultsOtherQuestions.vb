Public Class frmResultsOtherQuestions

    Private Sub btnSubmitScoreNOtherQuestions_Click(sender As Object, e As EventArgs) Handles btnSubmitScoreNOtherQuestions.Click
        'Declares a local integer variable called intFinalScoreOtherQuestions.
        Dim intFinalScoreOtherQuestions As Integer
        'Adds all the scores from the form 1,2 and 3 which it then stores in intFinalScoreOtherQuestions.
        intFinalScoreOtherQuestions = frmNetworkingOtherQuestions.intTotalOtherQuestionsScorefrm1 + frmNetworkingOtherQuestions2.intTotalOtherQuestionsScorefrm2 + frmNetworkingOtherQuestions3.intTotalOtherQuestionsScorefrm3
        'It the produces the score in the label lblShowScoreNOtherQuestions.Text and tells the user what they got out of 6.
        lblShowScoreNOtherQuestions.Text = ("You got  " & intFinalScoreOtherQuestions & "  out of 6")

    End Sub

    Private Sub btnBackfrmResultsOtherQuestions_Click(sender As Object, e As EventArgs) Handles btnBackfrmResultsOtherQuestions.Click

        'Hides the current form.
        Me.Hide()
        'Goes to the module modResetSection and runs the code that is in the public sub ResetSection.
        modResetSection.ResetSection()
        'Goes to the Main Menu.
        frmMainMenu.Show()

    End Sub
End Class