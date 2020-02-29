<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Supplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Supplier))
        Me.TxtKode = New System.Windows.Forms.TextBox()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ComboSAccount = New System.Windows.Forms.ComboBox()
        Me.CheckSStatus = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboSCurrency = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboSPGroup = New System.Windows.Forms.ComboBox()
        Me.ComboSGroup = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtSFax = New System.Windows.Forms.TextBox()
        Me.TxtSTelp = New System.Windows.Forms.TextBox()
        Me.TxtSZip = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboSCity = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtSAddres = New System.Windows.Forms.TextBox()
        Me.TxtSContact = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.DGVAP = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboNPWPPPN = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtNPWP = New System.Windows.Forms.TextBox()
        Me.TxtNPWPAddress = New System.Windows.Forms.TextBox()
        Me.TxtNPWPNama = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.DGVContact = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TxtCatatan = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.BtnBack = New System.Windows.Forms.PictureBox()
        Me.BtnSave = New System.Windows.Forms.PictureBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVAP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVContact, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.BtnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtKode
        '
        Me.TxtKode.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtKode.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.TxtKode.Location = New System.Drawing.Point(141, 23)
        Me.TxtKode.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtKode.Name = "TxtKode"
        Me.TxtKode.ReadOnly = True
        Me.TxtKode.Size = New System.Drawing.Size(156, 27)
        Me.TxtKode.TabIndex = 1
        Me.TxtKode.Text = "Supplier Code"
        '
        'TxtNama
        '
        Me.TxtNama.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNama.Location = New System.Drawing.Point(141, 54)
        Me.TxtNama.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(240, 35)
        Me.TxtNama.TabIndex = 2
        Me.TxtNama.Text = "Supplier Name"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label19.Location = New System.Drawing.Point(469, 13)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(229, 17)
        Me.Label19.TabIndex = 176
        Me.Label19.Text = "Box mempunyai tanda (*) wajib diisi"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(20, 109)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(785, 303)
        Me.TabControl1.TabIndex = 14
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.ComboSAccount)
        Me.TabPage1.Controls.Add(Me.CheckSStatus)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.ComboSCurrency)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.ComboSPGroup)
        Me.TabPage1.Controls.Add(Me.ComboSGroup)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.TxtSFax)
        Me.TabPage1.Controls.Add(Me.TxtSTelp)
        Me.TabPage1.Controls.Add(Me.TxtSZip)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.ComboSCity)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.TxtSAddres)
        Me.TabPage1.Controls.Add(Me.TxtSContact)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Size = New System.Drawing.Size(777, 277)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Details"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(304, 172)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 18)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Account A/P"
        '
        'ComboSAccount
        '
        Me.ComboSAccount.FormattingEnabled = True
        Me.ComboSAccount.Items.AddRange(New Object() {"11501                              PERSEDIAAN BAHAN BAKU", "21101                              HUTANG DAGANG-IDR", "21102                              HUTANG DAGANG-USD", "21109                              HUTANG DAGANG-HUBUNGAN ISTIMEWA", "21199                              HUTANG A/P TRANSIT", "21201                              HUTANG BANK MAYBANK-FL", "21211                              HUTANG KENDARAAN", "21301                              HUTANG GAJI", "21302                              HUTANG BUNGA", "21310                              HUTANG ICP", "21311                              HUTANGICEA", "21312                              HUTANG KARTIKA CERIA", "21313                              HUTANG PHK III", "21399                              HUTANG LAIN-LAIN"})
        Me.ComboSAccount.Location = New System.Drawing.Point(447, 172)
        Me.ComboSAccount.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboSAccount.Name = "ComboSAccount"
        Me.ComboSAccount.Size = New System.Drawing.Size(308, 21)
        Me.ComboSAccount.TabIndex = 12
        '
        'CheckSStatus
        '
        Me.CheckSStatus.AutoSize = True
        Me.CheckSStatus.Location = New System.Drawing.Point(447, 196)
        Me.CheckSStatus.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckSStatus.Name = "CheckSStatus"
        Me.CheckSStatus.Size = New System.Drawing.Size(68, 17)
        Me.CheckSStatus.TabIndex = 13
        Me.CheckSStatus.Text = "In Active"
        Me.CheckSStatus.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(304, 194)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 18)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Status"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(304, 150)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(118, 18)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Default Currency"
        '
        'ComboSCurrency
        '
        Me.ComboSCurrency.FormattingEnabled = True
        Me.ComboSCurrency.Items.AddRange(New Object() {"EURO", "IDR", "SGD", "USD"})
        Me.ComboSCurrency.Location = New System.Drawing.Point(447, 150)
        Me.ComboSCurrency.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboSCurrency.Name = "ComboSCurrency"
        Me.ComboSCurrency.Size = New System.Drawing.Size(308, 21)
        Me.ComboSCurrency.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(14, 223)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 18)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Product Group"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(14, 199)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 18)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Supplier Group"
        '
        'ComboSPGroup
        '
        Me.ComboSPGroup.FormattingEnabled = True
        Me.ComboSPGroup.Items.AddRange(New Object() {"ASURANSI", "BARANG IMPOR", "IT", "JASA ACCOUNTING & PAYROLL", "JASA CLEARANCE", "JASA MAINTENANCE & REPAIR", "LOAN", "OTHER", "PENGIRIMAN BARANG", "PENGIRIMAN DOKUMEN", "SEWA ANGKUTAN", "SUPPLIER PRODUK", "TAGIHAN AIR"})
        Me.ComboSPGroup.Location = New System.Drawing.Point(135, 223)
        Me.ComboSPGroup.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboSPGroup.Name = "ComboSPGroup"
        Me.ComboSPGroup.Size = New System.Drawing.Size(131, 21)
        Me.ComboSPGroup.TabIndex = 9
        '
        'ComboSGroup
        '
        Me.ComboSGroup.FormattingEnabled = True
        Me.ComboSGroup.Items.AddRange(New Object() {"ACCOUNTANT", "ESTATE", "FORWARDER", "IT", "JASA ASURANSI", "LOGISTIC", "MAINTENANCE & REPAIR", "OTHER", "PENYEWAAN", "SHAREHOLDER", "SUPPLIER PRODUK LN", "SUPPLIER PRODUK LOKAL"})
        Me.ComboSGroup.Location = New System.Drawing.Point(135, 198)
        Me.ComboSGroup.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboSGroup.Name = "ComboSGroup"
        Me.ComboSGroup.Size = New System.Drawing.Size(131, 21)
        Me.ComboSGroup.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 176)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 18)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Fax"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 153)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 18)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Telp"
        '
        'TxtSFax
        '
        Me.TxtSFax.Location = New System.Drawing.Point(135, 176)
        Me.TxtSFax.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtSFax.Name = "TxtSFax"
        Me.TxtSFax.Size = New System.Drawing.Size(131, 20)
        Me.TxtSFax.TabIndex = 7
        '
        'TxtSTelp
        '
        Me.TxtSTelp.Location = New System.Drawing.Point(135, 153)
        Me.TxtSTelp.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtSTelp.Name = "TxtSTelp"
        Me.TxtSTelp.Size = New System.Drawing.Size(131, 20)
        Me.TxtSTelp.TabIndex = 6
        '
        'TxtSZip
        '
        Me.TxtSZip.Location = New System.Drawing.Point(447, 128)
        Me.TxtSZip.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtSZip.Name = "TxtSZip"
        Me.TxtSZip.Size = New System.Drawing.Size(308, 20)
        Me.TxtSZip.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(304, 128)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 18)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Zip"
        '
        'ComboSCity
        '
        Me.ComboSCity.FormattingEnabled = True
        Me.ComboSCity.Items.AddRange(New Object() {"Bekasi", "Gresik", "Jakarta", "Malang", "Singapore", "Semarang", "Sidoarjo", "Surabaya", "Tangerang"})
        Me.ComboSCity.Location = New System.Drawing.Point(135, 128)
        Me.ComboSCity.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboSCity.Name = "ComboSCity"
        Me.ComboSCity.Size = New System.Drawing.Size(131, 21)
        Me.ComboSCity.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 128)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "City"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 45)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 18)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 15)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Contact Person"
        '
        'TxtSAddres
        '
        Me.TxtSAddres.Location = New System.Drawing.Point(135, 45)
        Me.TxtSAddres.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtSAddres.Multiline = True
        Me.TxtSAddres.Name = "TxtSAddres"
        Me.TxtSAddres.Size = New System.Drawing.Size(620, 76)
        Me.TxtSAddres.TabIndex = 4
        '
        'TxtSContact
        '
        Me.TxtSContact.Location = New System.Drawing.Point(135, 18)
        Me.TxtSContact.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtSContact.Name = "TxtSContact"
        Me.TxtSContact.Size = New System.Drawing.Size(234, 20)
        Me.TxtSContact.TabIndex = 3
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.PictureBox3)
        Me.TabPage2.Controls.Add(Me.Label18)
        Me.TabPage2.Controls.Add(Me.DGVAP)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Size = New System.Drawing.Size(777, 277)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Payment Account"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(748, 2)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(25, 28)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 227
        Me.PictureBox3.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(46, 9)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(237, 13)
        Me.Label18.TabIndex = 16
        Me.Label18.Text = "( Bank Descriptions, Currency, Bank Account # )"
        '
        'DGVAP
        '
        Me.DGVAP.BackgroundColor = System.Drawing.Color.White
        Me.DGVAP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVAP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn4})
        Me.DGVAP.Location = New System.Drawing.Point(5, 30)
        Me.DGVAP.Margin = New System.Windows.Forms.Padding(2)
        Me.DGVAP.Name = "DGVAP"
        Me.DGVAP.Size = New System.Drawing.Size(768, 245)
        Me.DGVAP.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Deskripsi Akun Pembayaran"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 355
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Detail Akun Pembayaran"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 355
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Controls.Add(Me.ComboNPWPPPN)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.TxtNPWP)
        Me.TabPage3.Controls.Add(Me.TxtNPWPAddress)
        Me.TabPage3.Controls.Add(Me.TxtNPWPNama)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage3.Size = New System.Drawing.Size(777, 277)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "NPWP"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 52)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 18)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "PPN"
        '
        'ComboNPWPPPN
        '
        Me.ComboNPWPPPN.FormattingEnabled = True
        Me.ComboNPWPPPN.Items.AddRange(New Object() {"PPN Spesial", "Standard"})
        Me.ComboNPWPPPN.Location = New System.Drawing.Point(96, 53)
        Me.ComboNPWPPPN.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboNPWPPPN.Name = "ComboNPWPPPN"
        Me.ComboNPWPPPN.Size = New System.Drawing.Size(234, 21)
        Me.ComboNPWPPPN.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(4, 74)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 36)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "NPWP " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Address"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(4, 31)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 18)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "NPWP"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(4, 10)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(82, 18)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "NPWP A/N"
        '
        'TxtNPWP
        '
        Me.TxtNPWP.Location = New System.Drawing.Point(96, 32)
        Me.TxtNPWP.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNPWP.Name = "TxtNPWP"
        Me.TxtNPWP.Size = New System.Drawing.Size(234, 20)
        Me.TxtNPWP.TabIndex = 4
        '
        'TxtNPWPAddress
        '
        Me.TxtNPWPAddress.Location = New System.Drawing.Point(96, 75)
        Me.TxtNPWPAddress.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNPWPAddress.Multiline = True
        Me.TxtNPWPAddress.Name = "TxtNPWPAddress"
        Me.TxtNPWPAddress.Size = New System.Drawing.Size(476, 76)
        Me.TxtNPWPAddress.TabIndex = 6
        '
        'TxtNPWPNama
        '
        Me.TxtNPWPNama.Location = New System.Drawing.Point(96, 11)
        Me.TxtNPWPNama.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNPWPNama.Name = "TxtNPWPNama"
        Me.TxtNPWPNama.Size = New System.Drawing.Size(234, 20)
        Me.TxtNPWPNama.TabIndex = 3
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.PictureBox4)
        Me.TabPage4.Controls.Add(Me.DGVContact)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage4.Size = New System.Drawing.Size(777, 277)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Contact"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(742, 2)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(25, 28)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 228
        Me.PictureBox4.TabStop = False
        '
        'DGVContact
        '
        Me.DGVContact.AllowUserToAddRows = False
        Me.DGVContact.AllowUserToDeleteRows = False
        Me.DGVContact.BackgroundColor = System.Drawing.Color.White
        Me.DGVContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVContact.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.DGVContact.Location = New System.Drawing.Point(12, 29)
        Me.DGVContact.Margin = New System.Windows.Forms.Padding(2)
        Me.DGVContact.Name = "DGVContact"
        Me.DGVContact.Size = New System.Drawing.Size(755, 236)
        Me.DGVContact.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Contact Person"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 205
        '
        'Column2
        '
        Me.Column2.HeaderText = "Divisi"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 160
        '
        'Column3
        '
        Me.Column3.HeaderText = "HP/Telp/Ext."
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 180
        '
        'Column4
        '
        Me.Column4.HeaderText = "Email"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 180
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.TxtCatatan)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage5.Size = New System.Drawing.Size(777, 277)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Remark"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'TxtCatatan
        '
        Me.TxtCatatan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtCatatan.Location = New System.Drawing.Point(2, 2)
        Me.TxtCatatan.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtCatatan.Multiline = True
        Me.TxtCatatan.Name = "TxtCatatan"
        Me.TxtCatatan.Size = New System.Drawing.Size(773, 273)
        Me.TxtCatatan.TabIndex = 6
        Me.TxtCatatan.Text = "Catatan Supplier"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(22, 67)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(90, 17)
        Me.Label16.TabIndex = 179
        Me.Label16.Text = "Description"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(22, 29)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(110, 17)
        Me.Label17.TabIndex = 180
        Me.Label17.Text = "Supplier Code"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(683, 423)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(118, 13)
        Me.Label21.TabIndex = 195
        Me.Label21.Text = "© Made by. ANSKE"
        '
        'BtnBack
        '
        Me.BtnBack.Image = CType(resources.GetObject("BtnBack.Image"), System.Drawing.Image)
        Me.BtnBack.Location = New System.Drawing.Point(749, 17)
        Me.BtnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(30, 33)
        Me.BtnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnBack.TabIndex = 194
        Me.BtnBack.TabStop = False
        '
        'BtnSave
        '
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(710, 12)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(36, 43)
        Me.BtnSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnSave.TabIndex = 193
        Me.BtnSave.TabStop = False
        '
        'Supplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(812, 445)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TxtKode)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Supplier"
        Me.Text = "Supplier"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVAP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVContact, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.BtnBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtKode As TextBox
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label12 As Label
    Friend WithEvents ComboSAccount As ComboBox
    Friend WithEvents CheckSStatus As CheckBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboSCurrency As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboSPGroup As ComboBox
    Friend WithEvents ComboSGroup As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtSFax As TextBox
    Friend WithEvents TxtSTelp As TextBox
    Friend WithEvents TxtSZip As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboSCity As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtSAddres As TextBox
    Friend WithEvents TxtSContact As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label18 As Label
    Friend WithEvents DGVAP As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboNPWPPPN As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtNPWP As TextBox
    Friend WithEvents TxtNPWPAddress As TextBox
    Friend WithEvents TxtNPWPNama As TextBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents DGVContact As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TxtCatatan As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents BtnSave As PictureBox
    Friend WithEvents BtnBack As PictureBox
    Friend WithEvents Label21 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
End Class
