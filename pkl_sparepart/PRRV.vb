Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class PRRV
    Private Sub PRRV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim rpt As New ReportDocument
        'rpt.Load("CR_PR.rpt")
        'rpt.SetDatabaseLogon("pkl", "pkl")
        ''CrystalReportViewer1.SelectionFormula = "{tblproduksi.Tgl_Pesanan} >= '" & DateTimePicker1.Text & "' and {tblproduksi.Tgl_Pesanan} <= '" & DateTimePicker2.Text & "' and {tblproduksi.Nama_Customer} like '" & TextBox3.Text & "'"
        'CrystalReportViewer1.SelectionFormula = "{T_PR.KODE_TRANSAKSIPR} = '" & TxtKode.Text & "'"
        'CrystalReportViewer1.ReportSource = rpt

    End Sub

    Private Sub TxtKode_TextChanged(sender As Object, e As EventArgs) Handles TxtKode.TextChanged
        If TxtKode.Text.Length = 14 Then
            Dim REPORT1 As New CR_PR
            Dim isian As String = "pkl"
            REPORT1.SetDatabaseLogon(isian, isian)
            REPORT1.SetParameterValue("KodeTransaksiPR", TxtKode.Text)
            CrystalReportViewer1.ReportSource = REPORT1
            CrystalReportViewer1.RefreshReport()
        End If

        'CR_PR1.SetParameterValue(0, TxtKode)
        ''CrystalReportViewer1.ReportSource = CR_PR;

    End Sub
End Class