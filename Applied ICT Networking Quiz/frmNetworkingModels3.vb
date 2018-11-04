Public Class frmNetworkingModels3
    'Declares a public shared Integer variable called intTotalModelsScorefrm3. 
    Public Shared intTotalModelsScorefrm3 As Integer

    Private Sub btnBackfrmNetworkingModels3_Click(sender As Object, e As EventArgs) Handles btnBackfrmNetworkingModels3.Click
        'Hides the current form.
        Me.Hide()
        'Goes to the module modResetSection and runs the code that is in the public sub ResetSection.
        modResetSection.ResetSection()
        'Shows the Main Menu to the user.
        frmMainMenu.Show()
    End Sub

    Private Sub btnNextNetworkingModels3_Click(sender As Object, e As EventArgs) Handles btnNextNetworkingModels3.Click
        'Declares a local Integer variable called intScoreQ5Models.
        Dim intScoreQ5Models As Integer
        'Declares a local Integer varible called intScoreQ6Models. 
        Dim intScoreQ6Models As Integer

        'Declares a local 7 element array String called strCorrectAnswersModelsQ5.
        Dim strCorrectAnswersModelsQ5(0 To 6) As String
        'Assigns strCorrectAnswersModelsQ5(0) to the control txtInsertAnswerQ5Models.Text and makes the text equal "PHYSICAL".
        strCorrectAnswersModelsQ5(0) = txtInsertAnswerQ5Models.Text = "PHYSICAL"
        'Assigns strCorrectAnswersModelsQ5(1) to the control txtInsertAnswer2Q5Models and makes the text equal "DATA LINK".
        strCorrectAnswersModelsQ5(1) = txtInsertAnswer2Q5Models.Text
        'Assigns strCorrectAnswersModelsQ5(2) to the control txtInsertAnswer3Q5Models and makes the text equal "NETWORK"
        strCorrectAnswersModelsQ5(2) = txtInsertAnswer3Q5Models.Text
        'Assigns strCorrectAnswersModelsQ5(3) to the control txtInsertAnswer4Q5Models and makes the text equal "TRANSPORT"
        strCorrectAnswersModelsQ5(3) = txtInsertAnswer4Q5Models.Text
        'Assigns strCorrectAnswersModelsQ5(4) to the control txtInsertAnswer5Q5Models and makes the text equal "SESSION"
        strCorrectAnswersModelsQ5(4) = txtInsertAnswer5Q5Models.Text
        'Assigns strCorrectAnswersModelsQ5(5) to the control txtInsertAnswer6Q5Models and makes the text equal "PRESENTATION"
        strCorrectAnswersModelsQ5(5) = txtInsertAnswer6Q5Models.Text
        'Assigns strCorrectAnswersModelsQ5(6) to the control txtInsertAnswer7Q5Models and makes the text equal "APPLICATION"
        strCorrectAnswersModelsQ5(6) = txtInsertAnswer7Q5Models.Text = "APPLICATION"

        'Declares a local 4 element array Boolean called strCorrectAnswersModelQ6.
        Dim strCorrectAnswersModelsQ6(0 To 3) As String
        'Assigns strCorrectAnswersModelsQ6(0) to the control txtInsertAnswerQ6Models and makes the text equal "NETWORK ACCESS"
        strCorrectAnswersModelsQ6(0) = txtInsertAnswerQ6Models.Text
        'Assigns strCorrectAnswersModelsQ6(1) to the control txtInsertAnswer2Q6Models and makes the text equal "INTERNET"
        strCorrectAnswersModelsQ6(1) = txtInsertAnswer2Q6Models.Text
        'Assigns strCorrectAnswersModelsQ6(2) to the control txtInsertAnswer3Q6Models and makes the text equal "TRANSPORT"
        strCorrectAnswersModelsQ6(2) = txtInsertAnswer3Q6Models.Text 
        'Assigns strCorrectAnswersModelsQ6(3) to the control txtInsertAnswer4Q6Models and makes the text equal "APPLICATION"
        strCorrectAnswersModelsQ6(3) = txtInsertAnswer4Q6Models.Text



        'Uses an If statement to see if the answers in the textboxes for question five and six are correct.
        If strCorrectAnswersModelsQ5(0) = "PHYSICAL" And strCorrectAnswersModelsQ5(1) = "DATA LINK" And strCorrectAnswersModelsQ5(2) = "NETWORK" And strCorrectAnswersModelsQ5(3) = "TRANSPORT" And strCorrectAnswersModelsQ5(4) = "SESSION" And strCorrectAnswersModelsQ5(5) = "PRESENTATION" And strCorrectAnswersModelsQ5(6) = "APPLICATION" And strCorrectAnswersModelsQ6(0) = "NETWORK ACCESS" And strCorrectAnswersModelsQ6(1) = "INTERNET" And strCorrectAnswersModelsQ6(2) = "TRANSPORT" And strCorrectAnswersModelsQ6(3) = "APPLICATION" Then
            'If the above statement is true then the prgram will add 1 point to intScoreQ5Models.
            intScoreQ5Models = intScoreQ5Models + 1
            'The program will then add another point in intScoreQ6Models. 
            intScoreQ6Models = intScoreQ6Models + 1
            'Otherwise if the statement is false the program will then check to see if question 5 is wrong and question 6 is correct.
        ElseIf strCorrectAnswersModelsQ5(0) <> "PHYSICAL" And strCorrectAnswersModelsQ5(1) <> "DATA LINK" And strCorrectAnswersModelsQ5(2) <> "NETWORK" And strCorrectAnswersModelsQ5(3) <> "TRANSPORT" And strCorrectAnswersModelsQ5(4) <> "SESSION" And strCorrectAnswersModelsQ5(5) <> "PRESENTATION" And strCorrectAnswersModelsQ5(6) <> "APPLICATION" And strCorrectAnswersModelsQ6(0) = "NETWORK ACCESS" And strCorrectAnswersModelsQ6(1) = "INTERNET" And strCorrectAnswersModelsQ6(2) = "TRANSPORT" And strCorrectAnswersModelsQ6(3) = "APPLICATION" Then
            'The program will then add no points to intScoreQ5Models if the above statement is true.
            intScoreQ5Models = intScoreQ5Models + 0
            'The program will then add 1 point to intScoreQ6Models.
            intScoreQ6Models = intScoreQ6Models + 1
            'Else if the statement above is false the program will then check to see if question 5 is correct and question 6 is wrong.
        ElseIf strCorrectAnswersModelsQ5(0) = "PHYSICAL" And strCorrectAnswersModelsQ5(1) = "DATA LINK" And strCorrectAnswersModelsQ5(2) = "NETWORK" And strCorrectAnswersModelsQ5(3) = "TRANSPORT" And strCorrectAnswersModelsQ5(4) = "SESSION" And strCorrectAnswersModelsQ5(5) = "PRESENTATION" And strCorrectAnswersModelsQ5(6) <> "APPLICATION" And strCorrectAnswersModelsQ6(0) <> "NETWORK ACCESS" And strCorrectAnswersModelsQ6(1) <> "INTERNET" And strCorrectAnswersModelsQ6(2) <> "TRANSPORT" And strCorrectAnswersModelsQ6(3) <> "APPLICATION" Then
            ''The program will then add 1 point to intScoreQ5Models if the above statement is true.
            intScoreQ5Models = intScoreQ5Models + 1
            'The program will then add no points to intScoreQ6Models.
            intScoreQ6Models = intScoreQ6Models + 0
            'If the user performs any other conditions outside this if statement then this part of the statement will run.
        Else
            'Adds no points to intScoreQ5Models.
            intScoreQ5Models = intScoreQ5Models + 0
            'Adds no points to intScoreQ6Models.
            intScoreQ6Models = intScoreQ6Models + 0
        End If
        'The program will then add the scores of intScoreQ5Models and intScoreQ6Models together and store it in the public integer variable intTotalModelsScorefrm3
        intTotalModelsScorefrm3 = intScoreQ5Models + intScoreQ6Models
        'Hides the Current form.
        Me.Hide()
        'Shows frmResultsModels.
        frmResultsModels.Show()



    End Sub
End Class