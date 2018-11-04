'Creates a module called modResetSection which can be used to run certain code on any form.
Module modResetSection
    'Creates a public sub called ResetSection which can be called from any form.
    Public Sub ResetSection()
        'Creates a For loop with a variable called controlArchitectures that will loop around the form frmNetworkingArchitectures. 
        For Each controlArchitectures In frmNetworkingArchitectures.Controls
            'Creates an if statement to see if there are any checkboxes on the form and to see if the checkboxes are checked on the form. 
            If TypeOf controlArchitectures Is CheckBox = True Then
                'Unchecks the checkboxes.
                controlArchitectures.Checked = False
                'Ends if statement.
            End If
            'Ends the loop. 
        Next
        'Creates a For loop with a variable called controlArchitectures2 that will loop around the form frmNetworkingArchitectures2. 
        For Each controlArchitectures2 In frmNetworkingArchitectures2.Controls
            'Creates an if statement to see if there are any checkboxes on the form and to see if the checkboxes are checked on the form. 
            If TypeOf controlArchitectures2 Is CheckBox = True Then
                'Unchecks the checkboxes.
                controlArchitectures2.Checked = False
                'Ends if statement.
            End If
            'Ends the loop.
        Next
        'Creates a For loop with a variable called controlArchitectures3 that will loop around the form frmNetworkingArchitectures3. 
        For Each controlArchitectures3 In frmNetworkingArchitectures3.Controls
            'Creates an if statement to see if there are any checkboxes on the form and to see if the checkboxes are checked on the form. 
            If TypeOf controlArchitectures3 Is CheckBox = True Then
                'Unchecks the checkboxes.
                controlArchitectures3.Checked = False
                'Ends if statement.
            End If
            'Ends the loop.
        Next
        'Creates a For loop with a variable called controlCablingAndConnectivity that will loop around the form frmNetworkingCablingAndConnectivity. 
        For Each controlCablingAndConnectivity In frmNetworkingCablingAndConnectivity.Controls
            'Creates an if statement to see if there are any checkboxes on the form and to see if the checkboxes are checked on the form. 
            If TypeOf controlCablingAndConnectivity Is CheckBox = True Then
                'Unchecks the checkboxes.
                controlCablingAndConnectivity.Checked = False
                'Ends if statement.
            End If
            'Ends the loop.
        Next
        'Creates a For loop with a variable called controlCablingAndConnectivity2 that will loop around the form frmNetworkingCablingAndConnectivity2. 
        For Each controlCablingAndConnectivity2 In frmNetworkingCablingAndConnectivity2.Controls
            'Creates an if statement to see if there are any checkboxes on the form and to see if the checkboxes are checked on the form. 
            If TypeOf controlCablingAndConnectivity2 Is CheckBox = True Then
                'Unchecks the checkboxes.
                controlCablingAndConnectivity2.Checked = False
                'Ends if statement.
            End If
            'Ends the loop.
        Next
        'Creates a For loop with a variable called controlCablingAndConnectivity3 that will loop around the form frmNetworkingCablingAndConnectivity3. 
        For Each controlCablingAndConnectivity3 In frmNetworkingCablingAndConnectivity3.Controls
            'Creates an if statement to see if there are any checkboxes on the form and to see if the checkboxes are checked on the form. 
            If TypeOf controlCablingAndConnectivity3 Is CheckBox = True Then
                'Unchecks the checkboxes.
                controlCablingAndConnectivity3.Checked = False
                'Ends if statement.
            End If
            'Ends the loop.
        Next
        'Creates a For loop with a variable called controlComponents that will loop around the form frmNetworkingComponents. 
        For Each controlComponents In frmNetworkingComponents.Controls
            'Creates an if statement to see if there are any checkboxes on the form and to see if the checkboxes are checked on the form. 
            If TypeOf controlComponents Is CheckBox = True Then
                'Unchecks the checkboxes.
                controlComponents.Checked = False
                'Ends if statement.
            End If
            'Ends the loop.
        Next
        'Creates a For loop with a variable called controlComponents2 that will loop around the form frmNetworkingComponents2. 
        For Each controlComponents2 In frmNetworkingComponents2.Controls
            'Creates an if statement to see if there are any checkboxes on the form and to see if the checkboxes are checked on the form. 
            If TypeOf controlComponents2 Is CheckBox = True Then
                'Unchecks the checkboxes.
                controlComponents2.Checked = False
                'Ends if statement.
            End If
            'Ends the loop.
        Next
        'Creates a For loop with a variable called controlComponents3 that will loop around the form frmNetworkingComponents3. 
        For Each controlComponents3 In frmNetworkingComponents3.Controls
            'Creates an if statement to see if there are any checkboxes on the form and to see if the checkboxes are checked on the form. 
            If TypeOf controlComponents3 Is CheckBox = True Then
                'Unchecks the checkboxes.
                controlComponents3.Checked = False
                'Ends if statement.
            End If
            'Ends the loop.
        Next
        'Creates a For loop with a variable called controlGeneral that will loop around the form frmNetworkingGeneral. 
        For Each controlGeneral In frmNetworkingGeneral.Controls
            'Creates an if statement to see if there are any checkboxes on the form and to see if the checkboxes are checked on the form. 
            If TypeOf controlGeneral Is CheckBox = True Then
                'Unchecks the checkboxes.
                controlGeneral.Checked = False
                'Ends if statement.
            End If
            'Ends the loop.
        Next
        'Creates a For loop with a variable called controlGeneral2 that will loop around the form frmNetworkingGeneral2. 
        For Each controlGeneral2 In frmNetworkingGeneral2.Controls
            'Creates an if statement to see if there are any checkboxes on the form and to see if the checkboxes are checked on the form. 
            If TypeOf controlGeneral2 Is CheckBox = True Then
                'Unchecks the checkboxes.
                controlGeneral2.Checked = False
                'Ends if statement.
            End If
            'Ends the loop.
        Next
        'Creates a For loop with a variable called controlGeneral3 that will loop around the form frmNetworkingGeneral3. 
        For Each controlGeneral3 In frmNetworkingGeneral3.Controls
            'Creates an if statement to see if there are any checkboxes on the form and to see if the checkboxes are checked on the form. 
            If TypeOf controlGeneral3 Is CheckBox = True Then
                'Unchecks the checkboxes.
                controlGeneral3.Checked = False
                'Ends if statement.
            End If
            'Ends the loop.
        Next

        'Creates a For loop with a variable called controlModels will loop around the form frmNetworkingModels.
        For Each controlModels In frmNetworkingModels.Controls
            'Creates an if statement to see if there are any checkboxes on the form and to see if the checkboxes are checked on the form. 
            If TypeOf controlModels Is CheckBox = True Then
                'Unchecks the checkboxes.
                controlModels.Checked = False
                'Ends if statement.
            End If
            'Ends the loop.
        Next

        'Creates a For loop with a variable called controlModels2 will loop around the form frmNetworkingModels2.
        For Each controlModels2 In frmNetworkingModels2.Controls
            'Creates an if statement to see if there are any checkboxes on the form and to see if the checkboxes are checked on the form. 
            If TypeOf controlModels2 Is CheckBox = True Then
                'Unchecks the checkboxes.
                controlModels2.Checked = False
                'Ends if statement.
            End If
            'Ends the loop.
        Next

        'Creates a For loop with a variable called controlOtherQuestions will loop around the form frmNetworkingOtherQuestions.
        For Each controlOtherQuestions In frmNetworkingOtherQuestions.Controls
            'Creates an if statement to see if there are any checkboxes on the form and to see if the checkboxes are checked on the form. 
            If TypeOf controlOtherQuestions Is CheckBox = True Then
                'Unchecks the checkboxes.
                controlOtherQuestions.Checked = False
                'Ends if statement.
            End If
            'Ends the loop.
        Next
        'Creates a For loop with a variable called controlOtherQuestions2 will loop around the form frmNetworkingOtherQuestions2.
        For Each controlOtherQuestions2 In frmNetworkingOtherQuestions2.Controls
            'Creates an if statement to see if there are any checkboxes on the form and to see if the checkboxes are checked on the form. 
            If TypeOf controlOtherQuestions2 Is CheckBox = True Then
                'Unchecks the checkboxes.
                controlOtherQuestions2.Checked = False
                'Ends if statement.
            End If
            'Ends the loop.
        Next
        'Creates a For loop with a variable called controlOtherQuestions3 will loop around the form frmNetworkingOtherQuestions3.
        For Each controlOtherQuestions3 In frmNetworkingOtherQuestions3.Controls
            'Creates an if statement to see if there are any checkboxes on the form and to see if the checkboxes are checked on the form. 
            If TypeOf controlOtherQuestions3 Is CheckBox = True Then
                'Unchecks the checkboxes.
                controlOtherQuestions3.Checked = False
                'Ends if statement.
            End If
            'Ends the loop.
        Next

        'Creates a For loop with a variable called controlProtocols will loop around the form frmNetworkingProtocols.
        For Each controlProtocols In frmNetworkingProtocols.Controls
            'Creates an if statement to see if there are any checkboxes on the form and to see if the checkboxes are checked on the form. 
            If TypeOf controlProtocols Is CheckBox = True Then
                'Unchecks the checkboxes.
                controlProtocols.Checked = False
                'Ends if statement.
            End If
            'Ends the loop.
        Next

        'Creates a For loop with a variable called controlProtocols2 will loop around the form frmNetworkingProtocols2.
        For Each controlProtocols2 In frmNetworkingProtocols2.Controls
            'Creates an if statement to see if there are any checkboxes on the form and to see if the checkboxes are checked on the form. 
            If TypeOf controlProtocols2 Is CheckBox = True Then
                'Unchecks the checkboxes.
                controlProtocols2.Checked = False
                'Ends if statement.
            End If
            'Ends the loop.
        Next

        'Creates a For loop with a variable called controlProtocols3 will loop around the form frmNetworkingProtocols3.
        For Each controlProtocols3 In frmNetworkingProtocols3.Controls
            'Creates an if statement to see if there are any checkboxes on the form and to see if the checkboxes are checked on the form. 
            If TypeOf controlProtocols3 Is CheckBox = True Then
                'Unchecks the checkboxes.
                controlProtocols3.Checked = False
                'Ends if statement.
            End If
            'Ends the loop.
        Next

        'Creates a For loop with a variable called controlTechnologies will loop around the form frmNetworkingTechnologies.
        For Each controlTechnologies In frmNetworkingTechnologies.Controls
            'Creates an if statement to see if there are any checkboxes on the form and to see if the checkboxes are checked on the form. 
            If TypeOf controlTechnologies Is CheckBox = True Then
                'Unchecks the checkboxes.
                controlTechnologies.Checked = False
                'Ends if statement.
            End If
            'Ends the loop.
        Next

        'Creates a For loop with a variable called controlTechnologies2 will loop around the form frmNetworkingTechnologies2.
        For Each controlTechnologies2 In frmNetworkingTechnologies2.Controls
            'Creates an if statement to see if there are any checkboxes on the form and to see if the checkboxes are checked on the form. 
            If TypeOf controlTechnologies2 Is CheckBox = True Then
                'Unchecks the checkboxes.
                controlTechnologies2.Checked = False
                'Ends if statement.
            End If
            'Ends the loop.
        Next

        'Creates a For loop with a variable called controlTechnologies3 will loop around the form frmNetworkingTechnologies3.
        For Each controlTechnologies3 In frmNetworkingTechnologies3.Controls
            'Creates an if statement to see if there are any checkboxes on the form and to see if the checkboxes are checked on the form. 
            If TypeOf controlTechnologies3 Is CheckBox = True Then
                'Unchecks the checkboxes.
                controlTechnologies3.Checked = False
                'Ends if statement.
            End If
            'Ends the loop.
        Next

        'Creates a For loop with a variable called controlTopologys that will loop around the form frmNetworkingTopologys. 
        For Each controlTopologys In frmNetworkingTopologys.Controls
            'Creates an if statement to see if there are any checkboxes on the form and to see if the checkboxes are checked on the form. 
            If TypeOf controlTopologys Is CheckBox = True Then
                'Unchecks the checkboxes.
                controlTopologys.Checked = False
                'Ends if statement.
            End If
            'Ends the loop.
        Next
        'Creates a For loop with a variable called controlTopologys2 that will loop around the form frmNetworkingTopologys2. 
        For Each controlTopologys2 In frmNetworkingTopologys2.Controls
            'Creates an if statement to see if there are any checkboxes on the form and to see if the checkboxes are checked on the form. 
            If TypeOf controlTopologys2 Is CheckBox = True Then
                'Unchecks the checkboxes.
                controlTopologys2.Checked = False
                'Ends if statement.
            End If
            'Ends the loop.
        Next
        'Creates a For loop with a variable called controlTopologys3 that will loop around the form frmNetworkingTopologys3. 
        For Each controlTopologys3 In frmNetworkingTopologys3.Controls
            'Creates an if statement to see if there are any checkboxes on the form and to see if the checkboxes are checked on the form. 
            If TypeOf controlTopologys3 Is CheckBox = True Then
                'Unchecks the checkboxes.
                controlTopologys3.Checked = False
                'Ends if statement.
            End If
            'Ends the loop.
        Next

        'Creates a For loop with a variable called controlTypes that will loop around the form frmNetworkingTypes. 
        For Each controlTypes In frmNetworkingTypes.Controls
            'Creates an if statement to see if there are any checkboxes on the form and to see if the checkboxes are checked on the form. 
            If TypeOf controlTypes Is CheckBox = True Then
                'Unchecks the checkboxes.
                controlTypes.Checked = False
                'Ends if statement.
            End If
            'Ends the loop.
        Next

        'Creates a For loop with a variable called controlTypes2 that will loop around the form frmNetworkingTypes2. 
        For Each controlTypes2 In frmNetworkingTypes2.Controls
            'Creates an if statement to see if there are any checkboxes on the form and to see if the checkboxes are checked on the form. 
            If TypeOf controlTypes2 Is CheckBox = True Then
                'Unchecks the checkboxes.
                controlTypes2.Checked = False
                'Ends if statement.
            End If
            'Ends the loop.
        Next

        'Creates a For loop with a variable called controlTypes3 that will loop around the form frmNetworkingTypes3. 
        For Each controlTypes3 In frmNetworkingTypes3.Controls
            'Creates an if statement to see if there are any checkboxes on the form and to see if the checkboxes are checked on the form. 
            If TypeOf controlTypes3 Is CheckBox = True Then
                'Unchecks the checkboxes.
                controlTypes3.Checked = False
                'Ends if statement.
            End If
            'Ends the loop.
        Next

    End Sub
End Module
