<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExpressionEvaluatorForm
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
        Me.ExpressionButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OutputTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.VariablesTextBox = New System.Windows.Forms.TextBox()
        Me.HelpButton = New System.Windows.Forms.Button()
        Me.ExpressionComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ExpressionButton
        '
        Me.ExpressionButton.Location = New System.Drawing.Point(17, 77)
        Me.ExpressionButton.Name = "ExpressionButton"
        Me.ExpressionButton.Size = New System.Drawing.Size(253, 36)
        Me.ExpressionButton.TabIndex = 0
        Me.ExpressionButton.Text = "Evaluate!"
        Me.ExpressionButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(116, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Expression: "
        '
        'OutputTextBox
        '
        Me.OutputTextBox.Location = New System.Drawing.Point(17, 158)
        Me.OutputTextBox.Name = "OutputTextBox"
        Me.OutputTextBox.Size = New System.Drawing.Size(253, 20)
        Me.OutputTextBox.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(124, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Output: "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.VariablesTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 204)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(251, 104)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Variables:"
        '
        'VariablesTextBox
        '
        Me.VariablesTextBox.Location = New System.Drawing.Point(6, 19)
        Me.VariablesTextBox.MaxLength = 3276700
        Me.VariablesTextBox.Multiline = True
        Me.VariablesTextBox.Name = "VariablesTextBox"
        Me.VariablesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.VariablesTextBox.Size = New System.Drawing.Size(239, 79)
        Me.VariablesTextBox.TabIndex = 6
        Me.VariablesTextBox.Text = "x=55|y=67"
        '
        'HelpButton
        '
        Me.HelpButton.Location = New System.Drawing.Point(127, 314)
        Me.HelpButton.Name = "HelpButton"
        Me.HelpButton.Size = New System.Drawing.Size(26, 24)
        Me.HelpButton.TabIndex = 6
        Me.HelpButton.Text = "?"
        Me.HelpButton.UseVisualStyleBackColor = True
        '
        'ExpressionComboBox
        '
        Me.ExpressionComboBox.FormattingEnabled = True
        Me.ExpressionComboBox.Items.AddRange(New Object() {"5+5", "5*(4+4)", "(5*(55+3))*7", "x+y"})
        Me.ExpressionComboBox.Location = New System.Drawing.Point(18, 38)
        Me.ExpressionComboBox.Name = "ExpressionComboBox"
        Me.ExpressionComboBox.Size = New System.Drawing.Size(254, 21)
        Me.ExpressionComboBox.TabIndex = 7
        '
        'ExpressionEvaluatorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 342)
        Me.Controls.Add(Me.ExpressionComboBox)
        Me.Controls.Add(Me.HelpButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.OutputTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ExpressionButton)
        Me.Name = "ExpressionEvaluatorForm"
        Me.Text = "ExpressionEvaluator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ExpressionButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OutputTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents VariablesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HelpButton As System.Windows.Forms.Button
    Friend WithEvents ExpressionComboBox As System.Windows.Forms.ComboBox

End Class
