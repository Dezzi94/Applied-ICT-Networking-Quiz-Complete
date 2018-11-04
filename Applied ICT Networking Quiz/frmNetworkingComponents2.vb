Public Class frmNetworkingComponents2
    'Declares a Public Shared Boolean Variable called blnCorrectAnswerComponentsQ3.
    Public Shared blnCorrectAnswerComponentsQ3 As Boolean
    'Declares a Public Shared Boolean Variable called blnCorrectAnswerComponentsQ4.
    Public Shared blnCorrectAnswerComponentsQ4 As Boolean
    'Declares a Public Shared Integer Variable called intTotalComponentsScorefrm2.
    Public Shared intTotalComponentsScorefrm2 As Integer

    Private Sub btnBackfrmNetworkingComponents2_Click(sender As Object, e As EventArgs) Handles btnBackfrmNetworkingComponents2.Click, btnBackfrmNetworkingComponents2.Click
        'Hides the current form.
        Me.Hide()
        'Goes to the module modResetSection and runs the code that is in the public sub ResetSection.
        modResetSection.ResetSection()
        'Shows Main Menu form.
        frmMainMenu.Show()
    End Sub

    Private Sub btnNextNetworkingComponents2_Click(sender As Object, e As EventArgs) Handles btnNextNetworkingComponents2.Click
        'Declares a local Integer variable called intScoreQ3Components.
        Dim intScoreQ3Components As Integer
        'Declares a local Intger variable called intScoreQ4Components.
        Dim intScoreQ4Components As Integer

        'Declares a local 4 element Array Boolean called blnWrongAnswersComponents.
        Dim blnWrongAnswersComponents(0 To 3) As Boolean
        'Assigns blnWrongAnswersComponents(0) to the control chkOption1Q3.Checked.
        blnWrongAnswersComponents(0) = chkOption1Q3Components.Checked
        'Assigns blnWrongAnswersComponents(1) to the control chkOption2Q4.Checked.
        blnWrongAnswersComponents(1) = chkOption2Q4Components.Checked
        'Assigns blnWrongAnswersComponents(2) to the control chkOption3Q4.Checked.
        blnWrongAnswersComponents(2) = chkOption3Q4Components.Checked
        'Assigns blnWrongAnswersComponents(3) to the control chkOption4Q4.Checked.
        blnWrongAnswersComponents(3) = chkOption4Q4Components.Checked

        'Assigns the Variable blnCorrectAnswerComponentsQ1 as chkOption2Q3Components.checked.
        blnCorrectAnswerComponentsQ3 = chkOption2Q3Components.Checked
        'Assigns the Variable blnCorrectAnswerComponentsQ2 as chkOption1Q4Components.checked.
        blnCorrectAnswerComponentsQ4 = chkOption1Q4Components.Checked

        'Uses an If statement to see if the checkboxes chkOption2Q3Components and chkOption1Q4Components have been checked and that the other checkboxes remain unchecked. 
        If blnCorrectAnswerComponentsQ3 And blnCorrectAnswerComponentsQ4 = True And blnWrongAnswersComponents(0) = False And blnWrongAnswersComponents(1) = False And blnWrongAnswersComponents(2) = False And blnWrongAnswersComponents(3) = False Then
            'If the above statement is true then the prgram will add 1 point to intScoreQ3Components.
            intScoreQ3Components = intScoreQ3Components + 1
            'The program will then add another point in intScoreQ4Components.
            intScoreQ4Components = intScoreQ4Components + 1
            'Otherwise if the statement is false the program will then check to see if blnCorrectAnswerComponentsQ3 is false and blnCorrectAnswerComponentsQ4 is true.
        ElseIf blnCorrectAnswerComponentsQ3 = False And blnCorrectAnswerComponentsQ4 = True Then
            'If the above statement is true then the prgram will add 0 points to intScoreQ3Components.
            intScoreQ3Components = intScoreQ3Components + 0
            'The program will then add 1 point in intScoreQ4Components.
            intScoreQ4Components = intScoreQ4Components + 1
            'Else if the statement above is false the program will then check to see if blnCorrectAnswerComponentsQ3 is true and blnCorrectAnswerComponentsQ4 is false.
        ElseIf blnCorrectAnswerComponentsQ3 = True And blnCorrectAnswerComponentsQ4 = False Then
            'If the above statement is true then the prgram will add 1 point to intScoreQ3Components.
            intScoreQ3Components = intScoreQ3Components + 1
            'The program will then add 0 points to intScoreQ4Components.
            intScoreQ4Components = intScoreQ4Components + 0
        Else
            'The program will add 0 points to intScoreQ3Components.
            intScoreQ3Components = intScoreQ3Components + 0
            'The program will then add 0 points in intScoreQ4Components.
            intScoreQ4Components = intScoreQ4Components + 0
        End If

        'The program will then add the scores of intScoreQ3Components and intScoreQ4Components together and store it in the Public Integer Variable intTotalComponentsScorefrm2.
        intTotalComponentsScorefrm2 = intScoreQ3Components + intScoreQ4Components

        'Hides the Current form.
        Me.Hide()
        'Shows frmNetworkingComponents3.
        frmNetworkingComponents3.Show()
    End Sub
End Class