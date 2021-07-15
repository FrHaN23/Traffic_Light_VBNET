Public Class Form2
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If hijau4.Visible = True Then
            hijau4.Visible = False
            kuning4.Visible = True
        ElseIf kuning4.Visible = True Then
            kuning4.Visible = False
            merah4.Visible = True
        End If


        If hijau3.Visible = True Then
            hijau3.Visible = False
            kuning3.Visible = True
            merah3.Visible = False
            merah2.Visible = True
            merah4.Visible = True
            merah1.Visible = True
        ElseIf kuning3.Visible = True Then
            merah3.Visible = True
            merah4.Visible = False
            kuning3.Visible = False
            hijau4.Visible = True
        End If

        If hijau2.Visible = True Then
            hijau2.Visible = False
            kuning2.Visible = True
            merah2.Visible = False
            merah1.Visible = True
            merah3.Visible = True
            merah4.Visible = True
        ElseIf kuning2.Visible = True Then
            kuning2.Visible = False
            merah2.Visible = True
            merah1.Visible = True
            merah3.Visible = False
            merah4.Visible = True
            hijau3.Visible = True

        End If

        If hijau1.Visible = True Then
            merah1.Visible = False
            kuning1.Visible = True
            hijau1.Visible = False
            merah2.Visible = True
            merah3.Visible = True
            merah4.Visible = True
        ElseIf kuning2.Visible = True Then
            merah1.Visible = True
        ElseIf merah1.Visible = True And merah2.Visible = True And merah3.Visible = True And merah4.Visible = True Then
            merah1.Visible = False
            kuning1.Visible = False
            hijau1.Visible = True
        ElseIf kuning1.Visible = True Then
            merah1.Visible = True
            kuning1.Visible = False
            hijau1.Visible = False
            merah2.Visible = False
            merah3.Visible = True
            merah4.Visible = True
            hijau2.Visible = True
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kuning1.Visible = False
        merah1.Visible = False
        hijau1.Visible = True

        kuning2.Visible = False
        merah2.Visible = True
        hijau2.Visible = False

        kuning3.Visible = False
        merah3.Visible = True
        hijau3.Visible = False

        kuning4.Visible = False
        merah4.Visible = True
        hijau4.Visible = False
    End Sub


End Class