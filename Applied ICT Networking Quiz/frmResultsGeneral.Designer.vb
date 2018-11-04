<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResultsGeneral
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
        Me.lblNetworkingGeneralTitleScore = New System.Windows.Forms.Label()
        Me.btnSubmitScoreNGeneral = New System.Windows.Forms.Button()
        Me.lblShowScoreNGeneral = New System.Windows.Forms.Label()
        Me.lblInstructionsGeneral = New System.Windows.Forms.Label()
        Me.btnBackfrmResultsGeneral = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNetworkingGeneralTitleScore
        '
        Me.lblNetworkingGeneralTitleScore.BackColor = System.Drawing.SystemColors.Highlight
        Me.lblNetworkingGeneralTitleScore.Font = New System.Drawing.Font("Modern No. 20", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetworkingGeneralTitleScore.Location = New System.Drawing.Point(135, 24)
        Me.lblNetworkingGeneralTitleScore.Name = "lblNetworkingGeneralTitleScore"
        Me.lblNetworkingGeneralTitleScore.Size = New System.Drawing.Size(422, 46)
        Me.lblNetworkingGeneralTitleScore.TabIndex = 35
        Me.lblNetworkingGeneralTitleScore.Text = "Networking General Score"
        Me.lblNetworkingGeneralTitleScore.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnSubmitScoreNGeneral
        '
        Me.btnSubmitScoreNGeneral.Location = New System.Drawing.Point(216, 146)
        Me.btnSubmitScoreNGeneral.Name = "btnSubmitScoreNGeneral"
        Me.btnSubmitScoreNGeneral.Size = New System.Drawing.Size(235, 48)
        Me.btnSubmitScoreNGeneral.TabIndex = 36
        Me.btnSubmitScoreNGeneral.Text = "Submit Score"
        Me.btnSubmitScoreNGeneral.UseVisualStyleBackColor = True
        '
        'lblShowScoreNGeneral
        '
        Me.lblShowScoreNGeneral.Font = New System.Drawing.Font("Modern No. 20", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowScoreNGeneral.Location = New System.Drawing.Point(76, 239)
        Me.lblShowScoreNGeneral.Name = "lblShowScoreNGeneral"
        Me.lblShowScoreNGeneral.Size = New System.Drawing.Size(497, 102)
        Me.lblShowScoreNGeneral.TabIndex = 37
        '
        'lblInstructionsGeneral
        '
        Me.lblInstructionsGeneral.Font = New System.Drawing.Font("Cambria", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructionsGeneral.Location = New System.Drawing.Point(28, 384)
        Me.lblInstructionsGeneral.Name = "lblInstructionsGeneral"
        Me.lblInstructionsGeneral.Size = New System.Drawing.Size(614, 61)
        Me.lblInstructionsGeneral.TabIndex = 38
        Me.lblInstructionsGeneral.Text = "Click the button above to view your score. Keep trying until you get full marks!!" & _
    "!"
        '
        'btnBackfrmResultsGeneral
        '
        Me.btnBackfrmResultsGeneral.BackColor = System.Drawing.Color.Crimson
        Me.btnBackfrmResultsGeneral.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackfrmResultsGeneral.Location = New System.Drawing.Point(12, 13)
        Me.btnBackfrmResultsGeneral.Name = "btnBackfrmResultsGeneral"
        Me.btnBackfrmResultsGeneral.Size = New System.Drawing.Size(145, 54)
        Me.btnBackfrmResultsGeneral.TabIndex = 46
        Me.btnBackfrmResultsGeneral.Text = "Back To Main Menu"
        Me.btnBackfrmResultsGeneral.UseVisualStyleBackColor = False
        '
        'frmResultsGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(667, 593)
        Me.Controls.Add(Me.btnBackfrmResultsGeneral)
        Me.Controls.Add(Me.lblInstructionsGeneral)
        Me.Controls.Add(Me.lblShowScoreNGeneral)
        Me.Controls.Add(Me.btnSubmitScoreNGeneral)
        Me.Controls.Add(Me.lblNetworkingGeneralTitleScore)
        Me.Name = "frmResultsGeneral"
        Me.Text = "Results General"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblNetworkingGeneralTitleScore As System.Windows.Forms.Label
    Friend WithEvents btnSubmitScoreNGeneral As System.Windows.Forms.Button
    Friend WithEvents lblShowScoreNGeneral As System.Windows.Forms.Label
    Friend WithEvents lblInstructionsGeneral As System.Windows.Forms.Label
    Friend WithEvents btnBackfrmResultsGeneral As System.Windows.Forms.Button
End Class
