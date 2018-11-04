Public Class frmNetworkingModels2
    'Declares a public shared Boolean variable called blnCorrectAnswerModelsQ3.
    Public Shared blnCorrectAnswerModelsQ3 As Boolean
    'Declares a public shared Boolean variable called blnCorrectAnswerModelsQ4.
    Public Shared blnCorrectAnswerModelsQ4 As Boolean
    'Declares a public shared Integer variable called intTotalModelsScorefrm2. 
    Public Shared intTotalModelsScorefrm2 As Integer

    Private Sub btnBackfrmNetworkingModels2_Click(sender As Object, e As EventArgs) Handles btnBackfrmNetworkingModels2.Click
        'Hides the current form.
        Me.Hide()
        'Goes to the module modResetSection and runs the code that is in the public sub ResetSection.
        modResetSection.ResetSection()
        'Shows the Main Menu to the user.
        frmMainMenu.Show()
    End Sub

    Private Sub btnNextNetworkingModels2_Click(sender As Object, e As EventArgs) Handles btnNextNetworkingModels2.Click
        'Declares a local Integer variable called intScoreQ3Models.
        Dim intScoreQ3Models As Integer
        'Declares a local Integer varible called intScoreQ4Models. 
        Dim intScoreQ4Models As Integer

        'Declares a local 2 element array Boolean called blnWrongAnswersModels2.
        Dim blnWrongAnswersModels2(0 To 1) As Boolean
        'Assigns blnWrongAnswersModels2(0) to the control chkOption2Q3Models.Checked.
        blnWrongAnswersModels2(0) = chkOption2Q3Models.Checked
        'Assigns blnWrongAnswersModels2(1) to the control chkOption2Q4Models.Checked.
        blnWrongAnswersModels2(1) = chkOption2Q4Models.Checked

        'Assigns the variable blnCorrectAnswerModelsQ1 as chkOption1Q3Models.checked. 
        blnCorrectAnswerModelsQ3 = chkOption1Q3Models.Checked()
        'Assigns the variable blnCorrectAnswerModelsQ4 as chkOption1Q4Models.checked.
        blnCorrectAnswerModelsQ4 = chkOption1Q4Models.Checked

        'Uses an If statement to see if the checkboxes chkOption1Q3Models and chkOption1Q4Models have been checked and that the other checkboxes remain unchecked. 
        If blnCorrectAnswerModelsQ3 = True And blnCorrectAnswerModelsQ4 = True And blnWrongAnswersModels2(0) = False And blnWrongAnswersModels2(1) = False Then
            'If the above statement is true then the prgram will add 1 point to intScoreQ3Models.
            intScoreQ3Models = intScoreQ3Models + 1
            'The program will then add another point in intScoreQ4Models. 
            intScoreQ4Models = intScoreQ4Models + 1
            'Otherwise if the statement is false the program will then check to see if blnCorrectAnswerModelsQ3 is false and blnCorrectAnswerModelsQ4 is true.
        ElseIf blnCorrectAnswerModelsQ3 = False And blnCorrectAnswerModelsQ4 = True Then
            'The program will then add no points to intScoreQ3Models if the above statement is true.
            intScoreQ3Models = intScoreQ3Models + 0
            'The program will then add 1 point to intScoreQ4Models.
            intScoreQ4Models = intScoreQ4Models + 1
            'Else if the statement above is false the program will then check to see if blnCorrectAnswerModelsQ3 is true and blnCorrectAnswerModelsQ4 is false.
        ElseIf blnCorrectAnswerModelsQ3 = True And blnCorrectAnswerModelsQ4 = False Then
            ''The program will then add 1 point to intScoreQ3Models if the above statement is true.
            intScoreQ3Models = intScoreQ3Models + 1
            'The program will then add no points to intScoreQ4Models.
            intScoreQ4Models = intScoreQ4Models + 0
            'If the user performs any other conditions outside this if statement then this part of the statement will run.
        Else
            'Adds no points to intScoreQ3Models.
            intScoreQ3Models = intScoreQ3Models + 0
            'Adds no points to intScoreQ4Models.
            intScoreQ4Models = intScoreQ4Models + 0
        End If

        'The program will then add the scores of intScoreQ3Models and intScoreQ4Models together and store it in the public integer variable intTotalModelsScorefrm2
        intTotalModelsScorefrm2 = intScoreQ3Models + intScoreQ4Models
        'Hides the Current form.
        Me.Hide()
        'Shows frmNetworkingModels3.
        frmNetworkingModels3.Show()
    End Sub
End Class