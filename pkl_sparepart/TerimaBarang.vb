Imports System.Data.OracleClient
Public Class TerimaBarang
    Public kuantiti1, kuantiti2, kuantiti3, kuantiti4, kuantiti5, kuantiti6, kuantiti7, kuantiti8, kuantiti9, kuantiti10 As Integer
    Public produk1, produk2, produk3, produk4, produk5, produk6, produk7, produk8, produk9, produk10 As String
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TerimaRV.Show()
    End Sub
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Me.TerimaBarang_Load(sender, e)
    End Sub
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs)
    End Sub
    Public produk, satuanproduk As String()
    Dim kdSP As String
    Dim status As String
    Dim grade As String
    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Try
            For index = 0 To DataGridView1.Rows.Count - 2 'dua kali
                Try
                    'cmd = New OracleCommand("select k.kode_kategori from t_po o join kategori_sparepart k on(o.kode_kategori = k.kode_kategori) where o.kode_transaksiPO LIKE '%" & TextBox2.Text & "%'", conn)
                    'dr = cmd.ExecuteReader()
                    'While dr.Read()
                    '    produk(index) = dr.Item(0)
                    'MsgBox(produk(index))
                    'dr.Close()
                    'cmd.Dispose()
                    If DataGridView1.Rows(index).Cells(4).Value = "0" Then
                        cmd = New OracleCommand("update t_po set status_PO = 'Terima' where kode_transaksiPO = '" & TxtKodePO.Text & "'", conn)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                    End If
                    'MsgBox(TextBox3.Text)
                    'MsgBox(txtKD_PR.Text)
                    cmd = New OracleCommand("insert into Penerimaan values ('" & txtkode.Text & "','" & TxtKodePO.Text & "','" & TxtKodeSupplier.Text & "','" & DataGridView1.Rows(index).Cells(6).Value & "','" & txtKD_PR.Text & "','" & DateTimePicker1.Value & "', '" & TxtDNVendor.Text & "', '" & TxtNoPol.Text & "','" & DataGridView1.Rows(index).Cells(0).Value & "','" & DataGridView1.Rows(index).Cells(2).Value & "','" & DataGridView1.Rows(index).Cells(4).Value & "','" & DataGridView1.Rows(index).Cells(5).Value & "')", conn)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    'MsgBox("skxw")
                Catch ex As Exception
                End Try
                For p = 1 To CInt(DataGridView1.Rows(index).Cells(2).Value)
                    'MsgBox(p)
                    'MsgBox(DataGridView1.Rows(index).Cells(2).Value)
                    Try
                        Dim bantT As String = ""
                        cmd = New OracleCommand("select COUNT(*)+1 from SPAREPART WHERE KODE_SPAREPART LIKE '%" & DataGridView1.Rows(index).Cells(6).Value & "%'", conn)
                        dr = cmd.ExecuteReader()
                        If dr.HasRows Then
                            dr.Read()
                            'kode = dr.Item(0)
                            kdSP = dr.Item(0)
                            'MsgBox(kdSP)
                            'MsgBox(kdSP)
                            For i As Integer = 1 To 3 - kdSP.Length
                                bantT += "0"
                            Next
                        End If
                        dr.Close()
                        cmd.Dispose()
                        kdSP = DataGridView1.Rows(index).Cells(6).Value & bantT & kdSP
                        'MsgBox(kdSP)
                    Catch ex As Exception
                        'ERRORR DISINI
                        'kdSP = "001"
                    End Try
                    status = "Tidak Terpakai"
                    grade = "Good"
                    'MsgBox(DataGridView1.Rows(index).Cells(6).Value)
                    Try
                        Dim sql As String = "insert into SPAREPART values('" & kdSP & "','" & DataGridView1.Rows(index).Cells(6).Value & "','" & status & "','" & grade & "','" & TxtCatatan.Text & "')"
                        cmd = New OracleCommand(sql, conn)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                    Catch ex As Exception
                    End Try
                Next
            Next
            MessageBox.Show("Berhasil Menyimpan Data", "Informasi")
            TerimaRV.TxtKode.Text = txtkode.Text
            Me.Hide()
            TerimaRV.ShowDialog()
            Me.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Informasi")
        End Try
        ''For index = 1 To CInt(DataGridView1.Rows(baris).Cells(2).Value)

        'Next
    End Sub
    Dim kodepr As String
    Dim anu1 As Integer
    Dim anuu As Integer
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        cmd = New OracleCommand("select distinct s.QTY_PERPACK,r.qty1,r.kode_transaksipr from KATEGORI_sparepart s join t_pr r on (s.kode_kategori = r.kode_kategori) join t_po o on(r.kode_transaksipr=o.kode_transaksipr) where  o.kode_transaksiPO = '" & TxtKodePO.Text & "'", conn)
        dr = cmd.ExecuteReader()
        Dim baris As Integer = 0
        While dr.Read()
            'MsgBox(dr.Item(5))
            kuantiti(baris) = CInt(DataGridView1.Rows(baris).Cells(0).Value)
            If kuantiti(baris) <> CInt(dr.Item(1)) Then
                DataGridView1.Rows(baris).Cells(4).Value = dr.Item(1) - kuantiti(baris)
                DataGridView1.Rows(baris).Cells(2).Value = ""
                DataGridView1.Rows(baris).Cells(2).Value = kuantiti(baris) * dr.Item(0)
                kodepr = dr.Item(2)
                anu1 = CInt(DataGridView1.Rows(baris).Cells(0).Value)
                anuu = CInt(DataGridView1.Rows(baris).Cells(2).Value)
                cmd = New OracleCommand("update t_pr set qty1 = '" & anu1 & "', qty2 = '" & anuu & "' where kode_transaksipr = '" & kodepr & "' ", conn)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            End If
            baris += 1
        End While
        dr.Close()
        cmd.Dispose()
    End Sub
    Public kuantiti As Integer()
    Private Sub TerimaBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetTPO.T_PO' table. You can move, or remove it, as needed.
        kuantiti = New Integer() {kuantiti1, kuantiti2, kuantiti3, kuantiti4, kuantiti5, kuantiti6, kuantiti7, kuantiti8, kuantiti9, kuantiti10}
        produk = New String() {produk1, produk2, produk3, produk4, produk5, produk6, produk7, produk8, produk9, produk10}
        koneksi()
        Dim month As String = Format(DateTimePicker1.Value, "MM")
        Dim year As String = Format(DateTimePicker1.Value, "yy")
        Dim gabungan As String = year + month
        Panel1.Hide()
        txtkode.Text = ""
        Try
            Dim bant As String = ""
            cmd = New OracleCommand("select count(*)+1 from penerimaan where kode_penerimaan like '%" & gabungan & "%'", conn)
            'cmd = New OracleCommand("select max(to_number(substr(KODE_penerimaan,10,20)))+1 from penerimaan", conn)
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                dr.Read()
                'kode = dr.Item(0)
                txtkode.Text = dr.Item(0)
                For i As Integer = 1 To 6 - txtkode.TextLength
                    bant += "0"
                Next
            End If
            dr.Close()
            cmd.Dispose()
            txtkode.Text = "BPSP-" & gabungan & bant & txtkode.Text
        Catch ex As Exception
            MessageBox.Show(ex.Message, "bacot")
            txtkode.Text = "BPSP-" & gabungan & "000001"
        End Try
        'UNTUK LISTVIEW
        cmd = New OracleCommand("SELECT distinct kode_transaksipo FROM T_PO", conn)
        dr = cmd.ExecuteReader()
        ListView1.Items.Clear()
        Try
            If dr.HasRows Then
                While dr.Read()
                    'MsgBox(dr.Item(0))
                    ListView1.Items.Add(dr.Item(0))
                End While
            Else
                '   MsgBox(dr.Item(0))
            End If
        Catch ex As Exception
        End Try
        dr.Close()
        cmd.Dispose()
    End Sub
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If (ListView1.SelectedItems.Count > 0) Then
            TxtKodePO.Text = ListView1.SelectedItems(0).SubItems(0).Text
            TxtNamaSupp.Text = ""
            TxtAlamatSupp.Text = ""
        End If
        cmd = New OracleCommand("select a.kode_transaksiPR, b.nama_supplier,b.alamat, b.KODE_SUPPLIER from t_po a join supplier b on (a.kode_supplier = b.kode_supplier) where a.kode_transaksiPO = '" & TxtKodePO.Text & "'", conn)
        dr = cmd.ExecuteReader()
        dr.Read()
        txtKD_PR.Text = dr.Item(0)
        TxtNamaSupp.Text = dr.Item(1)
        TxtAlamatSupp.Text = dr.Item(2)
        'MsgBox(dr.Item(2))
        TxtKodeSupplier.Text = dr.Item(3)
        dr.Close()
        cmd.Dispose()
        cmd = New OracleCommand("select distinct s.UOM,s.UOM_PACKAGING,r.qty1,r.qty2,s.nama_kategori,s.kode_kategori from KATEGORI_sparepart s join t_pr r on (s.kode_kategori = r.kode_kategori) join t_po o on(r.kode_transaksipr=o.kode_transaksipr) where  o.kode_transaksiPO =  '" & TxtKodePO.Text & "'", conn)
        dr = cmd.ExecuteReader()
        Dim baris As Integer = 0
        DataGridView1.Rows.Clear()
        While dr.Read()
            DataGridView1.Rows.Add()
            DataGridView1.Rows(baris).Cells(0).Value = dr.Item(2)
            DataGridView1.Rows(baris).Cells(1).Value = dr.Item(0)
            DataGridView1.Rows(baris).Cells(2).Value = dr.Item(3)
            DataGridView1.Rows(baris).Cells(3).Value = dr.Item(1)
            DataGridView1.Rows(baris).Cells(5).Value = dr.Item(4)
            DataGridView1.Rows(baris).Cells(6).Value = dr.Item(5)
            DataGridView1.Rows(baris).Cells(4).Value = "0"
            baris += 1
        End While
        dr.Close()
        cmd.Dispose()

        'cmd = New OracleCommand("select distinct s.UOM,s.UOM_PACKAGING from sparepart s join t_po o on (s.kode_kategori = o.kode_kategori) where  o.kode_transaksiPO = '" & TextBox2.Text & "'", conn)
        'dr = cmd.ExecuteReader()
        'Dim baris As Integer = 0
        'DataGridView1.Rows.Clear()

        'While dr.Read()


        '    DataGridView1.Rows.Add()
        '    'DataGridView1.Rows(baris).Cells(0).Value = dr.Item(0)
        '    DataGridView1.Rows(baris).Cells(1).Value = dr.Item(0)
        '    ' DataGridView1.Rows(baris).Cells(2).Value = dr.Item(1)
        '    DataGridView1.Rows(baris).Cells(3).Value = dr.Item(1)
        '    '  DataGridView1.Rows(baris).Cells(5).Value = dr.Item(4)
        '    baris += 1

        'End While
        'dr.Close()
        'cmd.Dispose()

        'cmd = New OracleCommand("select distinct r.qty1,r.qty2 from t_pr r join t_po o on (r.kode_transaksipR = o.kode_transaksipr)where o.kode_transaksiPO = '" & TextBox2.Text & "'", conn)
        'dr = cmd.ExecuteReader()
        'Dim i As Integer = 0

        'While dr.Read()

        '    DataGridView1.Rows(i).Cells(0).Value = dr.Item(0)
        '    DataGridView1.Rows(i).Cells(2).Value = dr.Item(1)
        '    'DataGridView1.Rows(i).Cells(5).Value = dr.Item(2)
        '    i += 1

        'End While
        'dr.Close()
        'cmd.Dispose()
        'cmd = New OracleCommand("select distinct s.nama_kategori from kategori_sparepart s join t_po o on (s.kode_kategori = o.kode_kategori)where o.kode_transaksiPO = '" & TextBox2.Text & "'", conn)
        'dr = cmd.ExecuteReader()
        'Dim u As Integer = 0

        'While dr.Read()


        '    DataGridView1.Rows(u).Cells(5).Value = dr.Item(0)
        '    u += 1

        'End While
        'dr.Close()
        'cmd.Dispose()

        TerimaBarang_Load(sender, e)
        Panel1.Hide()
    End Sub

    Private Sub TxtKodePO_TextChanged(sender As Object, e As EventArgs) Handles TxtKodePO.TextChanged
        Panel1.Show()
        cmd = New OracleCommand("select distinct kode_transaksipo from t_po where kode_transaksiPO like '%" & TxtKodePO.Text & "%' and status_po = 'Belum Diterima'", conn)
        dr = cmd.ExecuteReader()
        ListView1.Items.Clear()
        If dr.HasRows Then
            While dr.Read()
                ListView1.Items.Add(dr.Item(0))
            End While
        End If
        dr.Close()
        cmd.Dispose()
    End Sub

    Private Sub DataGridView1_TextChanged(sender As Object, e As EventArgs) Handles DataGridView1.TextChanged
        cmd = New OracleCommand("select s.UOM,s.UOM_PACKAGING,r.qty1,r.qty2,s.nama_kategori from KATEGORI_sparepart s join t_po o on (s.kode_kategori = o.kode_kategori) join t_pr r on(o.kode_transaksipr=r.kode_transaksipr) where  o.kode_transaksiPO = '" & TxtKodePO.Text & "'", conn)
        dr = cmd.ExecuteReader()
        Dim baris As Integer = 0
        While dr.Read()
            kuantiti(baris) = CInt(DataGridView1.Rows(baris).Cells(0).Value)
            If kuantiti(baris) <> CInt(dr.Item(2)) Then
                DataGridView1.Rows(baris).Cells(4).Value = dr.Item(2) - kuantiti(baris)
            ElseIf kuantiti(baris) = CInt(dr.Item(2)) Then
                DataGridView1.Rows(baris).Cells(4).Value = 0
            End If
            baris += 1
        End While
        dr.Close()
        cmd.Dispose()
    End Sub

    Private Sub DataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            'cmd = New OracleCommand("select s.UOM,s.UOM_PACKAGING,r.qty1,r.qty2,s.nama_kategori from KATEGORI_sparepart s join t_pr r on (s.kode_kategori = r.kode_kategori) join t_po o on(r.kode_transaksipr=o.kode_transaksipr) where  o.kode_transaksiPO = '" & TextBox2.Text & "'", conn)
            'dr = cmd.ExecuteReader()
            'Dim baris As Integer = 0
            'While dr.Read()


            '    kuantiti(baris) = CInt(DataGridView1.Rows(baris).Cells(0).Value)

            '    If kuantiti(baris) <> CInt(dr.Item(2)) Then
            '        DataGridView1.Rows(baris).Cells(4).Value = dr.Item(2) - kuantiti(baris)


            '    End If


            '    baris += 1

            'End While



            'dr.Close()
            'cmd.Dispose()
            cmd = New OracleCommand("select distinct s.QTY_PERPACK,r.qty1 from KATEGORI_sparepart s join t_pr r on (s.kode_kategori = r.kode_kategori) join t_po o on(r.kode_transaksipr=o.kode_transaksipr) where  o.kode_transaksiPO = '" & TxtKodePO.Text & "'", conn)
            dr = cmd.ExecuteReader()
            Dim baris As Integer = 0
            While dr.Read()
                'MsgBox(dr.Item(5))
                kuantiti(baris) = CInt(DataGridView1.Rows(baris).Cells(0).Value)
                If kuantiti(baris) <> CInt(dr.Item(1)) Then
                    DataGridView1.Rows(baris).Cells(4).Value = dr.Item(1) - kuantiti(baris)
                    DataGridView1.Rows(baris).Cells(2).Value = ""
                    DataGridView1.Rows(baris).Cells(2).Value = kuantiti(baris) * dr.Item(0)
                End If
                baris += 1
            End While
        End If
        dr.Close()
        cmd.Dispose()
    End Sub

    Private Sub DataGridView1_EditModeChanged(sender As Object, e As EventArgs) Handles DataGridView1.EditModeChanged
        cmd = New OracleCommand("select s.UOM,s.UOM_PACKAGING,r.qty1,r.qty2,s.nama_kategori from KATEGORI_sparepart s join t_po o on (s.kode_kategori = o.kode_kategori) join t_pr r on(o.kode_transaksipr=r.kode_transaksipr) where  o.kode_transaksiPO = '" & TxtKodePO.Text & "'", conn)
        dr = cmd.ExecuteReader()
        Dim baris As Integer = 0
        While dr.Read()
            MsgBox("hey")
            kuantiti(baris) = CInt(DataGridView1.Rows(baris).Cells(0).Value)
            If kuantiti(baris) <> CInt(dr.Item(2)) Then
                DataGridView1.Rows(baris).Cells(4).Value = dr.Item(2) - kuantiti(baris)
            ElseIf kuantiti(baris) = CInt(dr.Item(2)) Then
                DataGridView1.Rows(baris).Cells(4).Value = 0
            End If
            baris += 1
        End While
        dr.Close()
        cmd.Dispose()
    End Sub
End Class