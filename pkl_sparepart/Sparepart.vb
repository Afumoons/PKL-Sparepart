Imports System.Data.OracleClient
Public Class Sparepart
    Public status, kodeparam As String
    Dim hitung As Integer
    Dim radio, kdSP, cb As String
    Public angkatambah As Integer = 1

    Private Sub Sparepart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        Panel1.Hide()
        If status = "edit" Then
            PictureBox1.Hide()
            CheckBox1.Checked = True
            CheckBox1.Enabled = False
            NumericUpDown2.Value = 1
            NumericUpDown2.ReadOnly = True
            cmd = New OracleCommand("select * from sparepart where kode_sparepart ='" & kodeparam & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            TxtKode.Text = dr.Item(0)
            TxtNama.Text = dr.Item(1)
            TxtCatatan.Text = dr.Item(4)
        ElseIf status = "baru" Then
            PictureBox1.Hide()
            CheckBox1.Checked = True
            CheckBox1.Enabled = False
            NumericUpDown2.Value = 1
            NumericUpDown2.ReadOnly = True
        Else
            CheckBox1.Checked = False
            CheckBox1.Enabled = False
        End If
        cmd = New OracleCommand("select * from KATEGORI_SPAREPART", conn)
        dr = cmd.ExecuteReader()
        ListView1.Items.Clear()
        If dr.HasRows Then
            While dr.Read()
                ListView1.Items.Add(dr.Item(0))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(1))
            End While
        End If
        dr.Close()
        cmd.Dispose()
        'Try

        '    Dim bant As String = ""
        '    'cmd = New OracleCommand("select case when max(convert(decimal,substring(KODE_SPAREPART,4,15))) is null then '1' else max(convert(decimal,substring(KODE_SPAREPART,4,15)))+1 end kodee from SPAREPART;", conn)
        '    cmd = New OracleCommand("select max(to_number(substr(kode_sparepart,4,7)))+1 from sparepart", conn)

        '    dr = cmd.ExecuteReader()
        '    If dr.HasRows Then
        '        dr.Read()

        '        'kode = dr.Item(0)
        '        TxtKode.Text = dr.Item(0)
        '        For i As Integer = 1 To 4 - TxtKode.TextLength
        '            bant += "0"
        '        Next
        '    End If
        '    dr.Close()
        '    cmd.Dispose()
        '    TxtKode.Text = "BRG" & bant & TxtKode.Text
        'Catch ex As Exception
        '    '    MsgBox("aa")
        '    TxtKode.Text = "BRG" & "0001"
        'End Try
        ' ComboBox2.Text = anu
    End Sub

    Private Sub Btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If TxtCatatan.Text = "Catatan Tentang Produk Untuk Internal" Then
            TxtCatatan.Text = ""
        End If
        Try
            If CheckBox1.Checked = True Then
                cb = "Terpakai"
            Else
                cb = "Tidak Terpakai"
            End If
            If RadioButton1.Checked = True Then
                radio = "Good"
            ElseIf RadioButton2.Checked = True Then
                radio = "2nd Grade"

            End If
            If status = "edit" Then
                cmd = New OracleCommand("update sparepart set status_sparepart = '" & CheckBox1.Text & "', remark_sparepart = '" & TxtCatatan.Text & "' where kode_sparepart = '" & kodeparam & "'", conn)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                PengambilanBarang.LVBaru.Items.Add(TxtKode.Text)
                PengambilanBarang.LVBaru.Items(PengambilanBarang.LVBaru.Items.Count - 1).SubItems.Add(kodeparam)
                PengambilanBarang.LVBaru.Items(PengambilanBarang.LVBaru.Items.Count - 1).SubItems.Add(TxtNama.Text)
            ElseIf status = "baru" Then
                MsgBox("Baru")
                CountSparepartWhere()
                Dim sqlkiriman As String = "insert into SPAREPART values('" & kdSP & "','" & TxtKode.Text & "','" & cb & "','" & radio & "','" & TxtCatatan.Text & "')"
                'cmd = New OracleCommand(sqlkiriman, conn)
                'cmd.ExecuteNonQuery()
                'cmd.Dispose()
                PengambilanBarang.LVLama.Items.Add(kdSP)
                PengambilanBarang.LVLama.Items(PengambilanBarang.LVLama.Items.Count - 1).SubItems.Add(TxtKode.Text)
                PengambilanBarang.LVLama.Items(PengambilanBarang.LVLama.Items.Count - 1).SubItems.Add(TxtNama.Text)
                PengambilanBarang.LVLama.Items(PengambilanBarang.LVLama.Items.Count - 1).SubItems.Add(sqlkiriman)
                'PengambilanBarang.ListView2.Items.Add(TxtKode.Text)
                'PengambilanBarang.ListView2.Items(PengambilanBarang.ListView2.Items.Count - 1).SubItems.Add(TxtNama.Text)
                PengambilanBarang.statusP = "baru"
                cmd = New OracleCommand("select * from kategori_sparepart where kode_kategori = '" & TxtKode.Text & "'", conn)
                dr = cmd.ExecuteReader()
                PengambilanBarang.LVPilih.Items.Clear()
                If dr.HasRows Then
                    'MsgBox("js")
                    While dr.Read()
                        PengambilanBarang.LVPilih.Items.Add(dr.Item(0))
                        PengambilanBarang.LVPilih.Items(PengambilanBarang.LVPilih.Items.Count - 1).SubItems.Add(dr.Item(1))
                    End While
                End If
                dr.Close()
                cmd.Dispose()
                PengambilanBarang.Show()
            Else
                For p = 1 To CInt(NumericUpDown2.Text)
                    CountSparepartWhere()
                    Dim sql As String = "insert into SPAREPART values('" & kdSP & "','" & TxtKode.Text & "','" & cb & "','" & radio & "','" & TxtCatatan.Text & "')"
                    cmd = New OracleCommand(sql, conn)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                Next

            End If
            MessageBox.Show("Data Tersimpan", "Informasi Proses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            'Sparepart_Load(sender, e) 'gausah
            'uji coba
            '''''Dim sql As String = "insert into SPAREPART values('" & kdSP & "','" & TxtKode.Text & "','" & TxtNama.Text & "','" & ComboBox3.Text & "','" & ComboBox4.Text & "','" & ComboBox2.Text & "','" & ComboBox1.Text & "','" & CheckBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TxtCatatan.Text & "','" & radio & "','" & TxtCatatan.Text & "')"
            '''''cmd = New OracleCommand(sql, conn)
            '''''cmd.ExecuteNonQuery()
            '''''cmd.Dispose()
            '        MsgBox("Pembuatan/Penambahan Sukses")
            '        Me.Close()
            '        'Index.Panel6.Hide()
            '        'Produk.refreshtbl()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Maaf, tidak dapat menyimpan data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Sub CountSparepartWhere()
        Try
            Dim bantT As String = ""
            cmd = New OracleCommand("select COUNT(*) from SPAREPART WHERE KODE_SPAREPART LIKE '%" & TxtKode.Text & "%'", conn)
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                dr.Read()
                'kode = dr.Item(0)
                kdSP = dr.Item(0)
                kdSP += angkatambah
                For i As Integer = 1 To 3 - kdSP.Length
                    bantT += "0"
                Next
            End If
            dr.Close()
            cmd.Dispose()
            kdSP = TxtKode.Text & bantT & kdSP
        Catch ex As Exception
            'kdSP = "001"
        End Try
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        KategoriSparepart.ShowDialog()
    End Sub
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If (ListView1.SelectedItems.Count > 0) Then
            TxtKode.Text = ListView1.SelectedItems(0).SubItems(0).Text
            TxtNama.Text = ListView1.SelectedItems(0).SubItems(1).Text
        End If
        Panel1.Hide()
    End Sub
    Private Sub TxtKode_Click(sender As Object, e As EventArgs) Handles TxtKode.Click
        Sparepart_Load(sender, e)
        Panel1.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub Sparepart_MouseHover(sender As Object, e As EventArgs) Handles Me.MouseHover
        Panel1.Hide()
    End Sub
    Private Sub TxtCatatan_DoubleClick(sender As Object, e As EventArgs) Handles TxtCatatan.DoubleClick
        TxtCatatan.Text = Nothing
    End Sub

    Private Sub NumericUpDown2_TextChanged(sender As Object, e As EventArgs) Handles NumericUpDown2.TextChanged
        If status = "baru" Then
            NumericUpDown2.Text = 1
        End If
    End Sub
End Class
'Dim kode As Integer

'Private Sub Sparepart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'    
'    TxtKode.Text = ""
'    'Index.buka = "tutup"

'If status = "Buat" Then

'    TxtNama.Text = "Nama Produk"
'        TxtSatuan.Text = Nothing
'        TxtStok.Text = "0"
'        TxtCatatan.Text = "Catatan Tentang Produk Untuk Internal"
'    Try

'        Dim bant As String = ""
'        'cmd = New OracleCommand("Select Case When max(convert(Decimal, substring(KODE_SPAREPART, 4, 15))) Is null Then '1' else max(convert(decimal,substring(KODE_SPAREPART,4,15)))+1 end kodee from SPAREPART;", conn)
'        cmd = New OracleCommand("select max(to_number(substr(kode_sparepart,4,7)))+1 from sparepart", conn)

'        'Case [ expression ]

'        'WHEN condition_1 THEN result_1
'        'WHEN condition_2 THEN result_2
'        '...
'        'WHEN condition_n THEN result_n
'        '   Else result

'        'End

'        dr = cmd.ExecuteReader()
'        If dr.HasRows Then
'            dr.Read()

'            'kode = dr.Item(0)
'            TxtKode.Text = dr.Item(0)
'            For i As Integer = 1 To 4 - TxtKode.TextLength
'                bant += "0"
'            Next
'        End If
'        dr.Close()
'        cmd.Dispose()
'        TxtKode.Text = "BRG" & bant & TxtKode.Text
'    Catch ex As Exception
'        '    MsgBox("aa")
'        TxtKode.Text = "BRG" & "0001"
'    End Try
'    'cmd = New OracleCommand("select * from Produk where kode_produk = '" & kodeparam & "'", conn)
'    'dr = cmd.ExecuteReader()
'    '    If dr.HasRows = True Then
'    '        If dr.Read = True Then
'    '            TxtKode.Text = dr.Item(0)
'    '            TxtNama.Text = dr.Item(1)
'    '            TxtSatuan.Text = dr.Item(2)
'    '            TxtStok.Text = dr.Item(3)
'    '            TxtCatatan.Text = dr.Item(5)
'    '            Try 'ada picture
'    '                Dim img() As Byte
'    '                img = dr.Item(4)
'    '                Dim ms As New MemoryStream(img)
'    '                PictureBox1.BackgroundImage = Image.FromStream(ms)
'    '            Catch ex As Exception 'no picture
'    '            PictureBox1.BackgroundImage = pkl_sparepart.My.Resources.Resources.Product
'    '        End Try
'    '        End If
'    '    End If
'    '    dr.Close()
'    '    cmd.Dispose()
'    'End If
'End Sub

'Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
'    If TxtCatatan.Text = "Catatan Tentang Produk Untuk Internal" Then
'        TxtCatatan.Text = ""
'    End If
'    Try

'        Dim sql As String = "insert into SPAREPART values('" & TxtKode.Text & "','" & TxtNama.Text & "','" & TxtSatuan.Text & "','" & txtsatuanpack.Text & "','" & txttype.Text & "','" & txtclass.Text & "','" & txtstatus.Text & "','" & TxtStok.Text & "')"
'        cmd = New OracleCommand(sql, conn)


'        cmd.ExecuteNonQuery()
'        cmd.Dispose()

'        MsgBox("Pembuatan/Penambahan Sukses")
'        Me.Close()
'        'Index.Panel6.Hide()
'        'Produk.refreshtbl()
'    Catch ex As Exception
'        MessageBox.Show(ex.Message, "Maaf, tidak dapat menyimpan data", MessageBoxButtons.OK, MessageBoxIcon.Information)
'    End Try
'End Sub