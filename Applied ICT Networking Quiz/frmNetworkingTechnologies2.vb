Public Class frmNetworkingTechnologies2
    'Declares a public shared Boolean variable called blnCorrectAnswerTechnologiesQ3.
    Public Shared blnCorrectAnswerTechnologiesQ3 As Boolean
    'Declares a public shared Boolean variable called blnCorrectAnswerTechnologiesQ4.
    Public Shared blnCorrectAnswerTechnologiesQ4 As Boolean
    'Declares a public shared Integer variable called intTotalTechnologiesScorefrm2. 
    Public Shared intTotalTechnologiesScorefrm2 As Integer

    Private Sub btnBackfrmNetworkingTechnologies2_Click(sender As Object, e As EventArgs) Handles btnBackfrmNetworkingTechnologies2.Click
        'Hides the current form.
        Me.Hide()
        'Goes to the module modResetSection and runs the code that is in the public sub ResetSection.
        modResetSection.ResetSection()
        'Shows the Main Menu to the user.
        frmMainMenu.Show()
    End Sub

    Private Sub btnNextNetworkingTechnologies2_Click(sender As Object, e As EventArgs) Handles btnNextNetworkingTechnologies2.Click
        'Declares a local Integer variable called intScoreQ3Technologies.
        Dim intScoreQ3Technologies As Integer
        'Declares a local Integer varible called intScoreQ4Technologies. 
        Dim intScoreQ4Technologies As Integer

        'Declares a local 4 element array Boolean called blnWrongAnswersTechnologies2.
        Dim blnWrongAnswersTechnologies2(0 To 1) As Boolean
        'Assigns blnWrongAnswersTechnologies2(0) to the control chkOption1Q3Technologies.Checked.
        blnWrongAnswersTechnologies2(0) = chkOption1Q3Technologies.Checked
        'Assigns blnWrongAnswersTechnologies2(1) to the control chkOption2Q4Technologies.Checked.
        blnWrongAnswersTechnologies2(1) = chkOption2Q4Technologies.Checked

        'Assigns the variable blnCorrectAnswerTechnologiesQ3 as chkOption2Q3Technologies.checked. 
        blnCorrectAnswerTechnologiesQ3 = chkOption2Q3Technologies.Checked
        'Assigns the variable blnCorrectAnswerTechnologiesQ2 as chkOption1Q4Technologies.checked.
        blnCorrectAnswerTechnologiesQ4 = chkOption1Q4Technologies.Checked

        'Uses an If statement to see if the checkboxes chkOption2Q3Technologies and chkOption1Q4Technologies have been checked and that the other checkboxes remain unchecked. 
        If blnCorrectAnswerTechnologiesQ3 = True And blnCorrectAnswerTechnologiesQ4 = True And blnWrongAnswersTechnologies2(0) = False And blnWrongAnswersTechnologies2(1) = False Then
            'If the above statement is true then the prgram will add 1 point to intScoreQ3Technologies.
            intScoreQ3Technologies = intScoreQ3Technologies + 1
            'The program will then add another point in intScoreQ4Technologies. 
            intScoreQ4Technologies = intScoreQ4Technologies + 1
            'Otherwise if the statement is false the program will then check to see if blnCorrectAnswerTechnologiesQ3 is false and blnCorrectAnswerTechnologiesQ4 is true.
        ElseIf blnCorrectAnswerTechnologiesQ3 = False And blnCorrectAnswerTechnologiesQ4 = True Then
            'The program will then add no points to intScoreQ3Technologies if the above statement is true.
            intScoreQ3Technologies = intScoreQ3Technologies + 0
            'The program will then add 1 point to intScoreQ4Technologies.
            intScoreQ4Technologies = intScoreQ4Technologies + 1
            'Else if the statement above is false the program will then check to see if blnCorrectAnswerTechnologiesQ3 is true and blnCorrectAnswerTechnologiesQ4 is false.
        ElseIf blnCorrectAnswerTechnologiesQ3 = True And blnCorrectAnswerTechnologiesQ4 = False Then
            ''The program will then add 1 point to intScoreQ3Technologies if the above statement is true.
            intScoreQ3Technologies = intScoreQ3Technologies + 1
            'The program will then add no points to intScoreQ4Technologies.
            intScoreQ4Technologies = intScoreQ4Technologies + 0
            'If the user performs any other conditions outside this if statement then this part of the statement will run.
        Else
            'Adds no points to intScoreQ3Technologies.
            intScoreQ3Technologies = intScoreQ3Technologies + 0
            'Adds no points to intScoreQ4Technologies.
            intScoreQ4Technologies = intScoreQ4Technologies + 0
        End If

        'The program will then add the scores of intScoreQ3Technologies and intScoreQ4Technologies together and store it in the public integer variable intTotalTechnologiesScorefrm2
        intTotalTechnologiesScorefrm2 = intScoreQ3Technologies + intScoreQ4Technologies
        'Hides the Current form.
        Me.Hide()
        'Shows frmNetworkingTechnologies3.
        frmNetworkingTechnologies3.Show()
    End Sub
End Class