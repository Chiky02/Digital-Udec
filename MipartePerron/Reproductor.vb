Public Class VLC

   




   

    Private Sub ToolStripSplitButton1_ButtonClick(sender As Object, e As EventArgs) Handles ToolStripSplitButton1.ButtonClick

    End Sub

    Private Sub ElegirArchivoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ElegirArchivoToolStripMenuItem.Click
        If (OpenFileDialog1.ShowDialog = DialogResult.OK) Then

            AxWindowsMediaPlayer1.URL = OpenFileDialog1.FileName
        End If


    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click

    End Sub

    'para iniciar el video
    Private Sub Inicio_Click(sender As Object, e As EventArgs) Handles Inicio.Click
        AxWindowsMediaPlayer1.Ctlcontrols.play()


    End Sub

    'para pausar el video
    Private Sub pausaVideo_Click(sender As Object, e As EventArgs) Handles pausaVideo.Click
        AxWindowsMediaPlayer1.Ctlcontrols.pause()
    End Sub
    'para reiniciar el video
    Private Sub ResetVideo_Click(sender As Object, e As EventArgs) Handles ResetVideo.Click
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
        AxWindowsMediaPlayer1.Ctlcontrols.play()

    End Sub
End Class