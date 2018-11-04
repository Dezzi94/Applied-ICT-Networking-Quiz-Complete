Public Class frmNetworkingOtherQuestions2
    'Declares a public shared Boolean variable called blnCorrectAnswerOtherQuestionsQ3.
    Public Shared blnCorrectAnswerOtherQuestionsQ3 As Boolean
    'Declares a public shared Boolean variable called blnCorrectAnswerOtherQuestionsQ4.
    Public Shared blnCorrectAnswerOtherQuestionsQ4 As Boolean
    'Declares a public shared Integer variable called intTotalOtherQuestionsScorefrm2. 
    Public Shared intTotalOtherQuestionsScorefrm2 As Integer

    Private Sub btnBackfrmNetworkingOtherQuestions2_Click(sender As Object, e As EventArgs) Handles btnBackfrmNetworkingOtherQuestions2.Click
        'Hides the current form.
        Me.Hide()
        'Goes to the module modResetSection and runs the code that is in the public sub ResetSection.
        modResetSection.ResetSection()
        'Shows the Main Menu to the user.
        frmMainMenu.Show()
    End Sub

    Private Sub btnNextNetworkingOtherQuestions2_Click(sender As Object, e As EventArgs) Handles btnNextNetworkingOtherQuestions2.Click
        'Declares a local Integer variable called intScoreQ3OtherQuestions.
        Dim intScoreQ3OtherQuestions As Integer
        'Declares a local Integer varible called intScoreQ4OtherQuestions. 
        Dim intScoreQ4OtherQuestions As Integer

        'Declares a local 2 element array Boolean called blnWrongAnswersOtherQuestions2.
        Dim blnWrongAnswersOtherQuestions2(0 To 1) As Boolean
        'Assigns blnWrongAnswersOtherQuestions2(0) to the control chkOption2Q3OtherQuestions.Checked.
        blnWrongAnswersOtherQuestions2(0) = chkOption2Q3OtherQuestions.Checked
        'Assigns blnWrongAnswersOtherQuestions2(1) to the control chkOption2Q4OtherQuestions.Checked.
        blnWrongAnswersOtherQuestions2(1) = chkOption2Q4OtherQuestions.Checked

        'Assigns the variable blnCorrectAnswerOtherQuestionsQ3 as chkOption1Q3OtherQuestions.checked. 
        blnCorrectAnswerOtherQuestionsQ3 = chkOption1Q3OtherQuestions.Checked()
        'Assigns the variable blnCorrectAnswerOtherQuestionsQ4 as chkOption1Q4OtherQuestions.checked.
        blnCorrectAnswerOtherQuestionsQ4 = chkOption1Q4OtherQuestions.Checked

        'Uses an If statement to see if the checkboxes chkOption1Q3OtherQuestions and chkOption1Q4OtherQuestions have been checked and that the other checkboxes remain unchecked. 
        If blnCorrectAnswerOtherQuestionsQ3 = True And blnCorrectAnswerOtherQuestionsQ4 = True And blnWrongAnswersOtherQuestions2(0) = False And blnWrongAnswersOtherQuestions2(1) = False Then
            'If the above statement is true then the prgram will add 1 point to intScoreQ3OtherQuestions.
            intScoreQ3OtherQuestions = intScoreQ3OtherQuestions + 1
            'The program will then add another point in intScoreQ4OtherQuestions. 
            intScoreQ4OtherQuestions = intScoreQ4OtherQuestions + 1
            'Otherwise if the statement is false the program will then check to see if blnCorrectAnswerOtherQuestionsQ3 is false and blnCorrectAnswerOtherQuestionsQ4 is true.
        ElseIf blnCorrectAnswerOtherQuestionsQ3 = False And blnCorrectAnswerOtherQuestionsQ4 = True Then
            'The program will then add no points to intScoreQ3OtherQuestions if the above statement is true.
            intScoreQ3OtherQuestions = intScoreQ3OtherQuestions + 0
            'The program will then add 1 point to intScoreQ4OtherQuestions.
            intScoreQ4OtherQuestions = intScoreQ4OtherQuestions + 1
            'Else if the statement above is false the program will then check to see if blnCorrectAnswerOtherQuestionsQ3 is true and blnCorrectAnswerOtherQuestionsQ4 is false.
        ElseIf blnCorrectAnswerOtherQuestionsQ3 = True And blnCorrectAnswerOtherQuestionsQ4 = False Then
            ''The program will then add 1 point to intScoreQ3OtherQuestions if the above statement is true.
            intScoreQ3OtherQuestions = intScoreQ3OtherQuestions + 1
            'The program will then add no points to intScoreQ4OtherQuestions.
            intScoreQ4OtherQuestions = intScoreQ4OtherQuestions + 0
            'If the user performs any other conditions outside this if statement then this part of the statement will run.
        Else
            'Adds no points to intScoreQ3OtherQuestions.
            intScoreQ3OtherQuestions = intScoreQ3OtherQuestions + 0
            'Adds no points to intScoreQ4OtherQuestions.
            intScoreQ4OtherQuestions = intScoreQ4OtherQuestions + 0
        End If

        'The program will then add the scores of intScoreQ3OtherQuestions and intScoreQ4OtherQuestions together and store it in the public integer variable intTotalOtherQuestionsScorefrm2
        intTotalOtherQuestionsScorefrm2 = intScoreQ3OtherQuestions + intScoreQ4OtherQuestions
        'Hides the Current form.
        Me.Hide()
        'Shows frmNetworkingOtherQuestions3.
        frmNetworkingOtherQuestions3.Show()
    End Sub
End Class