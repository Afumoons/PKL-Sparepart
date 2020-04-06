Imports System.Data.OracleClient
Module Module1
#Disable Warning BC40000 ' Type or member is obsolete
    Public conn As New OracleConnection
#Enable Warning BC40000 ' Type or member is obsolete
#Disable Warning BC40000 ' Type or member is obsolete
    Public cmd As New OracleCommand
#Enable Warning BC40000 ' Type or member is obsolete
    Public dr As OracleDataReader
    Sub Koneksi()
        Try
            conn.Close()
            'conn = New OracleConnection("Data Source=orcl;User ID=pkl;Password=pkl;Unicode=True")
#Disable Warning BC40000 ' Type or member is obsolete
            conn = New OracleConnection("Data Source=orcl;User ID=pkl;Password=pkl;Unicode=True")
#Enable Warning BC40000 ' Type or member is obsolete
            conn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Tidak dapat terhubung ke Server", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Public Sub CloseConn(Type As String)  'Untuk close data reader dan command
        If Type = "dr" Then
            dr.Close()
        ElseIf Type = "cmd" Then
            cmd.Dispose()
        ElseIf Type = "all" Then
            dr.Close()
            cmd.Dispose()
        End If
    End Sub
End Module
