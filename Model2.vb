Public Class Model2
    Private Sub Model2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Objek As Control

        With Me
            .Text = "Demo: Nilai Default (Model 2"
            .lbOperand.Text = "Pilih Operand :"

            With .cbOperand
                .Items.Clear()
                .Items.Add("+")
                .Items.Add("-")
                .Items.Add("x")
                .Items.Add("/")
                .Items.Add("^")
                .SelectedItem = 0
            End With

            .gb1.Text = "Objek Input: TextBox"
            .gb2.Text = "Objek Output: ListBox"
            .btnHitung.Text = "Hitung"
            .btnBukaModel1.Text = "Buka: Model 1"
            .btnKeluar.Text = "Keluar"
            .MaximizeBox = False
            .MinimizeBox = False
            .lVarA.Text = "Nilai A"
            .lVarB.Text = "Nilai B"
            .lVarC.Text = "Nilai C"
            .lTd1.Text = ":"
            .lTd2.Text = ":"
            .lTd3.Text = ":"

            For Each Objek In Me.Controls
                If TypeName(Objek) = "TextBox" Then
                    Objek.Text = "Halo"
                End If
            Next

            .lbHasil.Items.Clear()
            .FormBorderStyle = FormBorderStyle.FixedSingle
        End With
    End Sub

    Private Sub BtnBukaModel1_Click(sender As Object, e As EventArgs) Handles btnBukaModel1.Click
        Model1.Show()
        Me.Hide()
    End Sub

    Private Sub BtnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim Hasil As Double

        If cbOperand.Text = "+" Or
                cbOperand.Text = "-" Or
                cbOperand.Text = "x" Or
                cbOperand.Text = "/" Or
                cbOperand.Text = "^" Then

            If tbVarA.Text = "" Then
                MsgBox("Silahkan Isi Nilai A", vbOKOnly + vbExclamation, "Input Kosong")
            ElseIf tbVarB.Text = "" Then
                MsgBox("Silahkan Isi Nilai B", vbOKOnly + vbExclamation, "Input Kosong")
            ElseIf tbVarC.Text = "" Then
                MsgBox("Silahkan Isi Nilai C", vbOKOnly + vbExclamation, "Input Kosong")
            Else
                With lbHasil.Items
                    .Clear()
                    .Add("Nilai A" & lTd1.Text & " " & Val(tbVarA.Text))
                    .Add("Nilai B" & lTd2.Text & " " & Val(tbVarB.Text))
                    .Add("Nilai C" & lTd3.Text & " " & Val(tbVarC.Text))

                    With cbOperand
                        If .SelectedIndex = 0 Then
                            Hasil = Val(tbVarA.Text) + Val(tbVarB.Text) + Val(tbVarC.Text)
                        ElseIf .SelectedIndex = 1 Then
                            Hasil = Val(tbVarA.Text) - Val(tbVarB.Text) - Val(tbVarC.Text)
                        ElseIf .SelectedIndex = 2 Then
                            Hasil = Val(tbVarA.Text) * Val(tbVarB.Text) * Val(tbVarC.Text)
                        ElseIf .SelectedIndex = 3 Then
                            Hasil = Val(tbVarA.Text) / Val(tbVarB.Text) / Val(tbVarC.Text)
                        ElseIf .SelectedIndex = 4 Then
                            Hasil = Val(tbVarA.Text) ^ Val(tbVarB.Text) ^ Val(tbVarC.Text)
                        End If
                    End With

                    .Add("Hasil " & lTd3.Text & " " & Hasil)

                End With
            End If
        Else
            MsgBox("Silahkan Pilih Operand Yang Tersedia.", vbOKOnly + vbExclamation, "Pilih Operand!")
        End If
    End Sub

    Private Sub CbOperand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbOperand.SelectedIndexChanged
        With Me
            .tbVarA.Text = vbEmpty
            .tbVarB.Text = vbEmpty
            .tbVarC.Text = vbEmpty
            .lbHasil.Items.Clear()
        End With
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        End
    End Sub
End Class