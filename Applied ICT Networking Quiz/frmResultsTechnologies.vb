Public Class frmResultsTechnologies

    Private Sub btnSubmitScoreNTechnologies_Click(sender As Object, e As EventArgs) Handles btnSubmitScoreNTechnologies.Click
        'Declares a local integer variable called intFinalScoreTechnologies.
        Dim intFinalScoreTechnologies As Integer
        'Adds all the scores from the form 1,2 and 3 which it then stores in intFinalScoreTechnologies.
        intFinalScoreTechnologies = frmNetworkingTechnologies.intTotalTechnologiesScorefrm1 + frmNetworkingTechnologies2.intTotalTechnologiesScorefrm2 + frmNetworkingTechnologies3.intTotalTechnologiesScorefrm3
        'It the produces the score in the label lblShowScoreNTechnologies.Text and tells the user what they got out of 6.
        lblShowScoreNTechnologies.Text = ("You got  " & intFinalScoreTechnologies & "  out of 6")

    End Sub

    Private Sub btnBackfrmResultsTechnologies_Click(sender As Object, e As EventArgs) Handles btnBackfrmResultsTechnologies.Click

        'Hides the current form.
        Me.Hide()
        'Goes to the module modResetSection and runs the code that is in the public sub ResetSection.
        modResetSection.ResetSection()
        'Goes to the Main Menu.
        frmMainMenu.Show()

    End Sub
End Class