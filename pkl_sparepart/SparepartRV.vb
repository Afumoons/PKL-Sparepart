Public Class SparepartRV


    Private Sub SparepartRV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If CheckBox1.Checked = True Then
            CRSparepartW.Show()
            CRSparepart.Hide()
            Dim REPORT1 As New CR_FSparepartW
            Dim isian As String = "pkl"
            REPORT1.SetDatabaseLogon(isian, isian)
            CRSparepartW.ReportSource = REPORT1
            CRSparepartW.RefreshReport()
        ElseIf CheckBox1.Checked = False Then
            CRSparepart.Show()
            CRSparepartW.Hide()
            Dim REPORT1 As New CR_FSparepart
            Dim isian As String = "pkl"
            REPORT1.SetDatabaseLogon(isian, isian)
            CRSparepart.ReportSource = REPORT1
            CRSparepart.RefreshReport()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Me.SparepartRV_Load(sender, e)
    End Sub
End Class