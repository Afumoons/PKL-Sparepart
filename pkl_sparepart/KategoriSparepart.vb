Imports System.Data.OracleClient
Public Class KategoriSparepart
    Private Sub KategoriSparepart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        TxtNama.Text = "DESCRIPTION SPAREPART"
        ComboBox1.Text = Nothing
        ComboBox2.Text = Nothing
        ComboBox3.Text = Nothing
        ComboBox4.Text = Nothing
        Try

            Dim bant As String = ""
            'cmd = New OracleCommand("select case when max(convert(decimal,substring(KODE_SPAREPART,4,15))) is null then '1' else max(convert(decimal,substring(KODE_SPAREPART,4,15)))+1 end kodee from SPAREPART;", conn)
            cmd = New OracleCommand("select max(to_number(substr(KODE_KATEGORI,4,7)))+1 from KATEGORI_SPAREPART", conn)

            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                dr.Read()

                'kode = dr.Item(0)
                TxtKode.Text = dr.Item(0)
                For i As Integer = 1 To 2 - TxtKode.TextLength
                    bant += "0"
                Next
            End If
            dr.Close()
            cmd.Dispose()
            TxtKode.Text = "BRG" & bant & TxtKode.Text
        Catch ex As Exception
            '    MsgBox("aa")
            TxtKode.Text = "BRG" & "01"
        End Try

    End Sub

    Private Sub Btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        Try
            cmd = New OracleCommand("insert into KATEGORI_SPAREPART values('" & TxtKode.Text & "','" & TxtNama.Text & "','" & ComboBox3.Text & "','" & ComboBox4.Text & "','" & ComboBox2.Text & "','" & ComboBox1.Text & "','" & TextBox3.Text & "','" & TextBox1.Text & "')", conn)
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
    Public anu2, anu3, anu4 As String
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Try
            'MsgBox(ComboBox2.SelectedItem)
            anu2 = Format(ComboBox2.SelectedItem.ToString.Substring(0, 10))
            'MsgBox(anu)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ComboBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            ComboBox2.Text = anu2

        End If
    End Sub

    Private Sub ComboBox3_MouseClick(sender As Object, e As MouseEventArgs) Handles ComboBox3.MouseClick
        ComboBox2.Text = anu2

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Try
            ComboBox2.Text = anu2
            anu3 = Format(ComboBox3.SelectedItem.ToString.Substring(0, 10))
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ComboBox3_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox3.KeyDown
        If e.KeyCode = Keys.Enter Then
            ComboBox3.Text = anu3

        End If
    End Sub
    Private Sub TextBox3_ValueChanged(sender As Object, e As EventArgs) Handles TextBox3.ValueChanged
        ComboBox4.Text = anu4
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        Try
            ComboBox3.Text = anu3
            anu4 = Format(ComboBox4.SelectedItem.ToString.Substring(0, 10))
        Catch ex As Exception

        End Try

    End Sub

    Private Sub TextBox3_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox3.MouseClick
        ComboBox4.Text = anu4
    End Sub
    Private Sub ComboBox4_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox4.KeyDown
        If e.KeyCode = Keys.Enter Then
            ComboBox4.Text = anu4

        End If

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        ComboBox4.Text = anu4
    End Sub
End Class