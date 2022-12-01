<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VLC
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VLC))
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.ElegirArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pausaVideo = New System.Windows.Forms.Button()
        Me.ResetVideo = New System.Windows.Forms.Button()
        Me.Inicio = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(13, 12)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(518, 412)
        Me.AxWindowsMediaPlayer1.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSplitButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(963, 27)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ElegirArchivoToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ToolStripSplitButton1.Image = CType(resources.GetObject("ToolStripSplitButton1.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(75, 24)
        Me.ToolStripSplitButton1.Text = "Archivo"
        '
        'ElegirArchivoToolStripMenuItem
        '
        Me.ElegirArchivoToolStripMenuItem.Name = "ElegirArchivoToolStripMenuItem"
        Me.ElegirArchivoToolStripMenuItem.Size = New System.Drawing.Size(168, 24)
        Me.ElegirArchivoToolStripMenuItem.Text = "Elegir archivo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(168, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'pausaVideo
        '
        Me.pausaVideo.BackColor = System.Drawing.Color.Transparent
        Me.pausaVideo.BackgroundImage = Global.MipartePerron.My.Resources.Resources.detener
        Me.pausaVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pausaVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pausaVideo.ForeColor = System.Drawing.Color.Transparent
        Me.pausaVideo.Location = New System.Drawing.Point(837, 117)
        Me.pausaVideo.Name = "pausaVideo"
        Me.pausaVideo.Size = New System.Drawing.Size(83, 75)
        Me.pausaVideo.TabIndex = 4
        Me.pausaVideo.UseVisualStyleBackColor = False
        '
        'ResetVideo
        '
        Me.ResetVideo.BackColor = System.Drawing.Color.Transparent
        Me.ResetVideo.BackgroundImage = Global.MipartePerron.My.Resources.Resources.reiniciar
        Me.ResetVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ResetVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ResetVideo.ForeColor = System.Drawing.Color.Transparent
        Me.ResetVideo.Location = New System.Drawing.Point(837, 198)
        Me.ResetVideo.Name = "ResetVideo"
        Me.ResetVideo.Size = New System.Drawing.Size(103, 80)
        Me.ResetVideo.TabIndex = 3
        Me.ResetVideo.UseVisualStyleBackColor = False
        '
        'Inicio
        '
        Me.Inicio.BackColor = System.Drawing.Color.Transparent
        Me.Inicio.BackgroundImage = Global.MipartePerron.My.Resources.Resources.reproducir
        Me.Inicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Inicio.ForeColor = System.Drawing.Color.Transparent
        Me.Inicio.Location = New System.Drawing.Point(837, 30)
        Me.Inicio.Name = "Inicio"
        Me.Inicio.Size = New System.Drawing.Size(79, 72)
        Me.Inicio.TabIndex = 2
        Me.Inicio.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Panel1.Location = New System.Drawing.Point(12, 39)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(787, 551)
        Me.Panel1.TabIndex = 6
        '
        'VLC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(963, 628)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.pausaVideo)
        Me.Controls.Add(Me.ResetVideo)
        Me.Controls.Add(Me.Inicio)
        Me.Name = "VLC"
        Me.Text = "VLC"
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Inicio As System.Windows.Forms.Button
    Friend WithEvents ResetVideo As System.Windows.Forms.Button
    Friend WithEvents pausaVideo As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents ElegirArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
