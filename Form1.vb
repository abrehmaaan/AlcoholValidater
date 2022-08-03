Public Class Form1
    Private Sub check_Click(sender As Object, e As EventArgs) Handles check.Click
        Dim s As String
        s = age.Text
        If (IsNumeric(s)) Then
            Dim a As Integer
            Integer.TryParse(s, a)
            If (a > 21) Then
                result.Text = "You can drink Alcohol!"
            Else
                result.Text = "You can't drink Alcohol!"
            End If
        Else
            result.Text = "Invalid Input! Please enter integer."
        End If
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Dim x As Integer
        x = (Me.Width - result.Width) / 2
        result.Location = New Point(x, result.Location.Y)
    End Sub
End Class
