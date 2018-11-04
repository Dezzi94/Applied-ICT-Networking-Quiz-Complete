Public Class frmResultsComponents

    Private Sub btnSubmitScoreNComponents_Click(sender As Object, e As EventArgs) Handles btnSubmitScoreNComponents.Click
        'Declares a local integer variable called intFinalScoreComponents.
        Dim intFinalScoreComponents As Integer
        'Adds all the scores from the form 1,2 and 3 which it then stores in intFinalScoreComponents.
        intFinalScoreComponents = frmNetworkingComponents.intTotalComponentsScorefrm1 + frmNetworkingComponents2.intTotalComponentsScorefrm2 + frmNetworkingComponents3.intTotalComponentsScorefrm3
        'It the produces the score in the label lblShowScoreNComponents.Text and tells the user what they got out of 6.
        lblShowScoreNComponents.Text = ("You got  " & intFinalScoreComponents & "  out of 6")

    End Sub

    Private Sub btnBackfrmResultsComponents_Click(sender As Object, e As EventArgs) Handles btnBackfrmResultsComponents.Click
        'Hides the current form.
        Me.Hide()
        'Goes to the module modResetSection and runs the code that is in the public sub ResetSection.
        modResetSection.ResetSection()
        'Goes to the Main Menu.
        frmMainMenu.Show()
    End Sub
End Class