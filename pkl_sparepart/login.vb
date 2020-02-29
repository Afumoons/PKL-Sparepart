Imports System.Data.OracleClient
Public Class login
    Dim user As String
    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        Try
            user = UsernameTextBox.Text
            If user = "operator" Then  'operator
#Disable Warning BC40000 ' Type or member is obsolete
                cmd = New OracleCommand("select * from user_aplikasi where username like 'op'", conn)
#Enable Warning BC40000 ' Type or member is obsolete
                dr = cmd.ExecuteReader
                If dr.HasRows Then 'Operator
                    dr.Read()
                    If PasswordTextBox.Text = dr.Item(1) Then
                        index.Panel3.Show()
                        index.Panel4.Hide()
                        index.Panel5.Hide()
                        index.Panel13.Hide()
                        index.Panel25.Hide()
                        index.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Mohon masukkan Password yang benar", "Password tidak valid", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    CloseConn("all")
                End If
            ElseIf user = "GA" Then   'GA
#Disable Warning BC40000 ' Type or member is obsolete
                cmd = New OracleCommand("select * from user_aplikasi where username like 'G'", conn)
#Enable Warning BC40000 ' Type or member is obsolete
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    dr.Read()
                    If PasswordTextBox.Text = dr.Item(1) Then
                        ' MessageBox.Show("Email")
                        index.Panel3.Show()
                        index.Panel4.Hide()
                        index.Panel5.Show()
                        index.Panel13.Hide()
                        index.Panel25.Hide()
                        index.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Mohon masukkan Password yang benar", "Password tidak valid", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    CloseConn("all")
                End If
            ElseIf user = "admin" Or user = "Admin" Then 'admin
#Disable Warning BC40000 ' Type or member is obsolete
                cmd = New OracleCommand("select * from user_aplikasi where username like '_dmin'", conn)
#Enable Warning BC40000 ' Type or member is obsolete
                dr = cmd.ExecuteReader
                MsgBox("Selamat datang Admin")
                If dr.HasRows Then
                    dr.Read()
                    MsgBox(dr.Item(1))
                    If PasswordTextBox.Text = dr.Item(1) Then
                        ' MessageBox.Show("Email")
                        index.Panel3.Show()
                        index.Panel4.Show()
                        index.Panel5.Show()
                        index.Panel13.Show()
                        index.Panel25.Hide()
                        index.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Mohon masukkan Password yang benar", "Password tidak valid", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    CloseConn("all")
                End If
            Else ' Purchasing
#Disable Warning BC40000 ' Type or member is obsolete
                cmd = New OracleCommand("select * from user_aplikasi where username like 'pur'", conn)
#Enable Warning BC40000 ' Type or member is obsolete
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    dr.Read()
                    If PasswordTextBox.Text = dr.Item(1) Then
                        'MessageBox.Show("Email")
                        index.Panel3.Show()
                        index.Panel4.Show()
                        index.Panel5.Show()
                        index.Panel13.Hide()
                        index.Panel25.Hide()
                        index.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Mohon masukkan Password yang benar", "Password tidak valid", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    CloseConn("all")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
End Class