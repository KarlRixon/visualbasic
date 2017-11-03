Public Class Form1
    Dim w% = 252, h% = 202
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Width = w
        PictureBox1.Height = h
        TextBox1.Top = 0
        TextBox1.Left = 0
        TextBox1.Width = Me.Width - 15
        TextBox1.Height = Me.Height - 30
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        TextBox1.Top = 0
        TextBox1.Left = 0
        TextBox1.Width = Me.Width - 15
        TextBox1.Height = Me.Height - 30
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        'Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PictureBox1.Height *= 0.9
        PictureBox1.Width *= 0.9
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Height *= 1.1
        PictureBox1.Width *= 1.1
    End Sub
End Class
