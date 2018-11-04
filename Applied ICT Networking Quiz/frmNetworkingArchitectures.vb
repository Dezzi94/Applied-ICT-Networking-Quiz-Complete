Public Class frmNetworkingArchitectures
    'Declares a public shared Boolean variable called blnCorrectAnswerArchitecturesQ1.
    Public Shared blnCorrectAnswerArchitecturesQ1 As Boolean
    'Declares a public shared Boolean variable called blnCorrectAnswerArchitecturesQ2.
    Public Shared blnCorrectAnswerArchitecturesQ2 As Boolean
    'Declares a public shared Integer variable called intTotalArchitecturesScorefrm1. 
    Public Shared intTotalArchitecturesScorefrm1 As Integer

    Private Sub btnBackfrmNetworkingArchitectures_Click(sender As Object, e As EventArgs) Handles btnBackfrmNetworkingArchitectures.Click
        'Hides the current form.
        Me.Hide()
        'Goes to the module modResetSection and runs the code that is in the public sub ResetSection.
        modResetSection.ResetSection()
        'Shows the Main Menu to the user.
        frmMainMenu.Show()
    End Sub

    Private Sub btnNextNetworkingArchitectures_Click(sender As Object, e As EventArgs) Handles btnNextNetworkingArchitectures.Click
        'Declares a local Integer variable called intScoreQ1Architectures.
        Dim intScoreQ1Architectures As Integer
        'Declares a local Integer varible called intScoreQ2Architectures. 
        Dim intScoreQ2Architectures As Integer

        'Declares a local 4 element array Boolean called blnWrongAnswersArchitectures.
        Dim blnWrongAnswersArchitectures(0 To 1) As Boolean
        'Assigns blnWrongAnswersArchitectures(0) to the control chkOption2Q1Architectures.Checked.
        blnWrongAnswersArchitectures(0) = chkOption2Q1Architectures.Checked
        'Assigns blnWrongAnswersArchitectures(1) to the control chkOption2Q2Architectures.Checked.
        blnWrongAnswersArchitectures(1) = chkOption2Q2Architectures.Checked

        'Assigns the variable blnCorrectAnswerArchitecturesQ1 as chkOption1Q1Architectures.checked. 
        blnCorrectAnswerArchitecturesQ1 = chkOption1Q1Architectures.Checked
        'Assigns the variable blnCorrectAnswerArchitecturesQ2 as chkOption1Q2Architectures.checked.
        blnCorrectAnswerArchitecturesQ2 = chkOption1Q2Architectures.Checked

        'Uses an If statement to see if the checkboxes chkOption1Q1Architectures and chkOption1Q2Architectures have been checked and that the other checkboxes remain unchecked. 
        If blnCorrectAnswerArchitecturesQ1 = True And blnCorrectAnswerArchitecturesQ2 = True And blnWrongAnswersArchitectures(0) = False And blnWrongAnswersArchitectures(1) = False Then
            'If the above statement is true then the prgram will add 1 point to intScoreQ1Architectures.
            intScoreQ1Architectures = intScoreQ1Architectures + 1
            'The program will then add another point in intScoreQ2Architectures. 
            intScoreQ2Architectures = intScoreQ2Architectures + 1
            'Otherwise if the statement is false the program will then check to see if blnCorrectAnswerArchitecturesQ1 is false and blnCorrectAnswerArchitecturesQ2 is true.
        ElseIf blnCorrectAnswerArchitecturesQ1 = False And blnCorrectAnswerArchitecturesQ2 = True Then
            'The program will then add no points to intScoreQ1Architectures if the above statement is true.
            intScoreQ1Architectures = intScoreQ1Architectures + 0
            'The program will then add 1 point to intScoreQ2Architectures.
            intScoreQ2Architectures = intScoreQ2Architectures + 1
            'Else if the statement above is false the program will then check to see if blnCorrectAnswerArchitecturesQ1 is true and blnCorrectAnswerArchitecturesQ2 is false.
        ElseIf blnCorrectAnswerArchitecturesQ1 = True And blnCorrectAnswerArchitecturesQ2 = False Then
            ''The program will then add 1 point to intScoreQ1Architectures if the above statement is true.
            intScoreQ1Architectures = intScoreQ1Architectures + 1
            'The program will then add no points to intScoreQ2Architectures.
            intScoreQ2Architectures = intScoreQ2Architectures + 0
            'If the user performs any other conditions outside this if statement then this part of the statement will run.
        Else
            'Adds no points to intScoreQ1Architectures.
            intScoreQ1Architectures = intScoreQ1Architectures + 0
            'Adds no points to intScoreQ2Architectures
            intScoreQ2Architectures = intScoreQ2Architectures + 0
        End If

        'The program will then add the scores of intScoreQ1Architectures and intScoreQ2Architectures together and store it in the public integer variable intTotalArchitecturesScorefrm1
        intTotalArchitecturesScorefrm1 = intScoreQ1Architectures + intScoreQ2Architectures

        'Hides the Current form.
        Me.Hide()
        'Shows frmNetworkingArchitectures2.
        frmNetworkingArchitectures2.Show()
    End Sub
End Class