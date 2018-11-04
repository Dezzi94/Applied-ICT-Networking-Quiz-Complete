Public Class frmMainMenu

    Private Sub btnGoToComponents_Click(sender As Object, e As EventArgs) Handles btnGoToComponents.Click
        'Hides the current form.
        Me.Hide()
        'Shows the form frmNetworkingComponents.
        frmNetworkingComponents.Show()
    End Sub

    Private Sub btnGoToTopology_Click(sender As Object, e As EventArgs) Handles btnGoToTopology.Click
        'Hides the current form.
        Me.Hide()
        'Shows the form frmNetworkingTopologys.
        frmNetworkingTopologys.Show()
    End Sub

    Private Sub btnGoToNetworkTypes_Click(sender As Object, e As EventArgs) Handles btnGoToNetworkTypes.Click
        'Hides current form.
        Me.Hide()
        'Shows the form frmNetworkingTypes.
        frmNetworkingTypes.Show()
    End Sub

    Private Sub btnGoToGeneralNetworkQuestions_Click(sender As Object, e As EventArgs) Handles btnGoToGeneralNetworkQuestions.Click
        'Hides current form.
        Me.Hide()
        'Shows the form frmNetworkingGeneral.
        frmNetworkingGeneral.Show()
    End Sub

    Private Sub btnGoToNetworkArchitectures_Click(sender As Object, e As EventArgs) Handles btnGoToNetworkArchitectures.Click
        'Hides current form.
        Me.Hide()
        'Shows the form frmNetworkingArchitectures.
        frmNetworkingArchitectures.Show()
    End Sub

    Private Sub btnGoToNetworkTechnologies_Click(sender As Object, e As EventArgs) Handles btnGoToNetworkTechnologies.Click
        'Hides current form.
        Me.Hide()
        'Shows the form frmNetworkingTechnologies.
        frmNetworkingTechnologies.Show()
    End Sub

    Private Sub btnGoToCablingAndConnectivity_Click(sender As Object, e As EventArgs) Handles btnGoToCablingAndConnectivity.Click
        'Hides current form.
        Me.Hide()
        'Shows the form frmNetworkingCablingAndConnectivity.
        frmNetworkingCablingAndConnectivity.Show()
    End Sub

    Private Sub btnGoToNetworkinProtocols_Click(sender As Object, e As EventArgs) Handles btnGoToNetworkinProtocols.Click
        'Hides current form.
        Me.Hide()
        'Shows the form frmNetworkingProtocols.
        frmNetworkingProtocols.Show()
    End Sub

    Private Sub btnGoToNetworkingModels_Click(sender As Object, e As EventArgs) Handles btnGoToNetworkingModels.Click
        'Hides current form.
        Me.Hide()
        'Shows the form frmNetworkingModels.
        frmNetworkingModels.Show()
    End Sub

    Private Sub btnGoToOtherNetworkingQuestions_Click(sender As Object, e As EventArgs) Handles btnGoToOtherNetworkingQuestions.Click
        'Hides current form.
        Me.Hide()
        'Shows the form frmNetworkingOtherQuestions.
        frmNetworkingOtherQuestions.Show()
    End Sub
End Class
