Public Class frmResultsTopologys

    Private Sub btnSubmitScoreNT_Click(sender As Object, e As EventArgs) Handles btnSubmitScoreNT.Click, btnSubmitScoreNT.Click
        'Declares a local integer variable called intFinalScoreTopology.
        Dim intFinalScoreTopology As Integer

        'Adds all the scores from the form 1,2 and 3 which it then stores in intFinalScoreTopology.
        intFinalScoreTopology = frmNetworkingTopologys.intTotalTopologyScorefrm1 + frmNetworkingTopologys2.intTotalTopologyScorefrm2 + frmNetworkingTopologys3.intTotalTopologyScorefrm3
        'It the produces the score in the label lblShowScoreNT.Text and tells the user what they got out of 6.
        lblShowScoreNT.Text = ("You got  " & intFinalScoreTopology & "  out of 6")

    End Sub

    Private Sub btnBackfrmResultsTopology_Click(sender As Object, e As EventArgs) Handles btnBackfrmResultsTopology.Click
        'Hides the current form.
        Me.Hide()
        'Goes to the module modResetSection and runs the code that is in the public sub ResetSection.
        modResetSection.ResetSection()
        lblShowScoreNT.Text = ""
        'Goes to the Main Menu.
        frmMainMenu.Show()
    End Sub
End Class