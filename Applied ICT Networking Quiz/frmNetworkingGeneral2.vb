Public Class frmNetworkingGeneral2
    'Declares a public shared Boolean variable called blnCorrectAnswerGeneralQ3.
    Public Shared blnCorrectAnswerGeneralQ3 As Boolean
    'Declares a public shared Boolean variable called blnCorrectAnswerGeneralQ4.
    Public Shared blnCorrectAnswerGeneralQ4 As Boolean
    'Declares a public shared Integer variable called intTotalGeneralScorefrm2. 
    Public Shared intTotalGeneralScorefrm2 As Integer

    Private Sub btnBackfrmNetworkingGeneral2_Click(sender As Object, e As EventArgs) Handles btnBackfrmNetworkingGeneral2.Click
        'Hides the current form.
        Me.Hide()
        'Goes to the module modResetSection and runs the code that is in the public sub ResetSection.
        modResetSection.ResetSection()
        'Shows the Main Menu to the user.
        frmMainMenu.Show()
    End Sub

    Private Sub btnNextNetworkingGeneral2_Click(sender As Object, e As EventArgs) Handles btnNextNetworkingGeneral2.Click
        'Declares a local Integer variable called intScoreQ3General.
        Dim intScoreQ3General As Integer
        'Declares a local Integer varible called intScoreQ4General. 
        Dim intScoreQ4General As Integer

        'Declares a local 4 element array Boolean called blnWrongAnswersGeneral2.
        Dim blnWrongAnswersGeneral2(0 To 1) As Boolean
        'Assigns blnWrongAnswersGeneral2(0) to the control chkOption2Q3General.Checked.
        blnWrongAnswersGeneral2(0) = chkOption2Q3General.Checked

        'Assigns the variable blnCorrectAnswerGeneralQ3 as chkOption1Q3General.checked. 
        blnCorrectAnswerGeneralQ3 = chkOption1Q3General.Checked
        'Assigns the variable blnCorrectAnswerGeneralQ4 as chkOption2Q4General.checked and chkOption1Q4General.Checked.
        blnCorrectAnswerGeneralQ4 = chkOption2Q3General.Checked + chkOption1Q4General.Checked

        'Uses an If statement to see if the checkboxes chkOption1Q3General and chkOption2Q4General have been checked and that the other checkboxes remain unchecked. 
        If blnCorrectAnswerGeneralQ3 = True And blnCorrectAnswerGeneralQ4 = True And blnWrongAnswersGeneral2(0) = False Then
            'If the above statement is true then the prgram will add 1 point to intScoreQ3General.
            intScoreQ3General = intScoreQ3General + 1
            'The program will then add another point in intScoreQ4General. 
            intScoreQ4General = intScoreQ4General + 1
            'Otherwise if the statement is false the program will then check to see if blnCorrectAnswerGeneralQ3 is false and blnCorrectAnswerGeneralQ4 is true.
        ElseIf blnCorrectAnswerGeneralQ3 = False And blnCorrectAnswerGeneralQ4 = True Then
            'The program will then add no points to intScoreQ3General if the above statement is true.
            intScoreQ3General = intScoreQ3General + 0
            'The program will then add 1 point to intScoreQ4General.
            intScoreQ4General = intScoreQ4General + 1
            'Else if the statement above is false the program will then check to see if blnCorrectAnswer2Q3General is true and blnCorrectAnswer3Q4General is false.
        ElseIf blnCorrectAnswerGeneralQ3 = True And blnCorrectAnswerGeneralQ4 = False Then
            ''The program will then add 1 point to intScoreQ3General if the above statement is true.
            intScoreQ3General = intScoreQ3General + 1
            'The program will then add no points to intScoreQ4General.
            intScoreQ4General = intScoreQ4General + 0
            'If the user performs any other conditions outside this if statement then this part of the statement will run.
        Else
            'Adds no points to intScoreQ3General.
            intScoreQ3General = intScoreQ3General + 0
            'Adds no points to intScoreQ4General
            intScoreQ4General = intScoreQ4General + 0
        End If

        'The program will then add the scores of intScoreQ3General and intScoreQ4General together and store it in the public integer variable intTotalGeneralScorefrm2
        intTotalGeneralScorefrm2 = intScoreQ3General + intScoreQ4General

        'Hides the Current form.
        Me.Hide()
        'Shows frmNetworkingGeneral3.
        frmNetworkingGeneral3.Show()
    End Sub
End Class