﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmJuegoPreguntas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmJuegoPreguntas))
        Me.MediaPlayer = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Progreso_Barra = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.Temporizador = New System.Windows.Forms.Timer(Me.components)
        Me.LBLPUNTOS = New System.Windows.Forms.Label()
        Me.IMAGENES = New System.Windows.Forms.ImageList(Me.components)
        Me.BTN1 = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN3 = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN4 = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN2 = New Guna.UI2.WinForms.Guna2Button()
        Me.LBLPREGUNTA = New System.Windows.Forms.Label()
        Me.TiempoPregunta = New System.Windows.Forms.Timer(Me.components)
        Me.TemporizadoTransicion = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Me.MediaPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MediaPlayer
        '
        Me.MediaPlayer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MediaPlayer.Enabled = True
        Me.MediaPlayer.Location = New System.Drawing.Point(-51, -38)
        Me.MediaPlayer.Name = "MediaPlayer"
        Me.MediaPlayer.OcxState = CType(resources.GetObject("MediaPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.MediaPlayer.Size = New System.Drawing.Size(1040, 560)
        Me.MediaPlayer.TabIndex = 2
        '
        'Progreso_Barra
        '
        Me.Progreso_Barra.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Progreso_Barra.BackColor = System.Drawing.Color.Transparent
        Me.Progreso_Barra.FillColor = System.Drawing.Color.Black
        Me.Progreso_Barra.Location = New System.Drawing.Point(76, 457)
        Me.Progreso_Barra.Name = "Progreso_Barra"
        Me.Progreso_Barra.ProgressColor = System.Drawing.Color.Gold
        Me.Progreso_Barra.ProgressColor2 = System.Drawing.Color.Gold
        Me.Progreso_Barra.Size = New System.Drawing.Size(806, 15)
        Me.Progreso_Barra.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.Progreso_Barra.TabIndex = 20
        Me.Progreso_Barra.Text = "Guna2ProgressBar1"
        Me.Progreso_Barra.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.Progreso_Barra.Value = 70
        '
        'Temporizador
        '
        '
        'LBLPUNTOS
        '
        Me.LBLPUNTOS.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.LBLPUNTOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLPUNTOS.ForeColor = System.Drawing.Color.White
        Me.LBLPUNTOS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LBLPUNTOS.Location = New System.Drawing.Point(169, 177)
        Me.LBLPUNTOS.Name = "LBLPUNTOS"
        Me.LBLPUNTOS.Size = New System.Drawing.Size(54, 31)
        Me.LBLPUNTOS.TabIndex = 21
        Me.LBLPUNTOS.Text = "0"
        Me.LBLPUNTOS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IMAGENES
        '
        Me.IMAGENES.ImageStream = CType(resources.GetObject("IMAGENES.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IMAGENES.TransparentColor = System.Drawing.Color.Transparent
        Me.IMAGENES.Images.SetKeyName(0, "score_containercoin_2x (1).png")
        '
        'BTN1
        '
        Me.BTN1.Animated = True
        Me.BTN1.BackColor = System.Drawing.Color.Transparent
        Me.BTN1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN1.FillColor = System.Drawing.Color.MediumSlateBlue
        Me.BTN1.Font = New System.Drawing.Font("Showcard Gothic", 9.0!)
        Me.BTN1.ForeColor = System.Drawing.Color.White
        Me.BTN1.Location = New System.Drawing.Point(53, 248)
        Me.BTN1.Name = "BTN1"
        Me.BTN1.Size = New System.Drawing.Size(374, 78)
        Me.BTN1.TabIndex = 1
        Me.BTN1.Text = "Guna2Button1"
        Me.BTN1.UseTransparentBackground = True
        '
        'BTN3
        '
        Me.BTN3.Animated = True
        Me.BTN3.BackColor = System.Drawing.Color.Transparent
        Me.BTN3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN3.FillColor = System.Drawing.Color.MediumSlateBlue
        Me.BTN3.Font = New System.Drawing.Font("Showcard Gothic", 9.0!)
        Me.BTN3.ForeColor = System.Drawing.Color.White
        Me.BTN3.Location = New System.Drawing.Point(533, 248)
        Me.BTN3.Name = "BTN3"
        Me.BTN3.Size = New System.Drawing.Size(374, 78)
        Me.BTN3.TabIndex = 2
        Me.BTN3.Text = "Guna2Button1"
        Me.BTN3.UseTransparentBackground = True
        '
        'BTN4
        '
        Me.BTN4.Animated = True
        Me.BTN4.BackColor = System.Drawing.Color.Transparent
        Me.BTN4.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN4.FillColor = System.Drawing.Color.MediumSlateBlue
        Me.BTN4.Font = New System.Drawing.Font("Showcard Gothic", 9.0!)
        Me.BTN4.ForeColor = System.Drawing.Color.White
        Me.BTN4.Location = New System.Drawing.Point(533, 345)
        Me.BTN4.Name = "BTN4"
        Me.BTN4.Size = New System.Drawing.Size(374, 78)
        Me.BTN4.TabIndex = 4
        Me.BTN4.Text = "Guna2Button1"
        Me.BTN4.UseTransparentBackground = True
        '
        'BTN2
        '
        Me.BTN2.Animated = True
        Me.BTN2.BackColor = System.Drawing.Color.Transparent
        Me.BTN2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN2.FillColor = System.Drawing.Color.MediumSlateBlue
        Me.BTN2.Font = New System.Drawing.Font("Showcard Gothic", 9.0!)
        Me.BTN2.ForeColor = System.Drawing.Color.White
        Me.BTN2.Location = New System.Drawing.Point(53, 345)
        Me.BTN2.Name = "BTN2"
        Me.BTN2.Size = New System.Drawing.Size(374, 78)
        Me.BTN2.TabIndex = 3
        Me.BTN2.Text = "Guna2Button1"
        Me.BTN2.UseTransparentBackground = True
        '
        'LBLPREGUNTA
        '
        Me.LBLPREGUNTA.BackColor = System.Drawing.Color.Transparent
        Me.LBLPREGUNTA.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLPREGUNTA.ForeColor = System.Drawing.SystemColors.Control
        Me.LBLPREGUNTA.Location = New System.Drawing.Point(244, 134)
        Me.LBLPREGUNTA.Name = "LBLPREGUNTA"
        Me.LBLPREGUNTA.Size = New System.Drawing.Size(481, 85)
        Me.LBLPREGUNTA.TabIndex = 29
        Me.LBLPREGUNTA.Text = "Nombre del estudiante:"
        Me.LBLPREGUNTA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TiempoPregunta
        '
        '
        'TemporizadoTransicion
        '
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(53, 154)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(185, 88)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 30
        Me.Guna2PictureBox1.TabStop = False
        '
        'FrmJuegoPreguntas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(961, 500)
        Me.Controls.Add(Me.LBLPUNTOS)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.LBLPREGUNTA)
        Me.Controls.Add(Me.BTN2)
        Me.Controls.Add(Me.BTN4)
        Me.Controls.Add(Me.BTN3)
        Me.Controls.Add(Me.BTN1)
        Me.Controls.Add(Me.Progreso_Barra)
        Me.Controls.Add(Me.MediaPlayer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmJuegoPreguntas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmJuegoPreguntas"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        CType(Me.MediaPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MediaPlayer As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Progreso_Barra As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents Temporizador As Timer
    Friend WithEvents LBLPUNTOS As Label
    Friend WithEvents IMAGENES As ImageList
    Friend WithEvents BTN1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LBLPREGUNTA As Label
    Friend WithEvents TiempoPregunta As Timer
    Friend WithEvents TemporizadoTransicion As Timer
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
End Class
