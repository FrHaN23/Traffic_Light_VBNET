Public Class Form1
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles lampuKuning.Click


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If lampuHijau.Visible = True Then
            lampuMerah.Visible = True
            lampuKuning.Visible = False
            lampuHijau.Visible = False
        ElseIf lampuMerah.Visible = True Then
            lampuMerah.Visible = False
            lampuKuning.Visible = True
            lampuHijau.Visible = False
        ElseIf lampuKuning.Visible = True Then
            lampuMerah.Visible = False
            lampuKuning.Visible = False
            lampuHijau.Visible = True
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bttnKeluar_Click(sender As Object, e As EventArgs) Handles bttnKeluar.Click
        End
    End Sub
End Class
