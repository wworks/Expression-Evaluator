Public Class ExpressionEvaluatorForm
    Dim ExpressionEvaluator As New ExpressionEvaluator
    Private Sub ExpressionButton_Click(sender As Object, e As EventArgs) Handles ExpressionButton.Click
        ExpressionEvaluator.VariableParser(VariablesTextBox.Text)
        OutputTextBox.Text = ExpressionEvaluator.Parser(ExpressionComboBox.Text)
    End Sub

    Private Sub HelpButton_Click(sender As Object, e As EventArgs) Handles HelpButton.Click
        MsgBox("The ExpressionEvaluator supports - + * / and brackets." & vbNewLine & "The variables must be | separated and look like this: x=55|y=66")
    End Sub
End Class
