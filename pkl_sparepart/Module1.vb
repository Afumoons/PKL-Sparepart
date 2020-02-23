Imports System.Data.OracleClient
Module Module1
    Public conn As New OracleConnection
    Public cmd As New OracleCommand
    Public dr As OracleDataReader
    Sub koneksi()
        Try
            conn.Close()
            'conn = New OracleConnection("Data Source=orcl;User ID=pkl;Password=pkl;Unicode=True")
            conn = New OracleConnection("Data Source=orcl;User ID=pkl;Password=pkl;Unicode=True")
            conn.Open()
        Catch ex As Exception
        MessageBox.Show(ex.Message, "Tidak dapat terhubung ke Server", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Module
