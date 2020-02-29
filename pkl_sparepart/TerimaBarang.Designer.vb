<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TerimaBarang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TerimaBarang))
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TxtNoPol = New System.Windows.Forms.TextBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtDNVendor = New System.Windows.Forms.TextBox()
        Me.TxtKodePO = New System.Windows.Forms.TextBox()
        Me.txtkode = New System.Windows.Forms.TextBox()
        Me.TxtNamaSupp = New System.Windows.Forms.TextBox()
        Me.TxtAlamatSupp = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtCatatan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LVKodePO = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtKD_PR = New System.Windows.Forms.TextBox()
        Me.KD_NPWP = New System.Windows.Forms.TextBox()
        Me.TxtKodeSupplier = New System.Windows.Forms.TextBox()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnPlus = New System.Windows.Forms.PictureBox()
        Me.BtnSimpan = New System.Windows.Forms.PictureBox()
        Me.BtnBack = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnPlus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSimpan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(110, 20)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(87, 20)
        Me.DateTimePicker1.TabIndex = 243
        '
        'TxtNoPol
        '
        Me.TxtNoPol.Location = New System.Drawing.Point(110, 115)
        Me.TxtNoPol.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNoPol.Name = "TxtNoPol"
        Me.TxtNoPol.Size = New System.Drawing.Size(194, 20)
        Me.TxtNoPol.TabIndex = 242
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"SPAREPART"})
        Me.ComboBox4.Location = New System.Drawing.Point(110, 43)
        Me.ComboBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(194, 21)
        Me.ComboBox4.TabIndex = 241
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(30, 117)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 13)
        Me.Label13.TabIndex = 237
        Me.Label13.Text = "No. Polisi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 93)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 236
        Me.Label4.Text = "DN Vendor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 70)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 235
        Me.Label3.Text = "PO no."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 233
        Me.Label1.Text = "Date"
        '
        'TxtDNVendor
        '
        Me.TxtDNVendor.Location = New System.Drawing.Point(110, 91)
        Me.TxtDNVendor.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtDNVendor.Name = "TxtDNVendor"
        Me.TxtDNVendor.Size = New System.Drawing.Size(194, 20)
        Me.TxtDNVendor.TabIndex = 244
        '
        'TxtKodePO
        '
        Me.TxtKodePO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtKodePO.Location = New System.Drawing.Point(110, 68)
        Me.TxtKodePO.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtKodePO.Name = "TxtKodePO"
        Me.TxtKodePO.Size = New System.Drawing.Size(194, 20)
        Me.TxtKodePO.TabIndex = 245
        '
        'txtkode
        '
        Me.txtkode.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtkode.Location = New System.Drawing.Point(385, 21)
        Me.txtkode.Margin = New System.Windows.Forms.Padding(2)
        Me.txtkode.Name = "txtkode"
        Me.txtkode.ReadOnly = True
        Me.txtkode.Size = New System.Drawing.Size(194, 20)
        Me.txtkode.TabIndex = 254
        '
        'TxtNamaSupp
        '
        Me.TxtNamaSupp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtNamaSupp.Location = New System.Drawing.Point(385, 45)
        Me.TxtNamaSupp.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNamaSupp.Name = "TxtNamaSupp"
        Me.TxtNamaSupp.ReadOnly = True
        Me.TxtNamaSupp.Size = New System.Drawing.Size(194, 20)
        Me.TxtNamaSupp.TabIndex = 253
        '
        'TxtAlamatSupp
        '
        Me.TxtAlamatSupp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtAlamatSupp.Location = New System.Drawing.Point(385, 68)
        Me.TxtAlamatSupp.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtAlamatSupp.Multiline = True
        Me.TxtAlamatSupp.Name = "TxtAlamatSupp"
        Me.TxtAlamatSupp.ReadOnly = True
        Me.TxtAlamatSupp.Size = New System.Drawing.Size(310, 63)
        Me.TxtAlamatSupp.TabIndex = 251
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(324, 47)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 248
        Me.Label5.Text = "Supplier"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(324, 24)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 247
        Me.Label6.Text = "Doc."
        '
        'TxtCatatan
        '
        Me.TxtCatatan.Location = New System.Drawing.Point(71, 353)
        Me.TxtCatatan.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtCatatan.Multiline = True
        Me.TxtCatatan.Name = "TxtCatatan"
        Me.TxtCatatan.Size = New System.Drawing.Size(656, 47)
        Me.TxtCatatan.TabIndex = 260
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 353)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 259
        Me.Label2.Text = "Remark"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(689, 424)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(118, 13)
        Me.Label20.TabIndex = 261
        Me.Label20.Text = "© Made by. ANSKE"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LVKodePO)
        Me.Panel1.Location = New System.Drawing.Point(110, 84)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(193, 70)
        Me.Panel1.TabIndex = 262
        '
        'LVKodePO
        '
        Me.LVKodePO.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.LVKodePO.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LVKodePO.HideSelection = False
        Me.LVKodePO.Location = New System.Drawing.Point(0, 0)
        Me.LVKodePO.Margin = New System.Windows.Forms.Padding(2)
        Me.LVKodePO.Name = "LVKodePO"
        Me.LVKodePO.Size = New System.Drawing.Size(193, 70)
        Me.LVKodePO.TabIndex = 0
        Me.LVKodePO.UseCompatibleStateImageBehavior = False
        Me.LVKodePO.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Kode PO"
        Me.ColumnHeader1.Width = 253
        '
        'txtKD_PR
        '
        Me.txtKD_PR.Location = New System.Drawing.Point(305, 407)
        Me.txtKD_PR.Margin = New System.Windows.Forms.Padding(2)
        Me.txtKD_PR.Name = "txtKD_PR"
        Me.txtKD_PR.Size = New System.Drawing.Size(71, 20)
        Me.txtKD_PR.TabIndex = 263
        Me.txtKD_PR.Visible = False
        '
        'KD_NPWP
        '
        Me.KD_NPWP.Location = New System.Drawing.Point(385, 406)
        Me.KD_NPWP.Margin = New System.Windows.Forms.Padding(2)
        Me.KD_NPWP.Name = "KD_NPWP"
        Me.KD_NPWP.Size = New System.Drawing.Size(71, 20)
        Me.KD_NPWP.TabIndex = 264
        Me.KD_NPWP.Visible = False
        '
        'TxtKodeSupplier
        '
        Me.TxtKodeSupplier.Location = New System.Drawing.Point(497, 419)
        Me.TxtKodeSupplier.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtKodeSupplier.Name = "TxtKodeSupplier"
        Me.TxtKodeSupplier.Size = New System.Drawing.Size(76, 20)
        Me.TxtKodeSupplier.TabIndex = 266
        Me.TxtKodeSupplier.Visible = False
        '
        'Column7
        '
        Me.Column7.HeaderText = "kode"
        Me.Column7.Name = "Column7"
        Me.Column7.Visible = False
        '
        'Column6
        '
        Me.Column6.HeaderText = "Item Description"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 400
        '
        'Column5
        '
        Me.Column5.HeaderText = "O/S PO"
        Me.Column5.Name = "Column5"
        '
        'Column4
        '
        Me.Column4.HeaderText = "UOM Code"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 130
        '
        'Column3
        '
        Me.Column3.HeaderText = "GRN Qty - 2"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 130
        '
        'Column2
        '
        Me.Column2.HeaderText = "UOM Code"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 130
        '
        'Column1
        '
        Me.Column1.HeaderText = "GRN Qty - 1"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 130
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.DataGridView1.Location = New System.Drawing.Point(9, 157)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(794, 191)
        Me.DataGridView1.TabIndex = 255
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(716, 65)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 267
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'BtnPlus
        '
        Me.BtnPlus.Image = CType(resources.GetObject("BtnPlus.Image"), System.Drawing.Image)
        Me.BtnPlus.Location = New System.Drawing.Point(778, 126)
        Me.BtnPlus.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnPlus.Name = "BtnPlus"
        Me.BtnPlus.Size = New System.Drawing.Size(25, 28)
        Me.BtnPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnPlus.TabIndex = 265
        Me.BtnPlus.TabStop = False
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Image = CType(resources.GetObject("BtnSimpan.Image"), System.Drawing.Image)
        Me.BtnSimpan.Location = New System.Drawing.Point(716, 9)
        Me.BtnSimpan.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(36, 43)
        Me.BtnSimpan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnSimpan.TabIndex = 257
        Me.BtnSimpan.TabStop = False
        '
        'BtnBack
        '
        Me.BtnBack.Image = CType(resources.GetObject("BtnBack.Image"), System.Drawing.Image)
        Me.BtnBack.Location = New System.Drawing.Point(754, 13)
        Me.BtnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(30, 33)
        Me.BtnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnBack.TabIndex = 256
        Me.BtnBack.TabStop = False
        '
        'TerimaBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(812, 445)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtKodeSupplier)
        Me.Controls.Add(Me.BtnPlus)
        Me.Controls.Add(Me.KD_NPWP)
        Me.Controls.Add(Me.txtKD_PR)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.TxtCatatan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtkode)
        Me.Controls.Add(Me.TxtNamaSupp)
        Me.Controls.Add(Me.TxtAlamatSupp)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtKodePO)
        Me.Controls.Add(Me.TxtDNVendor)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TxtNoPol)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "TerimaBarang"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnPlus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSimpan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TxtNoPol As TextBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtDNVendor As TextBox
    Friend WithEvents TxtKodePO As TextBox
    Friend WithEvents txtkode As TextBox
    Friend WithEvents TxtNamaSupp As TextBox
    Friend WithEvents TxtAlamatSupp As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnSimpan As PictureBox
    Friend WithEvents BtnBack As PictureBox
    Friend WithEvents TxtCatatan As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LVKodePO As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents txtKD_PR As TextBox
    Friend WithEvents KD_NPWP As TextBox
    Friend WithEvents BtnPlus As PictureBox
    Friend WithEvents TxtKodeSupplier As TextBox
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
End Class
