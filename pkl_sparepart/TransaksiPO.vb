'up = cp supplier
Imports System.Data.OracleClient
Public Class TransaksiPO
    Dim SubTotal, TotalSeluruh, DPP, PPN, DiscountAngka, Bantu As Long
    Dim BarisDGV1, BarisDGV2 As Integer
    Dim DiscountPersen, Keterangan, KodeS, NPWP, EmailKontak, DescAP, TaxScheme, Status As String

    Private Sub TxtDiscountP_TextChanged(sender As Object, e As EventArgs) Handles TxtDiscountP.TextChanged
        DiscountPersen = TxtDiscountP.Text
        Hitung()
    End Sub

    Private Sub TransaksiPO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()
        Isikode()
        Status = "Kode"
        Try
#Disable Warning BC40000 ' Type or member is obsolete
            cmd = New OracleCommand("select distinct nama_supplier from supplier ", conn)
#Enable Warning BC40000 ' Type or member is obsolete
            dr = cmd.ExecuteReader()
            While dr.Read
                ComboSupplier.Items.Add(dr.Item(0))
            End While
            CloseConn("all")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Informasi")
        End Try
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        DataGridView1.AllowUserToAddRows = True
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Isikode()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PORV.Show()
    End Sub

    Sub Isikode() 'Isi kode transaksi PO
        Dim month As String = Format(DateTimePicker1.Value, "MM")
        Dim year As String = Format(DateTimePicker1.Value, "yy")
        Dim gabungan As String = year + month
        TxtKode.Text = ""
        Try
            Dim bant As String = ""
#Disable Warning BC40000 ' Type or member is obsolete
            cmd = New OracleCommand("select max(to_number(substr(KODE_TRANSAKSIPO,12,5 )))+1 from t_po where kode_transaksiPO like '%" & gabungan & "%'", conn)
#Enable Warning BC40000 ' Type or member is obsolete
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                dr.Read()
                TxtKode.Text = dr.Item(0)
                For i As Integer = 1 To 4 - TxtKode.TextLength
                    bant += "0"
                Next
            End If
            CloseConn("all")
            TxtKode.Text = "PO-" & gabungan & "/" & "KLP" & bant & TxtKode.Text
        Catch ex As Exception
            TxtKode.Text = "PO-" & gabungan & "/" & "KLP" & "0001"
        End Try
    End Sub

    Sub Hitungdiskon()
        Try
            DiscountAngka = SubTotal * CLng(DiscountPersen) / 100
            TxtDiscountA.Text = DiscountAngka
        Catch ex As Exception
        End Try
    End Sub

    Sub Hitungsub()
        Try
            If DataGridView1.Rows(0).Cells(7).Value IsNot Nothing Then
                Bantu = 0
                For index = 0 To BarisDGV1
                    Bantu += DataGridView1.Rows(index).Cells(7).Value
                    TxtSubTotal.Text = Bantu
                Next
                Hitung()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Sub Hitung()
        SubTotal = Bantu
        If ComboVAT.Text = "E" Then
            Hitungdiskon()
            DPP = SubTotal - DiscountAngka
            PPN = DPP / 10
            TotalSeluruh = DPP + PPN
            TaxScheme = "Eksternal"
        ElseIf ComboVAT.Text = "I" Then
            PPN = SubTotal / 10
            SubTotal += PPN
            Hitungdiskon()
            DPP = SubTotal - PPN - DiscountAngka
            TotalSeluruh = DPP + PPN
            TaxScheme = "Internal"
        ElseIf ComboVAT.Enabled = False Then
            Hitungdiskon()
            DPP = SubTotal - DiscountAngka
            PPN = 0
            TotalSeluruh = DPP + PPN
            TaxScheme = "No PPN"
        End If
        TxtSubTotal.Text = SubTotal
        TxtDPP.Text = DPP
        TxtPPN.Text = PPN
        TxtTotal.Text = TotalSeluruh
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Try
            Dim sql As String
            For baris = 0 To BarisDGV1 - 1
                sql = "Insert Into T_PO values ('" & DataGridView1.Rows(baris).Cells(9).Value & "','" & DataGridView1.Rows(baris).Cells(0).Value & "','" & TxtKode.Text & "','" & KodeS & "','" & NPWP & "','" & EmailKontak & "','" & DescAP & "','" & DateTimePicker1.Value & "','" & ComboEntity.Text & "','" & ComboPOType.Text & "','" & TxtUp.Text & "','" & ComboTerm.Text & "','" & ComboCurrency.Text & "','" & TaxScheme & "','" & PPN & "','" & DataGridView1.Rows(baris).Cells(7).Value & "','" & TotalSeluruh & "','" & DiscountAngka & "','" & ComboShipping.Text & "','" & TxtCatatan.Text & "','Belum Diterima')"
#Disable Warning BC40000 ' Type or member is obsolete
                Dim cmd As New OracleCommand(sql, conn)
#Enable Warning BC40000 ' Type or member is obsolete
                cmd.ExecuteNonQuery()
                CloseConn("cmd")
            Next
#Disable Warning BC40000 ' Type or member is obsolete
            cmd = New OracleCommand("update T_pr set status_PR = 'Proses' where kode_transaksipr = '" & DataGridView1.Rows(0).Cells(0).Value & "'", conn)
#Enable Warning BC40000 ' Type or member is obsolete
            cmd.ExecuteNonQuery()
            CloseConn("cmd")
            MessageBox.Show("Berhasil menyimpan data!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            PORV.TxtKode.Text = TxtKode.Text
            PORV.TxtST.Text = TxtSubTotal.Text
            PORV.TxtDisc.Text = TxtDiscountA.Text
            PORV.TxtDPP.Text = TxtDPP.Text
            PORV.TxtPPN.Text = TxtPPN.Text
            PORV.TxtCur.Text = ComboCurrency.Text
            PORV.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Maaf, tidak dapat menyimpan data", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Me.Close()
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Close()
    End Sub

    Private Sub ComboTax_TextChanged(sender As Object, e As EventArgs) Handles ComboTax.TextChanged
        If ComboTax.Text = "NO - PPN" Then
            ComboVAT.Text = Nothing
            ComboVAT.Enabled = False
            Hitungsub()
        ElseIf ComboTax.Text = "PPN" Then
            ComboVAT.Enabled = True
            ComboVAT.Text = "E"
        End If
    End Sub

    Sub Dgvautofill()
        If Status = "Kode" Then
            Try
                BarisDGV1 = 0
                BarisDGV2 = 0
#Disable Warning BC40000 ' Type or member is obsolete
                cmd = New OracleCommand("select t.kode_transaksiPR, k.nama_kategori, t.qty1, k.uom, t.qty2, k.uom_packaging, t.date_pr, t.kode_kategori from t_pr t join kategori_sparepart k on (t.kode_kategori = k.kode_kategori) where kode_transaksiPR = '" & DataGridView1.Rows(BarisDGV1).Cells(0).Value & "'", conn)
#Enable Warning BC40000 ' Type or member is obsolete
                dr = cmd.ExecuteReader()
                If DataGridView1.AllowUserToAddRows = True Then
                    While dr.Read()
                        DataGridView1.Rows.Add()
                        DataGridView1.Rows(BarisDGV1).Cells(0).Value = dr.Item(0)
                        DataGridView1.Rows(BarisDGV1).Cells(1).Value = dr.Item(1)
                        DataGridView1.Rows(BarisDGV1).Cells(2).Value = dr.Item(2)
                        DataGridView1.Rows(BarisDGV1).Cells(3).Value = dr.Item(3)
                        DataGridView1.Rows(BarisDGV1).Cells(4).Value = dr.Item(4)
                        DataGridView1.Rows(BarisDGV1).Cells(5).Value = dr.Item(5)
                        DataGridView1.Rows(BarisDGV1).Cells(8).Value = dr.Item(6)
                        DataGridView1.Rows(BarisDGV1).Cells(9).Value = dr.Item(7)
                        BarisDGV1 += 1
                    End While
                    CloseConn("all")
                    Status = "Hitung"
                End If
            Catch ex As Exception
                MsgBox(ex.Message, "Produk Tidak Ditemukan")
                Keterangan = "tocab"
            End Try
        ElseIf Status = "Hitung" Then
            Try
                For BarisDGV2 = 0 To BarisDGV1 - 1
                    DataGridView1.Rows(BarisDGV2).Cells(7).Value = DataGridView1.Rows(BarisDGV2).Cells(4).Value * DataGridView1.Rows(BarisDGV2).Cells(6).Value
                Next
                Hitungsub()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub

    Private Sub DataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyDown
        If e.KeyCode = Keys.Tab Then
            Dgvautofill()
        End If
    End Sub

    Private Sub DataGridView1_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DataGridView1.EditingControlShowing
        Keterangan = "bacot"
        Dim autoText As TextBox = TryCast(e.Control, TextBox)
        If autoText IsNot Nothing Then
            autoText.AutoCompleteMode = AutoCompleteMode.Suggest
            autoText.AutoCompleteSource = AutoCompleteSource.CustomSource
            Dim DataCollection As New AutoCompleteStringCollection()
            AddItems(DataCollection)
            autoText.AutoCompleteCustomSource = DataCollection
        End If
        'End If
    End Sub

    Public Sub AddItems(ByVal col As AutoCompleteStringCollection) 'Untuk autocomplete
#Disable Warning BC40000 ' Type or member is obsolete
        cmd = New OracleCommand("select distinct kode_transaksipr from t_pr where status_pr = 'Belum Diproses'", conn)
#Enable Warning BC40000 ' Type or member is obsolete
        dr = cmd.ExecuteReader()
        While dr.Read()
            col.Add(dr.Item(0))
        End While
        CloseConn("all")
    End Sub

    Private Sub ComboSupplier_TextChanged(sender As Object, e As EventArgs) Handles ComboSupplier.TextChanged
        Try
#Disable Warning BC40000 ' Type or member is obsolete
            cmd = New OracleCommand("select kode_supplier,contact_person,default_currency,npwp,email_kontak,desc_ap from supplier where nama_supplier = '" & ComboSupplier.Text & "'", conn)
#Enable Warning BC40000 ' Type or member is obsolete
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                dr.Read()
                KodeS = dr.Item(0)
                TxtUp.Text = dr.Item(1)
                ComboCurrency.Text = dr.Item(2)
                NPWP = dr.Item(3)
                EmailKontak = dr.Item(4)
                DescAP = dr.Item(5)
            End If
            CloseConn("all")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboVAT_TextChanged(sender As Object, e As EventArgs) Handles ComboVAT.TextChanged
        Hitung()
    End Sub
End Class

