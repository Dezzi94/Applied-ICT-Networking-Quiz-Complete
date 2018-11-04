Public Class frmNetworkingArchitectures2
    'Declares a public shared Boolean variable called blnCorrectAnswerArchitecturesQ3.
    Public Shared blnCorrectAnswerArchitecturesQ3 As Boolean
    'Declares a public shared Boolean variable called blnCorrectAnswerArchitecturesQ4.
    Public Shared blnCorrectAnswerArchitecturesQ4 As Boolean
    'Declares a public shared Integer variable called intTotalArchitecturesScorefrm2. 
    Public Shared intTotalArchitecturesScorefrm2 As Integer

    Private Sub btnBackfrmNetworkingArchitectures2_Click(sender As Object, e As EventArgs) Handles btnBackfrmNetworkingArchitectures2.Click
        'Hides the current form.
        Me.Hide()
        'Goes to the module modResetSection and runs the code that is in the public sub ResetSection.
        modResetSection.ResetSection()
        'Shows the Main Menu to the user.
        frmMainMenu.Show()
    End Sub

    Private Sub btnNextNetworkingArchitectures2_Click(sender As Object, e As EventArgs) Handles btnNextNetworkingArchitectures2.Click
        'Declares a local Integer variable called intScoreQ3Architectures.
        Dim intScoreQ3Architectures As Integer
        'Declares a local Integer varible called intScoreQ4Architectures. 
        Dim intScoreQ4Architectures As Integer

        'Declares a local 4 element array Boolean called blnWrongAnswersArchitectures2.
        Dim blnWrongAnswersArchitectures2(0 To 1) As Boolean
        'Assigns blnWrongAnswersArchitectures(0) to the control chkOption2Q3Architectures.Checked.
        blnWrongAnswersArchitectures2(0) = chkOption2Q3Architectures.Checked
        'Assigns blnWrongAnswersArchitectures(1) to the control chkOption2Q4Architectures.Checked.
        blnWrongAnswersArchitectures2(1) = chkOption2Q4Architectures.Checked

        'Assigns the variable blnCorrectAnswerArchitecturesQ3 as chkOption1Q3Architectures.checked. 
        blnCorrectAnswerArchitecturesQ3 = chkOption1Q3Architectures.Checked
        'Assigns the variable blnCorrectAnswerArchitecturesQ4 as chkOption1Q4Architectures.checked.
        blnCorrectAnswerArchitecturesQ4 = chkOption1Q4Architectures.Checked

        'Uses an If statement to see if the checkboxes chkOption1Q3Architectures and chkOption1Q4Architectures have been checked and that the other checkboxes remain unchecked. 
        If blnCorrectAnswerArchitecturesQ3 = True And blnCorrectAnswerArchitecturesQ4 = True And blnWrongAnswersArchitectures2(0) = False And blnWrongAnswersArchitectures2(1) = False Then
            'If the above statement is true then the prgram will add 1 point to intScoreQ3Architectures.
            intScoreQ3Architectures = intScoreQ3Architectures + 1
            'The program will then add another point in intScoreQ4Architectures. 
            intScoreQ4Architectures = intScoreQ4Architectures + 1
            'Otherwise if the statement is false the program will then check to see if blnCorrectAnswerArchitecturesQ3 is false and blnCorrectAnswerArchitecturesQ4 is true.
        ElseIf blnCorrectAnswerArchitecturesQ3 = False And blnCorrectAnswerArchitecturesQ4 = True Then
            'The program will then add no points to intScoreQ3Architectures if the above statement is true.
            intScoreQ3Architectures = intScoreQ3Architectures + 0
            'The program will then add 1 point to intScoreQ4Architectures.
            intScoreQ4Architectures = intScoreQ4Architectures + 1
            'Else if the statement above is false the program will then check to see if blnCorrectAnswerArchitecturesQ3 is true and blnCorrectAnswerArchitecturesQ4 is false.
        ElseIf blnCorrectAnswerArchitecturesQ3 = True And blnCorrectAnswerArchitecturesQ4 = False Then
            ''The program will then add 1 point to intScoreQ3Architectures if the above statement is true.
            intScoreQ3Architectures = intScoreQ3Architectures + 1
            'The program will then add no points to intScoreQ4Architectures.
            intScoreQ4Architectures = intScoreQ4Architectures + 0
            'If the user performs any other conditions outside this if statement then this part of the statement will run.
        Else
            'Adds no points to intScoreQ3Architectures.
            intScoreQ3Architectures = intScoreQ3Architectures + 0
            'Adds no points to intScoreQ4Architectures
            intScoreQ4Architectures = intScoreQ4Architectures + 0
        End If

        'The program will then add the scores of intScoreQ3Architectures and intScoreQ4Architectures together and store it in the public integer variable intTotalArchitecturesScorefrm2
        intTotalArchitecturesScorefrm2 = intScoreQ3Architectures + intScoreQ4Architectures

        'Hides the Current form.
        Me.Hide()
        'Shows frmNetworkingArchitectures3.
        frmNetworkingArchitectures3.Show()
    End Sub
End Class