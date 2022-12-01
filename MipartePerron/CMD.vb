Public Class CMD



    Dim Caracteres As String

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Caracteres = TextBox1.Text

        If Caracteres = "CMD" Then

            Dim comando
            comando = Shell("cmd.exe /k", 1)

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()


    End Sub
End Class