<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResultsTypes
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
        Me.lblNetworkingTypesTitleScore = New System.Windows.Forms.Label()
        Me.btnSubmitScoreNTypes = New System.Windows.Forms.Button()
        Me.lblShowScoreNTypes = New System.Windows.Forms.Label()
        Me.lblInstructionsTypes = New System.Windows.Forms.Label()
        Me.btnBackfrmResultsTypes = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNetworkingTypesTitleScore
        '
        Me.lblNetworkingTypesTitleScore.BackColor = System.Drawing.SystemColors.Highlight
        Me.lblNetworkingTypesTitleScore.Font = New System.Drawing.Font("Modern No. 20", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetworkingTypesTitleScore.Location = New System.Drawing.Point(135, 24)
        Me.lblNetworkingTypesTitleScore.Name = "lblNetworkingTypesTitleScore"
        Me.lblNetworkingTypesTitleScore.Size = New System.Drawing.Size(422, 46)
        Me.lblNetworkingTypesTitleScore.TabIndex = 35
        Me.lblNetworkingTypesTitleScore.Text = "Networking Types Score"
        Me.lblNetworkingTypesTitleScore.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnSubmitScoreNTypes
        '
        Me.btnSubmitScoreNTypes.Location = New System.Drawing.Point(216, 146)
        Me.btnSubmitScoreNTypes.Name = "btnSubmitScoreNTypes"
        Me.btnSubmitScoreNTypes.Size = New System.Drawing.Size(235, 48)
        Me.btnSubmitScoreNTypes.TabIndex = 36
        Me.btnSubmitScoreNTypes.Text = "Submit Score"
        Me.btnSubmitScoreNTypes.UseVisualStyleBackColor = True
        '
        'lblShowScoreNTypes
        '
        Me.lblShowScoreNTypes.Font = New System.Drawing.Font("Modern No. 20", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowScoreNTypes.Location = New System.Drawing.Point(76, 239)
        Me.lblShowScoreNTypes.Name = "lblShowScoreNTypes"
        Me.lblShowScoreNTypes.Size = New System.Drawing.Size(497, 102)
        Me.lblShowScoreNTypes.TabIndex = 37
        '
        'lblInstructionsTypes
        '
        Me.lblInstructionsTypes.Font = New System.Drawing.Font("Cambria", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructionsTypes.Location = New System.Drawing.Point(28, 384)
        Me.lblInstructionsTypes.Name = "lblInstructionsTypes"
        Me.lblInstructionsTypes.Size = New System.Drawing.Size(614, 61)
        Me.lblInstructionsTypes.TabIndex = 38
        Me.lblInstructionsTypes.Text = "Click the button above to view your score. Keep trying until you get full marks!!" & _
    "!"
        '
        'btnBackfrmResultsTypes
        '
        Me.btnBackfrmResultsTypes.BackColor = System.Drawing.Color.Crimson
        Me.btnBackfrmResultsTypes.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackfrmResultsTypes.Location = New System.Drawing.Point(12, 24)
        Me.btnBackfrmResultsTypes.Name = "btnBackfrmResultsTypes"
        Me.btnBackfrmResultsTypes.Size = New System.Drawing.Size(145, 54)
        Me.btnBackfrmResultsTypes.TabIndex = 46
        Me.btnBackfrmResultsTypes.Text = "Back To Main Menu"
        Me.btnBackfrmResultsTypes.UseVisualStyleBackColor = False
        '
        'frmResultsTypes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(667, 593)
        Me.Controls.Add(Me.btnBackfrmResultsTypes)
        Me.Controls.Add(Me.lblInstructionsTypes)
        Me.Controls.Add(Me.lblShowScoreNTypes)
        Me.Controls.Add(Me.btnSubmitScoreNTypes)
        Me.Controls.Add(Me.lblNetworkingTypesTitleScore)
        Me.Name = "frmResultsTypes"
        Me.Text = "Results Types"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblNetworkingTypesTitleScore As System.Windows.Forms.Label
    Friend WithEvents btnSubmitScoreNTypes As System.Windows.Forms.Button
    Friend WithEvents lblShowScoreNTypes As System.Windows.Forms.Label
    Friend WithEvents lblInstructionsTypes As System.Windows.Forms.Label
    Friend WithEvents btnBackfrmResultsTypes As System.Windows.Forms.Button
End Class
