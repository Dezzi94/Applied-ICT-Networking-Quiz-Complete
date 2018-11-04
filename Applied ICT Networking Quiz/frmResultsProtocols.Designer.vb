<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResultsProtocols
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
        Me.lblNetworkingProtocolsTitleScore = New System.Windows.Forms.Label()
        Me.btnSubmitScoreNProtocols = New System.Windows.Forms.Button()
        Me.lblShowScoreNProtocols = New System.Windows.Forms.Label()
        Me.lblInstructionsProtocols = New System.Windows.Forms.Label()
        Me.btnBackfrmResultsProtocols = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNetworkingProtocolsTitleScore
        '
        Me.lblNetworkingProtocolsTitleScore.BackColor = System.Drawing.SystemColors.Highlight
        Me.lblNetworkingProtocolsTitleScore.Font = New System.Drawing.Font("Modern No. 20", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetworkingProtocolsTitleScore.Location = New System.Drawing.Point(174, 24)
        Me.lblNetworkingProtocolsTitleScore.Name = "lblNetworkingProtocolsTitleScore"
        Me.lblNetworkingProtocolsTitleScore.Size = New System.Drawing.Size(422, 46)
        Me.lblNetworkingProtocolsTitleScore.TabIndex = 35
        Me.lblNetworkingProtocolsTitleScore.Text = "Networking Protocols Score"
        Me.lblNetworkingProtocolsTitleScore.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnSubmitScoreNProtocols
        '
        Me.btnSubmitScoreNProtocols.Location = New System.Drawing.Point(216, 146)
        Me.btnSubmitScoreNProtocols.Name = "btnSubmitScoreNProtocols"
        Me.btnSubmitScoreNProtocols.Size = New System.Drawing.Size(235, 48)
        Me.btnSubmitScoreNProtocols.TabIndex = 36
        Me.btnSubmitScoreNProtocols.Text = "Submit Score"
        Me.btnSubmitScoreNProtocols.UseVisualStyleBackColor = True
        '
        'lblShowScoreNProtocols
        '
        Me.lblShowScoreNProtocols.Font = New System.Drawing.Font("Modern No. 20", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowScoreNProtocols.Location = New System.Drawing.Point(76, 239)
        Me.lblShowScoreNProtocols.Name = "lblShowScoreNProtocols"
        Me.lblShowScoreNProtocols.Size = New System.Drawing.Size(497, 102)
        Me.lblShowScoreNProtocols.TabIndex = 37
        '
        'lblInstructionsProtocols
        '
        Me.lblInstructionsProtocols.Font = New System.Drawing.Font("Cambria", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructionsProtocols.Location = New System.Drawing.Point(28, 384)
        Me.lblInstructionsProtocols.Name = "lblInstructionsProtocols"
        Me.lblInstructionsProtocols.Size = New System.Drawing.Size(614, 61)
        Me.lblInstructionsProtocols.TabIndex = 38
        Me.lblInstructionsProtocols.Text = "Click the button above to view your score. Keep trying until you get full marks!!" & _
    "!"
        '
        'btnBackfrmResultsProtocols
        '
        Me.btnBackfrmResultsProtocols.BackColor = System.Drawing.Color.Crimson
        Me.btnBackfrmResultsProtocols.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackfrmResultsProtocols.Location = New System.Drawing.Point(12, 16)
        Me.btnBackfrmResultsProtocols.Name = "btnBackfrmResultsProtocols"
        Me.btnBackfrmResultsProtocols.Size = New System.Drawing.Size(145, 54)
        Me.btnBackfrmResultsProtocols.TabIndex = 45
        Me.btnBackfrmResultsProtocols.Text = "Back To Main Menu"
        Me.btnBackfrmResultsProtocols.UseVisualStyleBackColor = False
        '
        'frmResultsProtocols
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(667, 593)
        Me.Controls.Add(Me.btnBackfrmResultsProtocols)
        Me.Controls.Add(Me.lblInstructionsProtocols)
        Me.Controls.Add(Me.lblShowScoreNProtocols)
        Me.Controls.Add(Me.btnSubmitScoreNProtocols)
        Me.Controls.Add(Me.lblNetworkingProtocolsTitleScore)
        Me.Name = "frmResultsProtocols"
        Me.Text = "Results Types"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblNetworkingProtocolsTitleScore As System.Windows.Forms.Label
    Friend WithEvents btnSubmitScoreNProtocols As System.Windows.Forms.Button
    Friend WithEvents lblShowScoreNProtocols As System.Windows.Forms.Label
    Friend WithEvents lblInstructionsProtocols As System.Windows.Forms.Label
    Friend WithEvents btnBackfrmResultsProtocols As System.Windows.Forms.Button
End Class
