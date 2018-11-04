Public Class frmNetworkingProtocols3
    'Declares a public shared Boolean variable called blnCorrectAnswerProtocolsQ3.
    Public Shared blnCorrectAnswerProtocolsQ5 As Boolean
    'Declares a public shared Boolean variable called blnCorrectAnswerProtocolsQ6.
    Public Shared blnCorrectAnswerProtocolsQ6 As Boolean
    'Declares a public shared Integer variable called intTotalProtocolsScorefrm3. 
    Public Shared intTotalProtocolsScorefrm3 As Integer

    Private Sub btnBackfrmNetworkingProtocols3_Click(sender As Object, e As EventArgs) Handles btnBackfrmNetworkingProtocols3.Click
        'Hides the current form.
        Me.Hide()
        'Goes to the module modResetSection and runs the code that is in the public sub ResetSection.
        modResetSection.ResetSection()
        'Shows the Main Menu to the user.
        frmMainMenu.Show()
    End Sub

    Private Sub btnNextNetworkingProtocols3_Click(sender As Object, e As EventArgs) Handles btnNextNetworkingProtocols3.Click
        'Declares a local Integer variable called intScoreQ5Protocols.
        Dim intScoreQ5Protocols As Integer
        'Declares a local Integer varible called intScoreQ6Protocols. 
        Dim intScoreQ6Protocols As Integer

        'Declares a local 2 element array Boolean called blnWrongAnswersProtocols3.
        Dim blnWrongAnswersProtocols3(0 To 1) As Boolean
        'Assigns blnWrongAnswersProtocols3(0) to the control chkOption1Q5Protocols.Checked.
        blnWrongAnswersProtocols3(0) = chkOption1Q5Protocols.Checked
        'Assigns blnWrongAnswersProtocols3(1) to the control chkOption2Q6Protocols.Checked.
        blnWrongAnswersProtocols3(1) = chkOption2Q6Protocols.Checked

        'Assigns the variable blnCorrectAnswerProtocolsQ5 as chkOption2Q5Protocols.checked. 
        blnCorrectAnswerProtocolsQ5 = chkOption2Q5Protocols.Checked()
        'Assigns the variable blnCorrectAnswerProtocolsQ6 as chkOption1Q6Protocols.checked.
        blnCorrectAnswerProtocolsQ6 = chkOption1Q6Protocols.Checked

        'Uses an If statement to see if the checkboxes chkOption2Q5Protocols and chkOption1Q6Protocols have been checked and that the other checkboxes remain unchecked. 
        If blnCorrectAnswerProtocolsQ5 = True And blnCorrectAnswerProtocolsQ6 = True And blnWrongAnswersProtocols3(0) = False And blnWrongAnswersProtocols3(1) = False Then
            'If the above statement is true then the prgram will add 1 point to intScoreQ5Protocols.
            intScoreQ5Protocols = intScoreQ5Protocols + 1
            'The program will then add another point in intScoreQ6Protocols. 
            intScoreQ6Protocols = intScoreQ6Protocols + 1
            'Otherwise if the statement is false the program will then check to see if blnCorrectAnswerProtocolsQ5 is false and blnCorrectAnswerProtocolsQ6 is true.
        ElseIf blnCorrectAnswerProtocolsQ5 = False And blnCorrectAnswerProtocolsQ6 = True Then
            'The program will then add no points to intScoreQ5Protocols if the above statement is true.
            intScoreQ5Protocols = intScoreQ5Protocols + 0
            'The program will then add 1 point to intScoreQ6CProtocols.
            intScoreQ6Protocols = intScoreQ6Protocols + 1
            'Else if the statement above is false the program will then check to see if blnCorrectAnswerProtocolsQ5 is true and blnCorrectAnswerProtocolsQ6 is false.
        ElseIf blnCorrectAnswerProtocolsQ5 = True And blnCorrectAnswerProtocolsQ6 = False Then
            ''The program will then add 1 point to intScoreQ5Protocols if the above statement is true.
            intScoreQ5Protocols = intScoreQ5Protocols + 1
            'The program will then add no points to intScoreQ6Protocols.
            intScoreQ6Protocols = intScoreQ6Protocols + 0
            'If the user performs any other conditions outside this if statement then this part of the statement will run.
        Else
            'Adds no points to intScoreQ5Protocols.
            intScoreQ5Protocols = intScoreQ5Protocols + 0
            'Adds no points to intScoreQ6Protocols.
            intScoreQ6Protocols = intScoreQ6Protocols + 0
        End If

        'The program will then add the scores of intScoreQ5Protocols and intScoreQ6Protocols together and store it in the public integer variable intTotalProtocolsScorefrm3
        intTotalProtocolsScorefrm3 = intScoreQ5Protocols + intScoreQ6Protocols
        'Hides the Current form.
        Me.Hide()
        'Shows frmResultsProtocols.
        frmResultsProtocols.Show()
    End Sub
End Class