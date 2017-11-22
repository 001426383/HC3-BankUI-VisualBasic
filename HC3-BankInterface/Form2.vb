Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Bounds = Form1.Bounds
    End Sub
    Private Sub InsertButton_Click(sender As Object, e As EventArgs) Handles InsertCardButton.Click
        Form3.Show()
        Me.Hide()
    End Sub
    Private Sub TextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles AccountNum1.KeyPress, AccountNum2.KeyPress, AccountNum3.KeyPress, AccountNum4.KeyPress, AccountNum5.KeyPress, AccountNum6.KeyPress, AccountNum7.KeyPress, AccountNum8.KeyPress, AccountNum9.KeyPress, AccountNum10.KeyPress, AccountNum11.KeyPress, AccountNum12.KeyPress, AccountNum13.KeyPress, AccountNum14.KeyPress, AccountNum15.KeyPress, AccountNum16.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
        'SendKeys.Send("{TAB}")
        If sender.Equals(AccountNum1) Then
            AccountNum2.Focus()
            AccountNum2.SelectAll()
        ElseIf sender.Equals(AccountNum2) Then
            AccountNum3.Focus()
            AccountNum3.SelectAll()
        ElseIf sender.Equals(AccountNum3) Then
            AccountNum4.Focus()
            AccountNum4.SelectAll()
        ElseIf sender.Equals(AccountNum4) Then
            AccountNum5.Focus()
            AccountNum5.SelectAll()
        ElseIf sender.Equals(AccountNum5) Then
            AccountNum6.Focus()
            AccountNum6.SelectAll()
        ElseIf sender.Equals(AccountNum6) Then
            AccountNum7.Focus()
            AccountNum7.SelectAll()
        ElseIf sender.Equals(AccountNum7) Then
            AccountNum8.Focus()
            AccountNum8.SelectAll()
        ElseIf sender.Equals(AccountNum8) Then
            AccountNum9.Focus()
            AccountNum9.SelectAll()
        ElseIf sender.Equals(AccountNum9) Then
            AccountNum10.Focus()
            AccountNum10.SelectAll()
        ElseIf sender.Equals(AccountNum10) Then
            AccountNum11.Focus()
            AccountNum11.SelectAll()
        ElseIf sender.Equals(AccountNum11) Then
            AccountNum12.Focus()
            AccountNum12.SelectAll()
        ElseIf sender.Equals(AccountNum12) Then
            AccountNum13.Focus()
            AccountNum13.SelectAll()
        ElseIf sender.Equals(AccountNum13) Then
            AccountNum14.Focus()
            AccountNum14.SelectAll()
        ElseIf sender.Equals(AccountNum14) Then
            AccountNum15.Focus()
            AccountNum15.SelectAll()
        ElseIf sender.Equals(AccountNum15) Then
            AccountNum16.Focus()
            AccountNum16.SelectAll()
        ElseIf sender.Equals(AccountNum16) Then
            Form3.Show()
            Me.Hide()
        End If
    End Sub
End Class