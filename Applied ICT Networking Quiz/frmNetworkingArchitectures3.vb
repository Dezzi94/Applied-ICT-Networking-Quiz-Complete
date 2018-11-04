Public Class frmNetworkingArchitectures3
    'Declares a public shared Boolean variable called blnCorrectAnswerArchitecturesQ5.
    Public Shared blnCorrectAnswerArchitecturesQ5 As Boolean
    'Declares a public shared Boolean variable called blnCorrectAnswerArchitecturesQ6.
    Public Shared blnCorrectAnswerArchitecturesQ6 As Boolean
    'Declares a public shared Integer variable called intTotalArchitecturesScorefrm3. 
    Public Shared intTotalArchitecturesScorefrm3 As Integer

    Private Sub btnBackfrmNetworkingArchitectures3_Click(sender As Object, e As EventArgs) Handles btnBackfrmNetworkingArchitectures3.Click
        'Hides the current form.
        Me.Hide()
        'Goes to the module modResetSection and runs the code that is in the public sub ResetSection.
        modResetSection.ResetSection()
        'Shows the Main Menu to the user.
        frmMainMenu.Show()
    End Sub

    Private Sub btnNextNetworkingArchitectures3_Click(sender As Object, e As EventArgs) Handles btnNextNetworkingArchitectures3.Click
        'Declares a local Integer variable called intScoreQ5Architectures.
        Dim intScoreQ5Architectures As Integer
        'Declares a local Integer varible called intScoreQ6Architectures. 
        Dim intScoreQ6Architectures As Integer

        'Declares a local 4 element array Boolean called blnWrongAnswersArchitectures3
        Dim blnWrongAnswersArchitectures3(0 To 1) As Boolean
        'Assigns blnWrongAnswersArchitectures3(0) to the control chkOption1Q5Architectures.Checked.
        blnWrongAnswersArchitectures3(0) = chkOption1Q5Architectures.Checked
        'Assigns blnWrongAnswersArchitectures(1) to the control chkOption2Q6Architectures.Checked.
        blnWrongAnswersArchitectures3(1) = chkOption2Q6Architectures.Checked

        'Assigns the variable blnCorrectAnswerArchitecturesQ5 as chkOption2Q5Architectures.checked. 
        blnCorrectAnswerArchitecturesQ5 = chkOption2Q5Architectures.Checked
        'Assigns the variable blnCorrectAnswerArchitecturesQ6 as chkOption1Q6Architectures.checked.
        blnCorrectAnswerArchitecturesQ6 = chkOption1Q6Architectures.Checked

        'Uses an If statement to see if the checkboxes chkOption2Q5Architectures and chkOption1Q6Architectures have been checked and that the other checkboxes remain unchecked. 
        If blnCorrectAnswerArchitecturesQ5 = True And blnCorrectAnswerArchitecturesQ6 = True And blnWrongAnswersArchitectures3(0) = False And blnWrongAnswersArchitectures3(1) = False Then
            'If the above statement is true then the prgram will add 1 point to intScoreQ5Architectures.
            intScoreQ5Architectures = intScoreQ5Architectures + 1
            'The program will then add another point in intScoreQ6Architectures. 
            intScoreQ6Architectures = intScoreQ6Architectures + 1
            'Otherwise if the statement is false the program will then check to see if blnCorrectAnswerArchitecturesQ5 is false and blnCorrectAnswerArchitecturesQ6 is true.
        ElseIf blnCorrectAnswerArchitecturesQ5 = False And blnCorrectAnswerArchitecturesQ6 = True Then
            'The program will then add no points to intScoreQ5Architectures if the above statement is true.
            intScoreQ5Architectures = intScoreQ5Architectures + 0
            'The program will then add 1 point to intScoreQ6Architectures.
            intScoreQ6Architectures = intScoreQ6Architectures + 1
            'Else if the statement above is false the program will then check to see if blnCorrectAnswerArchitecturesQ5 is true and blnCorrectAnswerArchitecturesQ6 is false.
        ElseIf blnCorrectAnswerArchitecturesQ5 = True And blnCorrectAnswerArchitecturesQ6 = False Then
            ''The program will then add 1 point to intScoreQ5Architectures if the above statement is true.
            intScoreQ5Architectures = intScoreQ5Architectures + 1
            'The program will then add no points to intScoreQ6Architectures.
            intScoreQ6Architectures = intScoreQ6Architectures + 0
            'If the user performs any other conditions outside this if statement then this part of the statement will run.
        Else
            'Adds no points to intScoreQ5Architectures.
            intScoreQ5Architectures = intScoreQ5Architectures + 0
            'Adds no points to intScoreQ6Architectures
            intScoreQ6Architectures = intScoreQ6Architectures + 0
        End If

        'The program will then add the scores of intScoreQ5Architectures and intScoreQ6Architectures together and store it in the public integer variable intTotalArchitecturesScorefrm3
        intTotalArchitecturesScorefrm3 = intScoreQ5Architectures + intScoreQ6Architectures

        'Hides the Current form.
        Me.Hide()
        'Shows frmResultsArchitectures.
        frmResultsArchitectures.Show()
    End Sub
End Class