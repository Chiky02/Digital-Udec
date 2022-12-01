Public Class Inicio

    'abrir la abrra de tareas
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim Open As Boolean
        Open = False



        If Panel1.Visible = False Then

            Panel1.Visible = True

        ElseIf Panel1.Visible = True Then

            Panel1.Visible = False

        End If

    End Sub

    Private Sub Inicio_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyData = Keys.Enter Then
            CMD.Show()

        ElseIf e.KeyData = Keys.P Then
            MsgBox("Se preciono P")
        End If



    End Sub




    'hacer transparentes los logos 
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Panel1.Parent = PictureBox1
        Iglu.Parent = PictureBox1

        Archivos.Parent = PictureBox2



    End Sub

    'Es para llamar a la pantalla de archivos
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Archivos.Click

    End Sub

    'para abrir las opciones del iglu (reiniciar-apagar-opciones)
    Private Sub Iglu_Click(sender As Object, e As EventArgs) Handles Iglu.Click

        If Toolsx.Visible = False And Restartx.Visible = False And Endx.Visible = False Then


            Toolsx.Visible = True
            Restartx.Visible = True
            Endx.Visible = True

        ElseIf Toolsx.Visible = True And Restartx.Visible = True And Endx.Visible = True Then

            Toolsx.Visible = False
            Restartx.Visible = False
            Endx.Visible = False
        End If

    End Sub

    'Este boton es para salir del sistema opertaivo 
    Private Sub Endx_Click(sender As Object, e As EventArgs) Handles Endx.Click
        Me.Close()


    End Sub

    Private Sub duckLogo_Click(sender As Object, e As EventArgs) Handles duckLogo.Click

        If Green.Visible = False And Blue.Visible = False And Red.Visible = False Then


            Green.Visible = True
            Blue.Visible = True
            Red.Visible = True

        ElseIf Green.Visible = True And Blue.Visible = True And Red.Visible = True Then

            Green.Visible = False
            Blue.Visible = False
            Red.Visible = False
        End If
    End Sub

    Private Sub ApliCmd_Click(sender As Object, e As EventArgs) Handles ApliCmd.Click

        CMD.Show()

    End Sub



    Private Sub raro_Click(sender As Object, e As EventArgs)

        If Toolsx.Visible = False And Restartx.Visible = False And Endx.Visible = False Then


            Toolsx.Visible = True
            Restartx.Visible = True
            Endx.Visible = True

        ElseIf Toolsx.Visible = True And Restartx.Visible = True And Endx.Visible = True Then

            Toolsx.Visible = False
            Restartx.Visible = False
            Endx.Visible = False
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        VLC.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
