Public Class frmNetworkingCablingAndConnectivity
    'Declares a public shared Boolean variable called blnCorrectAnswerCablingAndConnectivityQ1.
    Public Shared blnCorrectAnswerCablingAndConnectivityQ1 As Boolean
    'Declares a public shared Boolean variable called blnCorrectAnswerCablingAndConnectivityQ2.
    Public Shared blnCorrectAnswerCablingAndConnectivityQ2 As Boolean
    'Declares a public shared Integer variable called intTotalCablingAndConnectivityScorefrm1. 
    Public Shared intTotalCablingAndConnectivityScorefrm1 As Integer

    Private Sub btnBackfrmNetworkingCablingAndConnectivity_Click(sender As Object, e As EventArgs) Handles btnBackfrmNetworkingCablingAndConnectivity.Click
        'Hides the current form.
        Me.Hide()
        'Goes to the module modResetSection and runs the code that is in the public sub ResetSection.
        modResetSection.ResetSection()
        'Shows the Main Menu to the user.
        frmMainMenu.Show()
    End Sub

    Private Sub btnNextNetworkingCablingAndConnectivity_Click(sender As Object, e As EventArgs) Handles btnNextNetworkingCablingAndConnectivity.Click
        'Declares a local Integer variable called intScoreQ1CablingAndConnectivity.
        Dim intScoreQ1CablingAndConnectivity As Integer
        'Declares a local Integer varible called intScoreQ2CablingAndConnectivity. 
        Dim intScoreQ2CablingAndConnectivity As Integer

        'Declares a local 2 element array Boolean called blnWrongAnswersCablingAndConnectivity.
        Dim blnWrongAnswersCablingAndConnectivity(0 To 1) As Boolean
        'Assigns blnWrongAnswersCablingAndConnectivity(0) to the control chkOption1Q1CablingAndConnectivity.Checked.
        blnWrongAnswersCablingAndConnectivity(0) = chkOption1Q1CablingAndConnectivity.Checked
        'Assigns blnWrongAnswersCablingAndConnectivity(1) to the control chkOption2Q2CablingAndConnectivity.Checked.
        blnWrongAnswersCablingAndConnectivity(1) = chkOption2Q2CablingAndConnectivity.Checked

        'Assigns the variable blnCorrectAnswerCablingAndConnectivityQ1 as chkOption2Q1CablingAndConnectivity.checked. 
        blnCorrectAnswerCablingAndConnectivityQ1 = chkOption2Q1CablingAndConnectivity.Checked()
        'Assigns the variable blnCorrectAnswerCablingAndConnectivityQ2 as chkOption1Q2CablingAndConnectivity.checked.
        blnCorrectAnswerCablingAndConnectivityQ2 = chkOption1Q2CablingAndConnectivity.Checked

        'Uses an If statement to see if the checkboxes chkOption2Q1CablingAndConnectivity and chkOption1Q2CablingAndConnectivity have been checked and that the other checkboxes remain unchecked. 
        If blnCorrectAnswerCablingAndConnectivityQ1 = True And blnCorrectAnswerCablingAndConnectivityQ2 = True And blnWrongAnswersCablingAndConnectivity(0) = False And blnWrongAnswersCablingAndConnectivity(1) = False Then
            'If the above statement is true then the prgram will add 1 point to intScoreQ1CablingAndConnectivity.
            intScoreQ1CablingAndConnectivity = intScoreQ1CablingAndConnectivity + 1
            'The program will then add another point in intScoreQ2CablingAndConnectivity. 
            intScoreQ2CablingAndConnectivity = intScoreQ2CablingAndConnectivity + 1
            'Otherwise if the statement is false the program will then check to see if blnCorrectAnswerCablingAndConnectivityQ1 is false and blnCorrectAnswerCablingAndConnectivityQ2 is true.
        ElseIf blnCorrectAnswerCablingAndConnectivityQ1 = False And blnCorrectAnswerCablingAndConnectivityQ2 = True Then
            'The program will then add no points to intScoreQ1CablingAndConnectivity if the above statement is true.
            intScoreQ1CablingAndConnectivity = intScoreQ1CablingAndConnectivity + 0
            'The program will then add 1 point to intScoreQ2CablingAndConnectivity.
            intScoreQ2CablingAndConnectivity = intScoreQ2CablingAndConnectivity + 1
            'Else if the statement above is false the program will then check to see if blnCorrectAnswerCablingAndConnectivityQ1 is true and blnCorrectAnswerCablingAndConnectivityQ2 is false.
        ElseIf blnCorrectAnswerCablingAndConnectivityQ1 = True And blnCorrectAnswerCablingAndConnectivityQ2 = False Then
            ''The program will then add 1 point to intScoreQ1CablingAndConnectivity if the above statement is true.
            intScoreQ1CablingAndConnectivity = intScoreQ1CablingAndConnectivity + 1
            'The program will then add no points to intScoreQ2CablingAndConnectivity.
            intScoreQ2CablingAndConnectivity = intScoreQ2CablingAndConnectivity + 0
            'If the user performs any other conditions outside this if statement then this part of the statement will run.
        Else
            'Adds no points to intScoreQ1CablingAndConnectivity.
            intScoreQ1CablingAndConnectivity = intScoreQ1CablingAndConnectivity + 0
            'Adds no points to intScoreQ2CablingAndConnectivity.
            intScoreQ2CablingAndConnectivity = intScoreQ2CablingAndConnectivity + 0
        End If

        'The program will then add the scores of intScoreQ1CablingAndConnectivity and intScoreQ2CablingAndConnectivity together and store it in the public integer variable intTotalCablingAndConnectivityScorefrm1
        intTotalCablingAndConnectivityScorefrm1 = intScoreQ1CablingAndConnectivity + intScoreQ2CablingAndConnectivity
        'Hides the Current form.
        Me.Hide()
        'Shows frmNetworkingCablingAndConnectivity2.
        frmNetworkingCablingAndConnectivity2.Show()
    End Sub
End Class