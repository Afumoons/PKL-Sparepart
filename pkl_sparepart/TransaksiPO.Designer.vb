<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TransaksiPO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TransaksiPO))
        Me.Label27 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Detail = New System.Windows.Forms.TabControl()
        Me.TxtDPPersen = New System.Windows.Forms.TabPage()
        Me.TxtDiscountP = New System.Windows.Forms.TextBox()
        Me.TxtSubTotal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.TxtPPN = New System.Windows.Forms.TextBox()
        Me.TxtDPP = New System.Windows.Forms.TextBox()
        Me.TxtDiscountA = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox21 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TxtCatatan = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TxtUp = New System.Windows.Forms.TextBox()
        Me.TxtKode = New System.Windows.Forms.TextBox()
        Me.ComboTerm = New System.Windows.Forms.ComboBox()
        Me.ComboCurrency = New System.Windows.Forms.ComboBox()
        Me.ComboTax = New System.Windows.Forms.ComboBox()
        Me.ComboShipping = New System.Windows.Forms.ComboBox()
        Me.ComboVAT = New System.Windows.Forms.ComboBox()
        Me.ComboEntity = New System.Windows.Forms.ComboBox()
        Me.ComboPOType = New System.Windows.Forms.ComboBox()
        Me.ComboPOType2 = New System.Windows.Forms.ComboBox()
        Me.ComboSupplier = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.PictureBox()
        Me.BtnAdd = New System.Windows.Forms.PictureBox()
        Me.BtnBack = New System.Windows.Forms.PictureBox()
        Me.Detail.SuspendLayout()
        Me.TxtDPPersen.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.BtnSimpan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(685, 423)
        Me.Label27.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(118, 13)
        Me.Label27.TabIndex = 319
        Me.Label27.Text = "© Made by. ANSKE"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(90, 8)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(87, 20)
        Me.DateTimePicker1.TabIndex = 317
        '
        'Detail
        '
        Me.Detail.Controls.Add(Me.TxtDPPersen)
        Me.Detail.Controls.Add(Me.TabPage2)
        Me.Detail.Location = New System.Drawing.Point(9, 126)
        Me.Detail.Margin = New System.Windows.Forms.Padding(2)
        Me.Detail.Name = "Detail"
        Me.Detail.SelectedIndex = 0
        Me.Detail.Size = New System.Drawing.Size(794, 292)
        Me.Detail.TabIndex = 314
        '
        'TxtDPPersen
        '
        Me.TxtDPPersen.Controls.Add(Me.BtnAdd)
        Me.TxtDPPersen.Controls.Add(Me.TxtDiscountP)
        Me.TxtDPPersen.Controls.Add(Me.TxtSubTotal)
        Me.TxtDPPersen.Controls.Add(Me.Label6)
        Me.TxtDPPersen.Controls.Add(Me.TxtTotal)
        Me.TxtDPPersen.Controls.Add(Me.TxtPPN)
        Me.TxtDPPersen.Controls.Add(Me.TxtDPP)
        Me.TxtDPPersen.Controls.Add(Me.TxtDiscountA)
        Me.TxtDPPersen.Controls.Add(Me.Label8)
        Me.TxtDPPersen.Controls.Add(Me.Label9)
        Me.TxtDPPersen.Controls.Add(Me.Label15)
        Me.TxtDPPersen.Controls.Add(Me.Label17)
        Me.TxtDPPersen.Controls.Add(Me.DataGridView1)
        Me.TxtDPPersen.Location = New System.Drawing.Point(4, 22)
        Me.TxtDPPersen.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtDPPersen.Name = "TxtDPPersen"
        Me.TxtDPPersen.Padding = New System.Windows.Forms.Padding(2)
        Me.TxtDPPersen.Size = New System.Drawing.Size(786, 266)
        Me.TxtDPPersen.TabIndex = 0
        Me.TxtDPPersen.Text = "Detail"
        Me.TxtDPPersen.UseVisualStyleBackColor = True
        '
        'TxtDiscountP
        '
        Me.TxtDiscountP.Location = New System.Drawing.Point(492, 172)
        Me.TxtDiscountP.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtDiscountP.Name = "TxtDiscountP"
        Me.TxtDiscountP.Size = New System.Drawing.Size(62, 20)
        Me.TxtDiscountP.TabIndex = 246
        Me.TxtDiscountP.Text = "0%"
        '
        'TxtSubTotal
        '
        Me.TxtSubTotal.Location = New System.Drawing.Point(556, 152)
        Me.TxtSubTotal.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtSubTotal.Name = "TxtSubTotal"
        Me.TxtSubTotal.ReadOnly = True
        Me.TxtSubTotal.Size = New System.Drawing.Size(179, 20)
        Me.TxtSubTotal.TabIndex = 242
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(428, 155)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 241
        Me.Label6.Text = "Sub Total"
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(556, 230)
        Me.TxtTotal.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(179, 20)
        Me.TxtTotal.TabIndex = 240
        '
        'TxtPPN
        '
        Me.TxtPPN.Location = New System.Drawing.Point(556, 211)
        Me.TxtPPN.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPPN.Name = "TxtPPN"
        Me.TxtPPN.ReadOnly = True
        Me.TxtPPN.Size = New System.Drawing.Size(179, 20)
        Me.TxtPPN.TabIndex = 239
        '
        'TxtDPP
        '
        Me.TxtDPP.Location = New System.Drawing.Point(556, 191)
        Me.TxtDPP.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtDPP.Name = "TxtDPP"
        Me.TxtDPP.ReadOnly = True
        Me.TxtDPP.Size = New System.Drawing.Size(179, 20)
        Me.TxtDPP.TabIndex = 238
        '
        'TxtDiscountA
        '
        Me.TxtDiscountA.Location = New System.Drawing.Point(556, 172)
        Me.TxtDiscountA.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtDiscountA.Name = "TxtDiscountA"
        Me.TxtDiscountA.ReadOnly = True
        Me.TxtDiscountA.Size = New System.Drawing.Size(179, 20)
        Me.TxtDiscountA.TabIndex = 237
        Me.TxtDiscountA.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(427, 233)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 234
        Me.Label8.Text = "Total"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(427, 213)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 13)
        Me.Label9.TabIndex = 233
        Me.Label9.Text = "PPN"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(428, 194)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(29, 13)
        Me.Label15.TabIndex = 232
        Me.Label15.Text = "DPP"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(428, 174)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(49, 13)
        Me.Label17.TabIndex = 231
        Me.Label17.Text = "Discount"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
        Me.DataGridView1.Location = New System.Drawing.Point(2, 2)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(783, 135)
        Me.DataGridView1.TabIndex = 218
        '
        'Column1
        '
        Me.Column1.HeaderText = "PR #"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 200
        '
        'Column2
        '
        Me.Column2.HeaderText = "Item Description"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 350
        '
        'Column3
        '
        Me.Column3.HeaderText = "Qty - 1"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "UOM Code"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Qty - 2"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Uom Code"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Item Price"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 150
        '
        'Column8
        '
        Me.Column8.HeaderText = "Total"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 150
        '
        'Column9
        '
        Me.Column9.HeaderText = "Sch Date"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 150
        '
        'Column10
        '
        Me.Column10.HeaderText = "Kode Kategori"
        Me.Column10.Name = "Column10"
        Me.Column10.Visible = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TextBox1)
        Me.TabPage2.Controls.Add(Me.TextBox21)
        Me.TabPage2.Controls.Add(Me.Label20)
        Me.TabPage2.Controls.Add(Me.Label19)
        Me.TabPage2.Controls.Add(Me.TxtCatatan)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Size = New System.Drawing.Size(786, 266)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Notes Purchase Order"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(109, 117)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(56, 20)
        Me.TextBox1.TabIndex = 225
        Me.TextBox1.Text = "LCL02"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox21
        '
        Me.TextBox21.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox21.Location = New System.Drawing.Point(14, 141)
        Me.TextBox21.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox21.Multiline = True
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.ReadOnly = True
        Me.TextBox21.Size = New System.Drawing.Size(758, 113)
        Me.TextBox21.TabIndex = 224
        Me.TextBox21.Text = resources.GetString("TextBox21.Text")
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(12, 121)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(82, 13)
        Me.Label20.TabIndex = 223
        Me.Label20.Text = "Template Notes"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(11, 11)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(64, 13)
        Me.Label19.TabIndex = 222
        Me.Label19.Text = "PO Remaks"
        '
        'TxtCatatan
        '
        Me.TxtCatatan.Location = New System.Drawing.Point(14, 27)
        Me.TxtCatatan.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtCatatan.Multiline = True
        Me.TxtCatatan.Name = "TxtCatatan"
        Me.TxtCatatan.Size = New System.Drawing.Size(758, 87)
        Me.TxtCatatan.TabIndex = 33
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(541, 82)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(43, 13)
        Me.Label21.TabIndex = 313
        Me.Label21.Text = "V. A. T."
        '
        'TxtUp
        '
        Me.TxtUp.Location = New System.Drawing.Point(90, 103)
        Me.TxtUp.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtUp.Name = "TxtUp"
        Me.TxtUp.ReadOnly = True
        Me.TxtUp.Size = New System.Drawing.Size(225, 20)
        Me.TxtUp.TabIndex = 312
        '
        'TxtKode
        '
        Me.TxtKode.Location = New System.Drawing.Point(434, 10)
        Me.TxtKode.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtKode.Name = "TxtKode"
        Me.TxtKode.ReadOnly = True
        Me.TxtKode.Size = New System.Drawing.Size(215, 20)
        Me.TxtKode.TabIndex = 311
        '
        'ComboTerm
        '
        Me.ComboTerm.FormattingEnabled = True
        Me.ComboTerm.Items.AddRange(New Object() {"45 DAYS", "50 DAYS", "60 DAYS", "7 DAYS", "75 DAYS", "90 DAYS", "CASH", "CEK", "FIRE OF CHARGE", "GIRO 14 HARI", "GIRO 30 HARI", "GIRO 60 HARI", "LETTER OF CREDIT", "NO TERM", "TT IN ADVANCE"})
        Me.ComboTerm.Location = New System.Drawing.Point(434, 32)
        Me.ComboTerm.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboTerm.Name = "ComboTerm"
        Me.ComboTerm.Size = New System.Drawing.Size(215, 21)
        Me.ComboTerm.TabIndex = 5
        '
        'ComboCurrency
        '
        Me.ComboCurrency.FormattingEnabled = True
        Me.ComboCurrency.Items.AddRange(New Object() {"EURO", "IDR", "SGD", "USD"})
        Me.ComboCurrency.Location = New System.Drawing.Point(434, 56)
        Me.ComboCurrency.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboCurrency.Name = "ComboCurrency"
        Me.ComboCurrency.Size = New System.Drawing.Size(97, 21)
        Me.ComboCurrency.TabIndex = 6
        '
        'ComboTax
        '
        Me.ComboTax.FormattingEnabled = True
        Me.ComboTax.Items.AddRange(New Object() {"NO - PPN", "PPN"})
        Me.ComboTax.Location = New System.Drawing.Point(434, 80)
        Me.ComboTax.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboTax.Name = "ComboTax"
        Me.ComboTax.Size = New System.Drawing.Size(97, 21)
        Me.ComboTax.TabIndex = 7
        Me.ComboTax.Text = "NO - PPN"
        '
        'ComboShipping
        '
        Me.ComboShipping.FormattingEnabled = True
        Me.ComboShipping.Items.AddRange(New Object() {"PT. INDO CERIA", "PT. KIRANA LESTARI PERSADA"})
        Me.ComboShipping.Location = New System.Drawing.Point(434, 103)
        Me.ComboShipping.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboShipping.Name = "ComboShipping"
        Me.ComboShipping.Size = New System.Drawing.Size(215, 21)
        Me.ComboShipping.TabIndex = 9
        '
        'ComboVAT
        '
        Me.ComboVAT.Enabled = False
        Me.ComboVAT.FormattingEnabled = True
        Me.ComboVAT.Items.AddRange(New Object() {"E", "I"})
        Me.ComboVAT.Location = New System.Drawing.Point(586, 80)
        Me.ComboVAT.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboVAT.Name = "ComboVAT"
        Me.ComboVAT.Size = New System.Drawing.Size(62, 21)
        Me.ComboVAT.TabIndex = 8
        '
        'ComboEntity
        '
        Me.ComboEntity.FormattingEnabled = True
        Me.ComboEntity.Items.AddRange(New Object() {"IDC", "KLP"})
        Me.ComboEntity.Location = New System.Drawing.Point(90, 32)
        Me.ComboEntity.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboEntity.Name = "ComboEntity"
        Me.ComboEntity.Size = New System.Drawing.Size(92, 21)
        Me.ComboEntity.TabIndex = 1
        '
        'ComboPOType
        '
        Me.ComboPOType.FormattingEnabled = True
        Me.ComboPOType.Items.AddRange(New Object() {"FGS", "SPAREPART", "GA", "IT", "MATERIAL", "OTHERS"})
        Me.ComboPOType.Location = New System.Drawing.Point(90, 56)
        Me.ComboPOType.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboPOType.Name = "ComboPOType"
        Me.ComboPOType.Size = New System.Drawing.Size(103, 21)
        Me.ComboPOType.TabIndex = 2
        '
        'ComboPOType2
        '
        Me.ComboPOType2.FormattingEnabled = True
        Me.ComboPOType2.Items.AddRange(New Object() {"SPAREPART"})
        Me.ComboPOType2.Location = New System.Drawing.Point(196, 56)
        Me.ComboPOType2.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboPOType2.Name = "ComboPOType2"
        Me.ComboPOType2.Size = New System.Drawing.Size(119, 21)
        Me.ComboPOType2.TabIndex = 3
        '
        'ComboSupplier
        '
        Me.ComboSupplier.FormattingEnabled = True
        Me.ComboSupplier.Location = New System.Drawing.Point(90, 80)
        Me.ComboSupplier.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboSupplier.Name = "ComboSupplier"
        Me.ComboSupplier.Size = New System.Drawing.Size(225, 21)
        Me.ComboSupplier.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(333, 82)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 13)
        Me.Label14.TabIndex = 301
        Me.Label14.Text = "Tax Scheme"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(26, 106)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(24, 13)
        Me.Label13.TabIndex = 300
        Me.Label13.Text = "Up."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(333, 58)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 13)
        Me.Label12.TabIndex = 299
        Me.Label12.Text = "Currency"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(333, 106)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 13)
        Me.Label11.TabIndex = 298
        Me.Label11.Text = "Shipping Address"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(333, 34)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 13)
        Me.Label10.TabIndex = 297
        Me.Label10.Text = "Term"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(333, 12)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 296
        Me.Label5.Text = "Purchase #"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 82)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 295
        Me.Label4.Text = "Supplier"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 58)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 294
        Me.Label3.Text = "PO Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 34)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 293
        Me.Label2.Text = "Entity"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 292
        Me.Label1.Text = "Date"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(710, 59)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 320
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSimpan.Image = CType(resources.GetObject("BtnSimpan.Image"), System.Drawing.Image)
        Me.BtnSimpan.Location = New System.Drawing.Point(717, 11)
        Me.BtnSimpan.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(36, 43)
        Me.BtnSimpan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnSimpan.TabIndex = 316
        Me.BtnSimpan.TabStop = False
        '
        'BtnAdd
        '
        Me.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdd.Image = CType(resources.GetObject("BtnAdd.Image"), System.Drawing.Image)
        Me.BtnAdd.Location = New System.Drawing.Point(758, 141)
        Me.BtnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(25, 28)
        Me.BtnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnAdd.TabIndex = 227
        Me.BtnAdd.TabStop = False
        '
        'BtnBack
        '
        Me.BtnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBack.Image = CType(resources.GetObject("BtnBack.Image"), System.Drawing.Image)
        Me.BtnBack.Location = New System.Drawing.Point(755, 15)
        Me.BtnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(30, 33)
        Me.BtnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnBack.TabIndex = 315
        Me.BtnBack.TabStop = False
        '
        'TransaksiPO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(812, 445)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.Detail)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.TxtUp)
        Me.Controls.Add(Me.TxtKode)
        Me.Controls.Add(Me.ComboTerm)
        Me.Controls.Add(Me.ComboCurrency)
        Me.Controls.Add(Me.ComboTax)
        Me.Controls.Add(Me.ComboShipping)
        Me.Controls.Add(Me.ComboVAT)
        Me.Controls.Add(Me.ComboEntity)
        Me.Controls.Add(Me.ComboPOType)
        Me.Controls.Add(Me.ComboPOType2)
        Me.Controls.Add(Me.ComboSupplier)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "TransaksiPO"
        Me.Text = "TransaksiPO"
        Me.Detail.ResumeLayout(False)
        Me.TxtDPPersen.ResumeLayout(False)
        Me.TxtDPPersen.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.BtnSimpan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label27 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents BtnSimpan As PictureBox
    Friend WithEvents Detail As TabControl
    Friend WithEvents TxtDPPersen As TabPage
    Friend WithEvents BtnAdd As PictureBox
    Friend WithEvents TxtDiscountP As TextBox
    Friend WithEvents TxtSubTotal As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents TxtPPN As TextBox
    Friend WithEvents TxtDPP As TextBox
    Friend WithEvents TxtDiscountA As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox21 As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents TxtCatatan As TextBox
    Friend WithEvents BtnBack As PictureBox
    Friend WithEvents Label21 As Label
    Friend WithEvents TxtUp As TextBox
    Friend WithEvents TxtKode As TextBox
    Friend WithEvents ComboTerm As ComboBox
    Friend WithEvents ComboCurrency As ComboBox
    Friend WithEvents ComboTax As ComboBox
    Friend WithEvents ComboShipping As ComboBox
    Friend WithEvents ComboVAT As ComboBox
    Friend WithEvents ComboEntity As ComboBox
    Friend WithEvents ComboPOType As ComboBox
    Friend WithEvents ComboPOType2 As ComboBox
    Friend WithEvents ComboSupplier As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class
