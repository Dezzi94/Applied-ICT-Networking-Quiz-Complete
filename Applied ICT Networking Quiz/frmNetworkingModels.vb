Public Class frmNetworkingModels
    'Declares a public shared Boolean variable called blnCorrectAnswerModelsQ1.
    Public Shared blnCorrectAnswerModelsQ1 As Boolean
    'Declares a public shared Boolean variable called blnCorrectAnswerModelsQ2.
    Public Shared blnCorrectAnswerModelsQ2 As Boolean
    'Declares a public shared Integer variable called intTotalModelsScorefrm1. 
    Public Shared intTotalModelsScorefrm1 As Integer

    Private Sub btnBackfrmNetworkingModels_Click(sender As Object, e As EventArgs) Handles btnBackfrmNetworkingModels.Click
        'Hides the current form.
        Me.Hide()
        'Goes to the module modResetSection and runs the code that is in the public sub ResetSection.
        modResetSection.ResetSection()
        'Shows the Main Menu to the user.
        frmMainMenu.Show()
    End Sub

    Private Sub btnNextNetworkingModels_Click(sender As Object, e As EventArgs) Handles btnNextNetworkingModels.Click
        'Declares a local Integer variable called intScoreQ1Models.
        Dim intScoreQ1Models As Integer
        'Declares a local Integer varible called intScoreQ2Models. 
        Dim intScoreQ2Models As Integer

        'Declares a local 2 element array Boolean called blnWrongAnswersModels.
        Dim blnWrongAnswersModels(0 To 1) As Boolean
        'Assigns blnWrongAnswersModels(0) to the control chkOption2Q1Models.Checked.
        blnWrongAnswersModels(0) = chkOption2Q1Models.Checked
        'Assigns blnWrongAnswersModels(1) to the control chkOption2Q2Models.Checked.
        blnWrongAnswersModels(1) = chkOption2Q2Models.Checked

        'Assigns the variable blnCorrectAnswerModelsQ1 as chkOption1Q1Models.checked. 
        blnCorrectAnswerModelsQ1 = chkOption1Q1Models.Checked
        'Assigns the variable blnCorrectAnswerModelsQ2 as chkOption1Q2Models.checked.
        blnCorrectAnswerModelsQ2 = chkOption1Q2Models.Checked

        'Uses an If statement to see if the checkboxes chkOption1Q1Models and chkOption1Q2Models have been checked and that the other checkboxes remain unchecked. 
        If blnCorrectAnswerModelsQ1 = True And blnCorrectAnswerModelsQ2 = True And blnWrongAnswersModels(0) = False And blnWrongAnswersModels(1) = False Then
            'If the above statement is true then the prgram will add 1 point to intScoreQ1Models.
            intScoreQ1Models = intScoreQ1Models + 1
            'The program will then add another point in intScoreQ2Models. 
            intScoreQ2Models = intScoreQ2Models + 1
            'Otherwise if the statement is false the program will then check to see if blnCorrectAnswerModelsQ1 is false and blnCorrectAnswerModelsQ2 is true.
        ElseIf blnCorrectAnswerModelsQ1 = False And blnCorrectAnswerModelsQ2 = True Then
            'The program will then add no points to intScoreQ1Models if the above statement is true.
            intScoreQ1Models = intScoreQ1Models + 0
            'The program will then add 1 point to intScoreQ2Models.
            intScoreQ2Models = intScoreQ2Models + 1
            'Else if the statement above is false the program will then check to see if blnCorrectAnswerModelsQ1 is true and blnCorrectAnswerModelsQ2 is false.
        ElseIf blnCorrectAnswerModelsQ1 = True And blnCorrectAnswerModelsQ2 = False Then
            ''The program will then add 1 point to intScoreQ1Models if the above statement is true.
            intScoreQ1Models = intScoreQ1Models + 1
            'The program will then add no points to intScoreQ2Models.
            intScoreQ2Models = intScoreQ2Models + 0
            'If the user performs any other conditions outside this if statement then this part of the statement will run.
        Else
            'Adds no points to intScoreQ1Models.
            intScoreQ1Models = intScoreQ1Models + 0
            'Adds no points to intScoreQ2Models.
            intScoreQ2Models = intScoreQ2Models + 0
        End If

        'The program will then add the scores of intScoreQ1Models and intScoreQ2Models together and store it in the public integer variable intTotalModelsScorefrm1
        intTotalModelsScorefrm1 = intScoreQ1Models + intScoreQ2Models
        'Hides the Current form.
        Me.Hide()
        'Shows frmNetworkingModels2.
        frmNetworkingModels2.Show()
    End Sub
End Class