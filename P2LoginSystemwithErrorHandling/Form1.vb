Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim userName As String = TextBox1.Text
            Dim passWord As String = TextBox2.Text


            If String.IsNullOrEmpty(userName) Then
                Throw New ArgumentException("Username cannot be empty.")
            End If

            If String.IsNullOrEmpty(passWord) Then
                Throw New ArgumentException("Password cannot be empty.")
            End If


            If userName = "kayrell" And passWord = "12345" Then
                Label3.Text = "Login Successful"
            Else
                Label3.Text = "Invalid username or password."
            End If

        Catch ex As ArgumentException
            Label3.Text = ex.Message
        End Try
    End Sub
End Class
