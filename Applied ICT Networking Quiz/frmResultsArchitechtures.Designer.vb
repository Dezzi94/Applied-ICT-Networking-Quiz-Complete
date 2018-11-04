<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResultsArchitectures
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
        Me.lblNetworkingArchitecturesTitleScore = New System.Windows.Forms.Label()
        Me.btnSubmitScoreNArchitectures = New System.Windows.Forms.Button()
        Me.lblShowScoreNArchitectures = New System.Windows.Forms.Label()
        Me.lblInstructionsArchitectures = New System.Windows.Forms.Label()
        Me.btnBackfrmResultsArchitectures = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNetworkingArchitecturesTitleScore
        '
        Me.lblNetworkingArchitecturesTitleScore.BackColor = System.Drawing.SystemColors.Highlight
        Me.lblNetworkingArchitecturesTitleScore.Font = New System.Drawing.Font("Modern No. 20", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetworkingArchitecturesTitleScore.Location = New System.Drawing.Point(174, 24)
        Me.lblNetworkingArchitecturesTitleScore.Name = "lblNetworkingArchitecturesTitleScore"
        Me.lblNetworkingArchitecturesTitleScore.Size = New System.Drawing.Size(422, 46)
        Me.lblNetworkingArchitecturesTitleScore.TabIndex = 35
        Me.lblNetworkingArchitecturesTitleScore.Text = "Networking Architectures Score"
        Me.lblNetworkingArchitecturesTitleScore.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnSubmitScoreNArchitectures
        '
        Me.btnSubmitScoreNArchitectures.Location = New System.Drawing.Point(216, 146)
        Me.btnSubmitScoreNArchitectures.Name = "btnSubmitScoreNArchitectures"
        Me.btnSubmitScoreNArchitectures.Size = New System.Drawing.Size(235, 48)
        Me.btnSubmitScoreNArchitectures.TabIndex = 36
        Me.btnSubmitScoreNArchitectures.Text = "Submit Score"
        Me.btnSubmitScoreNArchitectures.UseVisualStyleBackColor = True
        '
        'lblShowScoreNArchitectures
        '
        Me.lblShowScoreNArchitectures.Font = New System.Drawing.Font("Modern No. 20", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowScoreNArchitectures.Location = New System.Drawing.Point(76, 239)
        Me.lblShowScoreNArchitectures.Name = "lblShowScoreNArchitectures"
        Me.lblShowScoreNArchitectures.Size = New System.Drawing.Size(497, 102)
        Me.lblShowScoreNArchitectures.TabIndex = 37
        '
        'lblInstructionsArchitectures
        '
        Me.lblInstructionsArchitectures.Font = New System.Drawing.Font("Cambria", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructionsArchitectures.Location = New System.Drawing.Point(28, 384)
        Me.lblInstructionsArchitectures.Name = "lblInstructionsArchitectures"
        Me.lblInstructionsArchitectures.Size = New System.Drawing.Size(614, 61)
        Me.lblInstructionsArchitectures.TabIndex = 38
        Me.lblInstructionsArchitectures.Text = "Click the button above to view your score. Keep trying until you get full marks!!" & _
    "!"
        '
        'btnBackfrmResultsArchitectures
        '
        Me.btnBackfrmResultsArchitectures.BackColor = System.Drawing.Color.Crimson
        Me.btnBackfrmResultsArchitectures.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackfrmResultsArchitectures.Location = New System.Drawing.Point(12, 16)
        Me.btnBackfrmResultsArchitectures.Name = "btnBackfrmResultsArchitectures"
        Me.btnBackfrmResultsArchitectures.Size = New System.Drawing.Size(145, 54)
        Me.btnBackfrmResultsArchitectures.TabIndex = 45
        Me.btnBackfrmResultsArchitectures.Text = "Back To Main Menu"
        Me.btnBackfrmResultsArchitectures.UseVisualStyleBackColor = False
        '
        'frmResultsArchitectures
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(667, 593)
        Me.Controls.Add(Me.btnBackfrmResultsArchitectures)
        Me.Controls.Add(Me.lblInstructionsArchitectures)
        Me.Controls.Add(Me.lblShowScoreNArchitectures)
        Me.Controls.Add(Me.btnSubmitScoreNArchitectures)
        Me.Controls.Add(Me.lblNetworkingArchitecturesTitleScore)
        Me.Name = "frmResultsArchitectures"
        Me.Text = "Results Types"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblNetworkingArchitecturesTitleScore As System.Windows.Forms.Label
    Friend WithEvents btnSubmitScoreNArchitectures As System.Windows.Forms.Button
    Friend WithEvents lblShowScoreNArchitectures As System.Windows.Forms.Label
    Friend WithEvents lblInstructionsArchitectures As System.Windows.Forms.Label
    Friend WithEvents btnBackfrmResultsArchitectures As System.Windows.Forms.Button
End Class
