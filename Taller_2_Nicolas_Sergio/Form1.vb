Public Class Form1
    Dim g As Double = 9.81
    Dim x0 As Double = 50
    Dim y0 As Double = 40
    Dim v0 As Double = 50
    Dim x As Double = x0
    Dim y As Double = y0
    Dim deltaTime As Double = 0.1
    Dim angleDegrees As Double = 30
    Dim angleRadians As Double = angleDegrees * Math.PI / 180
    Dim v0x As Double = v0 * Math.Cos(angleRadians)
    Dim v0y As Double = v0 * Math.Sin(angleRadians)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim valueX As Integer = CInt(Int(((500 - 200) * Rnd()) + 200))
        Dim valueY As Integer = CInt(Int(((300 - 100) * Rnd()) + 100))
        Label2.Text = "Y: " & valueY
        valueY = 549 - valueY

        PictureBoxPunto.Location = New Point(valueX, valueY)
        Label1.Text = "X: " & valueX

        graficarParabola()
        'Timer1.Enabled = True

    End Sub

    Public Function graficarParabola()
        x0 = 50
        y0 = 40
        'v0 = 20
        x = x0
        y = y0
        deltaTime = 0.1
        angleDegrees += 1
        angleRadians = angleDegrees * Math.PI / 180
        v0y = v0 * Math.Sin(angleRadians)
        v0x = v0 * Math.Cos(angleRadians)

        If angleDegrees >= 60 Then
            angleDegrees = 30
            v0 += 1
            If (v0 > 100) Then
                Timer1.Enabled = False
            Else
                Timer1.Enabled = True
            End If

        Else
            Timer1.Enabled = True
        End If



    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        x = x + v0x * deltaTime
        y = y + v0y * deltaTime - 0.5 * g * deltaTime * deltaTime

        PicturePiedra.Location = New Point(x, 400 - y)
        LabelXPiedra.Text = "X: " & x
        LabelYPiedra.Text = "Y: " & y
        LabelVo.Text = "velocidad inicial: " & v0
        LabelAngulo.Text = "ángulo: " & angleDegrees

        ' Actualizar la velocidad en y (afectada por la gravedad)
        v0y = v0y - g * deltaTime

        'verificar si toca al punto
        If (PicturePiedra.Location.X >= PictureBoxPunto.Location.X And PicturePiedra.Location.X <= (PictureBoxPunto.Location.X + 10)) And (PicturePiedra.Location.Y >= PictureBoxPunto.Location.Y And PicturePiedra.Location.Y <= (PictureBoxPunto.Location.Y + 10)) Then
            tablaEfectivos.Rows.Add(v0, angleDegrees)
        End If

        ' Incrementar el tiempo
        If (y <= 0) Then
                Timer1.Enabled = False

                graficarParabola()
            End If
            deltaTime += 0.1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Enabled = False

    End Sub
End Class
