Public Class frmResultsTypes

    Private Sub btnSubmitScoreNTypes_Click(sender As Object, e As EventArgs) Handles btnSubmitScoreNTypes.Click, btnSubmitScoreNTypes.Click, btnSubmitScoreNTypes.Click
        'Declares a local integer variable called intFinalScoreTypes.
        Dim intFinalScoreTypes As Integer
        'Adds all the scores from the form 1,2 and 3 which it then stores in intFinalScoreTypes.
        intFinalScoreTypes = frmNetworkingTypes.intTotalTypesScorefrm1 + frmNetworkingTypes2.intTotalTypesScorefrm2 + frmNetworkingTypes3.intTotalTypesScorefrm3
        'It the produces the score in the label lblShowScoreNTypes.Text and tells the user what they got out of 6.
        lblShowScoreNTypes.Text = ("You got  " & intFinalScoreTypes & "  out of 6")

    End Sub

    Private Sub btnBackfrmResultsTypes_Click(sender As Object, e As EventArgs) Handles btnBackfrmResultsTypes.Click
        'Hides the current form.
        Me.Hide()
        'Goes to the module modResetSection and runs the code that is in the public sub ResetSection.
        modResetSection.ResetSection()
        'Goes to the Main Menu.
        frmMainMenu.Show()
    End Sub
End Class