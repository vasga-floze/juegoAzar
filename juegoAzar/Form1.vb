Public Class Form1

    Dim N1, N2, N3, C As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        C = 0
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Timer1.Enabled = True
        Timer2.Enabled = True
        Timer3.Enabled = True

        btnPlay.Enabled = False
        btnStop.Enabled = True

        'Inicializar contador en cero, para la segunda o siguientes partidas
        C = 0
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        N1 = Rnd() * 9
        txtN1.Text = Str(N1)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        N2 = Rnd() * 9
        txtN2.Text = Str(N2)
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        N3 = Rnd() * 9
        txtN3.Text = Str(N3)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        C = C + 1
        If C = 1 Then
            Timer1.Enabled = False
        End If

        If C = 2 Then
            Timer2.Enabled = False
        End If

        If C = 3 Then
            Timer3.Enabled = False
            If (N1 = N2) And (N2 = N3) Then
                MsgBox("Felicidades!", MsgBoxStyle.Information, "Ganaste!")
            Else
                MsgBox("Perdiste", 16, "Vuelve a intentarlo")
            End If
            btnPlay.Enabled = True
            btnStop.Enabled = False
        End If
    End Sub

End Class
