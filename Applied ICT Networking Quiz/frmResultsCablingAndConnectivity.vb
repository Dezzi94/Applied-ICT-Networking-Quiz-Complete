Public Class frmResultsCablingAndConnectivity

    Private Sub btnSubmitScoreNCablingAndConnectivity_Click(sender As Object, e As EventArgs) Handles btnSubmitScoreNCablingAndConnectivity.Click
        'Declares a local integer variable called intFinalScoreCablingAndConnectivity.
        Dim intFinalScoreCablingAndConnectivity As Integer
        'Adds all the scores from the form 1,2 and 3 which it then stores in intFinalScoreCablingAndConnectivity.
        intFinalScoreCablingAndConnectivity = frmNetworkingCablingAndConnectivity.intTotalCablingAndConnectivityScorefrm1 + frmNetworkingCablingAndConnectivity2.intTotalCablingAndConnectivityScorefrm2 + frmNetworkingCablingAndConnectivity3.intTotalCablingAndConnectivityScorefrm3
        'It the produces the score in the label lblShowScoreNCablingAndConnectivity.Text and tells the user what they got out of 6.
        lblShowScoreNCablingAndConnectivity.Text = ("You got  " & intFinalScoreCablingAndConnectivity & "  out of 6")

    End Sub

    Private Sub btnBackfrmResultsCablingAndConnectivity_Click(sender As Object, e As EventArgs) Handles btnBackfrmResultsCablingAndConnectivity.Click

        'Hides the current form.
        Me.Hide()
        'Goes to the module modResetSection and runs the code that is in the public sub ResetSection.
        modResetSection.ResetSection()
        'Goes to the Main Menu.
        frmMainMenu.Show()

    End Sub
End Class