Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str1, str2
        Dim vcount, i, str1len As Integer

        str1 = TextBox1.Text
        str1len = Len(str1)
        For i = 1 To str1len
            str2 = Mid(str1, i, 1)
            If str2 = "a" Or str2 = "e" Or str2 = "i" Or str2 = "o" Or str2 = "u" Or str2 = "A" Or str2 = "E" Or str2 = "I" Or str2 = "O" Or str2 = "U" Then
                vcount = vcount + 1
            End If
        Next
        TextBox2.Text = vcount


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class
