Public Class frmNetworkingProtocols2
    'Declares a public shared Boolean variable called blnCorrectAnswerProtocolsQ3.
    Public Shared blnCorrectAnswerProtocolsQ3 As Boolean
    'Declares a public shared Boolean variable called blnCorrectAnswerProtocolsQ4.
    Public Shared blnCorrectAnswerProtocolsQ4 As Boolean
    'Declares a public shared Integer variable called intTotalProtocolsScorefrm2. 
    Public Shared intTotalProtocolsScorefrm2 As Integer

    Private Sub btnBackfrmNetworkingProtocols2_Click(sender As Object, e As EventArgs) Handles btnBackfrmNetworkingProtocols2.Click
        'Hides the current form.
        Me.Hide()
        'Goes to the module modResetSection and runs the code that is in the public sub ResetSection.
        modResetSection.ResetSection()
        'Shows the Main Menu to the user.
        frmMainMenu.Show()
    End Sub

    Private Sub btnNextNetworkingProtocols2_Click(sender As Object, e As EventArgs) Handles btnNextNetworkingProtocols2.Click
        'Declares a local Integer variable called intScoreQ3Protocols.
        Dim intScoreQ3Protocols As Integer
        'Declares a local Integer varible called intScoreQ4Protocols. 
        Dim intScoreQ4Protocols As Integer

        'Declares a local 2 element array Boolean called blnWrongAnswersProtocols2.
        Dim blnWrongAnswersProtocols2(0 To 1) As Boolean
        'Assigns blnWrongAnswersProtocols2(0) to the control chkOption1Q3Protocols.Checked.
        blnWrongAnswersProtocols2(0) = chkOption1Q3Protocols.Checked
        'Assigns blnWrongAnswersProtocols2(1) to the control chkOption2Q4Protocols.Checked.
        blnWrongAnswersProtocols2(1) = chkOption2Q4Protocols.Checked

        'Assigns the variable blnCorrectAnswerProtocolsQ3 as chkOption2Q3Protocols.checked. 
        blnCorrectAnswerProtocolsQ3 = chkOption2Q3Protocols.Checked()
        'Assigns the variable blnCorrectAnswerProtocolsQ4 as chkOption1Q4Protocols.checked.
        blnCorrectAnswerProtocolsQ4 = chkOption1Q4Protocols.Checked

        'Uses an If statement to see if the checkboxes chkOption2Q3Protocols and chkOption1Q4Protocols have been checked and that the other checkboxes remain unchecked. 
        If blnCorrectAnswerProtocolsQ3 = True And blnCorrectAnswerProtocolsQ4 = True And blnWrongAnswersProtocols2(0) = False And blnWrongAnswersProtocols2(1) = False Then
            'If the above statement is true then the prgram will add 1 point to intScoreQ3Protocols.
            intScoreQ3Protocols = intScoreQ3Protocols + 1
            'The program will then add another point in intScoreQ4Protocols. 
            intScoreQ4Protocols = intScoreQ4Protocols + 1
            'Otherwise if the statement is false the program will then check to see if blnCorrectAnswerProtocolsQ3 is false and blnCorrectAnswerProtocolsQ4 is true.
        ElseIf blnCorrectAnswerProtocolsQ3 = False And blnCorrectAnswerProtocolsQ4 = True Then
            'The program will then add no points to intScoreQ3Protocols if the above statement is true.
            intScoreQ3Protocols = intScoreQ3Protocols + 0
            'The program will then add 1 point to intScoreQ4CProtocols.
            intScoreQ4Protocols = intScoreQ4Protocols + 1
            'Else if the statement above is false the program will then check to see if blnCorrectAnswerProtocolsQ3 is true and blnCorrectAnswerProtocolsQ4 is false.
        ElseIf blnCorrectAnswerProtocolsQ3 = True And blnCorrectAnswerProtocolsQ4 = False Then
            ''The program will then add 1 point to intScoreQ3Protocols if the above statement is true.
            intScoreQ3Protocols = intScoreQ3Protocols + 1
            'The program will then add no points to intScoreQ4Protocols.
            intScoreQ4Protocols = intScoreQ4Protocols + 0
            'If the user performs any other conditions outside this if statement then this part of the statement will run.
        Else
            'Adds no points to intScoreQ3Protocols.
            intScoreQ3Protocols = intScoreQ3Protocols + 0
            'Adds no points to intScoreQ4Protocols.
            intScoreQ4Protocols = intScoreQ4Protocols + 0
        End If

        'The program will then add the scores of intScoreQ3Protocols and intScoreQ4Protocols together and store it in the public integer variable intTotalProtocolsScorefrm2
        intTotalProtocolsScorefrm2 = intScoreQ3Protocols + intScoreQ4Protocols
        'Hides the Current form.
        Me.Hide()
        'Shows frmNetworkingProtocols3.
        frmNetworkingProtocols3.Show()
    End Sub
End Class