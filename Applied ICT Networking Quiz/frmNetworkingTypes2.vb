Public Class frmNetworkingTypes2
    'Declares a public shared Boolean variable called blnCorrectAnswerTypesQ3. 
    Public Shared blnCorrectAnswerTypesQ3 As Boolean
    'Declares a public shared Boolean variable called blnCorrectAnswerTypesQ4. 
    Public Shared blnCorrectAnswerTypesQ4 As Boolean
    'Declares a public shared Integer variable called intTotalTypesScorefrm2. 
    Public Shared intTotalTypesScorefrm2 As Integer

    Private Sub btnBackfrmNetworkingTypes2_Click(sender As Object, e As EventArgs) Handles btnBackfrmNetworkingTypes2.Click
        'Hides the current form.
        Me.Hide()
        'Goes to the module modResetSection and runs the code that is in the public sub ResetSection.
        modResetSection.ResetSection()
        'Shows the Main Menu to the user.
        frmMainMenu.Show()
    End Sub

    Private Sub btnNextNetworkingTypes2_Click(sender As Object, e As EventArgs) Handles btnNextNetworkingTypes2.Click
        'Declares a local Integer varible called intScoreQ3Types.
        Dim intScoreQ3Types As Integer
        'Declares a local Integer varible called intScoreQ4Types.
        Dim intScoreQ4Types As Integer

        'Declares a local 4 element array Boolean called blnWrongAnswersTypes2.
        Dim blnWrongAnswersTypes2(0 To 1) As Boolean
        'Assigns blnWrongAnswersTypes(0) to the control chkOption2Q2Types.Checked.
        blnWrongAnswersTypes2(0) = chkOption2Q3Types.Checked
        'Assigns blnWrongAnswersTypes(1) to the control chkOption1Q2Types.Checked.
        blnWrongAnswersTypes2(1) = chkOption1Q4Types.Checked

        'Assigns the variable blnCorrectAnswerQ3Types as chkOption1Q3Types.checked.
        blnCorrectAnswerTypesQ3 = chkOption1Q3Types.Checked
        'Assigns the variable blnCorrectAnswerQ4Types as chkOption2Q4Types.checked.
        blnCorrectAnswerTypesQ4 = chkOption2Q4Types.Checked()

        'Uses an If statement to see if the chkOption1Q3Types and chkOption2Q4Types have been checked and that the other checkboxes remain unchecked. 
        If blnCorrectAnswerTypesQ3 = True And blnCorrectAnswerTypesQ4 = True And blnWrongAnswersTypes2(0) = False And blnWrongAnswersTypes2(1) = False Then
            'The program will then add another point in intScoreQ3Types. 
            intScoreQ3Types = intScoreQ3Types + 1
            'The program will then add another point in intScoreQ4Types. 
            intScoreQ4Types = intScoreQ4Types + 1
            'Otherwise if the statement is false the program will then check to see if blnCorrectAnswerTypesQ3 is false and blnCorrectAnswerTypesQ4 is true.
        ElseIf blnCorrectAnswerTypesQ3 = False And blnCorrectAnswerTypesQ4 = True Then
            'The program will then add no points to intScoreQ3Types if the above statement is true.
            intScoreQ3Types = intScoreQ4Types + 0
            'The program will then add 1 point to intScoreQ4Types.
            intScoreQ3Types = intScoreQ4Types + 1
            'Else if the statement above is false the program will then check to see if blnCorrectAnswerTypesQ3 is true and blnCorrectAnswerTypesQ4 is false.
        ElseIf blnCorrectAnswerTypesQ3 = True And blnCorrectAnswerTypesQ4 = False Then
            ''The program will then add 1 point to intScoreQ3Types if the above statement is true.
            intScoreQ3Types = intScoreQ4Types + 1
            'The program will then add no points to intScoreQ4Types.
            intScoreQ3Types = intScoreQ4Types + 0
            'If the user performs any other conditions outside this if statement then this part of the statement will run.
        Else
            'Adds no points to intScoreQ3Types.
            intScoreQ3Types = intScoreQ4Types + 0
            'Adds no points to intScoreQ4Types
            intScoreQ3Types = intScoreQ4Types + 0
        End If

        'The program will then add the scores of intScoreQ3Types and intScoreQ4Types together and store it in the public integer variable intTotalTypesScorefrm2
        intTotalTypesScorefrm2 = intScoreQ3Types + intScoreQ4Types

        'Hides the Current form.
        Me.Hide()
        'Shows frmNetworkingTypes3.
        frmNetworkingTypes3.Show()
    End Sub
End Class
