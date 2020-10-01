Public Class OddEvenChecker
    Dim userInput As Integer

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click

        userInput = Int(value.Text)
        If userInput Mod 2 = 0 Then
            result.Visible = True
            result.Text = "Even"
        Else
            result.Visible = True
            result.Text = "Odd"
        End If
    End Sub

    Private Sub value_TextChanged(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles value.KeyDown, value.TextChanged
        If e.KeyCode = Keys.Enter Then

            userInput = Int(value.Text)
            If userInput Mod 2 = 0 Then
                result.Visible = True
                result.Text = "Even"
            Else
                result.Visible = True
                result.Text = "Odd"
            End If
        End If

    End Sub

    Private Sub value_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class
