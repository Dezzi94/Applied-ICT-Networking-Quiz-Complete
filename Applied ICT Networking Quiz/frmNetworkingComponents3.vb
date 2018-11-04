Public Class frmNetworkingComponents3
    'Declares a public shared boolean variable called blnCorrectAnswerComponentsQ5
    Public Shared blnCorrectAnswerComponentsQ5 As Boolean
    'Declares a public shared boolean variable called blnCorrectAnswerComponentsQ6
    Public Shared blnCorrectAnswerComponentsQ6 As Boolean
    'Declares a public shared integer variable called intTotalComponentsScorefrm3
    Public Shared intTotalComponentsScorefrm3 As Integer

    Private Sub btnBackfrmNetworkingComponents3_Click(sender As Object, e As EventArgs) Handles btnBackfrmNetworkingComponents3.Click
        'Hides form.
        Me.Hide()
        'Goes to the module modResetSection and runs the code that is in the public sub ResetSection.
        modResetSection.ResetSection()
        'Shows frmMainMenu.
        frmMainMenu.Show()
    End Sub

    Private Sub btnNextNetworkingComponents3_Click(sender As Object, e As EventArgs) Handles btnNextNetworkingComponents3.Click
        'Declares a local Integer variable called intScoreQ5Components.
        Dim intScoreQ5Components As Integer
        'Declares a local Intger variable called intScoreQ6Components.
        Dim intScoreQ6Components As Integer


        'Declares a local 4 element Array Boolean called blnWrongAnswersComponents2.
        Dim blnWrongAnswersComponents2(0 To 1) As Boolean
        'Assigns blnWrongAnswersComponents2(0) to the control chkOption1Q5.Checked.
        blnWrongAnswersComponents2(0) = chkOption2Q5Components.Checked
        'Assigns blnWrongAnswersComponents2(1) to the control chkOption2Q6.Checked.
        blnWrongAnswersComponents2(1) = chkOption2Q6Components.Checked


        'Assigns the Variable blnCorrectAnswerComponentsQ5 as chkOption2Q5Components.checked.
        blnCorrectAnswerComponentsQ5 = chkOption1Q5Components.Checked
        'Assigns the Variable blnCorrectAnswerComponentsQ6 as chkOption1Q6Components.checked.
        blnCorrectAnswerComponentsQ6 = chkOption1Q6Components.Checked

        'Uses an If statement to see if the checkboxes chkOption2Q5Components and chkOption1Q6Components have been checked and that the other checkboxes remain unchecked. 
        If blnCorrectAnswerComponentsQ5 And blnCorrectAnswerComponentsQ6 = True And blnWrongAnswersComponents2(0) = False And blnWrongAnswersComponents2(1) = False Then
            'If the above statement is true then the prgram will add 1 point to intScoreQ5Components.
            intScoreQ5Components = intScoreQ5Components + 1
            'If the above statement is true then the prgram will add 1 point to intScoreQ6Components.
            intScoreQ6Components = intScoreQ6Components + 1
            'Otherwise if the statement is false the program will then check to see if blnCorrectAnswerComponentsQ5 is false and blnCorrectAnswerComponentsQ6 is true.
        ElseIf blnCorrectAnswerComponentsQ5 = False And blnCorrectAnswerComponentsQ6 = True Then
            'If the above statement is true then the prgram will add 1 point to intScoreQ5Components.
            intScoreQ5Components = intScoreQ5Components + 0
            'If the above statement is true then the prgram will add 1 point to intScoreQ6Components.
            intScoreQ6Components = intScoreQ6Components + 1
            'Otherwise if the statement is false the program will then check to see if blnCorrectAnswerComponentsQ6 is false and blnCorrectAnswerComponentsQ5 is true.
        ElseIf blnCorrectAnswerComponentsQ5 = True And blnCorrectAnswerComponentsQ6 = False Then
            'If the above statement is true then the prgram will add 1 point to intScoreQ5Components.
            intScoreQ5Components = intScoreQ5Components + 1
            'If the above statement is true then the prgram will add 0 points to intScoreQ6Components.
            intScoreQ6Components = intScoreQ6Components + 0
        Else
            'The program will add 0 points to intScoreQ5Components.
            intScoreQ5Components = intScoreQ5Components + 0
            'The program will then add 0 points in intScoreQ6Components.
            intScoreQ6Components = intScoreQ6Components + 0
        End If
        'The program will then add the scores of intScoreQ5Components and intScoreQ6Components together and store it in the Public Integer Variable intTotalComponentsScorefrm3
        intTotalComponentsScorefrm3 = intScoreQ5Components + intScoreQ6Components

        'Hides form.
        Me.Hide()
        'Shows Results page.
        frmResultsComponents.Show()
    End Sub

End Class