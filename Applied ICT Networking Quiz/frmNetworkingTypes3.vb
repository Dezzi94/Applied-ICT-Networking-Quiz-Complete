Public Class frmNetworkingTypes3
    'Declares a public shared Boolean variable called blnCorrectAnswerTypesQ5. 
    Public Shared blnCorrectAnswerTypesQ5 As Boolean
    'Declares a public shared Boolean variable called blnCorrectAnswerTypesQ6. 
    Public Shared blnCorrectAnswerTypesQ6 As Boolean
    'Declares a public shared Integer variable called intTotalTypesScorefrm3. 
    Public Shared intTotalTypesScorefrm3 As Integer

    Private Sub btnBackfrmNetworkingTypes3_Click(sender As Object, e As EventArgs) Handles btnBackfrmNetworkingTypes3.Click
        'Hides the current form.
        Me.Hide()
        'Goes to the module modResetSection and runs the code that is in the public sub ResetSection.
        modResetSection.ResetSection()
        'Shows the Main Menu to the user.
        frmMainMenu.Show()
    End Sub

    Private Sub btnNextNetworkingTypes3_Click(sender As Object, e As EventArgs) Handles btnNextNetworkingTypes3.Click
        'Declares a local Integer variable called intScoreQ5Types.
        Dim intScoreQ5Types As Integer
        'Declares a local Integer varible called intScoreQ6Types. 
        Dim intScoreQ6Types As Integer

        'Declares a local 4 element array Boolean called blnWrongAnswersTypes3.
        Dim blnWrongAnswersTypes3(0 To 1) As Boolean
        'Assigns blnWrongAnswersTypes3(0) to the control chkOption2Q5Types.Checked.
        blnWrongAnswersTypes3(0) = chkOption1Q5Types.Checked
        'Assigns blnWrongAnswersTypes3(1) to the control chkOption2Q6Types.Checked.
        blnWrongAnswersTypes3(1) = chkOption2Q6Types.Checked

        'Assigns the variable blnCorrectAnswerTypesQ5 as chkOption1Q5Types.checked. 
        blnCorrectAnswerTypesQ5 = chkOption2Q5Types.Checked
        'Assigns the variable blnCorrectAnswerTypesQ6 as chkOption1Q6Types.checked.
        blnCorrectAnswerTypesQ6 = chkOption1Q6Types.Checked

        'Uses an If statement to see if the checkboxes chkOption1Q5Types and chkOption1Q6Types have been checked and that the other checkboxes remain unchecked. 
        If blnCorrectAnswerTypesQ5 = True And blnCorrectAnswerTypesQ6 = True And blnWrongAnswersTypes3(0) = False And blnWrongAnswersTypes3(1) = False Then
            'If the above statement is true then the prgram will add 1 point to intScoreQ5Types.
            intScoreQ5Types = intScoreQ5Types + 1
            'The program will then add another point in intScoreQ6Types. 
            intScoreQ6Types = intScoreQ6Types + 1
            'Otherwise if the statement is false the program will then check to see if blnCorrectAnswerTypesQ5 is false and blnCorrectAnswerTypesQ6 is true.
        ElseIf blnCorrectAnswerTypesQ5 = False And blnCorrectAnswerTypesQ6 = True Then
            'The program will then add no points to intScoreQ1Types if the above statement is true.
            intScoreQ5Types = intScoreQ5Types + 0
            'The program will then add 1 point to intScoreQ2Types.
            intScoreQ6Types = intScoreQ6Types + 1
            'Else if the statement above is false the program will then check to see if blnCorrectAnswerTypesQ5 is true and blnCorrectAnswerTypesQ6 is false.
        ElseIf blnCorrectAnswerTypesQ5 = True And blnCorrectAnswerTypesQ6 = False Then
            ''The program will then add 1 point to intScoreQ5Types if the above statement is true.
            intScoreQ5Types = intScoreQ5Types + 1
            'The program will then add no points to intScoreQ6Types.
            intScoreQ6Types = intScoreQ6Types + 0
            'If the user performs any other conditions outside this if statement then this part of the statement will run.
        Else
            'Adds no points to intScoreQ5Types.
            intScoreQ5Types = intScoreQ5Types + 0
            'Adds no points to intScoreQ6Types
            intScoreQ6Types = intScoreQ6Types + 0
        End If

        'The program will then add the scores of intScoreQ5Types and intScoreQ6Types together and store it in the public integer variable intTotalTypesScorefrm3
        intTotalTypesScorefrm3 = intScoreQ5Types + intScoreQ6Types

        'Hides the Current form.
        Me.Hide()
        'Shows the form frmResultsTypes.
        frmResultsTypes.Show()
    End Sub
End Class