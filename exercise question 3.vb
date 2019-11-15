Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim temperature As Integer
        Dim status As String

        temperature = Val(TextBox1.Text)

        Select Case temperature
            Case 0 To 30
                status = "cold"
            Case 31 To 50
                status = "medium"
            Case 51 To 70
                status = "hot"
            Case 71 To 100
                status = "very hot"
        End Select

        TextBox2.Text = status

    End Sub
End Class
