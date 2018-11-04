Public Class frmResultsModels

    Private Sub btnSubmitScoreNModels_Click(sender As Object, e As EventArgs) Handles btnSubmitScoreNModels.Click
        'Declares a local integer variable called intFinalScoreModels.
        Dim intFinalScoreModels As Integer
        'Adds all the scores from the form 1,2 and 3 which it then stores in intFinalScoreModels.
        intFinalScoreModels = frmNetworkingModels.intTotalModelsScorefrm1 + frmNetworkingModels2.intTotalModelsScorefrm2 + frmNetworkingModels3.intTotalModelsScorefrm3
        'It the produces the score in the label lblShowScoreNModels.Text and tells the user what they got out of 6.
        lblShowScoreNModels.Text = ("You got  " & intFinalScoreModels & "  out of 6")

    End Sub

    Private Sub btnBackfrmResultsModels_Click(sender As Object, e As EventArgs) Handles btnBackfrmResultsModels.Click
        'Hides the current form.
        Me.Hide()
        'Goes to the module modResetSection and runs the code that is in the public sub ResetSection.
        modResetSection.ResetSection()
        'Runs code in the private subroutine called Cleartextboxes.
        Cleartextboxes()
        'Goes to the Main Menu.
        frmMainMenu.Show()
    End Sub

    Private Sub Cleartextboxes()
        'Creates a For loop to makes all textboxes blank on the form frmNetworkingModels3.
        For index = 0 To 1
            'Makes textbox txtInsertAnswerQ5Models blank.
            frmNetworkingModels3.txtInsertAnswerQ5Models.Text = ""
            'Makes textbox txtInsertAnswer2Q5Models blank.
            frmNetworkingModels3.txtInsertAnswer2Q5Models.Text = ""
            'Makes textbox txtInsertAnswer3Q5Models blank.
            frmNetworkingModels3.txtInsertAnswer3Q5Models.Text = ""
            'Makes textbox txtInsertAnswer4Q5Models blank.
            frmNetworkingModels3.txtInsertAnswer4Q5Models.Text = ""
            'Makes textbox txtInsertAnswer5Q5Models blank.
            frmNetworkingModels3.txtInsertAnswer5Q5Models.Text = ""
            'Makes textbox txtInsertAnswer6Q5Models blank.
            frmNetworkingModels3.txtInsertAnswer6Q5Models.Text = ""
            'Makes textbox txtInsertAnswer7Q5Models blank.
            frmNetworkingModels3.txtInsertAnswer7Q5Models.Text = ""
            'Makes textbox txtInsertAnswerQ6Models blank.
            frmNetworkingModels3.txtInsertAnswerQ6Models.Text = ""
            'Makes textbox txtInsertAnswer2Q6Models blank.
            frmNetworkingModels3.txtInsertAnswer2Q6Models.Text = ""
            'Makes textbox txtInsertAnswer3Q6Models blank.
            frmNetworkingModels3.txtInsertAnswer3Q6Models.Text = ""
            'Makes textbox txtInsertAnswer4Q6Models blank.
            frmNetworkingModels3.txtInsertAnswer4Q6Models.Text = ""
        Next
    End Sub
End Class