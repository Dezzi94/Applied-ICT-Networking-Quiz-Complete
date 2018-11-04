Public Class frmNetworkingOtherQuestions3
    'Declares a public shared Boolean variable called blnCorrectAnswerOtherQuestionsQ5.
    Public Shared blnCorrectAnswerOtherQuestionsQ5 As Boolean
    'Declares a public shared Boolean variable called blnCorrectAnswerOtherQuestionsQ6.
    Public Shared blnCorrectAnswerOtherQuestionsQ6 As Boolean
    'Declares a public shared Integer variable called intTotalOtherQuestionsScorefrm3. 
    Public Shared intTotalOtherQuestionsScorefrm3 As Integer

    Private Sub btnBackfrmNetworkingOtherQuestions3_Click(sender As Object, e As EventArgs) Handles btnBackfrmNetworkingOtherQuestions3.Click
        'Hides the current form.
        Me.Hide()
        'Goes to the module modResetSection and runs the code that is in the public sub ResetSection.
        modResetSection.ResetSection()
        'Shows the Main Menu to the user.
        frmMainMenu.Show()
    End Sub

    Private Sub btnNextNetworkingOtherQuestions3_Click(sender As Object, e As EventArgs) Handles btnNextNetworkingOtherQuestions3.Click
        'Declares a local Integer variable called intScoreQ5OtherQuestions.
        Dim intScoreQ5OtherQuestions As Integer
        'Declares a local Integer varible called intScoreQ6OtherQuestions. 
        Dim intScoreQ6OtherQuestions As Integer

        'Declares a local 2 element array Boolean called blnWrongAnswersOtherQuestions3.
        Dim blnWrongAnswersOtherQuestions3(0 To 1) As Boolean
        'Assigns blnWrongAnswersOtherQuestions3(0) to the control chkOption2Q5OtherQuestions.Checked.
        blnWrongAnswersOtherQuestions3(0) = chkOption2Q5OtherQuestions.Checked
        'Assigns blnWrongAnswersOtherQuestions3(1) to the control chkOption2Q6OtherQuestions.Checked.
        blnWrongAnswersOtherQuestions3(1) = chkOption2Q6OtherQuestions.Checked

        'Assigns the variable blnCorrectAnswerOtherQuestionsQ5 as chkOption1Q5OtherQuestions.checked. 
        blnCorrectAnswerOtherQuestionsQ5 = chkOption1Q5OtherQuestions.Checked()
        'Assigns the variable blnCorrectAnswerOtherQuestionsQ6 as chkOption1Q6OtherQuestions.checked.
        blnCorrectAnswerOtherQuestionsQ6 = chkOption1Q6OtherQuestions.Checked

        'Uses an If statement to see if the checkboxes chkOption1Q5OtherQuestions and chkOption1Q6OtherQuestions have been checked and that the other checkboxes remain unchecked. 
        If blnCorrectAnswerOtherQuestionsQ5 = True And blnCorrectAnswerOtherQuestionsQ6 = True And blnWrongAnswersOtherQuestions3(0) = False And blnWrongAnswersOtherQuestions3(1) = False Then
            'If the above statement is true then the prgram will add 1 point to intScoreQ5OtherQuestions.
            intScoreQ5OtherQuestions = intScoreQ5OtherQuestions + 1
            'The program will then add another point in intScoreQ6OtherQuestions. 
            intScoreQ6OtherQuestions = intScoreQ6OtherQuestions + 1
            'Otherwise if the statement is false the program will then check to see if blnCorrectAnswerOtherQuestionsQ5 is false and blnCorrectAnswerOtherQuestionsQ6 is true.
        ElseIf blnCorrectAnswerOtherQuestionsQ5 = False And blnCorrectAnswerOtherQuestionsQ6 = True Then
            'The program will then add no points to intScoreQ5OtherQuestions if the above statement is true.
            intScoreQ5OtherQuestions = intScoreQ5OtherQuestions + 0
            'The program will then add 1 point to intScoreQ6OtherQuestions.
            intScoreQ6OtherQuestions = intScoreQ6OtherQuestions + 1
            'Else if the statement above is false the program will then check to see if blnCorrectAnswerOtherQuestionsQ5 is true and blnCorrectAnswerOtherQuestionsQ6 is false.
        ElseIf blnCorrectAnswerOtherQuestionsQ5 = True And blnCorrectAnswerOtherQuestionsQ6 = False Then
            ''The program will then add 1 point to intScoreQ5OtherQuestions if the above statement is true.
            intScoreQ5OtherQuestions = intScoreQ5OtherQuestions + 1
            'The program will then add no points to intScoreQ6OtherQuestions.
            intScoreQ6OtherQuestions = intScoreQ6OtherQuestions + 0
            'If the user performs any other conditions outside this if statement then this part of the statement will run.
        Else
            'Adds no points to intScoreQ5OtherQuestions.
            intScoreQ5OtherQuestions = intScoreQ5OtherQuestions + 0
            'Adds no points to intScoreQ6OtherQuestions.
            intScoreQ6OtherQuestions = intScoreQ6OtherQuestions + 0
        End If

        'The program will then add the scores of intScoreQ5OtherQuestions and intScoreQ6OtherQuestions together and store it in the public integer variable intTotalOtherQuestionsScorefrm3
        intTotalOtherQuestionsScorefrm3 = intScoreQ5OtherQuestions + intScoreQ6OtherQuestions
        'Hides the Current form.
        Me.Hide()
        'Shows frmResultsOtherQuestions.
        frmResultsOtherQuestions.Show()
    End Sub
End Class