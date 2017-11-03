Public Class Form1
    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBox2.Click
        If Not IsNumeric(TextBox1.Text) Then
            MsgBox("账号必须为数字",, "警告")
            TextBox1.Text = ""
            TextBox1.Focus()
        ElseIf TextBox1.TextLength <> 6 Then
            MsgBox("账号必须为六位数",, "警告")
            TextBox1.Text = ""
            TextBox1.Focus()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox1.MaxLength = 6
        TextBox2.MaxLength = 4
        TextBox2.PasswordChar = "*"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i%
        If TextBox2.Text <> "karl" Then
            i = MsgBox("密码错误", MsgBoxStyle.RetryCancel, "警告")
            If i = MsgBoxResult.Cancel Then
                Close()
            Else
                TextBox2.Text = ""
                TextBox2.Focus()
            End If
        Else
            MsgBox("登录成功",, "提示")
        End If
    End Sub
End Class
