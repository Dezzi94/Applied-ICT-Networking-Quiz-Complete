Public Class frmResultsProtocols

    Private Sub btnSubmitScoreNProtocols_Click(sender As Object, e As EventArgs) Handles btnSubmitScoreNProtocols.Click
        'Declares a local integer variable called intFinalScoreProtocols.
        Dim intFinalScoreProtocols As Integer
        'Adds all the scores from the form 1,2 and 3 which it then stores in intFinalScoreProtocols.
        intFinalScoreProtocols = frmNetworkingProtocols.intTotalProtocolsScorefrm1 + frmNetworkingProtocols2.intTotalProtocolsScorefrm2 + frmNetworkingProtocols3.intTotalProtocolsScorefrm3
        'It the produces the score in the label lblShowScoreNProtocols.Text and tells the user what they got out of 6.
        lblShowScoreNProtocols.Text = ("You got  " & intFinalScoreProtocols & "  out of 6")

    End Sub

    Private Sub btnBackfrmResultsProtocols_Click(sender As Object, e As EventArgs) Handles btnBackfrmResultsProtocols.Click

        'Hides the current form.
        Me.Hide()
        'Goes to the module modResetSection and runs the code that is in the public sub ResetSection.
        modResetSection.ResetSection()
        'Goes to the Main Menu.
        frmMainMenu.Show()

    End Sub
End Class