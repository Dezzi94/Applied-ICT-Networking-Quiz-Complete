<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResultsTechnologies
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
        Me.lblNetworkingTechnologiesTitleScore = New System.Windows.Forms.Label()
        Me.btnSubmitScoreNTechnologies = New System.Windows.Forms.Button()
        Me.lblShowScoreNTechnologies = New System.Windows.Forms.Label()
        Me.lblInstructionsTechnologies = New System.Windows.Forms.Label()
        Me.btnBackfrmResultsTechnologies = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNetworkingTechnologiesTitleScore
        '
        Me.lblNetworkingTechnologiesTitleScore.BackColor = System.Drawing.SystemColors.Highlight
        Me.lblNetworkingTechnologiesTitleScore.Font = New System.Drawing.Font("Modern No. 20", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetworkingTechnologiesTitleScore.Location = New System.Drawing.Point(174, 24)
        Me.lblNetworkingTechnologiesTitleScore.Name = "lblNetworkingTechnologiesTitleScore"
        Me.lblNetworkingTechnologiesTitleScore.Size = New System.Drawing.Size(422, 46)
        Me.lblNetworkingTechnologiesTitleScore.TabIndex = 35
        Me.lblNetworkingTechnologiesTitleScore.Text = "Networking Architectures Score"
        Me.lblNetworkingTechnologiesTitleScore.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnSubmitScoreNTechnologies
        '
        Me.btnSubmitScoreNTechnologies.Location = New System.Drawing.Point(216, 146)
        Me.btnSubmitScoreNTechnologies.Name = "btnSubmitScoreNTechnologies"
        Me.btnSubmitScoreNTechnologies.Size = New System.Drawing.Size(235, 48)
        Me.btnSubmitScoreNTechnologies.TabIndex = 36
        Me.btnSubmitScoreNTechnologies.Text = "Submit Score"
        Me.btnSubmitScoreNTechnologies.UseVisualStyleBackColor = True
        '
        'lblShowScoreNTechnologies
        '
        Me.lblShowScoreNTechnologies.Font = New System.Drawing.Font("Modern No. 20", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowScoreNTechnologies.Location = New System.Drawing.Point(76, 239)
        Me.lblShowScoreNTechnologies.Name = "lblShowScoreNTechnologies"
        Me.lblShowScoreNTechnologies.Size = New System.Drawing.Size(497, 102)
        Me.lblShowScoreNTechnologies.TabIndex = 37
        '
        'lblInstructionsTechnologies
        '
        Me.lblInstructionsTechnologies.Font = New System.Drawing.Font("Cambria", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructionsTechnologies.Location = New System.Drawing.Point(28, 384)
        Me.lblInstructionsTechnologies.Name = "lblInstructionsTechnologies"
        Me.lblInstructionsTechnologies.Size = New System.Drawing.Size(614, 61)
        Me.lblInstructionsTechnologies.TabIndex = 38
        Me.lblInstructionsTechnologies.Text = "Click the button above to view your score. Keep trying until you get full marks!!" & _
    "!"
        '
        'btnBackfrmResultsTechnologies
        '
        Me.btnBackfrmResultsTechnologies.BackColor = System.Drawing.Color.Crimson
        Me.btnBackfrmResultsTechnologies.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackfrmResultsTechnologies.Location = New System.Drawing.Point(12, 16)
        Me.btnBackfrmResultsTechnologies.Name = "btnBackfrmResultsTechnologies"
        Me.btnBackfrmResultsTechnologies.Size = New System.Drawing.Size(145, 54)
        Me.btnBackfrmResultsTechnologies.TabIndex = 45
        Me.btnBackfrmResultsTechnologies.Text = "Back To Main Menu"
        Me.btnBackfrmResultsTechnologies.UseVisualStyleBackColor = False
        '
        'frmResultsTechnologies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(667, 593)
        Me.Controls.Add(Me.btnBackfrmResultsTechnologies)
        Me.Controls.Add(Me.lblInstructionsTechnologies)
        Me.Controls.Add(Me.lblShowScoreNTechnologies)
        Me.Controls.Add(Me.btnSubmitScoreNTechnologies)
        Me.Controls.Add(Me.lblNetworkingTechnologiesTitleScore)
        Me.Name = "frmResultsTechnologies"
        Me.Text = "Results Types"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblNetworkingTechnologiesTitleScore As System.Windows.Forms.Label
    Friend WithEvents btnSubmitScoreNTechnologies As System.Windows.Forms.Button
    Friend WithEvents lblShowScoreNTechnologies As System.Windows.Forms.Label
    Friend WithEvents lblInstructionsTechnologies As System.Windows.Forms.Label
    Friend WithEvents btnBackfrmResultsTechnologies As System.Windows.Forms.Button
End Class
