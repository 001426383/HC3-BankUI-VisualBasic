Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Bounds = Form2.Bounds
    End Sub

    Private Sub TextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PIN1.KeyPress, PIN2.KeyPress, PIN3.KeyPress, PIN4.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
        'SendKeys.Send("{TAB}")
        If sender.Equals(PIN1) Then
            PIN2.Focus()
            PIN2.SelectAll()
        ElseIf sender.Equals(PIN2) Then
            PIN3.Focus()
            PIN3.SelectAll()
        ElseIf sender.Equals(PIN3) Then
            PIN4.Focus()
            PIN4.SelectAll()
        ElseIf sender.Equals(PIN4) Then
            Form4.Show()
            Me.Hide()
        End If
    End Sub
End Class