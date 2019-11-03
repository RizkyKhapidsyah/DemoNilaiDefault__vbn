Public Class Model1
    Private Sub Model1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me
            .Text = "Demo: Nilai Default (Model 1)"
            .MinimizeBox = False
            .MaximizeBox = False
            .lbHasil.Items.Clear()
            .btnHitung.Text = "Hitung"
            .btnBukaModel2.Text = "Buka: Model 2"
            .btnKeluar.Text = "Keluar"
            .FormBorderStyle = FormBorderStyle.FixedSingle
        End With
    End Sub

    Private Sub BtnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim A As Double
        Dim B As Double
        Dim C As Double

        B = 3

        With lbHasil
            .Items.Clear()
            .Items.Add(A)
            .Items.Add(B)

            A = 5
            C = A * (2 + B)

            .Items.Add(C)
        End With
    End Sub

    Private Sub BtnBukaModel2_Click(sender As Object, e As EventArgs) Handles btnBukaModel2.Click
        Model2.Show()
        Me.Hide()
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        End
    End Sub
End Class
