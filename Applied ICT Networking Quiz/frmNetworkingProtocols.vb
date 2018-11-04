Public Class frmNetworkingProtocols
    'Declares a public shared Boolean variable called blnCorrectAnswerProtocolsQ1.
    Public Shared blnCorrectAnswerProtocolsQ1 As Boolean
    'Declares a public shared Boolean variable called blnCorrectAnswerProtocolsQ2.
    Public Shared blnCorrectAnswerProtocolsQ2 As Boolean
    'Declares a public shared Integer variable called intTotalProtocolsScorefrm1. 
    Public Shared intTotalProtocolsScorefrm1 As Integer

    Private Sub btnBackfrmNetworkingProtocols_Click(sender As Object, e As EventArgs) Handles btnBackfrmNetworkingProtocols.Click
        'Hides the current form.
        Me.Hide()
        'Goes to the module modResetSection and runs the code that is in the public sub ResetSection.
        modResetSection.ResetSection()
        'Shows the Main Menu to the user.
        frmMainMenu.Show()
    End Sub

    Private Sub btnNextNetworkingProtocols_Click(sender As Object, e As EventArgs) Handles btnNextNetworkingProtocols.Click
        'Declares a local Integer variable called intScoreQ1Protocols.
        Dim intScoreQ1Protocols As Integer
        'Declares a local Integer varible called intScoreQ2Protocols. 
        Dim intScoreQ2Protocols As Integer

        'Declares a local 2 element array Boolean called blnWrongAnswersProtocols.
        Dim blnWrongAnswersProtocols(0 To 1) As Boolean
        'Assigns blnWrongAnswersProtocols(0) to the control chkOption2Q1Protocols.Checked.
        blnWrongAnswersProtocols(0) = chkOption2Q1Protocols.Checked
        'Assigns blnWrongAnswersProtocols(1) to the control chkOption2Q2Protocols.Checked.
        blnWrongAnswersProtocols(1) = chkOption2Q2Protocols.Checked

        'Assigns the variable blnCorrectAnswerProtocolsQ1 as chkOption1Q1Protocols.checked. 
        blnCorrectAnswerProtocolsQ1 = chkOption1Q1Protocols.Checked()
        'Assigns the variable blnCorrectAnswerProtocolsQ2 as chkOption1Q2Protocols.checked.
        blnCorrectAnswerProtocolsQ2 = chkOption1Q2Protocols.Checked

        'Uses an If statement to see if the checkboxes chkOption1Q1Protocols and chkOption1Q2Protocols have been checked and that the other checkboxes remain unchecked. 
        If blnCorrectAnswerProtocolsQ1 = True And blnCorrectAnswerProtocolsQ2 = True And blnWrongAnswersProtocols(0) = False And blnWrongAnswersProtocols(1) = False Then
            'If the above statement is true then the prgram will add 1 point to intScoreQ1Protocols.
            intScoreQ1Protocols = intScoreQ1Protocols + 1
            'The program will then add another point in intScoreQ2Protocols. 
            intScoreQ2Protocols = intScoreQ2Protocols + 1
            'Otherwise if the statement is false the program will then check to see if blnCorrectAnswerProtocolsQ1 is false and blnCorrectAnswerProtocolsQ2 is true.
        ElseIf blnCorrectAnswerProtocolsQ1 = False And blnCorrectAnswerProtocolsQ2 = True Then
            'The program will then add no points to intScoreQ1Protocols if the above statement is true.
            intScoreQ1Protocols = intScoreQ1Protocols + 0
            'The program will then add 1 point to intScoreQ2CProtocols.
            intScoreQ2Protocols = intScoreQ2Protocols + 1
            'Else if the statement above is false the program will then check to see if blnCorrectAnswerProtocolsQ1 is true and blnCorrectAnswerProtocolsQ2 is false.
        ElseIf blnCorrectAnswerProtocolsQ1 = True And blnCorrectAnswerProtocolsQ2 = False Then
            ''The program will then add 1 point to intScoreQ1Protocols if the above statement is true.
            intScoreQ1Protocols = intScoreQ1Protocols + 1
            'The program will then add no points to intScoreQ2Protocols.
            intScoreQ2Protocols = intScoreQ2Protocols + 0
            'If the user performs any other conditions outside this if statement then this part of the statement will run.
        Else
            'Adds no points to intScoreQ1Protocols.
            intScoreQ1Protocols = intScoreQ1Protocols + 0
            'Adds no points to intScoreQ2Protocols.
            intScoreQ2Protocols = intScoreQ2Protocols + 0
        End If

        'The program will then add the scores of intScoreQ1Protocols and intScoreQ2Protocols together and store it in the public integer variable intTotalProtocolsScorefrm1
        intTotalProtocolsScorefrm1 = intScoreQ1Protocols + intScoreQ2Protocols
        'Hides the Current form.
        Me.Hide()
        'Shows frmNetworkingProtocols2.
        frmNetworkingProtocols2.Show()
    End Sub
End Class