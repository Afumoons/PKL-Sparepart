Imports System.Data.OracleClient

Public Class PengambilanBarang

    Dim anu, mantul, cb, cb1 As String
    Public statusP As String
    Public angkakirim As Integer = 0
    Private Sub PengambilanBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        Panel1.Hide()
        MessageBox.Show("Button + jika barang lama sudah terdata, Button EDIT jika barang lama belum terdata, Button .. jika hanya mengambil barang baru", "Panduan", MessageBoxButtons.OK, MessageBoxIcon.Information)

        'MsgBox("i")
        Try
            Dim bant As String = ""
            cmd = New OracleCommand("select max(to_number(substr(kode_pengambilan,4,7)))+1 from pengambilan", conn)
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                dr.Read()
                'kode = dr.Item(0)
                TxtCodePickUp.Text = dr.Item(0)
                For i As Integer = 1 To 3 - TxtCodePickUp.TextLength
                    bant += "0"
                Next
            End If
            dr.Close()
            cmd.Dispose()
            TxtCodePickUp.Text = "PUC" & bant & TxtCodePickUp.Text
        Catch ex As Exception
            '    MsgBox("aa")
            TxtCodePickUp.Text = "PUC" & "001"
        End Try
        Panel2.Hide()
        If Sparepart.status = "baru" Then
            'MsgBox("masuk")
        Else
            cmd = New OracleCommand("select * from pengambilan where status_sparepartP = 'Active'", conn)
            dr = cmd.ExecuteReader()
            LVPilih.Items.Clear()
            If dr.HasRows Then
                While dr.Read()
                    LVPilih.Items.Add(dr.Item(2))
                    LVPilih.Items(LVPilih.Items.Count - 1).SubItems.Add(dr.Item(1))
                End While
            End If
            dr.Close()
            cmd.Dispose()
        End If
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        'cmd = New OracleCommand("select * from kategori_sparepart", conn)
        'dr = cmd.ExecuteReader()
        'ListView1.Items.Clear()
        'If dr.HasRows Then
        '    While dr.Read()
        '        ListView1.Items.Add(dr.Item(0))
        '        ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(1))
        '    End While
        'End If
        'dr.Close()
        'cmd.Dispose()
        If statusP = "baru" Then
            'cmd = New OracleCommand("select * from kategori_sparepart where kode_kategori = '" & TxtKode.Text & "'", conn)
            'dr = cmd.ExecuteReader()
            'LVPilih.Items.Clear()
            'If dr.HasRows Then
            '    While dr.Read()
            '        LVPilih.Items.Add(dr.Item(0))
            '        LVPilih.Items(LVPilih.Items.Count - 1).SubItems.Add(dr.Item(1))
            '    End While
            'End If
            'dr.Close()
            'cmd.Dispose()
        Else
            'MsgBox("Masuk else")
            'cmd = New OracleCommand("select * from kategori_sparepart", conn)
            'dr = cmd.ExecuteReader()
            ''MsgBox("masuk")
            'LVPilih.Items.Clear()
            'If dr.HasRows Then
            '    While dr.Read()
            '        LVPilih.Items.Add(dr.Item(0))
            '        LVPilih.Items(LVPilih.Items.Count - 1).SubItems.Add(dr.Item(1))
            '    End While
            'End If
            'dr.Close()
            'cmd.Dispose()
            'Label4.Visible = False
            Sparepart.status = "baru"
            Me.Hide()
            angkakirim += 1
            Sparepart.angkatambah = angkakirim
            Sparepart.ShowDialog()
            TxtKode.Text = ""
            mantul = "iya"
        End If
        'cmd = New OracleCommand("SELECT * FROM SPAREPART WHERE ROWNUM = 1 AND STATUS_SPAREPART = 'Tidak Terpakai'", conn)
        'dr = cmd.ExecuteReader()
        'dr.Read()
        'Sparepart.kodeparam = dr.Item(0)
        'dr.Close()
        'cmd.Dispose()
        'TxtKode.Visible = False
        'Label4.Visible = False

        'Sparepart.status = "baru"
        'Sparepart.Show()
        'TxtKode.Text = ""
        'mantul = "iya"
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        PengambilanBarang_Load(sender, e)
        TxtCodePickUp.ReadOnly = False
        TxtKode.ReadOnly = False
    End Sub

    'BELOM BENER TABLENYA!
    Dim cek As String
    Dim aindex As Integer = -1
    Private Sub ListView1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles LVPilih.SelectedIndexChanged
        Panel2.Hide()
        'MsgBox(mantul)
        Dim coba As String
        If mantul = "iya" Then
            'Try
            '  MsgBox(LVBaru.Items.Count - 1)
            For index = aindex To LVBaru.Items.Count - 1
                'MsgBox("Masuk for bambang")
                'Try
                If index >= 0 Then
                    cek = LVBaru.Items(index).SubItems(0).Text

                    'MsgBox(cek)
                    Try
                        cmd = New OracleCommand("SELECT * FROM SPAREPART WHERE ROWNUM = 1 AND STATUS_SPAREPART = 'Tidak Terpakai' and kode_kategori = '" & LVPilih.SelectedItems(0).SubItems(0).Text & "' and kode_sparepart not like '" & cek & "'", conn)
                        dr = cmd.ExecuteReader()
                        dr.Read()
                        coba = dr.Item(0)
                        TextBox4.Text = dr.Item(0)

                    Catch ex As Exception
                        cmd = New OracleCommand("SELECT * FROM SPAREPART WHERE ROWNUM = 1 AND STATUS_SPAREPART = 'Tidak Terpakai'  and kode_kategori = '" & LVPilih.SelectedItems(0).SubItems(0).Text & "' ", conn)
                        dr = cmd.ExecuteReader()
                        dr.Read()
                        coba = dr.Item(0)
                        TextBox4.Text = dr.Item(0)
                        'MsgBox("gadisini")
                    End Try
                    'MsgBox("Try")
                ElseIf index = -1 Then
                    cmd = New OracleCommand("SELECT * FROM SPAREPART WHERE ROWNUM = 1 AND STATUS_SPAREPART = 'Tidak Terpakai'  and kode_kategori = '" & LVPilih.SelectedItems(0).SubItems(0).Text & "'", conn)
                    dr = cmd.ExecuteReader()
                    dr.Read()
                    coba = dr.Item(0)
                    'MsgBox("ex")
                    TextBox4.Text = dr.Item(0)
                    aindex += 1
                End If


                'Catch ex As Exception

                '    '   TextBox4.Text = dr.Item(0)
                'End Try
            Next
            'Sparepart.kodeparam = dr.Item(0)
            TxtKode.Text = LVPilih.SelectedItems(0).SubItems(0).Text
            CheckBox1.Text = "Terpakai"
            '   If Sparepart.status = "baru" Then
            cb = "Terpakai"
                CheckBox1.Checked = True
                CheckBox1.Enabled = False
                Panel1.Show()
                dr.Close()
                cmd.Dispose()
                anu = "s"
                'Catch ex As Exception
                '    MessageBox.Show(ex.Message, "Errror")
                'End Try
                Else
            Try
                cmd = New OracleCommand("select * from pengambilan where kode_sparepart = '" & LVPilih.SelectedItems(0).SubItems(1).Text & "'", conn)
                dr = cmd.ExecuteReader()
                dr.Read()
                TxtKode.Text = LVPilih.SelectedItems(0).SubItems(0).Text
                TextBox4.Text = dr.Item(1)
                CheckBox1.Text = "Active"
                If CheckBox1.Checked = True Then
                    cb = "Active"
                ElseIf CheckBox1.Checked = False Then
                    cb = "Non Active"
                End If
                CheckBox1.Checked = False
                CheckBox1.Enabled = False
                Panel1.Show()
                dr.Close()
                cmd.Dispose()
                anu = "s"
            Catch ex As Exception
                'MessageBox.Show(ex.Message, "Informasi Error")
            End Try
        End If
    End Sub
    'BELON BISA

    Private Sub PengambilanBarang_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control And e.KeyCode = Keys.S Then
            If anu = "s" Then
                'MsgBox(statusP + "statusp")
                If statusP = "baru" Then
                    'MsgBox(cb)
                    Dim sqlkiriman As String = "update sparepart set status_sparepart = '" & cb & "', remark_sparepart = '" & TextBox1.Text & "' where kode_sparepart = '" & TextBox4.Text & "'"
                    'cmd = New OracleCommand(sqlkiriman, conn)
                    'cmd.ExecuteNonQuery()
                    'cmd.Dispose()
                    'MsgBox(TextBox4.Text)
                    cmd = New OracleCommand("select kode_kategori,nama_kategori from kategori_sparepart where kode_kategori = '" & LVPilih.SelectedItems(0).SubItems(0).Text & "'", conn)
                    dr = cmd.ExecuteReader()
                    dr.Read()
                    LVBaru.Items.Add(TextBox4.Text)
                    LVBaru.Items(LVBaru.Items.Count - 1).SubItems.Add(dr.Item(0))
                    LVBaru.Items(LVBaru.Items.Count - 1).SubItems.Add(dr.Item(1))
                    LVBaru.Items(LVBaru.Items.Count - 1).SubItems.Add(sqlkiriman)
                    anu = "b"
                    dr.Close()
                    cmd.Dispose()
                    MessageBox.Show("Berhasil", "Informasi Proses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mantul = ""
                    statusP = Nothing
                    Panel1.Hide()
                Else
                    Dim sqlkiriman As String = "update pengambilan set status_sparepartp = '" & cb & "', remark_pengambilan = '" & TextBox1.Text & "' where kode_sparepart = '" & TextBox4.Text & "'"
                    'cmd = New OracleCommand("update pengambilan set status_sparepartp = '" & cb & "', remark_pengambilan = '" & TextBox1.Text & "' where kode_sparepart = '" & TextBox4.Text & "'", conn)
                    'cmd.ExecuteNonQuery()
                    'cmd.Dispose()
                    cmd = New OracleCommand("SELECT * FROM SPAREPART WHERE ROWNUM = 1 AND STATUS_SPAREPART = 'Tidak Terpakai' and kode_kategori = '" & LVPilih.SelectedItems(0).SubItems(0).Text & "'", conn)
                    dr = cmd.ExecuteReader()
                    dr.Read()
                    LVBaru.Items.Add(dr.Item(0))
                    dr.Close()
                    cmd.Dispose()
                    cmd = New OracleCommand("select kode_kategori,nama_kategori from kategori_sparepart where kode_kategori = '" & LVPilih.SelectedItems(0).SubItems(0).Text & "'", conn)
                    dr = cmd.ExecuteReader()
                    dr.Read()
                    Dialog1.ShowDialog()
                    If Dialog1.DialogResult = System.Windows.Forms.DialogResult.OK Then
                        LVLama.Items.Add(TextBox4.Text)
                        LVLama.Items(LVLama.Items.Count - 1).SubItems.Add(dr.Item(0))
                        LVLama.Items(LVLama.Items.Count - 1).SubItems.Add(dr.Item(1))
                    End If
                    LVBaru.Items(LVBaru.Items.Count - 1).SubItems.Add(dr.Item(0))
                    LVBaru.Items(LVBaru.Items.Count - 1).SubItems.Add(dr.Item(1))
                    LVBaru.Items(LVBaru.Items.Count - 1).SubItems.Add(sqlkiriman)
                    dr.Close()
                    cmd.Dispose()
                    MessageBox.Show("Berhasil", "Informasi Proses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mantul = ""
                    Panel1.Hide()
                End If
            End If
            TextBox3.Text = Nothing
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        For index = 0 To LVBaru.Items.Count - 1
            Try
                If mantul = "iya" Then
                Else
                    cb = "Terpakai"
                    cmd = New OracleCommand("update sparepart set status_sparepart = '" & cb & "' where kode_sparepart = '" & LVBaru.Items(index).SubItems(0).Text & "'", conn)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    MessageBox.Show("Data Terupdate", "Informasi Proses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                cb = "Active"
                cmd = New OracleCommand("insert into pengambilan values('" & TxtCodePickUp.Text & "','" & LVBaru.Items(index).SubItems(0).Text & "','" & LVBaru.Items(index).SubItems(1).Text & "','" & DateTimePicker1.Value & "','" & cb & "','" & TextBox1.Text & "')", conn)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                'update sparepart set status_sparepart ='Terpakai',remark_sparepart='blabla' where kode_sparepart=(SELECT kode_sparepart FROM SPAREPART WHERE ROWNUM = 1 AND (STATUS_SPAREPART = 'Tidak Terpakai' or STATUS_SPAREPART='Active') and kode_kategori = '" & LVPilih.SelectedItems(0).SubItems(0).Text & "'")
                Dim Sql As String = LVBaru.Items(index).SubItems(3).Text
                'MsgBox(Sql)
                cmd = New OracleCommand(Sql, conn)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                MessageBox.Show("Data Tersimpan", "Informasi Proses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Informasi Error")
            End Try
            Try
                cmd = New OracleCommand("insert into TBBaru values('" & TxtCodePickUp.Text & "','" & LVBaru.Items(index).SubItems(0).Text & "','" & LVBaru.Items(index).SubItems(0).Text & "','" & LVBaru.Items(index).SubItems(1).Text & "','" & LVBaru.Items(index).SubItems(2).Text & "')", conn)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            Catch ex As Exception
            End Try
        Next
        For index = 0 To LVLama.Items.Count - 1
            Try
                'insert into sparepart values((select COUNT(*)+1 from SPAREPART WHERE KODE_SPAREPART LIKE '%" & TxtKode.Text & "%'),'BRG01','Terpakai',blabla..)
                Dim Sql As String = LVLama.Items(index).SubItems(3).Text
                'MsgBox(Sql)
                cmd = New OracleCommand(Sql, conn)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            Catch ex As Exception
            End Try
            Try
                cmd = New OracleCommand("insert into TBLama values('" & TxtCodePickUp.Text & "','" & LVBaru.Items(index).SubItems(0).Text & "','" & LVLama.Items(index).SubItems(0).Text & "','" & LVLama.Items(index).SubItems(1).Text & "','" & LVLama.Items(index).SubItems(2).Text & "')", conn)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Informasi Error")
            End Try
        Next
        Me.Hide()
        PengambilanRV.TxtKode.Text = TxtCodePickUp.Text
        PengambilanRV.ShowDialog()
        Me.Show()
    End Sub

    Private Sub TxtKode_Click(sender As Object, e As EventArgs) Handles TxtKode.Click
        Panel2.Show()
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PengambilanRV.Show()
    End Sub
    Private Sub Panel1_KeyDown(sender As Object, e As KeyEventArgs) Handles Panel1.KeyDown
        If e.Control And e.KeyCode = Keys.S Then
            'MsgBox("hai")
        End If
    End Sub
    Private Sub PengambilanBarang_MouseHover(sender As Object, e As EventArgs) Handles Me.MouseHover
        Panel2.Hide()
    End Sub
    Private Sub TxtKode_TextChanged(sender As Object, e As EventArgs) Handles TxtKode.TextChanged
        'Panel2.Show()
        'cmd = New OracleCommand("select * from kategori_sparepart where kode_kategori like '%" & TxtKode.Text & "%' Or nama_kategori Like '%" & TxtKode.Text & "%'", conn)
        'dr = cmd.ExecuteReader()
        'ListView1.Items.Clear()

        'If dr.HasRows Then


        '    While dr.Read()
        '        ListView1.Items.Add(dr.Item(0))
        '        ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(1))
        '    End While

        'End If

        'dr.Close()
        'cmd.Dispose()

    End Sub
    'ketika udah ctrl save di yang panel kecil baru kasih ini 
    'If (ListView1.SelectedItems.Count > 0) Then


    '        TxtKode.Text = ListView1.SelectedItems(0).SubItems(0).Text
    '        'TextBox3.Text = ListView1.SelectedItems(0).SubItems(1).Text
    '        ListView2.Items.Add(ListView1.SelectedItems(0).SubItems(0).Text)
    '        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(ListView1.SelectedItems(0).SubItems(1).Text)
    '    End If
End Class