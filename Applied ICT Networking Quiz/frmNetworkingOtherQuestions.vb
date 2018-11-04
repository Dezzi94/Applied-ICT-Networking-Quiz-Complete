Public Class frmNetworkingOtherQuestions
    'Declares a public shared Boolean variable called blnCorrectAnswerOtherQuestionsQ1.
    Public Shared blnCorrectAnswerOtherQuestionsQ1 As Boolean
    'Declares a public shared Boolean variable called blnCorrectAnswerOtherQuestionsQ2.
    Public Shared blnCorrectAnswerOtherQuestionsQ2 As Boolean
    'Declares a public shared Integer variable called intTotalOtherQuestionsScorefrm1. 
    Public Shared intTotalOtherQuestionsScorefrm1 As Integer

    Private Sub btnBackfrmNetworkingOtherQuestions_Click(sender As Object, e As EventArgs) Handles btnBackfrmNetworkingOtherQuestions.Click
        'Hides the current form.
        Me.Hide()
        'Goes to the module modResetSection and runs the code that is in the public sub ResetSection.
        modResetSection.ResetSection()
        'Shows the Main Menu to the user.
        frmMainMenu.Show()
    End Sub

    Private Sub btnNextNetworkingOtherQuestions_Click(sender As Object, e As EventArgs) Handles btnNextNetworkingOtherQuestions.Click
        'Declares a local Integer variable called intScoreQ1OtherQuestions.
        Dim intScoreQ1OtherQuestions As Integer
        'Declares a local Integer varible called intScoreQ2OtherQuestions. 
        Dim intScoreQ2OtherQuestions As Integer

        'Declares a local 2 element array Boolean called blnWrongAnswersOtherQuestions.
        Dim blnWrongAnswersOtherQuestions(0 To 1) As Boolean
        'Assigns blnWrongAnswersOtherQuestions(0) to the control chkOption2Q1OtherQuestions.Checked.
        blnWrongAnswersOtherQuestions(0) = chkOption2Q1OtherQuestions.Checked
        'Assigns blnWrongAnswersOtherQuestions(1) to the control chkOption2Q2OtherQuestions.Checked.
        blnWrongAnswersOtherQuestions(1) = chkOption2Q2OtherQuestions.Checked

        'Assigns the variable blnCorrectAnswerOtherQuestionsQ1 as chkOption1Q1OtherQuestions.checked. 
        blnCorrectAnswerOtherQuestionsQ1 = chkOption1Q1OtherQuestions.Checked()
        'Assigns the variable blnCorrectAnswerOtherQuestionsQ2 as chkOption1Q2OtherQuestions.checked.
        blnCorrectAnswerOtherQuestionsQ2 = chkOption1Q2OtherQuestions.Checked

        'Uses an If statement to see if the checkboxes chkOption1Q1OtherQuestions and chkOption1Q2OtherQuestions have been checked and that the other checkboxes remain unchecked. 
        If blnCorrectAnswerOtherQuestionsQ1 = True And blnCorrectAnswerOtherQuestionsQ2 = True And blnWrongAnswersOtherQuestions(0) = False And blnWrongAnswersOtherQuestions(1) = False Then
            'If the above statement is true then the prgram will add 1 point to intScoreQ1OtherQuestions.
            intScoreQ1OtherQuestions = intScoreQ1OtherQuestions + 1
            'The program will then add another point in intScoreQ2OtherQuestions. 
            intScoreQ2OtherQuestions = intScoreQ2OtherQuestions + 1
            'Otherwise if the statement is false the program will then check to see if blnCorrectAnswerOtherQuestionsQ1 is false and blnCorrectAnswerOtherQuestionsQ2 is true.
        ElseIf blnCorrectAnswerOtherQuestionsQ1 = False And blnCorrectAnswerOtherQuestionsQ2 = True Then
            'The program will then add no points to intScoreQ1OtherQuestions if the above statement is true.
            intScoreQ1OtherQuestions = intScoreQ1OtherQuestions + 0
            'The program will then add 1 point to intScoreQ2OtherQuestions.
            intScoreQ2OtherQuestions = intScoreQ2OtherQuestions + 1
            'Else if the statement above is false the program will then check to see if blnCorrectAnswerOtherQuestionsQ1 is true and blnCorrectAnswerOtherQuestionsQ2 is false.
        ElseIf blnCorrectAnswerOtherQuestionsQ1 = True And blnCorrectAnswerOtherQuestionsQ2 = False Then
            ''The program will then add 1 point to intScoreQ1OtherQuestions if the above statement is true.
            intScoreQ1OtherQuestions = intScoreQ1OtherQuestions + 1
            'The program will then add no points to intScoreQ2OtherQuestions.
            intScoreQ2OtherQuestions = intScoreQ2OtherQuestions + 0
            'If the user performs any other conditions outside this if statement then this part of the statement will run.
        Else
            'Adds no points to intScoreQ1OtherQuestions.
            intScoreQ1OtherQuestions = intScoreQ1OtherQuestions + 0
            'Adds no points to intScoreQ2OtherQuestions.
            intScoreQ2OtherQuestions = intScoreQ2OtherQuestions + 0
        End If

        'The program will then add the scores of intScoreQ1OtherQuestions and intScoreQ2OtherQuestions together and store it in the public integer variable intTotalOtherQuestionsScorefrm1
        intTotalOtherQuestionsScorefrm1 = intScoreQ1OtherQuestions + intScoreQ2OtherQuestions
        'Hides the Current form.
        Me.Hide()
        'Shows frmNetworkingOtherQuestions2.
        frmNetworkingOtherQuestions2.Show()
    End Sub
End Class