Public Class frmNetworkingTopologys3
    'Declares a public shared Boolean variable called blnCorrectAnswerTopologyQ5. 
    Public Shared blnCorrectAnswerTopologyQ5 As Boolean
    'Declares a public shared Boolean variable called blnCorrectAnswerTopologyQ6. 
    Public Shared blnCorrectAnswerTopologyQ6 As Boolean
    'Declares a public shared Integer variable called intTotalTopologyScorefrm3. 
    Public Shared intTotalTopologyScorefrm3 As Integer

    Private Sub btnBackfrmNetworkingTopology3_Click(sender As Object, e As EventArgs) Handles btnBackfrmNetworkingTopology3.Click
        'Hides the current form.
        Me.Hide()
        'Goes to the module modResetSection and runs the code that is in the public sub ResetSection.
        modResetSection.ResetSection()
        'Shows the Main Menu to the user.
        frmMainMenu.Show()
    End Sub

    Private Sub btnNextNetworkingTopology3_Click(sender As Object, e As EventArgs) Handles btnNextNetworkingTopology3.Click
        'Declares a local Integer variable called intScoreQ5Topology.
        Dim intScoreQ5Topology As Integer
        'Declares a local Intger varible called intScoreQ6Topology. 
        Dim intScoreQ6Topology As Integer

        'Declares a local 5 element array Boolean called blnWrongAnswersTopology3.
        Dim blnWrongAnswersTopology3(0 To 1) As Boolean
        'Assigns blnWrongAnswersTopology3(0) to the control chkOption1Q5Topology.Checked.
        blnWrongAnswersTopology3(0) = chkOption1Q5Topology.Checked
        'Assigns blnWrongAnswersTopology3(1) to the control chkOption1Q6Topology.Checked.
        blnWrongAnswersTopology3(1) = chkOption1Q6Topology.Checked


        'Assigns the variable blnCorrectAnswerTopologyQ1 as chkOption2Q5.checked while setting it to true. 
        blnCorrectAnswerTopologyQ5 = chkOption2Q5Topology.Checked = True
        'Assigns the variable blnCorrectAnswerTopologyQ2 as chkOption2Q6.checked while setting it to true.
        blnCorrectAnswerTopologyQ6 = chkOption2Q6Topology.Checked = True

        'Uses an If statement to see if the checkboxes chkOption2Q1 and chkOption3Q2 have been checked and that the other checkboxes remain unchecked. 
        If blnCorrectAnswerTopologyQ5 = True And blnCorrectAnswerTopologyQ6 = True And blnWrongAnswersTopology3(0) = False And blnWrongAnswersTopology3(0) = False And blnWrongAnswersTopology3(1) = False Then
            'If the above statement is true then the prgram will add 1 point to intScoreQ5Topology.
            intScoreQ5Topology = intScoreQ5Topology + 1
            'The program will then add another point in intScoreQ6Topology. 
            intScoreQ6Topology = intScoreQ6Topology + 1
            'Otherwise if the statement is false the program will then check to see if blnCorrectAnswerTopologyQ5 is false and blnCorrectAnswerTopologyQ6 is true.
        ElseIf blnCorrectAnswerTopologyQ5 = False And blnCorrectAnswerTopologyQ6 = True Then
            'The program will then add no points to intScoreQ5Topology if the above statement is true.
            intScoreQ5Topology = intScoreQ5Topology + 0
            'The program will then add 1 point to intScoreQ6Topology.
            intScoreQ6Topology = intScoreQ6Topology + 1
            'Else if the statement above is false the program will then check to see if blnCorrectAnswerTopologyQ5 is true and blnCorrectAnswerTopologyQ6 is false.
        ElseIf blnCorrectAnswerTopologyQ5 = True And blnCorrectAnswerTopologyQ6 = False Then
            ''The program will then add 1 point to intScoreQ5Topology if the above statement is true.
            intScoreQ5Topology = intScoreQ5Topology + 1
            'The program will then add no points to intScoreQ6Topology.
            intScoreQ6Topology = intScoreQ6Topology + 0
            'If the user performs any other conditions outside this if statement then this part of the statement will run.
        Else
            'Adds no points to intScoreQ5Topology.
            intScoreQ5Topology = intScoreQ5Topology + 0
            'Adds no points to intScoreQ6Topology.
            intScoreQ6Topology = intScoreQ6Topology + 0
        End If

        'The program will then add the scores of intScoreQ5Topology and intScoreQ6Topology together and store it in the public integer variable intTotalTopologyScorefrm3
        intTotalTopologyScorefrm3 = intScoreQ5Topology + intScoreQ6Topology

        'Hides the Current form.
        Me.Hide()
        'Shows the results page frmResultsTopologys.
        frmResultsTopologys.Show()
    End Sub
End Class