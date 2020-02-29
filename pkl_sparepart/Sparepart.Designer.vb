<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Sparepart
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sparepart))
        Me.TxtKode = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.RbGood = New System.Windows.Forms.RadioButton()
        Me.Rb2ndGrade = New System.Windows.Forms.RadioButton()
        Me.CbStatus = New System.Windows.Forms.CheckBox()
        Me.TabBuatBarang = New System.Windows.Forms.TabControl()
        Me.TabInformasi = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtStok = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtCatatan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnCategory = New System.Windows.Forms.PictureBox()
        Me.BtnSimpan = New System.Windows.Forms.PictureBox()
        Me.BtnBack = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.TabBuatBarang.SuspendLayout()
        Me.TabInformasi.SuspendLayout()
        CType(Me.TxtStok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSimpan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtKode
        '
        Me.TxtKode.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.TxtKode.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.TxtKode.Location = New System.Drawing.Point(134, 38)
        Me.TxtKode.Name = "TxtKode"
        Me.TxtKode.ReadOnly = True
        Me.TxtKode.Size = New System.Drawing.Size(252, 27)
        Me.TxtKode.TabIndex = 1
        Me.TxtKode.Text = "Item Code"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(688, 424)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(118, 13)
        Me.Label20.TabIndex = 166
        Me.Label20.Text = "© Made by. ANSKE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(22, 39)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 17)
        Me.Label8.TabIndex = 168
        Me.Label8.Text = "Item Code"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(22, 76)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 17)
        Me.Label9.TabIndex = 169
        Me.Label9.Text = "Description"
        '
        'TxtNama
        '
        Me.TxtNama.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.TxtNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.TxtNama.Location = New System.Drawing.Point(134, 76)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.ReadOnly = True
        Me.TxtNama.Size = New System.Drawing.Size(378, 27)
        Me.TxtNama.TabIndex = 171
        Me.TxtNama.Text = "Description Sparepart"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(2)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(457, 367)
        Me.ListView1.TabIndex = 197
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Kode Sparepart"
        Me.ColumnHeader1.Width = 150
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Item Description"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 300
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ListView1)
        Me.Panel1.Location = New System.Drawing.Point(134, 64)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(457, 367)
        Me.Panel1.TabIndex = 198
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 179
        Me.Label1.Text = "Status"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(28, 94)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 13)
        Me.Label15.TabIndex = 194
        Me.Label15.Text = "Item Grade"
        '
        'RbGood
        '
        Me.RbGood.AutoSize = True
        Me.RbGood.Location = New System.Drawing.Point(110, 93)
        Me.RbGood.Margin = New System.Windows.Forms.Padding(2)
        Me.RbGood.Name = "RbGood"
        Me.RbGood.Size = New System.Drawing.Size(51, 17)
        Me.RbGood.TabIndex = 10
        Me.RbGood.TabStop = True
        Me.RbGood.Text = "Good"
        Me.RbGood.UseVisualStyleBackColor = True
        '
        'Rb2ndGrade
        '
        Me.Rb2ndGrade.AutoSize = True
        Me.Rb2ndGrade.Location = New System.Drawing.Point(162, 93)
        Me.Rb2ndGrade.Margin = New System.Windows.Forms.Padding(2)
        Me.Rb2ndGrade.Name = "Rb2ndGrade"
        Me.Rb2ndGrade.Size = New System.Drawing.Size(75, 17)
        Me.Rb2ndGrade.TabIndex = 11
        Me.Rb2ndGrade.TabStop = True
        Me.Rb2ndGrade.Text = "2nd Grade"
        Me.Rb2ndGrade.UseVisualStyleBackColor = True
        '
        'CbStatus
        '
        Me.CbStatus.AutoSize = True
        Me.CbStatus.Location = New System.Drawing.Point(110, 24)
        Me.CbStatus.Margin = New System.Windows.Forms.Padding(2)
        Me.CbStatus.Name = "CbStatus"
        Me.CbStatus.Size = New System.Drawing.Size(68, 17)
        Me.CbStatus.TabIndex = 9
        Me.CbStatus.Text = "Terpakai"
        Me.CbStatus.UseVisualStyleBackColor = True
        '
        'TabBuatBarang
        '
        Me.TabBuatBarang.Controls.Add(Me.TabInformasi)
        Me.TabBuatBarang.Location = New System.Drawing.Point(25, 139)
        Me.TabBuatBarang.Name = "TabBuatBarang"
        Me.TabBuatBarang.SelectedIndex = 0
        Me.TabBuatBarang.Size = New System.Drawing.Size(691, 160)
        Me.TabBuatBarang.TabIndex = 163
        '
        'TabInformasi
        '
        Me.TabInformasi.Controls.Add(Me.Label5)
        Me.TabInformasi.Controls.Add(Me.TxtStok)
        Me.TabInformasi.Controls.Add(Me.CbStatus)
        Me.TabInformasi.Controls.Add(Me.Label10)
        Me.TabInformasi.Controls.Add(Me.Label4)
        Me.TabInformasi.Controls.Add(Me.Rb2ndGrade)
        Me.TabInformasi.Controls.Add(Me.Label3)
        Me.TabInformasi.Controls.Add(Me.Label1)
        Me.TabInformasi.Controls.Add(Me.RbGood)
        Me.TabInformasi.Controls.Add(Me.Label15)
        Me.TabInformasi.Location = New System.Drawing.Point(4, 22)
        Me.TabInformasi.Name = "TabInformasi"
        Me.TabInformasi.Padding = New System.Windows.Forms.Padding(3)
        Me.TabInformasi.Size = New System.Drawing.Size(683, 134)
        Me.TabInformasi.TabIndex = 0
        Me.TabInformasi.Text = "Stok Level Parameter"
        Me.TabInformasi.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 62)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 197
        Me.Label5.Text = "Stok"
        '
        'TxtStok
        '
        Me.TxtStok.Location = New System.Drawing.Point(110, 60)
        Me.TxtStok.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtStok.Name = "TxtStok"
        Me.TxtStok.Size = New System.Drawing.Size(92, 20)
        Me.TxtStok.TabIndex = 196
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label10.Location = New System.Drawing.Point(16, 168)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 20)
        Me.Label10.TabIndex = 58
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(16, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 20)
        Me.Label4.TabIndex = 56
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(16, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 20)
        Me.Label3.TabIndex = 55
        '
        'TxtCatatan
        '
        Me.TxtCatatan.Location = New System.Drawing.Point(73, 314)
        Me.TxtCatatan.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtCatatan.Multiline = True
        Me.TxtCatatan.Name = "TxtCatatan"
        Me.TxtCatatan.Size = New System.Drawing.Size(641, 73)
        Me.TxtCatatan.TabIndex = 199
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 314)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 200
        Me.Label2.Text = "Remark"
        '
        'BtnCategory
        '
        Me.BtnCategory.Image = CType(resources.GetObject("BtnCategory.Image"), System.Drawing.Image)
        Me.BtnCategory.Location = New System.Drawing.Point(391, 37)
        Me.BtnCategory.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCategory.Name = "BtnCategory"
        Me.BtnCategory.Size = New System.Drawing.Size(23, 27)
        Me.BtnCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnCategory.TabIndex = 196
        Me.BtnCategory.TabStop = False
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Image = CType(resources.GetObject("BtnSimpan.Image"), System.Drawing.Image)
        Me.BtnSimpan.Location = New System.Drawing.Point(721, 11)
        Me.BtnSimpan.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(36, 43)
        Me.BtnSimpan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnSimpan.TabIndex = 192
        Me.BtnSimpan.TabStop = False
        '
        'BtnBack
        '
        Me.BtnBack.Image = CType(resources.GetObject("BtnBack.Image"), System.Drawing.Image)
        Me.BtnBack.Location = New System.Drawing.Point(759, 15)
        Me.BtnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(30, 33)
        Me.BtnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnBack.TabIndex = 164
        Me.BtnBack.TabStop = False
        '
        'Sparepart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(812, 445)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnCategory)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.TabBuatBarang)
        Me.Controls.Add(Me.TxtKode)
        Me.Controls.Add(Me.TxtCatatan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Sparepart"
        Me.Text = "Sparepart"
        Me.Panel1.ResumeLayout(False)
        Me.TabBuatBarang.ResumeLayout(False)
        Me.TabInformasi.ResumeLayout(False)
        Me.TabInformasi.PerformLayout()
        CType(Me.TxtStok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSimpan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtKode As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents BtnBack As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents BtnSimpan As PictureBox
    Friend WithEvents BtnCategory As PictureBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents RbGood As RadioButton
    Friend WithEvents Rb2ndGrade As RadioButton
    Friend WithEvents CbStatus As CheckBox
    Friend WithEvents TabBuatBarang As TabControl
    Friend WithEvents TabInformasi As TabPage
    Friend WithEvents Label10 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtCatatan As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtStok As NumericUpDown
End Class
