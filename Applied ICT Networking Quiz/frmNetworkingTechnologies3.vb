Public Class frmNetworkingTechnologies3
    'Declares a public shared Boolean variable called blnCorrectAnswerTechnologiesQ5.
    Public Shared blnCorrectAnswerTechnologiesQ5 As Boolean
    'Declares a public shared Boolean variable called blnCorrectAnswerTechnologiesQ6.
    Public Shared blnCorrectAnswerTechnologiesQ6 As Boolean
    'Declares a public shared Integer variable called intTotalTechnologiesScorefrm3. 
    Public Shared intTotalTechnologiesScorefrm3 As Integer

    Private Sub btnBackfrmNetworkingTechnologies3_Click(sender As Object, e As EventArgs) Handles btnBackfrmNetworkingTechnologies3.Click
        'Hides the current form.
        Me.Hide()
        'Goes to the module modResetSection and runs the code that is in the public sub ResetSection.
        modResetSection.ResetSection()
        'Shows the Main Menu to the user.
        frmMainMenu.Show()
    End Sub

    Private Sub btnNextNetworkingTechnologies3_Click(sender As Object, e As EventArgs) Handles btnNextNetworkingTechnologies3.Click
        'Declares a local Integer variable called intScoreQ5Technologies.
        Dim intScoreQ5Technologies As Integer
        'Declares a local Integer varible called intScoreQ6Technologies. 
        Dim intScoreQ6Technologies As Integer

        'Declares a local 4 element array Boolean called blnWrongAnswersTechnologies3.
        Dim blnWrongAnswersTechnologies3(0 To 1) As Boolean
        'Assigns blnWrongAnswersTechnologies3(0) to the control chkOption1Q5Technologies.Checked.
        blnWrongAnswersTechnologies3(0) = chkOption1Q5Technologies.Checked
        'Assigns blnWrongAnswersTechnologies3(1) to the control chkOption1Q6Technologies.Checked.
        blnWrongAnswersTechnologies3(1) = chkOption1Q6Technologies.Checked

        'Assigns the variable blnCorrectAnswerTechnologiesQ5 as chkOption2Q5Technologies.checked. 
        blnCorrectAnswerTechnologiesQ5 = chkOption2Q5Technologies.Checked()
        'Assigns the variable blnCorrectAnswerTechnologiesQ6 as chkOption2Q6Technologies.checked.
        blnCorrectAnswerTechnologiesQ6 = chkOption2Q6Technologies.Checked

        'Uses an If statement to see if the checkboxes chkOption2Q5Technologies and chkOption2Q6Technologies have been checked and that the other checkboxes remain unchecked. 
        If blnCorrectAnswerTechnologiesQ5 = True And blnCorrectAnswerTechnologiesQ6 = True And blnWrongAnswersTechnologies3(0) = False And blnWrongAnswersTechnologies3(1) = False Then
            'If the above statement is true then the prgram will add 1 point to intScoreQ5Technologies.
            intScoreQ5Technologies = intScoreQ5Technologies + 1
            'The program will then add another point in intScoreQ6Technologies. 
            intScoreQ6Technologies = intScoreQ6Technologies + 1
            'Otherwise if the statement is false the program will then check to see if blnCorrectAnswerTechnologiesQ5 is false and blnCorrectAnswerTechnologiesQ6 is true.
        ElseIf blnCorrectAnswerTechnologiesQ5 = False And blnCorrectAnswerTechnologiesQ6 = True Then
            'The program will then add no points to intScoreQ5Technologies if the above statement is true.
            intScoreQ5Technologies = intScoreQ5Technologies + 0
            'The program will then add 1 point to intScoreQ6Technologies.
            intScoreQ6Technologies = intScoreQ6Technologies + 1
            'Else if the statement above is false the program will then check to see if blnCorrectAnswerTechnologiesQ5 is true and blnCorrectAnswerTechnologiesQ6 is false.
        ElseIf blnCorrectAnswerTechnologiesQ5 = True And blnCorrectAnswerTechnologiesQ6 = False Then
            ''The program will then add 1 point to intScoreQ5Technologies if the above statement is true.
            intScoreQ5Technologies = intScoreQ5Technologies + 1
            'The program will then add no points to intScoreQ6Technologies.
            intScoreQ6Technologies = intScoreQ6Technologies + 0
            'If the user performs any other conditions outside this if statement then this part of the statement will run.
        Else
            'Adds no points to intScoreQ5Technologies.
            intScoreQ5Technologies = intScoreQ5Technologies + 0
            'Adds no points to intScoreQ6Technologies.
            intScoreQ6Technologies = intScoreQ6Technologies + 0
        End If

        'The program will then add the scores of intScoreQ5Technologies and intScoreQ6Technologies together and store it in the public integer variable intTotalTechnologiesScorefrm3
        intTotalTechnologiesScorefrm3 = intScoreQ5Technologies + intScoreQ6Technologies
        'Hides the Current form.
        Me.Hide()
        'Shows frmResultsTechnologies
        frmResultsTechnologies.Show()
    End Sub
End Class