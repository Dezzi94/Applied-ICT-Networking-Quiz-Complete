<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResultsCablingAndConnectivity
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
        Me.lblNetworkingCablingAndConnectivityTitleScore = New System.Windows.Forms.Label()
        Me.btnSubmitScoreNCablingAndConnectivity = New System.Windows.Forms.Button()
        Me.lblShowScoreNCablingAndConnectivity = New System.Windows.Forms.Label()
        Me.lblInstructionsCablingAndConnectivity = New System.Windows.Forms.Label()
        Me.btnBackfrmResultsCablingAndConnectivity = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNetworkingCablingAndConnectivityTitleScore
        '
        Me.lblNetworkingCablingAndConnectivityTitleScore.BackColor = System.Drawing.SystemColors.Highlight
        Me.lblNetworkingCablingAndConnectivityTitleScore.Font = New System.Drawing.Font("Modern No. 20", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetworkingCablingAndConnectivityTitleScore.Location = New System.Drawing.Point(174, 24)
        Me.lblNetworkingCablingAndConnectivityTitleScore.Name = "lblNetworkingCablingAndConnectivityTitleScore"
        Me.lblNetworkingCablingAndConnectivityTitleScore.Size = New System.Drawing.Size(422, 46)
        Me.lblNetworkingCablingAndConnectivityTitleScore.TabIndex = 35
        Me.lblNetworkingCablingAndConnectivityTitleScore.Text = "Networking Architectures Score"
        Me.lblNetworkingCablingAndConnectivityTitleScore.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnSubmitScoreNCablingAndConnectivity
        '
        Me.btnSubmitScoreNCablingAndConnectivity.Location = New System.Drawing.Point(216, 146)
        Me.btnSubmitScoreNCablingAndConnectivity.Name = "btnSubmitScoreNCablingAndConnectivity"
        Me.btnSubmitScoreNCablingAndConnectivity.Size = New System.Drawing.Size(235, 48)
        Me.btnSubmitScoreNCablingAndConnectivity.TabIndex = 36
        Me.btnSubmitScoreNCablingAndConnectivity.Text = "Submit Score"
        Me.btnSubmitScoreNCablingAndConnectivity.UseVisualStyleBackColor = True
        '
        'lblShowScoreNCablingAndConnectivity
        '
        Me.lblShowScoreNCablingAndConnectivity.Font = New System.Drawing.Font("Modern No. 20", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowScoreNCablingAndConnectivity.Location = New System.Drawing.Point(76, 239)
        Me.lblShowScoreNCablingAndConnectivity.Name = "lblShowScoreNCablingAndConnectivity"
        Me.lblShowScoreNCablingAndConnectivity.Size = New System.Drawing.Size(497, 102)
        Me.lblShowScoreNCablingAndConnectivity.TabIndex = 37
        '
        'lblInstructionsCablingAndConnectivity
        '
        Me.lblInstructionsCablingAndConnectivity.Font = New System.Drawing.Font("Cambria", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructionsCablingAndConnectivity.Location = New System.Drawing.Point(28, 384)
        Me.lblInstructionsCablingAndConnectivity.Name = "lblInstructionsCablingAndConnectivity"
        Me.lblInstructionsCablingAndConnectivity.Size = New System.Drawing.Size(614, 61)
        Me.lblInstructionsCablingAndConnectivity.TabIndex = 38
        Me.lblInstructionsCablingAndConnectivity.Text = "Click the button above to view your score. Keep trying until you get full marks!!" & _
    "!"
        '
        'btnBackfrmResultsCablingAndConnectivity
        '
        Me.btnBackfrmResultsCablingAndConnectivity.BackColor = System.Drawing.Color.Crimson
        Me.btnBackfrmResultsCablingAndConnectivity.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackfrmResultsCablingAndConnectivity.Location = New System.Drawing.Point(12, 16)
        Me.btnBackfrmResultsCablingAndConnectivity.Name = "btnBackfrmResultsCablingAndConnectivity"
        Me.btnBackfrmResultsCablingAndConnectivity.Size = New System.Drawing.Size(145, 54)
        Me.btnBackfrmResultsCablingAndConnectivity.TabIndex = 45
        Me.btnBackfrmResultsCablingAndConnectivity.Text = "Back To Main Menu"
        Me.btnBackfrmResultsCablingAndConnectivity.UseVisualStyleBackColor = False
        '
        'frmResultsCablingAndConnectivity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(667, 593)
        Me.Controls.Add(Me.btnBackfrmResultsCablingAndConnectivity)
        Me.Controls.Add(Me.lblInstructionsCablingAndConnectivity)
        Me.Controls.Add(Me.lblShowScoreNCablingAndConnectivity)
        Me.Controls.Add(Me.btnSubmitScoreNCablingAndConnectivity)
        Me.Controls.Add(Me.lblNetworkingCablingAndConnectivityTitleScore)
        Me.Name = "frmResultsCablingAndConnectivity"
        Me.Text = "Results Types"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblNetworkingCablingAndConnectivityTitleScore As System.Windows.Forms.Label
    Friend WithEvents btnSubmitScoreNCablingAndConnectivity As System.Windows.Forms.Button
    Friend WithEvents lblShowScoreNCablingAndConnectivity As System.Windows.Forms.Label
    Friend WithEvents lblInstructionsCablingAndConnectivity As System.Windows.Forms.Label
    Friend WithEvents btnBackfrmResultsCablingAndConnectivity As System.Windows.Forms.Button
End Class
