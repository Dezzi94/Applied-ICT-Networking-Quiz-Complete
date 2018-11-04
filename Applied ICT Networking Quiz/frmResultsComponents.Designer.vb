<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResultsComponents
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
        Me.lblNetworkingComponentsTitleScore = New System.Windows.Forms.Label()
        Me.btnSubmitScoreNComponents = New System.Windows.Forms.Button()
        Me.lblShowScoreNComponents = New System.Windows.Forms.Label()
        Me.lblInstructionsComponents = New System.Windows.Forms.Label()
        Me.btnBackfrmResultsComponents = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNetworkingComponentsTitleScore
        '
        Me.lblNetworkingComponentsTitleScore.BackColor = System.Drawing.SystemColors.Highlight
        Me.lblNetworkingComponentsTitleScore.Font = New System.Drawing.Font("Modern No. 20", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetworkingComponentsTitleScore.Location = New System.Drawing.Point(163, 24)
        Me.lblNetworkingComponentsTitleScore.Name = "lblNetworkingComponentsTitleScore"
        Me.lblNetworkingComponentsTitleScore.Size = New System.Drawing.Size(422, 46)
        Me.lblNetworkingComponentsTitleScore.TabIndex = 35
        Me.lblNetworkingComponentsTitleScore.Text = "Networking Components Score"
        Me.lblNetworkingComponentsTitleScore.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnSubmitScoreNComponents
        '
        Me.btnSubmitScoreNComponents.Location = New System.Drawing.Point(216, 146)
        Me.btnSubmitScoreNComponents.Name = "btnSubmitScoreNComponents"
        Me.btnSubmitScoreNComponents.Size = New System.Drawing.Size(235, 48)
        Me.btnSubmitScoreNComponents.TabIndex = 36
        Me.btnSubmitScoreNComponents.Text = "Submit Score"
        Me.btnSubmitScoreNComponents.UseVisualStyleBackColor = True
        '
        'lblShowScoreNComponents
        '
        Me.lblShowScoreNComponents.Font = New System.Drawing.Font("Modern No. 20", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowScoreNComponents.Location = New System.Drawing.Point(131, 242)
        Me.lblShowScoreNComponents.Name = "lblShowScoreNComponents"
        Me.lblShowScoreNComponents.Size = New System.Drawing.Size(497, 102)
        Me.lblShowScoreNComponents.TabIndex = 37
        '
        'lblInstructionsComponents
        '
        Me.lblInstructionsComponents.Font = New System.Drawing.Font("Cambria", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructionsComponents.Location = New System.Drawing.Point(28, 384)
        Me.lblInstructionsComponents.Name = "lblInstructionsComponents"
        Me.lblInstructionsComponents.Size = New System.Drawing.Size(614, 61)
        Me.lblInstructionsComponents.TabIndex = 38
        Me.lblInstructionsComponents.Text = "Click the button above to view your score. Keep trying until you get full marks!!" & _
    "!"
        '
        'btnBackfrmResultsComponents
        '
        Me.btnBackfrmResultsComponents.BackColor = System.Drawing.Color.Crimson
        Me.btnBackfrmResultsComponents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnBackfrmResultsComponents.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackfrmResultsComponents.Location = New System.Drawing.Point(12, 24)
        Me.btnBackfrmResultsComponents.Name = "btnBackfrmResultsComponents"
        Me.btnBackfrmResultsComponents.Size = New System.Drawing.Size(145, 54)
        Me.btnBackfrmResultsComponents.TabIndex = 46
        Me.btnBackfrmResultsComponents.Text = "Back To Main Menu"
        Me.btnBackfrmResultsComponents.UseVisualStyleBackColor = False
        '
        'frmResultsComponents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(667, 593)
        Me.Controls.Add(Me.btnBackfrmResultsComponents)
        Me.Controls.Add(Me.lblInstructionsComponents)
        Me.Controls.Add(Me.lblShowScoreNComponents)
        Me.Controls.Add(Me.btnSubmitScoreNComponents)
        Me.Controls.Add(Me.lblNetworkingComponentsTitleScore)
        Me.Name = "frmResultsComponents"
        Me.Text = "ResultsComponents"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblNetworkingComponentsTitleScore As System.Windows.Forms.Label
    Friend WithEvents btnSubmitScoreNComponents As System.Windows.Forms.Button
    Friend WithEvents lblShowScoreNComponents As System.Windows.Forms.Label
    Friend WithEvents lblInstructionsComponents As System.Windows.Forms.Label
    Friend WithEvents btnBackfrmResultsComponents As System.Windows.Forms.Button
End Class
