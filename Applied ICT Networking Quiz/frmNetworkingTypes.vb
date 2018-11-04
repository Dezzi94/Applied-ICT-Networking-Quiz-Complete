Public Class frmNetworkingTypes
    'Declares a public shared Boolean variable called blnCorrectAnswerTypesQ1. 
    Public Shared blnCorrectAnswerTypesQ1 As Boolean
    'Declares a public shared Boolean variable called blnCorrectAnswerTypesQ2. 
    Public Shared blnCorrectAnswerTypesQ2 As Boolean
    'Declares a public shared Integer variable called intTotalTypesScorefrm1. 
    Public Shared intTotalTypesScorefrm1 As Integer

    Private Sub btnBackfrmNetworkingTypes_Click(sender As Object, e As EventArgs) Handles btnBackfrmNetworkingTypes.Click
        'Hides the current form.
        Me.Hide()
        'Goes to the module modResetSection and runs the code that is in the public sub ResetSection.
        modResetSection.ResetSection()
        'Shows the Main Menu to the user.
        frmMainMenu.Show()
    End Sub

    Private Sub btnNextNetworkingTypes_Click(sender As Object, e As EventArgs) Handles btnNextNetworkingTypes.Click
        'Declares a local Integer variable called intScoreQ1Types.
        Dim intScoreQ1Types As Integer
        'Declares a local Integer varible called intScoreQ2Types. 
        Dim intScoreQ2Types As Integer

        'Declares a local 4 element array Boolean called blnWrongAnswersTypes.
        Dim blnWrongAnswersTypes(0 To 1) As Boolean
        'Assigns blnWrongAnswersTypes(0) to the control chkOption2Q1Types.Checked.
        blnWrongAnswersTypes(0) = chkOption2Q1Types.Checked
        'Assigns blnWrongAnswersTypes(1) to the control chkOption1Q2Types.Checked.
        blnWrongAnswersTypes(1) = chkOption1Q2Types.Checked

        'Assigns the variable blnCorrectAnswerTypesQ1 as chkOption1Q1Types.checked. 
        blnCorrectAnswerTypesQ1 = chkOption1Q1Types.Checked
        'Assigns the variable blnCorrectAnswerQ2Types as chkOption2Q2Types.checked.
        blnCorrectAnswerTypesQ2 = chkOption2Q2Types.Checked

        'Uses an If statement to see if the checkboxes chkOption1Q1Types and chkOption2Q2Types have been checked and that the other checkboxes remain unchecked. 
        If blnCorrectAnswerTypesQ1 = True And blnCorrectAnswerTypesQ2 = True And blnWrongAnswersTypes(0) = False And blnWrongAnswersTypes(1) = False Then
            'If the above statement is true then the prgram will add 1 point to intScoreQ1Types.
            intScoreQ1Types = intScoreQ1Types + 1
            'The program will then add another point in intScoreQ2Types. 
            intScoreQ2Types = intScoreQ2Types + 1
            'Otherwise if the statement is false the program will then check to see if blnCorrectAnswerTypesQ1 is false and blnCorrectAnswerTypesQ2 is true.
        ElseIf blnCorrectAnswerTypesQ1 = False And blnCorrectAnswerTypesQ2 = True Then
            'The program will then add no points to intScoreQ1Types if the above statement is true.
            intScoreQ1Types = intScoreQ1Types + 0
            'The program will then add 1 point to intScoreQ2Types.
            intScoreQ2Types = intScoreQ2Types + 1
            'Else if the statement above is false the program will then check to see if blnCorrectAnswer2Q1Types is true and blnCorrectAnswer3Q2Types is false.
        ElseIf blnCorrectAnswerTypesQ1 = True And blnCorrectAnswerTypesQ2 = False Then
            ''The program will then add 1 point to intScoreQ1Types if the above statement is true.
            intScoreQ1Types = intScoreQ1Types + 1
            'The program will then add no points to intScoreQ2Types.
            intScoreQ2Types = intScoreQ2Types + 0
            'If the user performs any other conditions outside this if statement then this part of the statement will run.
        Else
            'Adds no points to intScoreQ1Types.
            intScoreQ1Types = intScoreQ1Types + 0
            'Adds no points to intScoreQ2Types
            intScoreQ2Types = intScoreQ2Types + 0
        End If

        'The program will then add the scores of intScoreQ1Types and intScoreQ2Types together and store it in the public integer variable intTotalTypesScorefrm1
        intTotalTypesScorefrm1 = intScoreQ1Types + intScoreQ2Types

        'Hides the Current form.
        Me.Hide()
        'Shows frmNetworkingTypes2.
        frmNetworkingTypes2.Show()
    End Sub
End Class