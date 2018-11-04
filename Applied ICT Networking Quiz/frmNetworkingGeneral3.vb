Public Class frmNetworkingGeneral3
    'Declares a public shared Boolean variable called blnCorrectAnswerGeneralQ5.
    Public Shared blnCorrectAnswerGeneralQ5 As Boolean
    'Declares a public shared Boolean variable called blnCorrectAnswerGeneralQ6.
    Public Shared blnCorrectAnswerGeneralQ6 As Boolean
    'Declares a public shared Integer variable called intTotalGeneralScorefrm3. 
    Public Shared intTotalGeneralScorefrm3 As Integer

    Private Sub btnBackfrmNetworkingGeneral3_Click(sender As Object, e As EventArgs) Handles btnBackfrmNetworkingGeneral3.Click, btnBackfrmNetworkingGeneral3.Click
        'Hides the current form.
        Me.Hide()
        'Goes to the module modResetSection and runs the code that is in the public sub ResetSection.
        modResetSection.ResetSection()
        'Shows the Main Menu to the user.
        frmMainMenu.Show()
    End Sub

    Private Sub btnNextNetworkingGeneral3_Click(sender As Object, e As EventArgs) Handles btnNextNetworkingGeneral3.Click, btnNextNetworkingGeneral3.Click
        'Declares a local Integer variable called intScoreQ5General.
        Dim intScoreQ5General As Integer
        'Declares a local Integer varible called intScoreQ6General. 
        Dim intScoreQ6General As Integer

        'Declares a local 4 element array Boolean called blnWrongAnswersGeneral3.
        Dim blnWrongAnswersGeneral3(0 To 1) As Boolean
        'Assigns blnWrongAnswersGeneral3(0) to the control chkOption1Q5General.Checked.
        blnWrongAnswersGeneral3(0) = chkOption1Q5General.Checked
        'Assigns blnWrongAnswersGeneral3(1) to the control chkOption2Q6General.Checked.
        blnWrongAnswersGeneral3(1) = chkOption2Q6General.Checked

        'Assigns the variable blnCorrectAnswerGeneralQ5 as chkOption2Q5General.checked. 
        blnCorrectAnswerGeneralQ5 = chkOption2Q5General.Checked
        'Assigns the variable blnCorrectAnswerGeneralQ6 as chkOption1Q6General.checked.
        blnCorrectAnswerGeneralQ6 = chkOption1Q6General.Checked

        'Uses an If statement to see if the checkboxes chkOption2Q5General and chkOption1Q6General have been checked and that the other checkboxes remain unchecked. 
        If blnCorrectAnswerGeneralQ5 = True And blnCorrectAnswerGeneralQ6 = True And blnWrongAnswersGeneral3(0) = False And blnWrongAnswersGeneral3(1) = False Then
            'If the above statement is true then the prgram will add 1 point to intScoreQ5General.
            intScoreQ5General = intScoreQ5General + 1
            'The program will then add another point in intScoreQ6General. 
            intScoreQ6General = intScoreQ6General + 1
            'Otherwise if the statement is false the program will then check to see if blnCorrectAnswerGeneralQ5 is false and blnCorrectAnswerGeneralQ6 is true.
        ElseIf blnCorrectAnswerGeneralQ5 = False And blnCorrectAnswerGeneralQ6 = True Then
            'The program will then add no points to intScoreQ5General if the above statement is true.
            intScoreQ5General = intScoreQ5General + 0
            'The program will then add 1 point to intScoreQ6General.
            intScoreQ6General = intScoreQ6General + 1
            'Else if the statement above is false the program will then check to see if blnCorrectAnswer2Q5General is true and blnCorrectAnswer3Q6General is false.
        ElseIf blnCorrectAnswerGeneralQ5 = True And blnCorrectAnswerGeneralQ6 = False Then
            ''The program will then add 1 point to intScoreQ5General if the above statement is true.
            intScoreQ5General = intScoreQ5General + 1
            'The program will then add no points to intScoreQ6General.
            intScoreQ6General = intScoreQ6General + 0
            'If the user performs any other conditions outside this if statement then this part of the statement will run.
        Else
            'Adds no points to intScoreQ5General.
            intScoreQ5General = intScoreQ5General + 0
            'Adds no points to intScoreQ6General
            intScoreQ6General = intScoreQ6General + 0
        End If

        'The program will then add the scores of intScoreQ5General and intScoreQ5General together and store it in the public integer variable intTotalGeneralScorefrm3
        intTotalGeneralScorefrm3 = intScoreQ5General + intScoreQ6General

        'Hides the Current form.
        Me.Hide()
        'Shows frmNetworkingResultsGeneral.
        frmResultsGeneral.Show()
    End Sub
End Class