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
#Disable Warning BC40000 ' Type or member is obsolete
            cmd = New OracleCommand("select max(to_number(substr(kode_supplier,4,7)))+1 from supplier", conn)
#Enable Warning BC40000 ' Type or member is obsolete
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                dr.Read()
                TxtKode.Text = dr.Item(0)
                For i As Integer = 1 To 4 - TxtKode.TextLength
                    bant += "0"
                Next
            End If
            dr.Close()
            cmd.Dispose()
            TxtKode.Text = "SPL" & bant & TxtKode.Text
        Catch ex As Exception
            TxtKode.Text = "SPL" & "0001"
        End Try
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
#Disable Warning BC40000 ' Type or member is obsolete
                    Dim cmd As New OracleCommand(sql, conn)
#Enable Warning BC40000 ' Type or member is obsolete
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                Catch ex As Exception

                End Try
            Next
            'Contact
            For baris = 1 To DGVContact.Rows.Count - 2
                Try
                    sql = "Insert Into supplier values ('" & TxtKode.Text & "','" & TxtNama.Text & "','" & TxtSContact.Text & "','" & TxtSAddres.Text & "','" & ComboSCity.Text & "','" & TxtSZip.Text & "','" & TxtSTelp.Text & "','" & TxtSFax.Text & "','" & ComboSGroup.Text & "','" & ComboSPGroup.Text & "','" & ComboSCurrency.Text & "','" & ComboSAccount.Text & "','" & x & "','" & TxtCatatan.Text & "','" & TxtNPWP.Text & "','" & TxtNPWPNama.Text & "','" & TxtNPWPAddress.Text & "','" & ComboNPWPPPN.Text & "','" & DGVContact.Rows(0).Cells(3).Value & "','" & DGVContact.Rows(0).Cells(0).Value & "','" & DGVContact.Rows(baris).Cells(1).Value & "','" & DGVContact.Rows(0).Cells(2).Value & "','" & DGVAP.Rows(baris).Cells(0).Value & "','" & DGVAP.Rows(baris).Cells(1).Value & "')"
#Disable Warning BC40000 ' Type or member is obsolete
                    Dim cmdd As New OracleCommand(sql, conn)
#Enable Warning BC40000 ' Type or member is obsolete
                    cmdd.ExecuteNonQuery()
                    cmdd.Dispose()
                Catch ex As Exception
                End Try
            Next
            MessageBox.Show("Berhasil menyimpan data!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Supplier_Load(sender, e)
            DGVAP.Rows.Clear()
            DGVContact.Rows.Clear()
        Catch ex As Exception
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
End Class
