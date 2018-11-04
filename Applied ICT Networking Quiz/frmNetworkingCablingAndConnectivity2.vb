Public Class frmNetworkingCablingAndConnectivity2
    'Declares a public shared Boolean variable called blnCorrectAnswerCablingAndConnectivityQ3.
    Public Shared blnCorrectAnswerCablingAndConnectivityQ3 As Boolean
    'Declares a public shared Boolean variable called blnCorrectAnswerCablingAndConnectivityQ4.
    Public Shared blnCorrectAnswerCablingAndConnectivityQ4 As Boolean
    'Declares a public shared Integer variable called intTotalCablingAndConnectivityScorefrm2. 
    Public Shared intTotalCablingAndConnectivityScorefrm2 As Integer

    Private Sub btnBackfrmNetworkingCablingAndConnectivity_Click(sender As Object, e As EventArgs) Handles btnBackfrmNetworkingCablingAndConnectivity2.Click
        'Hides the current form.
        Me.Hide()
        'Goes to the module modResetSection and runs the code that is in the public sub ResetSection.
        modResetSection.ResetSection()
        'Shows the Main Menu to the user.
        frmMainMenu.Show()
    End Sub

    Private Sub btnNextNetworkingCablingAndConnectivity_Click(sender As Object, e As EventArgs) Handles btnNextNetworkingCablingAndConnectivity2.Click
        'Declares a local Integer variable called intScoreQ3CablingAndConnectivity.
        Dim intScoreQ3CablingAndConnectivity As Integer
        'Declares a local Integer varible called intScoreQ4CablingAndConnectivity. 
        Dim intScoreQ4CablingAndConnectivity As Integer

        'Declares a local 2 element array Boolean called blnWrongAnswersCablingAndConnectivity2.
        Dim blnWrongAnswersCablingAndConnectivity2(0 To 1) As Boolean
        'Assigns blnWrongAnswersCablingAndConnectivity2(0) to the control chkOption1Q3CablingAndConnectivity.Checked.
        blnWrongAnswersCablingAndConnectivity2(0) = chkOption1Q3CablingAndConnectivity.Checked
        'Assigns blnWrongAnswersCablingAndConnectivity2(1) to the control chkOption2Q4CablingAndConnectivity.Checked.
        blnWrongAnswersCablingAndConnectivity2(1) = chkOption2Q4CablingAndConnectivity.Checked

        'Assigns the variable blnCorrectAnswerCablingAndConnectivityQ3 as chkOption2Q3CablingAndConnectivity.checked. 
        blnCorrectAnswerCablingAndConnectivityQ3 = chkOption2Q3CablingAndConnectivity.Checked()
        'Assigns the variable blnCorrectAnswerCablingAndConnectivityQ2 as chkOption1Q4CablingAndConnectivity.checked.
        blnCorrectAnswerCablingAndConnectivityQ4 = chkOption1Q4CablingAndConnectivity.Checked

        'Uses an If statement to see if the checkboxes chkOption2Q3CablingAndConnectivity and chkOption1Q4CablingAndConnectivity have been checked and that the other checkboxes remain unchecked. 
        If blnCorrectAnswerCablingAndConnectivityQ3 = True And blnCorrectAnswerCablingAndConnectivityQ4 = True And blnWrongAnswersCablingAndConnectivity2(0) = False And blnWrongAnswersCablingAndConnectivity2(1) = False Then
            'If the above statement is true then the prgram will add 1 point to intScoreQ3CablingAndConnectivity.
            intScoreQ3CablingAndConnectivity = intScoreQ3CablingAndConnectivity + 1
            'The program will then add another point in intScoreQ4CablingAndConnectivity. 
            intScoreQ4CablingAndConnectivity = intScoreQ4CablingAndConnectivity + 1
            'Otherwise if the statement is false the program will then check to see if blnCorrectAnswerCablingAndConnectivityQ3 is false and blnCorrectAnswerCablingAndConnectivityQ4 is true.
        ElseIf blnCorrectAnswerCablingAndConnectivityQ3 = False And blnCorrectAnswerCablingAndConnectivityQ4 = True Then
            'The program will then add no points to intScoreQ3CablingAndConnectivity if the above statement is true.
            intScoreQ3CablingAndConnectivity = intScoreQ3CablingAndConnectivity + 0
            'The program will then add 1 point to intScoreQ4CablingAndConnectivity.
            intScoreQ4CablingAndConnectivity = intScoreQ4CablingAndConnectivity + 1
            'Else if the statement above is false the program will then check to see if blnCorrectAnswerCablingAndConnectivityQ3 is true and blnCorrectAnswerCablingAndConnectivityQ4 is false.
        ElseIf blnCorrectAnswerCablingAndConnectivityQ3 = True And blnCorrectAnswerCablingAndConnectivityQ4 = False Then
            ''The program will then add 1 point to intScoreQ3CablingAndConnectivity if the above statement is true.
            intScoreQ3CablingAndConnectivity = intScoreQ3CablingAndConnectivity + 1
            'The program will then add no points to intScoreQ4CablingAndConnectivity.
            intScoreQ4CablingAndConnectivity = intScoreQ4CablingAndConnectivity + 0
            'If the user performs any other conditions outside this if statement then this part of the statement will run.
        Else
            'Adds no points to intScoreQ3CablingAndConnectivity.
            intScoreQ3CablingAndConnectivity = intScoreQ3CablingAndConnectivity + 0
            'Adds no points to intScoreQ4CablingAndConnectivity.
            intScoreQ4CablingAndConnectivity = intScoreQ4CablingAndConnectivity + 0
        End If

        'The program will then add the scores of intScoreQ3CablingAndConnectivity and intScoreQ4CablingAndConnectivity together and store it in the public integer variable intTotalCablingAndConnectivityScorefrm2
        intTotalCablingAndConnectivityScorefrm2 = intScoreQ3CablingAndConnectivity + intScoreQ4CablingAndConnectivity
        'Hides the Current form.
        Me.Hide()
        'Shows frmNetworkingCablingAndConnectivity3.
        frmNetworkingCablingAndConnectivity3.Show()
    End Sub
End Class