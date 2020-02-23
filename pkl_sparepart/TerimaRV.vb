Imports CrystalDecisions.CrystalReports.Engine

Public Class TerimaRV
    Private Sub TxtKode_TextChanged(sender As Object, e As EventArgs) Handles TxtKode.TextChanged
        Dim REPORT1 As New CR_Terima
        Dim isian As String = "pkl"
        REPORT1.SetDatabaseLogon(isian, isian)
        REPORT1.SetParameterValue("KodePenerimaan", TxtKode.Text)
        CrystalReportViewer1.ReportSource = REPORT1
        CrystalReportViewer1.RefreshReport()
    End Sub

    'Private Sub TerimaRV_Load(sender As Object, e As EventArgs) Handles Me.Load
    '    Dim rpt As New ReportDocument
    '    rpt.Load("CR_Terima.rpt")
    '    rpt.SetDatabaseLogon("pkl", "pkl")
    '    CrystalReportViewer1.SelectionFormula = "{tblproduksi.Tgl_Pesanan} >= '" & DateTimePicker1.Text & "' and {tblproduksi.Tgl_Pesanan} <= '" & DateTimePicker2.Text & "' and {tblproduksi.Nama_Customer} like '" & TextBox3.Text & "'"
    '    'CrystalReportViewer1.SelectionFormula = "{tblproduksi.Tgl_Pesanan} >= '" & TextBox1.Text & "' and {tblproduksi.Tgl_Pesanan} <= '" & TextBox2.Text & "' and {tblproduksi.Nama_Customer} like '" & TextBox3.Text & "' "
    '    CrystalReportViewer1.ReportSource = rpt
    '    CrystalReportViewer1.RefreshReport()
    'End Sub
End Class