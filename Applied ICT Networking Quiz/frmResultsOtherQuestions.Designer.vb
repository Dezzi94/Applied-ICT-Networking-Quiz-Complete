<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResultsOtherQuestions
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
        Me.lblNetworkingOtherQuestionsTitleScore = New System.Windows.Forms.Label()
        Me.btnSubmitScoreNOtherQuestions = New System.Windows.Forms.Button()
        Me.lblShowScoreNOtherQuestions = New System.Windows.Forms.Label()
        Me.lblInstructionsOtherQuestions = New System.Windows.Forms.Label()
        Me.btnBackfrmResultsOtherQuestions = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNetworkingOtherQuestionsTitleScore
        '
        Me.lblNetworkingOtherQuestionsTitleScore.BackColor = System.Drawing.SystemColors.Highlight
        Me.lblNetworkingOtherQuestionsTitleScore.Font = New System.Drawing.Font("Modern No. 20", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetworkingOtherQuestionsTitleScore.Location = New System.Drawing.Point(174, 24)
        Me.lblNetworkingOtherQuestionsTitleScore.Name = "lblNetworkingOtherQuestionsTitleScore"
        Me.lblNetworkingOtherQuestionsTitleScore.Size = New System.Drawing.Size(422, 46)
        Me.lblNetworkingOtherQuestionsTitleScore.TabIndex = 35
        Me.lblNetworkingOtherQuestionsTitleScore.Text = "Other Networking Questions Score"
        Me.lblNetworkingOtherQuestionsTitleScore.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnSubmitScoreNOtherQuestions
        '
        Me.btnSubmitScoreNOtherQuestions.Location = New System.Drawing.Point(216, 146)
        Me.btnSubmitScoreNOtherQuestions.Name = "btnSubmitScoreNOtherQuestions"
        Me.btnSubmitScoreNOtherQuestions.Size = New System.Drawing.Size(235, 48)
        Me.btnSubmitScoreNOtherQuestions.TabIndex = 36
        Me.btnSubmitScoreNOtherQuestions.Text = "Submit Score"
        Me.btnSubmitScoreNOtherQuestions.UseVisualStyleBackColor = True
        '
        'lblShowScoreNOtherQuestions
        '
        Me.lblShowScoreNOtherQuestions.Font = New System.Drawing.Font("Modern No. 20", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowScoreNOtherQuestions.Location = New System.Drawing.Point(76, 239)
        Me.lblShowScoreNOtherQuestions.Name = "lblShowScoreNOtherQuestions"
        Me.lblShowScoreNOtherQuestions.Size = New System.Drawing.Size(497, 102)
        Me.lblShowScoreNOtherQuestions.TabIndex = 37
        '
        'lblInstructionsOtherQuestions
        '
        Me.lblInstructionsOtherQuestions.Font = New System.Drawing.Font("Cambria", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructionsOtherQuestions.Location = New System.Drawing.Point(28, 384)
        Me.lblInstructionsOtherQuestions.Name = "lblInstructionsOtherQuestions"
        Me.lblInstructionsOtherQuestions.Size = New System.Drawing.Size(614, 61)
        Me.lblInstructionsOtherQuestions.TabIndex = 38
        Me.lblInstructionsOtherQuestions.Text = "Click the button above to view your score. Keep trying until you get full marks!!" & _
    "!"
        '
        'btnBackfrmResultsOtherQuestions
        '
        Me.btnBackfrmResultsOtherQuestions.BackColor = System.Drawing.Color.Crimson
        Me.btnBackfrmResultsOtherQuestions.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackfrmResultsOtherQuestions.Location = New System.Drawing.Point(12, 16)
        Me.btnBackfrmResultsOtherQuestions.Name = "btnBackfrmResultsOtherQuestions"
        Me.btnBackfrmResultsOtherQuestions.Size = New System.Drawing.Size(145, 54)
        Me.btnBackfrmResultsOtherQuestions.TabIndex = 45
        Me.btnBackfrmResultsOtherQuestions.Text = "Back To Main Menu"
        Me.btnBackfrmResultsOtherQuestions.UseVisualStyleBackColor = False
        '
        'frmResultsOtherQuestions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(667, 593)
        Me.Controls.Add(Me.btnBackfrmResultsOtherQuestions)
        Me.Controls.Add(Me.lblInstructionsOtherQuestions)
        Me.Controls.Add(Me.lblShowScoreNOtherQuestions)
        Me.Controls.Add(Me.btnSubmitScoreNOtherQuestions)
        Me.Controls.Add(Me.lblNetworkingOtherQuestionsTitleScore)
        Me.Name = "frmResultsOtherQuestions"
        Me.ShowIcon = False
        Me.Text = "Results OtherQuestions"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblNetworkingOtherQuestionsTitleScore As System.Windows.Forms.Label
    Friend WithEvents btnSubmitScoreNOtherQuestions As System.Windows.Forms.Button
    Friend WithEvents lblShowScoreNOtherQuestions As System.Windows.Forms.Label
    Friend WithEvents lblInstructionsOtherQuestions As System.Windows.Forms.Label
    Friend WithEvents btnBackfrmResultsOtherQuestions As System.Windows.Forms.Button
End Class
