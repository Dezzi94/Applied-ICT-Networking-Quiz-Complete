Public Class frmNetworkingCablingAndConnectivity3
    'Declares a public shared Boolean variable called blnCorrectAnswerCablingAndConnectivityQ5.
    Public Shared blnCorrectAnswerCablingAndConnectivityQ5 As Boolean
    'Declares a public shared Boolean variable called blnCorrectAnswerCablingAndConnectivityQ6.
    Public Shared blnCorrectAnswerCablingAndConnectivityQ6 As Boolean
    'Declares a public shared Integer variable called intTotalCablingAndConnectivityScorefrm3. 
    Public Shared intTotalCablingAndConnectivityScorefrm3 As Integer

    Private Sub btnBackfrmNetworkingCablingAndConnectivity3_Click(sender As Object, e As EventArgs) Handles btnBackfrmNetworkingCablingAndConnectivity3.Click
        'Hides the current form.
        Me.Hide()
        'Goes to the module modResetSection and runs the code that is in the public sub ResetSection.
        modResetSection.ResetSection()
        'Shows the Main Menu to the user.
        frmMainMenu.Show()
    End Sub

    Private Sub btnNextNetworkingCablingAndConnectivity_Click3(sender As Object, e As EventArgs) Handles btnNextNetworkingCablingAndConnectivity3.Click
        'Declares a local Integer variable called intScoreQ5CablingAndConnectivity.
        Dim intScoreQ5CablingAndConnectivity As Integer
        'Declares a local Integer varible called intScoreQ6CablingAndConnectivity. 
        Dim intScoreQ6CablingAndConnectivity As Integer

        'Declares a local 2 element array Boolean called blnWrongAnswersCablingAndConnectivity3.
        Dim blnWrongAnswersCablingAndConnectivity3(0 To 1) As Boolean
        'Assigns blnWrongAnswersCablingAndConnectivity3(0) to the control chkOption1Q5CablingAndConnectivity.Checked.
        blnWrongAnswersCablingAndConnectivity3(0) = chkOption1Q5CablingAndConnectivity.Checked
        'Assigns blnWrongAnswersCablingAndConnectivity3(1) to the control chkOption1Q6CablingAndConnectivity.Checked.
        blnWrongAnswersCablingAndConnectivity3(1) = chkOption1Q6CablingAndConnectivity.Checked

        'Assigns the variable blnCorrectAnswerCablingAndConnectivityQ5 as chkOption2Q5CablingAndConnectivity.checked. 
        blnCorrectAnswerCablingAndConnectivityQ5 = chkOption2Q5CablingAndConnectivity.Checked()
        'Assigns the variable blnCorrectAnswerCablingAndConnectivityQ6 as chkOption2Q6CablingAndConnectivity.checked.
        blnCorrectAnswerCablingAndConnectivityQ6 = chkOption2Q6CablingAndConnectivity.Checked

        'Uses an If statement to see if the checkboxes chkOption2Q5CablingAndConnectivity and chkOption2Q6CablingAndConnectivity have been checked and that the other checkboxes remain unchecked. 
        If blnCorrectAnswerCablingAndConnectivityQ5 = True And blnCorrectAnswerCablingAndConnectivityQ6 = True And blnWrongAnswersCablingAndConnectivity3(0) = False And blnWrongAnswersCablingAndConnectivity3(1) = False Then
            'If the above statement is true then the prgram will add 1 point to intScoreQ5CablingAndConnectivity.
            intScoreQ5CablingAndConnectivity = intScoreQ5CablingAndConnectivity + 1
            'The program will then add another point in intScoreQ6CablingAndConnectivity. 
            intScoreQ6CablingAndConnectivity = intScoreQ6CablingAndConnectivity + 1
            'Otherwise if the statement is false the program will then check to see if blnCorrectAnswerCablingAndConnectivityQ5 is false and blnCorrectAnswerCablingAndConnectivityQ6 is true.
        ElseIf blnCorrectAnswerCablingAndConnectivityQ5 = False And blnCorrectAnswerCablingAndConnectivityQ6 = True Then
            'The program will then add no points to intScoreQ5CablingAndConnectivity if the above statement is true.
            intScoreQ5CablingAndConnectivity = intScoreQ5CablingAndConnectivity + 0
            'The program will then add 1 point to intScoreQ6CablingAndConnectivity.
            intScoreQ6CablingAndConnectivity = intScoreQ6CablingAndConnectivity + 1
            'Else if the statement above is false the program will then check to see if blnCorrectAnswerCablingAndConnectivityQ5 is true and blnCorrectAnswerCablingAndConnectivityQ6 is false.
        ElseIf blnCorrectAnswerCablingAndConnectivityQ5 = True And blnCorrectAnswerCablingAndConnectivityQ6 = False Then
            ''The program will then add 1 point to intScoreQ5CablingAndConnectivity if the above statement is true.
            intScoreQ5CablingAndConnectivity = intScoreQ5CablingAndConnectivity + 1
            'The program will then add no points to intScoreQ6CablingAndConnectivity.
            intScoreQ6CablingAndConnectivity = intScoreQ6CablingAndConnectivity + 0
            'If the user performs any other conditions outside this if statement then this part of the statement will run.
        Else
            'Adds no points to intScoreQ5CablingAndConnectivity.
            intScoreQ5CablingAndConnectivity = intScoreQ5CablingAndConnectivity + 0
            'Adds no points to intScoreQ6CablingAndConnectivity.
            intScoreQ6CablingAndConnectivity = intScoreQ6CablingAndConnectivity + 0
        End If

        'The program will then add the scores of intScoreQ5CablingAndConnectivity and intScoreQ6CablingAndConnectivity together and store it in the public integer variable intTotalCablingAndConnectivityScorefrm3
        intTotalCablingAndConnectivityScorefrm3 = intScoreQ5CablingAndConnectivity + intScoreQ6CablingAndConnectivity
        'Hides the Current form.
        Me.Hide()
        'Shows frmResultsCablingAndConnectivity.
        frmResultsCablingAndConnectivity.Show()
    End Sub
End Class