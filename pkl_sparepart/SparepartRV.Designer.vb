<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SparepartRV
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
        Me.CRSparepart = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CRSparepartW = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.CR_FSparepartW1 = New SIANSKE.CR_FSparepartW()
        Me.CR_FSparepart1 = New SIANSKE.CR_FSparepart()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CRSparepart
        '
        Me.CRSparepart.ActiveViewIndex = 0
        Me.CRSparepart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRSparepart.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRSparepart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRSparepart.Location = New System.Drawing.Point(0, 0)
        Me.CRSparepart.Name = "CRSparepart"
        Me.CRSparepart.ReportSource = Me.CR_FSparepart1
        Me.CRSparepart.Size = New System.Drawing.Size(702, 426)
        Me.CRSparepart.TabIndex = 0
        Me.CRSparepart.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CRSparepart)
        Me.Panel1.Controls.Add(Me.CRSparepartW)
        Me.Panel1.Location = New System.Drawing.Point(86, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(702, 426)
        Me.Panel1.TabIndex = 1
        '
        'CRSparepartW
        '
        Me.CRSparepartW.ActiveViewIndex = 0
        Me.CRSparepartW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRSparepartW.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRSparepartW.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRSparepartW.Location = New System.Drawing.Point(0, 0)
        Me.CRSparepartW.Name = "CRSparepartW"
        Me.CRSparepartW.ReportSource = Me.CR_FSparepartW1
        Me.CRSparepartW.Size = New System.Drawing.Size(702, 426)
        Me.CRSparepartW.TabIndex = 1
        Me.CRSparepartW.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(12, 12)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(60, 17)
        Me.CheckBox1.TabIndex = 2
        Me.CheckBox1.Text = "Seleksi"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'SparepartRV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "SparepartRV"
        Me.Text = "Report"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CRSparepart As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CR_FSparepart1 As CR_FSparepart
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CRSparepartW As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CR_FSparepartW1 As CR_FSparepartW
    Friend WithEvents CheckBox1 As CheckBox
End Class
