Public Class frmNetworkingTopologys2
    'Declares a public shared Boolean variable called blnCorrectAnswerTopologyQ3.  
    Public Shared blnCorrectAnswerTopologyQ3 As Boolean
    'Declares a public shared Boolean variable called blnCorrectAnswerTopologyQ4.
    Public Shared blnCorrectAnswerTopologyQ4 As Boolean
    'Declares a public shared Integer variable called intTotalTopologyScorefrm2.
    Public Shared intTotalTopologyScorefrm2 As Integer

    Private Sub btnBackfrmNetworkingTopology2_Click(sender As Object, e As EventArgs) Handles btnBackfrmNetworkingTopology2.Click
        'Hides Current form.
        Me.Hide()
        'Goes to the module modResetSection and runs the code that is in the public sub ResetSection.
        modResetSection.ResetSection()
        'Shows Main Menu form.
        frmMainMenu.Show()
    End Sub

    Private Sub btnNextNetworkingTopology2_Click(sender As Object, e As EventArgs) Handles btnNextNetworkingTopology2.Click
        'Declares a local integer variable called intScoreQ3Topology.
        Dim intScoreQ3Topology As Integer
        'Declares a local integer variable called intScoreQ4Topology.
        Dim intScoreQ4Topology As Integer

        'Declares a local 2 element array boolean called blnWrongAnswersTopology2.
        Dim blnWrongAnswersTopology2(0 To 1) As Boolean
        'Assigns blnWrongAnswersTopology2(0) to the control chkOption2Q3Topology.Checked.
        blnWrongAnswersTopology2(0) = chkOption2Q3Topology.Checked
        'Assigns blnWrongAnswersTopology2(0) to the control chkOption2Q4Topology.Checked.
        blnWrongAnswersTopology2(1) = chkOption2Q4Topology.Checked

        'Assigns the variable blnCorrectAnswerTopologyQ3 as chkOption1Q3Topology.checked while setting it to true.
        blnCorrectAnswerTopologyQ3 = chkOption1Q3Topology.Checked
        'Assigns the variable blnCorrectAnswerTopologyQ4 as chkOption1Q4Topology.checked while setting it to true.
        blnCorrectAnswerTopologyQ4 = chkOption1Q4Topology.Checked

        'Uses an If statement to see if the checkboxes chkOption1Q3Topology and chkOption1Q4Topology have been checked and that the other checkboxes remain unchecked.
        If blnCorrectAnswerTopologyQ3 And blnCorrectAnswerTopologyQ4 = True And blnWrongAnswersTopology2(0) = False And blnWrongAnswersTopology2(1) = False Then
            'If the above statement is true then the prgram will add 1 point to intScoreQ3Topology.
            intScoreQ3Topology = intScoreQ3Topology + 1
            'The program will then add another point in intScoreQ2Topology. 
            intScoreQ4Topology = intScoreQ4Topology + 1
            'Otherwise if the statement is false the program will then check to see if blnCorrectAnswerTopologyQ3 is false and blnCorrectAnswerTopologyQ4 is true.
        ElseIf blnCorrectAnswerTopologyQ3 = False And blnCorrectAnswerTopologyQ4 = True Then
            'The program will then add no points to intScoreQ3Topology if the above statement is true.
            intScoreQ3Topology = intScoreQ3Topology + 0
            'The program will then add 1 point to intScoreQ4Topology.
            intScoreQ4Topology = intScoreQ4Topology + 1
            'Else if the statement above is false the program will then check to see if blnCorrectAnswerTopologyQ3 is true and blnCorrectAnswerTopologyQ4 is false.
        ElseIf blnCorrectAnswerTopologyQ3 = True And blnCorrectAnswerTopologyQ4 = False Then
            'The program will then add 1 point to intScoreQ3Topology if the above statement is true.
            intScoreQ3Topology = intScoreQ3Topology + 1
            'The program will then add no points to intScoreQ4Topology.
            intScoreQ4Topology = intScoreQ4Topology + 0
            'If the user performs any other conditions outside this If statement then this part of the statement will run.
        Else
            'Adds no points to intScoreQ3Topology.
            intScoreQ3Topology = intScoreQ3Topology + 0
            'Adds no points to intScoreQ4Topology.
            intScoreQ4Topology = intScoreQ4Topology + 0
        End If
        'The program will then add the scores of intScoreQ3Topology and intScoreQ4Topology together and store it in the public integer variable intTotalTopologyScorefrm2.
        intTotalTopologyScorefrm2 = intScoreQ3Topology + intScoreQ4Topology

        'Hides the Current form.
        Me.Hide()
        'Shows frmNetworkingTopologys3.
        frmNetworkingTopologys3.Show()
    End Sub
End Class