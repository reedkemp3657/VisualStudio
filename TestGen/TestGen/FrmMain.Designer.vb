﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnTestStart = New System.Windows.Forms.Button()
        Me.CboQuestionNum = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(259, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select the number of questions for your test:"
        '
        'BtnTestStart
        '
        Me.BtnTestStart.Location = New System.Drawing.Point(81, 190)
        Me.BtnTestStart.Name = "BtnTestStart"
        Me.BtnTestStart.Size = New System.Drawing.Size(117, 36)
        Me.BtnTestStart.TabIndex = 1
        Me.BtnTestStart.Text = "Begin Test"
        Me.BtnTestStart.UseVisualStyleBackColor = True
        '
        'CboQuestionNum
        '
        Me.CboQuestionNum.FormattingEnabled = True
        Me.CboQuestionNum.Location = New System.Drawing.Point(109, 71)
        Me.CboQuestionNum.Name = "CboQuestionNum"
        Me.CboQuestionNum.Size = New System.Drawing.Size(53, 21)
        Me.CboQuestionNum.TabIndex = 2
        Me.CboQuestionNum.Text = "25"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.CboQuestionNum)
        Me.Controls.Add(Me.BtnTestStart)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Number of Questions?"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnTestStart As System.Windows.Forms.Button
    Friend WithEvents CboQuestionNum As System.Windows.Forms.ComboBox

End Class
