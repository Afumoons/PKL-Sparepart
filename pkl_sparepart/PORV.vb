Imports CrystalDecisions.Shared

Public Class PORV
    Private Sub TxtKode_TextChanged(sender As Object, e As EventArgs) Handles TxtKode.TextChanged
        Dim REPORT1 As New CR_PO
        Dim isian As String = "pkl"
        REPORT1.SetDatabaseLogon(isian, isian)
        REPORT1.SetParameterValue("KodeTransaksiPO", TxtKode.Text)
        REPORT1.SetParameterValue("ST", TxtST.Text)
        REPORT1.SetParameterValue("DPP", TxtDPP.Text)
        CrystalReportViewer1.ReportSource = REPORT1
        CrystalReportViewer1.RefreshReport()
    End Sub
End Class