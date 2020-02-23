Public Class PengambilanRV
    Private Sub TxtKode_TextChanged(sender As Object, e As EventArgs) Handles TxtKode.TextChanged
        Dim REPORT1 As New CR_Pengambilan
        Dim isian As String = "pkl"
        REPORT1.SetDatabaseLogon(isian, isian)
        REPORT1.SetParameterValue("Kode Pengambilan", TxtKode.Text)
        CrystalReportViewer1.ReportSource = REPORT1
        CrystalReportViewer1.RefreshReport()
    End Sub
End Class