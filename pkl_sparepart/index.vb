Public Class index
    Public Sub index_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()
        Panel10.Hide()
        Panel9.Hide()
        Panel11.Hide()
        Panel6.Hide()
        Panel7.Hide()
        Panel8.Hide()
        Panel14.Hide()
        Panel15.Hide()
        Panel16.Hide()
        Panel17.Hide()
        Panel18.Hide()
        Panel19.Hide()
        Panel25.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TransaksiPR.MdiParent = Me
        Me.Panel12.Controls.Add(TransaksiPR)
        TransaksiPR.Show()
    End Sub

    Private Sub button2_click(sender As Object, e As EventArgs) Handles Button2.Click
        TransaksiPO.MdiParent = Me
        Me.Panel12.Controls.Add(TransaksiPO)
        TransaksiPO.Show()
    End Sub

    Private Sub button3_click(sender As Object, e As EventArgs) Handles Button3.Click
        Supplier.MdiParent = Me
        Me.Panel12.Controls.Add(Supplier)
        Supplier.Show()
    End Sub

    Private Sub button4_click(sender As Object, e As EventArgs) Handles Button4.Click
        PengambilanBarang.MdiParent = Me
        Me.Panel12.Controls.Add(PengambilanBarang)
        PengambilanBarang.Show()
    End Sub

    Private Sub button5_click(sender As Object, e As EventArgs) Handles Button5.Click
        TerimaBarang.MdiParent = Me
        Me.Panel12.Controls.Add(TerimaBarang)
        TerimaBarang.Show()
    End Sub

    Private Sub button6_click(sender As Object, e As EventArgs) Handles Button6.Click
        Sparepart.MdiParent = Me
        Me.Panel12.Controls.Add(Sparepart)
        Sparepart.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try
            CloseConn("all")
            Me.Close()
            login.Close()
        Catch ex As Exception
            Me.Close()
            login.Close()
        End Try
    End Sub

    Private Sub Button5_MouseHover(sender As Object, e As EventArgs) Handles Button5.MouseHover
        Panel10.Show()
        Panel9.Hide()
        Panel11.Hide()
    End Sub

    Private Sub Button4_MouseHover(sender As Object, e As EventArgs) Handles Button4.MouseHover
        Panel10.Hide()
        Panel9.Show()
        Panel11.Hide()
    End Sub

    Private Sub Button6_MouseHover(sender As Object, e As EventArgs) Handles Button6.MouseHover
        Panel10.Hide()
        Panel9.Hide()
        Panel11.Show()
    End Sub


    Private Sub Panel1_MouseHover(sender As Object, e As EventArgs) Handles Panel1.MouseHover
        Panel10.Hide()
        Panel9.Hide()
        Panel11.Hide()
        Panel6.Hide()
        Panel7.Hide()
        Panel8.Hide()
        Panel14.Hide()
        Panel15.Hide()
        Panel16.Hide()
        Panel17.Hide()
        Panel18.Hide()
        Panel19.Hide()
        Panel25.Hide()
    End Sub

    Private Sub Panel5_MouseHover(sender As Object, e As EventArgs) Handles Panel5.MouseHover
        Panel10.Hide()
        Panel9.Hide()
        Panel11.Hide()
        Panel6.Hide()
        Panel7.Hide()
        Panel8.Hide()
    End Sub

    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        Panel10.Hide()
        Panel9.Hide()
        Panel11.Hide()
        Panel6.Show()
        Panel7.Hide()
        Panel8.Hide()
    End Sub

    Private Sub Button3_MouseHover(sender As Object, e As EventArgs) Handles Button3.MouseHover
        Panel10.Hide()
        Panel9.Hide()
        Panel11.Hide()
        Panel6.Hide()
        Panel7.Hide()
        Panel8.Show()
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Panel10.Hide()
        Panel9.Hide()
        Panel11.Hide()
        Panel6.Hide()
        Panel7.Show()
        Panel8.Hide()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TerimaBarang.MdiParent = Me
        Me.Panel12.Controls.Add(TerimaBarang)
        TerimaBarang.Show()
    End Sub

    Private Sub Button9_MouseHover(sender As Object, e As EventArgs) Handles Button9.MouseHover
        Panel14.Hide()
        Panel15.Hide()
        Panel16.Show()
        Panel17.Hide()
        Panel18.Hide()
        Panel19.Hide()
        Panel24.Hide()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        PengambilanBarang.MdiParent = Me
        Me.Panel12.Controls.Add(PengambilanBarang)
        PengambilanBarang.Show()
    End Sub

    Private Sub Button8_MouseHover(sender As Object, e As EventArgs) Handles Button8.MouseHover
        Panel14.Hide()
        Panel15.Show()
        Panel16.Hide()
        Panel17.Hide()
        Panel18.Hide()
        Panel19.Hide()
        Panel24.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Sparepart.MdiParent = Me
        Me.Panel12.Controls.Add(Sparepart)
        Sparepart.Show()
    End Sub

    Private Sub Button7_MouseHover(sender As Object, e As EventArgs) Handles Button7.MouseHover
        Panel14.Show()
        Panel15.hide()
        Panel16.Hide()
        Panel17.Hide()
        Panel18.Hide()
        Panel24.Hide()
        Panel19.Hide()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TransaksiPO.MdiParent = Me
        Me.Panel12.Controls.Add(TransaksiPO)
        TransaksiPO.Show()
    End Sub

    Private Sub Button11_MouseHover(sender As Object, e As EventArgs) Handles Button11.MouseHover
        Panel14.Hide()
        Panel15.Hide()
        Panel16.Hide()
        Panel17.Hide()
        Panel18.Show()
        Panel19.Hide()
        Panel24.Hide()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Supplier.MdiParent = Me
        Me.Panel12.Controls.Add(Supplier)
        Supplier.Show()
    End Sub

    Private Sub Button10_MouseHover(sender As Object, e As EventArgs) Handles Button10.MouseHover
        Panel14.Hide()
        Panel15.Hide()
        Panel16.Hide()
        Panel17.Show()
        Panel18.Hide()
        Panel24.Hide()
        Panel19.Hide()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TransaksiPR.MdiParent = Me
        Me.Panel12.Controls.Add(TransaksiPR)
        TransaksiPR.Show()
    End Sub

    Private Sub Button12_MouseHover(sender As Object, e As EventArgs) Handles Button12.MouseHover
        Panel14.Hide()
        Panel15.Hide()
        Panel24.Hide()
        Panel16.Hide()
        Panel17.Hide()
        Panel18.Hide()
        Panel19.Show()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Panel25.Show()
        Panel30.Show()
        Panel31.Show()
        Panel26.Show()
        Panel27.Show()
        Panel28.Show()
    End Sub

    Private Sub Panel12_MouseHover(sender As Object, e As EventArgs) Handles Panel12.MouseHover
        Panel10.Hide()
        Panel9.Hide()
        Panel11.Hide()
        Panel6.Hide()
        Panel7.Hide()
        Panel8.Hide()
        Panel14.Hide()
        Panel15.Hide()
        Panel16.Hide()
        Panel17.Hide()
        Panel18.Hide()
        Panel19.Hide()
        Panel25.Hide()
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Panel24.Hide()
    End Sub

    Private Sub Button23_MouseHover(sender As Object, e As EventArgs) Handles Button23.MouseHover
        Panel27.Hide()
        Panel26.Hide()
        Panel28.Hide()
        Panel30.Hide()
        Panel31.Show()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Panel25.Hide()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Panel25.Hide()
    End Sub

    Private Sub Button22_MouseHover(sender As Object, e As EventArgs) Handles Button22.MouseHover
        Panel26.Hide()
        Panel28.Hide()
        Panel30.Show()
        Panel31.Hide()
        Panel27.Hide()
    End Sub

    Private Sub Button20_MouseHover(sender As Object, e As EventArgs) Handles Button20.MouseHover
        Panel26.Hide()
        Panel28.Show()
        Panel30.Hide()
        Panel31.Hide()
        Panel27.Hide()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Panel25.Hide()
    End Sub

    Private Sub Button18_MouseHover(sender As Object, e As EventArgs) Handles Button18.MouseHover
        Panel26.Show()
        Panel28.Hide()
        Panel30.Hide()
        Panel31.Hide()
        Panel27.Hide()
    End Sub

    Private Sub Panel13_MouseHover(sender As Object, e As EventArgs) Handles Panel13.MouseHover
        Panel25.Hide()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        SparepartRV.MdiParent = Me
        Me.Panel12.Controls.Add(SparepartRV)
        SparepartRV.Show()
    End Sub

    Private Sub Button19_MouseHover(sender As Object, e As EventArgs) Handles Button19.MouseHover
        Panel26.Hide()
        Panel27.Show()
        Panel28.Hide()
        Panel30.Hide()
        Panel31.Hide()
    End Sub
End Class