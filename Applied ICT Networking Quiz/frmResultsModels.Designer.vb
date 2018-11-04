<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResultsModels
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblNetworkingModelsTitleScore = New System.Windows.Forms.Label()
        Me.btnSubmitScoreNModels = New System.Windows.Forms.Button()
        Me.lblShowScoreNModels = New System.Windows.Forms.Label()
        Me.lblInstructionsModels = New System.Windows.Forms.Label()
        Me.btnBackfrmResultsModels = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNetworkingModelsTitleScore
        '
        Me.lblNetworkingModelsTitleScore.BackColor = System.Drawing.SystemColors.Highlight
        Me.lblNetworkingModelsTitleScore.Font = New System.Drawing.Font("Modern No. 20", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetworkingModelsTitleScore.Location = New System.Drawing.Point(174, 24)
        Me.lblNetworkingModelsTitleScore.Name = "lblNetworkingModelsTitleScore"
        Me.lblNetworkingModelsTitleScore.Size = New System.Drawing.Size(422, 46)
        Me.lblNetworkingModelsTitleScore.TabIndex = 35
        Me.lblNetworkingModelsTitleScore.Text = "Networking Models Score"
        Me.lblNetworkingModelsTitleScore.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnSubmitScoreNModels
        '
        Me.btnSubmitScoreNModels.Location = New System.Drawing.Point(216, 146)
        Me.btnSubmitScoreNModels.Name = "btnSubmitScoreNModels"
        Me.btnSubmitScoreNModels.Size = New System.Drawing.Size(235, 48)
        Me.btnSubmitScoreNModels.TabIndex = 36
        Me.btnSubmitScoreNModels.Text = "Submit Score"
        Me.btnSubmitScoreNModels.UseVisualStyleBackColor = True
        '
        'lblShowScoreNModels
        '
        Me.lblShowScoreNModels.Font = New System.Drawing.Font("Modern No. 20", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowScoreNModels.Location = New System.Drawing.Point(76, 239)
        Me.lblShowScoreNModels.Name = "lblShowScoreNModels"
        Me.lblShowScoreNModels.Size = New System.Drawing.Size(497, 102)
        Me.lblShowScoreNModels.TabIndex = 37
        '
        'lblInstructionsModels
        '
        Me.lblInstructionsModels.Font = New System.Drawing.Font("Cambria", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructionsModels.Location = New System.Drawing.Point(28, 384)
        Me.lblInstructionsModels.Name = "lblInstructionsModels"
        Me.lblInstructionsModels.Size = New System.Drawing.Size(614, 61)
        Me.lblInstructionsModels.TabIndex = 38
        Me.lblInstructionsModels.Text = "Click the button above to view your score. Keep trying until you get full marks!!" & _
    "!"
        '
        'btnBackfrmResultsModels
        '
        Me.btnBackfrmResultsModels.BackColor = System.Drawing.Color.Crimson
        Me.btnBackfrmResultsModels.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackfrmResultsModels.Location = New System.Drawing.Point(12, 16)
        Me.btnBackfrmResultsModels.Name = "btnBackfrmResultsModels"
        Me.btnBackfrmResultsModels.Size = New System.Drawing.Size(145, 54)
        Me.btnBackfrmResultsModels.TabIndex = 45
        Me.btnBackfrmResultsModels.Text = "Back To Main Menu"
        Me.btnBackfrmResultsModels.UseVisualStyleBackColor = False
        '
        'frmResultsModels
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(667, 593)
        Me.Controls.Add(Me.btnBackfrmResultsModels)
        Me.Controls.Add(Me.lblInstructionsModels)
        Me.Controls.Add(Me.lblShowScoreNModels)
        Me.Controls.Add(Me.btnSubmitScoreNModels)
        Me.Controls.Add(Me.lblNetworkingModelsTitleScore)
        Me.Name = "frmResultsModels"
        Me.Text = "Results Models"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblNetworkingModelsTitleScore As System.Windows.Forms.Label
    Friend WithEvents btnSubmitScoreNModels As System.Windows.Forms.Button
    Friend WithEvents lblShowScoreNModels As System.Windows.Forms.Label
    Friend WithEvents lblInstructionsModels As System.Windows.Forms.Label
    Friend WithEvents btnBackfrmResultsModels As System.Windows.Forms.Button
End Class
