Public Class frmResultsGeneral

    Private Sub btnSubmitScoreNGeneral_Click(sender As Object, e As EventArgs) Handles btnSubmitScoreNGeneral.Click, btnSubmitScoreNGeneral.Click, btnSubmitScoreNGeneral.Click
        'Declares a local integer variable called intFinalScoreGeneral.
        Dim intFinalScoreGeneral As Integer
        'Adds all the scores from the form 1,2 and 3 which it then stores in intFinalScoreGeneral.
        intFinalScoreGeneral = frmNetworkingGeneral.intTotalGeneralScorefrm1 + frmNetworkingGeneral2.intTotalGeneralScorefrm2 + frmNetworkingGeneral3.intTotalGeneralScorefrm3
        'It the produces the score in the label lblShowScoreNGeneral.Text and tells the user what they got out of 6.
        lblShowScoreNGeneral.Text = ("You got  " & intFinalScoreGeneral & "  out of 6")

    End Sub

    Private Sub btnBackfrmResultsGeneral_Click(sender As Object, e As EventArgs) Handles btnBackfrmResultsGeneral.Click
        'Hides the current form.
        Me.Hide()
        'Goes to the module modResetSection and runs the code that is in the public sub ResetSection.
        modResetSection.ResetSection()
        'Goes to the Main Menu.
        frmMainMenu.Show()
    End Sub
End Class