<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PORV
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TxtKode = New System.Windows.Forms.TextBox()
        Me.TxtST = New System.Windows.Forms.TextBox()
        Me.TxtDisc = New System.Windows.Forms.TextBox()
        Me.TxtPPN = New System.Windows.Forms.TextBox()
        Me.TxtDPP = New System.Windows.Forms.TextBox()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.CR_PO2 = New SIANSKE.CR_PO()
        Me.CR_PO1 = New SIANSKE.CR_PO()
        Me.TxtCur = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TxtKode
        '
        Me.TxtKode.Location = New System.Drawing.Point(79, 12)
        Me.TxtKode.Name = "TxtKode"
        Me.TxtKode.Size = New System.Drawing.Size(47, 20)
        Me.TxtKode.TabIndex = 1
        '
        'TxtST
        '
        Me.TxtST.Location = New System.Drawing.Point(79, 38)
        Me.TxtST.Name = "TxtST"
        Me.TxtST.Size = New System.Drawing.Size(47, 20)
        Me.TxtST.TabIndex = 2
        '
        'TxtDisc
        '
        Me.TxtDisc.Location = New System.Drawing.Point(79, 64)
        Me.TxtDisc.Name = "TxtDisc"
        Me.TxtDisc.Size = New System.Drawing.Size(47, 20)
        Me.TxtDisc.TabIndex = 3
        '
        'TxtPPN
        '
        Me.TxtPPN.Location = New System.Drawing.Point(132, 38)
        Me.TxtPPN.Name = "TxtPPN"
        Me.TxtPPN.Size = New System.Drawing.Size(47, 20)
        Me.TxtPPN.TabIndex = 5
        '
        'TxtDPP
        '
        Me.TxtDPP.Location = New System.Drawing.Point(132, 12)
        Me.TxtDPP.Name = "TxtDPP"
        Me.TxtDPP.Size = New System.Drawing.Size(47, 20)
        Me.TxtDPP.TabIndex = 4
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.CR_PO2
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'TxtCur
        '
        Me.TxtCur.Location = New System.Drawing.Point(132, 64)
        Me.TxtCur.Name = "TxtCur"
        Me.TxtCur.Size = New System.Drawing.Size(47, 20)
        Me.TxtCur.TabIndex = 6
        '
        'PORV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.TxtCur)
        Me.Controls.Add(Me.TxtPPN)
        Me.Controls.Add(Me.TxtDPP)
        Me.Controls.Add(Me.TxtDisc)
        Me.Controls.Add(Me.TxtST)
        Me.Controls.Add(Me.TxtKode)
        Me.Name = "PORV"
        Me.Text = "PORV"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CR_PO1 As CR_PO
    Friend WithEvents CR_PO2 As CR_PO
    Friend WithEvents TxtKode As TextBox
    Friend WithEvents TxtST As TextBox
    Friend WithEvents TxtDisc As TextBox
    Friend WithEvents TxtPPN As TextBox
    Friend WithEvents TxtDPP As TextBox
    Friend WithEvents TxtCur As TextBox
End Class
