Public Class frmNetworkingGeneral
    'Declares a public shared Boolean variable called blnCorrectAnswerGeneralQ1. 
    Public Shared blnCorrectAnswerGeneralQ1 As Boolean
    'Declares a public shared Boolean variable called blnCorrectAnswerGeneralQ2. 
    Public Shared blnCorrectAnswerGeneralQ2 As Boolean
    'Declares a public shared Integer variable called intTotalGeneralScorefrm1. 
    Public Shared intTotalGeneralScorefrm1 As Integer

    Private Sub btnBackfrmNetworkingGeneral_Click(sender As Object, e As EventArgs) Handles btnBackfrmNetworkingGeneral.Click
        'Hides the current form.
        Me.Hide()
        'Goes to the module modResetSection and runs the code that is in the public sub ResetSection.
        modResetSection.ResetSection()
        'Shows the Main Menu to the user.
        frmMainMenu.Show()
    End Sub

    Private Sub btnNextNetworkingGeneral_Click(sender As Object, e As EventArgs) Handles btnNextNetworkingGeneral.Click
        'Declares a local Integer variable called intScoreQ1General.
        Dim intScoreQ1General As Integer
        'Declares a local Integer varible called intScoreQ2General. 
        Dim intScoreQ2General As Integer

        'Declares a local 4 element array Boolean called blnWrongAnswersGeneral.
        Dim blnWrongAnswersGeneral(0 To 1) As Boolean
        'Assigns blnWrongAnswersTypes(0) to the control chkOption2Q1General.Checked.
        blnWrongAnswersGeneral(0) = chkOption2Q1General.Checked
        'Assigns blnWrongAnswersTypes(1) to the control chkOption1Q2General.Checked.
        blnWrongAnswersGeneral(1) = chkOption1Q2General.Checked

        'Assigns the variable blnCorrectAnswerGeneralQ1 as chkOption1Q1General.checked. 
        blnCorrectAnswerGeneralQ1 = chkOption1Q1General.Checked
        'Assigns the variable blnCorrectAnswerQ2General as chkOption2Q2General.checked.
        blnCorrectAnswerGeneralQ2 = chkOption2Q2General.Checked

        'Uses an If statement to see if the checkboxes chkOption1Q1General and chkOption2Q2General have been checked and that the other checkboxes remain unchecked. 
        If blnCorrectAnswerGeneralQ1 = True And blnCorrectAnswerGeneralQ2 = True And blnWrongAnswersGeneral(0) = False And blnWrongAnswersGeneral(1) = False Then
            'If the above statement is true then the prgram will add 1 point to intScoreQ1General.
            intScoreQ1General = intScoreQ1General + 1
            'The program will then add another point in intScoreQ2General. 
            intScoreQ2General = intScoreQ2General + 1
            'Otherwise if the statement is false the program will then check to see if blnCorrectAnswerGeneralQ1 is false and blnCorrectAnswerGeneralQ2 is true.
        ElseIf blnCorrectAnswerGeneralQ1 = False And blnCorrectAnswerGeneralQ2 = True Then
            'The program will then add no points to intScoreQ1General if the above statement is true.
            intScoreQ1General = intScoreQ1General + 0
            'The program will then add 1 point to intScoreQ2General.
            intScoreQ2General = intScoreQ2General + 1
            'Else if the statement above is false the program will then check to see if blnCorrectAnswer2Q1General is true and blnCorrectAnswer3Q2General is false.
        ElseIf blnCorrectAnswerGeneralQ1 = True And blnCorrectAnswerGeneralQ2 = False Then
            ''The program will then add 1 point to intScoreQ1General if the above statement is true.
            intScoreQ1General = intScoreQ1General + 1
            'The program will then add no points to intScoreQ2General.
            intScoreQ2General = intScoreQ2General + 0
            'If the user performs any other conditions outside this if statement then this part of the statement will run.
        Else
            'Adds no points to intScoreQ1General.
            intScoreQ1General = intScoreQ1General + 0
            'Adds no points to intScoreQ2Types
            intScoreQ2General = intScoreQ2General + 0
        End If

        'The program will then add the scores of intScoreQ1General and intScoreQ2General together and store it in the public integer variable intTotalGeneralScorefrm1
        intTotalGeneralScorefrm1 = intScoreQ1General + intScoreQ2General

        'Hides the Current form.
        Me.Hide()
        'Shows frmNetworkingGeneral2.
        frmNetworkingGeneral2.Show()
    End Sub
End Class