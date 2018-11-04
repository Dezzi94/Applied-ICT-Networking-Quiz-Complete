Public Class frmResultsArchitectures

    Private Sub btnSubmitScoreNArchitectures_Click(sender As Object, e As EventArgs) Handles btnSubmitScoreNArchitectures.Click, btnSubmitScoreNArchitectures.Click, btnSubmitScoreNArchitectures.Click
        'Declares a local integer variable called intFinalScoreArchitectures.
        Dim intFinalScoreArchitectures As Integer
        'Adds all the scores from the form 1,2 and 3 which it then stores in intFinalScoreArchitectures.
        intFinalScoreArchitectures = frmNetworkingArchitectures.intTotalArchitecturesScorefrm1 + frmNetworkingArchitectures2.intTotalArchitecturesScorefrm2 + frmNetworkingArchitectures3.intTotalArchitecturesScorefrm3
        'It the produces the score in the label lblShowScoreNArchitectures.Text and tells the user what they got out of 6.
        lblShowScoreNArchitectures.Text = ("You got  " & intFinalScoreArchitectures & "  out of 6")

    End Sub

    Private Sub btnBackfrmResultsArchitectures_Click(sender As Object, e As EventArgs) Handles btnBackfrmResultsArchitectures.Click

        'Hides the current form.
        Me.Hide()
        'Goes to the module modResetSection and runs the code that is in the public sub ResetSection.
        modResetSection.ResetSection()
        'Goes to the Main Menu.
        frmMainMenu.Show()

    End Sub
End Class