Imports System.Data.OracleClient
Public Class KategoriSparepart
    Public anu2, anu3, anu4 As String

    Private Sub KategoriSparepart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        TxtNama.Text = "DESCRIPTION SPAREPART"
        CBItemClass.Text = Nothing
        CBSubClass.Text = Nothing
        CBUOM.Text = Nothing
        CBPackaging.Text = Nothing
        Try
            Dim bant As String = ""
#Disable Warning BC40000 ' Type or member is obsolete
            cmd = New OracleCommand("select max(to_number(substr(KODE_KATEGORI,4,7)))+1 from KATEGORI_SPAREPART", conn)
#Enable Warning BC40000 ' Type or member is obsolete

            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                dr.Read()
                TxtKode.Text = dr.Item(0)
                For i As Integer = 1 To 2 - TxtKode.TextLength
                    bant += "0"
                Next
            End If
            dr.Close()
            cmd.Dispose()
            TxtKode.Text = "BRG" & bant & TxtKode.Text
        Catch ex As Exception
            'Kode Kategori masih kosong
            TxtKode.Text = "BRG" & "01"
        End Try

    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Try
#Disable Warning BC40000 ' Type or member is obsolete
            cmd = New OracleCommand("insert into KATEGORI_SPAREPART values('" & TxtKode.Text & "','" & TxtNama.Text & "','" & CBUOM.Text & "','" & CBPackaging.Text & "','" & CBSubClass.Text & "','" & CBItemClass.Text & "','" & TxtQty.Text & "','" & TxtLeadTime.Text & "')", conn)
#Enable Warning BC40000 ' Type or member is obsolete
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            Me.Close()
            Sparepart.Show()
            MessageBox.Show("Berhasil menyimpan data!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TxtNama_DoubleClick(sender As Object, e As EventArgs) Handles TxtNama.DoubleClick
        TxtNama.Text = Nothing
    End Sub

    Private Sub CBSubClass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBSubClass.SelectedIndexChanged
        Try
            anu2 = Format(CBSubClass.SelectedItem.ToString.Substring(0, 10))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub CBSubClass_KeyDown(sender As Object, e As KeyEventArgs) Handles CBSubClass.KeyDown
        If e.KeyCode = Keys.Enter Then
            CBSubClass.Text = anu2
        End If
    End Sub

    Private Sub CBUOM_MouseClick(sender As Object, e As MouseEventArgs) Handles CBUOM.MouseClick
        CBSubClass.Text = anu2
    End Sub

    Private Sub CBUOM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBUOM.SelectedIndexChanged
        Try
            CBSubClass.Text = anu2
            anu3 = Format(CBUOM.SelectedItem.ToString.Substring(0, 10))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub CBUOM_KeyDown(sender As Object, e As KeyEventArgs) Handles CBUOM.KeyDown
        If e.KeyCode = Keys.Enter Then
            CBUOM.Text = anu3
        End If
    End Sub

    Private Sub TxtQty_ValueChanged(sender As Object, e As EventArgs) Handles TxtQty.ValueChanged
        CBPackaging.Text = anu4
    End Sub

    Private Sub CBPackaging_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBPackaging.SelectedIndexChanged
        Try
            CBUOM.Text = anu3
            anu4 = Format(CBPackaging.SelectedItem.ToString.Substring(0, 10))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TxtQty_MouseClick(sender As Object, e As MouseEventArgs) Handles TxtQty.MouseClick
        CBPackaging.Text = anu4
    End Sub

    Private Sub CBPackaging_KeyDown(sender As Object, e As KeyEventArgs) Handles CBPackaging.KeyDown
        If e.KeyCode = Keys.Enter Then
            CBPackaging.Text = anu4
        End If
    End Sub

    Private Sub TxtQty_TextChanged(sender As Object, e As EventArgs) Handles TxtQty.TextChanged
        CBPackaging.Text = anu4
    End Sub
End Class