<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResultsTopologys
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
        Me.lblNetworkingTopologyTitleScore = New System.Windows.Forms.Label()
        Me.btnSubmitScoreNT = New System.Windows.Forms.Button()
        Me.lblShowScoreNT = New System.Windows.Forms.Label()
        Me.lblInstructionsTopology = New System.Windows.Forms.Label()
        Me.btnBackfrmResultsTopology = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNetworkingTopologyTitleScore
        '
        Me.lblNetworkingTopologyTitleScore.BackColor = System.Drawing.SystemColors.Highlight
        Me.lblNetworkingTopologyTitleScore.Font = New System.Drawing.Font("Modern No. 20", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetworkingTopologyTitleScore.Location = New System.Drawing.Point(135, 24)
        Me.lblNetworkingTopologyTitleScore.Name = "lblNetworkingTopologyTitleScore"
        Me.lblNetworkingTopologyTitleScore.Size = New System.Drawing.Size(422, 46)
        Me.lblNetworkingTopologyTitleScore.TabIndex = 35
        Me.lblNetworkingTopologyTitleScore.Text = "Networking Topology Score"
        Me.lblNetworkingTopologyTitleScore.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnSubmitScoreNT
        '
        Me.btnSubmitScoreNT.Location = New System.Drawing.Point(216, 146)
        Me.btnSubmitScoreNT.Name = "btnSubmitScoreNT"
        Me.btnSubmitScoreNT.Size = New System.Drawing.Size(235, 48)
        Me.btnSubmitScoreNT.TabIndex = 36
        Me.btnSubmitScoreNT.Text = "Submit Score"
        Me.btnSubmitScoreNT.UseVisualStyleBackColor = True
        '
        'lblShowScoreNT
        '
        Me.lblShowScoreNT.Font = New System.Drawing.Font("Modern No. 20", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowScoreNT.Location = New System.Drawing.Point(76, 239)
        Me.lblShowScoreNT.Name = "lblShowScoreNT"
        Me.lblShowScoreNT.Size = New System.Drawing.Size(497, 102)
        Me.lblShowScoreNT.TabIndex = 37
        '
        'lblInstructionsTopology
        '
        Me.lblInstructionsTopology.Font = New System.Drawing.Font("Cambria", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructionsTopology.Location = New System.Drawing.Point(28, 384)
        Me.lblInstructionsTopology.Name = "lblInstructionsTopology"
        Me.lblInstructionsTopology.Size = New System.Drawing.Size(614, 61)
        Me.lblInstructionsTopology.TabIndex = 38
        Me.lblInstructionsTopology.Text = "Click the button above to view your score. Keep trying until you get full marks!!" & _
    "!"
        '
        'btnBackfrmResultsTopology
        '
        Me.btnBackfrmResultsTopology.BackColor = System.Drawing.Color.Crimson
        Me.btnBackfrmResultsTopology.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackfrmResultsTopology.Location = New System.Drawing.Point(12, 24)
        Me.btnBackfrmResultsTopology.Name = "btnBackfrmResultsTopology"
        Me.btnBackfrmResultsTopology.Size = New System.Drawing.Size(145, 54)
        Me.btnBackfrmResultsTopology.TabIndex = 46
        Me.btnBackfrmResultsTopology.Text = "Back To Main Menu"
        Me.btnBackfrmResultsTopology.UseVisualStyleBackColor = False
        '
        'frmResultsTopologys
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(667, 593)
        Me.Controls.Add(Me.btnBackfrmResultsTopology)
        Me.Controls.Add(Me.lblInstructionsTopology)
        Me.Controls.Add(Me.lblShowScoreNT)
        Me.Controls.Add(Me.btnSubmitScoreNT)
        Me.Controls.Add(Me.lblNetworkingTopologyTitleScore)
        Me.Name = "frmResultsTopologys"
        Me.Text = "Results Topology"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblNetworkingTopologyTitleScore As System.Windows.Forms.Label
    Friend WithEvents btnSubmitScoreNT As System.Windows.Forms.Button
    Friend WithEvents lblShowScoreNT As System.Windows.Forms.Label
    Friend WithEvents lblInstructionsTopology As System.Windows.Forms.Label
    Friend WithEvents btnBackfrmResultsTopology As System.Windows.Forms.Button
End Class
