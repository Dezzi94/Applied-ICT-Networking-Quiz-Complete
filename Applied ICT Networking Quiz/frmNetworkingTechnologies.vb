Public Class frmNetworkingTechnologies
    'Declares a public shared Boolean variable called blnCorrectAnswerTechnologiesQ1.
    Public Shared blnCorrectAnswerTechnologiesQ1 As Boolean
    'Declares a public shared Boolean variable called blnCorrectAnswerTechnologiesQ2.
    Public Shared blnCorrectAnswerTechnologiesQ2 As Boolean
    'Declares a public shared Integer variable called intTotalTechnologiesScorefrm1. 
    Public Shared intTotalTechnologiesScorefrm1 As Integer

    Private Sub btnBackfrmNetworkingTechnologies_Click(sender As Object, e As EventArgs) Handles btnBackfrmNetworkingTechnologies.Click
        'Hides the current form.
        Me.Hide()
        'Goes to the module modResetSection and runs the code that is in the public sub ResetSection.
        modResetSection.ResetSection()
        'Shows the Main Menu to the user.
        frmMainMenu.Show()
    End Sub

    Private Sub btnNextNetworkingTechnologies_Click(sender As Object, e As EventArgs) Handles btnNextNetworkingTechnologies.Click
        'Declares a local Integer variable called intScoreQ1Technologies.
        Dim intScoreQ1Technologies As Integer
        'Declares a local Integer varible called intScoreQ2Technologies. 
        Dim intScoreQ2Technologies As Integer

        'Declares a local 4 element array Boolean called blnWrongAnswersTechnologies.
        Dim blnWrongAnswersTechnologies(0 To 1) As Boolean
        'Assigns blnWrongAnswersTechnologies(0) to the control chkOption1Q1Technologies.Checked.
        blnWrongAnswersTechnologies(0) = chkOption1Q1Technologies.Checked
        'Assigns blnWrongAnswersTechnologies(1) to the control chkOption2Q2Technologies.Checked.
        blnWrongAnswersTechnologies(1) = chkOption2Q2Technologies.Checked

        'Assigns the variable blnCorrectAnswerTechnologiesQ1 as chkOption2Q1Technologies.checked. 
        blnCorrectAnswerTechnologiesQ1 = chkOption2Q1Technologies.Checked()
        'Assigns the variable blnCorrectAnswerTechnologiesQ2 as chkOption1Q2Technologies.checked.
        blnCorrectAnswerTechnologiesQ2 = chkOption1Q2Technologies.Checked

        'Uses an If statement to see if the checkboxes chkOption2Q1Technologies and chkOption1Q2Technologies have been checked and that the other checkboxes remain unchecked. 
        If blnCorrectAnswerTechnologiesQ1 = True And blnCorrectAnswerTechnologiesQ2 = True And blnWrongAnswersTechnologies(0) = False And blnWrongAnswersTechnologies(1) = False Then
            'If the above statement is true then the prgram will add 1 point to intScoreQ1Technologies.
            intScoreQ1Technologies = intScoreQ1Technologies + 1
            'The program will then add another point in intScoreQ2Technologies. 
            intScoreQ2Technologies = intScoreQ2Technologies + 1
            'Otherwise if the statement is false the program will then check to see if blnCorrectAnswerTechnologiesQ1 is false and blnCorrectAnswerTechnologiesQ2 is true.
        ElseIf blnCorrectAnswerTechnologiesQ1 = False And blnCorrectAnswerTechnologiesQ2 = True Then
            'The program will then add no points to intScoreQ1Technologies if the above statement is true.
            intScoreQ1Technologies = intScoreQ1Technologies + 0
            'The program will then add 1 point to intScoreQ2Technologies.
            intScoreQ2Technologies = intScoreQ2Technologies + 1
            'Else if the statement above is false the program will then check to see if blnCorrectAnswerTechnologiesQ1 is true and blnCorrectAnswerTechnologiesQ2 is false.
        ElseIf blnCorrectAnswerTechnologiesQ1 = True And blnCorrectAnswerTechnologiesQ2 = False Then
            ''The program will then add 1 point to intScoreQ1Technologies if the above statement is true.
            intScoreQ1Technologies = intScoreQ1Technologies + 1
            'The program will then add no points to intScoreQ2Technologies.
            intScoreQ2Technologies = intScoreQ2Technologies + 0
            'If the user performs any other conditions outside this if statement then this part of the statement will run.
        Else
            'Adds no points to intScoreQ1Technologies.
            intScoreQ1Technologies = intScoreQ1Technologies + 0
            'Adds no points to intScoreQ2Technologies.
            intScoreQ2Technologies = intScoreQ2Technologies + 0
        End If

        'The program will then add the scores of intScoreQ1Technologies and intScoreQ2Technologies together and store it in the public integer variable intTotalTechnologiesScorefrm1
        intTotalTechnologiesScorefrm1 = intScoreQ1Technologies + intScoreQ2Technologies
        'Hides the Current form.
        Me.Hide()
        'Shows frmNetworkingTechnologies2.
        frmNetworkingTechnologies2.Show()
    End Sub
End Class