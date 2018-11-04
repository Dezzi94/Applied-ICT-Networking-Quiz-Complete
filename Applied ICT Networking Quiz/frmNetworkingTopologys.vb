Public Class frmNetworkingTopologys
    'Declares a public shared Boolean variable called blnCorrectAnswerTopologyQ1. 
    Public Shared blnCorrectAnswerTopologyQ1 As Boolean
    'Declares a public shared Boolean variable called blnCorrectAnswerTopologyQ2. 
    Public Shared blnCorrectAnswerTopologyQ2 As Boolean
    'Declares a public shared Integer variable called intTotalTopologyScorefrm1. 
    Public Shared intTotalTopologyScorefrm1 As Integer

    Private Sub btnBackfrmNetworkingTopology_Click(sender As Object, e As EventArgs) Handles btnBackfrmNetworkingTopology.Click
        'Hides the current form.
        Me.Hide()
        'Goes to the module modResetSection and runs the code that is in the public sub ResetSection.
        modResetSection.ResetSection()
        'Shows the Main Menu to the user.
        frmMainMenu.Show()
    End Sub

    Private Sub btnNextNetworkingTopology_Click(sender As Object, e As EventArgs) Handles btnNextNetworkingTopology.Click
        'Declares a local Integer variable called intScoreQ1Topology.
        Dim intScoreQ1Topology As Integer
        'Declares a local Integer varible called intScoreQ2Topology. 
        Dim intScoreQ2Topology As Integer

        'Declares a local 4 element array Boolean called blnWrongAnswers.
        Dim blnWrongAnswersTopology(0 To 3) As Boolean
        'Assigns blnWrongAnswersTopology(0) to the control chkOption2Q1Topology.Checked.
        blnWrongAnswersTopology(0) = chkOption2Q1Topology.Checked
        'Assigns blnWrongAnswersTopology(1) to the control chkOption1Q2Topology.Checked.
        blnWrongAnswersTopology(1) = chkOption1Q2Topology.Checked
        'Assigns blnWrongAnswersTopology(2) to the control chkOption3Q2Topology.Checked.
        blnWrongAnswersTopology(2) = chkOption3Q2Topology.Checked
        'Assigns blnWrongAnswersTopology(3) to the control chkOption4Q2Topology.Checked.
        blnWrongAnswersTopology(3) = chkOption4Q2Topology.Checked


        'Assigns the variable blnCorrectAnswerTopologyQ1 as chkOption1Q1Topology.checked while setting it to true. 
        blnCorrectAnswerTopologyQ1 = chkOption1Q1Topology.Checked
        'Assigns the variable blnCorrectAnswerQ2Topology as chkOption2Q2Topology.checked while setting it to true.
        blnCorrectAnswerTopologyQ2 = chkOption2Q2Topology.Checked

        'Uses an If statement to see if the checkboxes chkOption1Q1Topology and chkOption2Q2Topology have been checked and that the other checkboxes remain unchecked. 
        If blnCorrectAnswerTopologyQ1 = True And blnCorrectAnswerTopologyQ2 = True And blnWrongAnswersTopology(0) = False And blnWrongAnswersTopology(1) = False And blnWrongAnswersTopology(2) = False And blnWrongAnswersTopology(3) = False Then
            'If the above statement is true then the prgram will add 1 point to intScoreQ1Topology.
            intScoreQ1Topology = intScoreQ1Topology + 1
            'The program will then add another point in intScoreQ2Topology. 
            intScoreQ2Topology = intScoreQ2Topology + 1
            'Otherwise if the statement is false the program will then check to see if blnCorrectAnswerTopologyQ1 is false and blnCorrectAnswerTopologyQ2 is true.
        ElseIf blnCorrectAnswerTopologyQ1 = False And blnCorrectAnswerTopologyQ2 = True Then
            'The program will then add no points to intScoreQ1Topology if the above statement is true.
            intScoreQ1Topology = intScoreQ1Topology + 0
            'The program will then add 1 point to intScoreQ2Topology.
            intScoreQ2Topology = intScoreQ2Topology + 1
            'Else if the statement above is false the program will then check to see if blnCorrectAnswer2Q1Topology is true and blnCorrectAnswer3Q2Topology is false.
        ElseIf blnCorrectAnswerTopologyQ1 = True And blnCorrectAnswerTopologyQ2 = False Then
            ''The program will then add 1 point to intScoreQ1Topology if the above statement is true.
            intScoreQ1Topology = intScoreQ1Topology + 1
            'The program will then add no points to intScoreQ2Topology.
            intScoreQ2Topology = intScoreQ2Topology + 0
            'If the user performs any other conditions outside this if statement then this part of the statement will run.
        Else
            'Adds no points to intScoreQ1Topology.
            intScoreQ1Topology = intScoreQ1Topology + 0
            'Adds no points to intScoreQ2Topology
            intScoreQ2Topology = intScoreQ2Topology + 0
        End If

        'The program will then add the scores of intScoreQ1Topology and intScoreQ2Topology together and store it in the public integer variable intTotalTopologyScorefrm1
        intTotalTopologyScorefrm1 = intScoreQ1Topology + intScoreQ2Topology

        'Hides the Current form.
        Me.Hide()
        'Shows frmNetworkingTopologys2.
        frmNetworkingTopologys2.Show()
    End Sub
End Class