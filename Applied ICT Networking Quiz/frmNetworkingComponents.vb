Public Class frmNetworkingComponents
    'Declares a Public Shared Boolean Variable called blnCorrectAnswerComponentsQ1. 
    Public Shared blnCorrectAnswerComponentsQ1 As Boolean
    'Declares a Public Shared Boolean Variable called blnCorrectAnswerComponentsQ2. 
    Public Shared blnCorrectAnswerComponentsQ2 As Boolean
    'Declares a Public Shared Integer Variable called intTotalScorefrm1. 
    Public Shared intTotalComponentsScorefrm1 As Integer

    Private Sub btnBackfrmNetworkingComponents_Click(sender As Object, e As EventArgs) Handles btnBackfrmNetworkingComponents.Click
        'Hides the current form.
        Me.Hide()
        'Goes to the module modResetSection and runs the code that is in the public sub ResetSection.
        modResetSection.ResetSection()
        'Shows the Main Menu to the user.
        frmMainMenu.Show()
    End Sub

    Private Sub btnNextNetworkingComponents_Click(sender As Object, e As EventArgs) Handles btnNextNetworkingComponents.Click
        'Declares a local Integer variable called intScoreQ1Components.
        Dim intScoreQ1Components As Integer
        'Declares a local Intger variable called intScoreQ2Components. 
        Dim intScoreQ2Components As Integer

        'Declares a local 4 element Array Boolean called blnWrongAnswersComponents.
        Dim blnWrongAnswersComponents(0 To 3) As Boolean
        'Assigns blnWrongAnswersComponents(0) to the control chkOption2Q1.Checked.
        blnWrongAnswersComponents(0) = chkOption2Q1Components.Checked
        'Assigns blnWrongAnswersComponents(1) to the control chkOption1Q2.Checked.
        blnWrongAnswersComponents(1) = chkOption1Q2Components.Checked
        'Assigns blnWrongAnswersComponents(2) to the control chkOption2Q2.Checked.
        blnWrongAnswersComponents(2) = chkOption2Q2Components.Checked
        'Assigns blnWrongAnswersComponents(3) to the control chkOption4Q2.Checked.
        blnWrongAnswersComponents(3) = chkOption4Q2Components.Checked


        'Assigns the Variable blnCorrectAnswerComponentsQ1 as chkOption1Q1Components.checked. 
        blnCorrectAnswerComponentsQ1 = chkOption1Q1Components.Checked
        'Assigns the Variable blnCorrectAnswerComponentsQ2 as chkOption3Q2Components.checked.
        blnCorrectAnswerComponentsQ2 = chkOption3Q2Components.Checked

        'Uses an If statement to see if the checkboxes chkOption2Q1Components and chkOption3Q2Components have been checked and that the other checkboxes remain unchecked. 
        If blnCorrectAnswerComponentsQ1 = True And blnCorrectAnswerComponentsQ2 = True And blnWrongAnswersComponents(0) = False And blnWrongAnswersComponents(1) = False And blnWrongAnswersComponents(2) = False And blnWrongAnswersComponents(3) = False Then
            'If the above statement is true then the program will add 1 point to intScoreQ1Components.
            intScoreQ1Components = intScoreQ1Components + 1
            'The program will then add another point in intScoreQ2Components. 
            intScoreQ2Components = intScoreQ2Components + 1
            'Otherwise if the statement is false the program will then check to see if blnCorrectAnswerComponentsQ1 is false and blnCorrectAnswerComponentsQ2 is true.
        ElseIf blnCorrectAnswerComponentsQ1 = False And blnCorrectAnswerComponentsQ2 = True Then
            'The program will then add no points to intScoreQ1Components if the above statement is true.
            intScoreQ1Components = intScoreQ1Components + 0
            'The program will then add 1 point to intScoreQ2Components.
            intScoreQ2Components = intScoreQ2Components + 1
            'Else if the statement above is false the program will then check to see if blnCorrectAnswerComponentsQ1 is true and blnCorrectAnswerComponentsQ2 is false.
        ElseIf blnCorrectAnswerComponentsQ1 = True And blnCorrectAnswerComponentsQ2 = False Then
            'The program will then add 1 point to intScoreQ1Components if the above statement is true.
            intScoreQ1Components = intScoreQ1Components + 1
            'The program will then add no points to intScoreQ2Components.
            intScoreQ2Components = intScoreQ2Components + 0
            'If the user performs any other conditions outside this If statement then this part of the statement will run.
        Else
            'Adds no points to intScoreQ1Components.
            intScoreQ1Components = intScoreQ1Components + 0
            'Adds no points to intScoreQ2Components.
            intScoreQ2Components = intScoreQ2Components + 0
        End If

        'The program will then add the scores of intScoreQ1Components and intScoreQ2Components together and store it in the Public Integer Variable intTotalComponentsScorefrm1.
        intTotalComponentsScorefrm1 = intScoreQ1Components + intScoreQ2Components

        'Hides the Current form.
        Me.Hide()
        'Shows frmNetworkingComponents2.
        frmNetworkingComponents2.Show()
    End Sub
End Class