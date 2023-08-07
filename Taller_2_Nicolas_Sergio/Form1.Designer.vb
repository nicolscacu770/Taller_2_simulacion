<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PictureBoxPunto = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelVo = New System.Windows.Forms.Label()
        Me.LabelAngulo = New System.Windows.Forms.Label()
        Me.tablaEfectivos = New System.Windows.Forms.DataGridView()
        Me.velocidad_inicial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.angulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PicturePiedra = New System.Windows.Forms.PictureBox()
        Me.LabelYPiedra = New System.Windows.Forms.Label()
        Me.LabelXPiedra = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PictureBoxPunto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tablaEfectivos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicturePiedra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxPunto
        '
        Me.PictureBoxPunto.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.PictureBoxPunto.Image = Global.Taller_2_Nicolas_Sergio.My.Resources.Resources.ovni
        Me.PictureBoxPunto.Location = New System.Drawing.Point(347, 495)
        Me.PictureBoxPunto.MaximumSize = New System.Drawing.Size(10, 10)
        Me.PictureBoxPunto.Name = "PictureBoxPunto"
        Me.PictureBoxPunto.Size = New System.Drawing.Size(10, 10)
        Me.PictureBoxPunto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxPunto.TabIndex = 0
        Me.PictureBoxPunto.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.SaddleBrown
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 549)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1451, 96)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(51, 564)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 26)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Lanzar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 606)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "X: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(106, 606)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Y:"
        '
        'LabelVo
        '
        Me.LabelVo.AutoSize = True
        Me.LabelVo.Location = New System.Drawing.Point(204, 569)
        Me.LabelVo.Name = "LabelVo"
        Me.LabelVo.Size = New System.Drawing.Size(107, 16)
        Me.LabelVo.TabIndex = 5
        Me.LabelVo.Text = "velocidad inicial:"
        '
        'LabelAngulo
        '
        Me.LabelAngulo.AutoSize = True
        Me.LabelAngulo.Location = New System.Drawing.Point(204, 591)
        Me.LabelAngulo.Name = "LabelAngulo"
        Me.LabelAngulo.Size = New System.Drawing.Size(54, 16)
        Me.LabelAngulo.TabIndex = 6
        Me.LabelAngulo.Text = "ángulo: "
        '
        'tablaEfectivos
        '
        Me.tablaEfectivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaEfectivos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.velocidad_inicial, Me.angulo})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InfoText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tablaEfectivos.DefaultCellStyle = DataGridViewCellStyle2
        Me.tablaEfectivos.Location = New System.Drawing.Point(756, 34)
        Me.tablaEfectivos.Name = "tablaEfectivos"
        Me.tablaEfectivos.RowHeadersWidth = 51
        Me.tablaEfectivos.RowTemplate.Height = 24
        Me.tablaEfectivos.Size = New System.Drawing.Size(384, 170)
        Me.tablaEfectivos.TabIndex = 7
        '
        'velocidad_inicial
        '
        Me.velocidad_inicial.FillWeight = 10.0!
        Me.velocidad_inicial.HeaderText = "velocidad inicial"
        Me.velocidad_inicial.MinimumWidth = 6
        Me.velocidad_inicial.Name = "velocidad_inicial"
        Me.velocidad_inicial.Width = 125
        '
        'angulo
        '
        Me.angulo.HeaderText = "ángulo inicial"
        Me.angulo.MinimumWidth = 6
        Me.angulo.Name = "angulo"
        Me.angulo.Width = 125
        '
        'PicturePiedra
        '
        Me.PicturePiedra.BackColor = System.Drawing.Color.DarkCyan
        Me.PicturePiedra.Location = New System.Drawing.Point(80, 513)
        Me.PicturePiedra.MaximumSize = New System.Drawing.Size(13, 13)
        Me.PicturePiedra.Name = "PicturePiedra"
        Me.PicturePiedra.Size = New System.Drawing.Size(13, 13)
        Me.PicturePiedra.TabIndex = 8
        Me.PicturePiedra.TabStop = False
        '
        'LabelYPiedra
        '
        Me.LabelYPiedra.AutoSize = True
        Me.LabelYPiedra.Location = New System.Drawing.Point(507, 587)
        Me.LabelYPiedra.Name = "LabelYPiedra"
        Me.LabelYPiedra.Size = New System.Drawing.Size(19, 16)
        Me.LabelYPiedra.TabIndex = 10
        Me.LabelYPiedra.Text = "Y:"
        '
        'LabelXPiedra
        '
        Me.LabelXPiedra.AutoSize = True
        Me.LabelXPiedra.Location = New System.Drawing.Point(449, 587)
        Me.LabelXPiedra.Name = "LabelXPiedra"
        Me.LabelXPiedra.Size = New System.Drawing.Size(21, 16)
        Me.LabelXPiedra.TabIndex = 9
        Me.LabelXPiedra.Text = "X: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(448, 564)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "ubicación piedra"
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(51, 95)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "pausar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1457, 642)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LabelYPiedra)
        Me.Controls.Add(Me.LabelXPiedra)
        Me.Controls.Add(Me.PicturePiedra)
        Me.Controls.Add(Me.tablaEfectivos)
        Me.Controls.Add(Me.LabelAngulo)
        Me.Controls.Add(Me.LabelVo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBoxPunto)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBoxPunto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tablaEfectivos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicturePiedra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBoxPunto As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelVo As Label
    Friend WithEvents LabelAngulo As Label
    Friend WithEvents tablaEfectivos As DataGridView
    Friend WithEvents velocidad_inicial As DataGridViewTextBoxColumn
    Friend WithEvents angulo As DataGridViewTextBoxColumn
    Friend WithEvents PicturePiedra As PictureBox
    Friend WithEvents LabelYPiedra As Label
    Friend WithEvents LabelXPiedra As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button2 As Button
End Class
