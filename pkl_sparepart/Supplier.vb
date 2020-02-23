Imports System.Data.OracleClient
Public Class Supplier

    Private Sub Supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        DGVAP.AllowUserToAddRows = False
        DGVContact.AllowUserToAddRows = False
        TxtKode.Text = ""
        TxtNama.Text = "Nama Supplier"
        TxtCatatan.Text = "Catatan Tentang Supplier Untuk Internal"
        Try
            Dim bant As String = ""
            cmd = New OracleCommand("select max(to_number(substr(kode_supplier,4,7)))+1 from supplier", conn)
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                dr.Read()
                'kode = dr.Item(0)
                TxtKode.Text = dr.Item(0)
                For i As Integer = 1 To 4 - TxtKode.TextLength
                    bant += "0"
                Next
            End If
            dr.Close()
            cmd.Dispose()
            TxtKode.Text = "SPL" & bant & TxtKode.Text
        Catch ex As Exception
            '    MsgBox("aa")
            TxtKode.Text = "SPL" & "0001"
        End Try
        'cmd = New OracleCommand("select * from supplier where kode_supplier = '" & kodeparam & "'", conn)
        'dr = cmd.ExecuteReader()
        '    If dr.HasRows = True Then
        '        If dr.Read = True Then
        '            TxtKode.Text = dr.Item(0)
        '            TxtNama.Text = dr.Item(1)
        '            TxtSatuan.Text = dr.Item(2)
        '            TxtStok.Text = dr.Item(3)
        '            TxtCatatan.Text = dr.Item(5)
        '            Try 'ada picture
        '                Dim img() As Byte
        '                img = dr.Item(4)
        '                Dim ms As New MemoryStream(img)
        '                PictureBox1.BackgroundImage = Image.FromStream(ms)
        '            Catch ex As Exception 'no picture
        '            PictureBox1.BackgroundImage = pkl_sparepart.My.Resources.Resources.Product
        '        End Try
        '        End If
        '    End If
        '    dr.Close()
        '    cmd.Dispose()
        'End If
    End Sub

    Private Sub TxtNama_DoubleClick(sender As Object, e As EventArgs) Handles TxtNama.DoubleClick
        TxtNama.Text = Nothing
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If TxtCatatan.Text = "Catatan Tentang Supplier Untuk Internal" Then
            TxtCatatan.Text = ""
        End If
        Try
            Dim sql As String
            Dim x As String
            If CheckSStatus.Checked = True Then
                x = "Aktif"
            ElseIf CheckSStatus.Checked = False Then
                x = "Non Aktif"
            End If
            'Account Payment
            For baris = 0 To DGVAP.Rows.Count - 2
                Try
                    sql = "Insert Into supplier values ('" & TxtKode.Text & "','" & TxtNama.Text & "','" & TxtSContact.Text & "','" & TxtSAddres.Text & "','" & ComboSCity.Text & "','" & TxtSZip.Text & "','" & TxtSTelp.Text & "','" & TxtSFax.Text & "','" & ComboSGroup.Text & "','" & ComboSPGroup.Text & "','" & ComboSCurrency.Text & "','" & ComboSAccount.Text & "','" & x & "','" & TxtCatatan.Text & "','" & TxtNPWP.Text & "','" & TxtNPWPNama.Text & "','" & TxtNPWPAddress.Text & "','" & ComboNPWPPPN.Text & "','" & DGVContact.Rows(baris).Cells(3).Value & "','" & DGVContact.Rows(baris).Cells(0).Value & "','" & DGVContact.Rows(baris).Cells(1).Value & "','" & DGVContact.Rows(baris).Cells(2).Value & "','" & DGVAP.Rows(0).Cells(0).Value & "','" & DGVAP.Rows(0).Cells(1).Value & "')"
                    Dim cmd As New OracleCommand(sql, conn)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                Catch ex As Exception

                End Try
            Next
            'Contact
            For baris = 1 To DGVContact.Rows.Count - 2
                Try
                    sql = "Insert Into supplier values ('" & TxtKode.Text & "','" & TxtNama.Text & "','" & TxtSContact.Text & "','" & TxtSAddres.Text & "','" & ComboSCity.Text & "','" & TxtSZip.Text & "','" & TxtSTelp.Text & "','" & TxtSFax.Text & "','" & ComboSGroup.Text & "','" & ComboSPGroup.Text & "','" & ComboSCurrency.Text & "','" & ComboSAccount.Text & "','" & x & "','" & TxtCatatan.Text & "','" & TxtNPWP.Text & "','" & TxtNPWPNama.Text & "','" & TxtNPWPAddress.Text & "','" & ComboNPWPPPN.Text & "','" & DGVContact.Rows(0).Cells(3).Value & "','" & DGVContact.Rows(0).Cells(0).Value & "','" & DGVContact.Rows(baris).Cells(1).Value & "','" & DGVContact.Rows(0).Cells(2).Value & "','" & DGVAP.Rows(baris).Cells(0).Value & "','" & DGVAP.Rows(baris).Cells(1).Value & "')"
                    Dim cmdd As New OracleCommand(sql, conn)
                    cmdd.ExecuteNonQuery()
                    cmdd.Dispose()
                Catch ex As Exception
                    'baris += 1
                    'sql = "Insert Into supplier values ('" & TxtKode.Text & "','" & TxtNama.Text & "','" & TxtSContact.Text & "','" & TxtSAddres.Text & "','" & ComboSCity.Text & "','" & TxtSZip.Text & "','" & TxtSTelp.Text & "','" & TxtSFax.Text & "','" & ComboSGroup.Text & "','" & ComboSPGroup.Text & "','" & ComboSCurrency.Text & "','" & ComboSAccount.Text & "','" & x & "','" & TxtCatatan.Text & "','" & TxtNPWP.Text & "','" & TxtNPWPNama.Text & "','" & TxtNPWPAddress.Text & "','" & ComboNPWPPPN.Text & "','" & DGVContact.Rows(0).Cells(3).Value & "','" & DGVContact.Rows(0).Cells(0).Value & "','" & DGVContact.Rows(baris).Cells(1).Value & "','" & DGVContact.Rows(0).Cells(2).Value & "','" & DGVAP.Rows(baris).Cells(0).Value & "','" & DGVAP.Rows(baris).Cells(1).Value & "')"
                    'Dim cmdd As New OracleCommand(sql, conn)
                    'cmdd.ExecuteNonQuery()
                    'cmdd.Dispose()
                End Try
            Next
            MessageBox.Show("Berhasil menyimpan data!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Supplier_Load(sender, e)
            DGVAP.Rows.Clear()
            DGVContact.Rows.Clear()
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "Maaf, tidak dapat menyimpan data", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        DGVAP.AllowUserToAddRows = True
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        DGVContact.AllowUserToAddRows = True
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub
    'Public Sub FuncKeysModule(ByVal value As Keys)
    '    Select Case value
    '        Case Keys.Control + Keys.S

    '            MsgBox("hay")


    '    End Select

    'End Sub

    'Private Sub Supplier_KeyDown1(ByValsender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
    '    If e.Control And e.KeyCode = Keys.S Then
    '        MsgBox("hay")
    '    Else

    '    End If
    'End Sub
    'Private Sub Supplier_KeyDown2(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
    '    If e.KeyCode = Keys.ControlKey Then
    '        MsgBox("aa")
    '    End If
    'End Sub
End Class

'Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
'    If TxtCatatan.Text = "Catatan Tentang Supplier Untuk Internal" Then
'        TxtCatatan.Text = ""
'    End If
'    'Try
'    Dim sql As String
'    Dim x As String
'    If CheckSStatus.Checked = True Then
'        x = "Aktif"
'    ElseIf CheckSStatus.Checked = False Then
'        x = "Non Aktif"
'    End If
'    sql = "Insert Into supplier values ('" & TxtKode.Text & "','" & TxtSContact.Text & "','" & TxtSAddres.Text & "','" & ComboSCity.Text & "','" & TxtSZip.Text & "','" & TxtSTelp.Text & "','" & TxtSFax.Text & "','" & ComboSGroup.Text & "','" & ComboSPGroup.Text & "','" & TxtCatatan.Text & "','" & x & "')"
'    Dim cmdd As New OracleCommand(sql, conn)
'    cmdd.ExecuteNonQuery()
'    cmdd.Dispose()
'    sql = "Insert Into npwp values ('" & TxtNPWPNama.Text & "','" & TxtNPWP.Text & "','" & TxtKode.Text & "','" & TxtNPWPAddress.Text & "','" & ComboNPWPPPN.Text & "')"
'    Dim cmddd As New OracleCommand(sql, conn)
'    cmddd.ExecuteNonQuery()
'    cmddd.Dispose()
'    For baris = 0 To DGVAP.Rows.Count - 2
'        sql = "Insert Into Payment values ('" & DGVAP.Rows(baris).Cells(0).Value & "','" & TxtKode.Text & "','" & DGVAP.Rows(baris).Cells(1).Value & "')"
'        Dim cmd As New OracleCommand(sql, conn)
'        cmd.ExecuteNonQuery()
'        cmd.Dispose()
'    Next

'    For baris = 0 To DGVContact.Rows.Count - 2
'        sql = "Insert Into Kontak values ('" & DGVContact.Rows(baris).Cells(3).Value & "','" & TxtKode.Text & "','" & DGVContact.Rows(baris).Cells(0).Value & "','" & DGVContact.Rows(baris).Cells(1).Value & "','" & DGVContact.Rows(baris).Cells(2).Value & "')"
'        Dim cmd As New OracleCommand(sql, conn)
'        cmd.ExecuteNonQuery()
'        cmd.Dispose()
'    Next
'    MessageBox.Show("Berhasil menyimpan data!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
'    'Catch ex As Exception
'    '    MessageBox.Show(ex.Message, "Maaf, tidak dapat menyimpan data", MessageBoxButtons.OK, MessageBoxIcon.Information)
'    'End Try
'End Sub
