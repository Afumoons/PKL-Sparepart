<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PengambilanBarang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PengambilanBarang))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtKode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtCodePickUp = New System.Windows.Forms.TextBox()
        Me.LVBaru = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LVPilih = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.LVLama = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.PictureBox()
        Me.BtnTambah = New System.Windows.Forms.PictureBox()
        Me.BtnBack = New System.Windows.Forms.PictureBox()
        Me.BtnSave = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.BtnEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnTambah, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 124)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 17)
        Me.Label4.TabIndex = 232
        Me.Label4.Text = "Item Code"
        '
        'TxtKode
        '
        Me.TxtKode.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.TxtKode.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.TxtKode.Location = New System.Drawing.Point(170, 114)
        Me.TxtKode.Name = "TxtKode"
        Me.TxtKode.ReadOnly = True
        Me.TxtKode.Size = New System.Drawing.Size(184, 27)
        Me.TxtKode.TabIndex = 231
        Me.TxtKode.Text = "Item Code"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 79)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 17)
        Me.Label1.TabIndex = 234
        Me.Label1.Text = "PickUp Code"
        '
        'TxtCodePickUp
        '
        Me.TxtCodePickUp.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.TxtCodePickUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.TxtCodePickUp.Location = New System.Drawing.Point(170, 72)
        Me.TxtCodePickUp.Name = "TxtCodePickUp"
        Me.TxtCodePickUp.ReadOnly = True
        Me.TxtCodePickUp.Size = New System.Drawing.Size(184, 27)
        Me.TxtCodePickUp.TabIndex = 233
        Me.TxtCodePickUp.Text = "PickUp Code"
        '
        'LVBaru
        '
        Me.LVBaru.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader10})
        Me.LVBaru.GridLines = True
        Me.LVBaru.HideSelection = False
        Me.LVBaru.Location = New System.Drawing.Point(375, 240)
        Me.LVBaru.Margin = New System.Windows.Forms.Padding(2)
        Me.LVBaru.Name = "LVBaru"
        Me.LVBaru.Size = New System.Drawing.Size(381, 140)
        Me.LVBaru.TabIndex = 236
        Me.LVBaru.UseCompatibleStateImageBehavior = False
        Me.LVBaru.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Type Code"
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Item Code"
        Me.ColumnHeader3.Width = 150
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Item Description"
        Me.ColumnHeader4.Width = 300
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Query"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(91, 198)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(273, 168)
        Me.TextBox1.TabIndex = 237
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 196)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 238
        Me.Label2.Text = "Remark"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(93, 167)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(87, 20)
        Me.DateTimePicker1.TabIndex = 319
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 171)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 318
        Me.Label5.Text = "Date"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(671, 384)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(118, 13)
        Me.Label21.TabIndex = 320
        Me.Label21.Text = "© Made by. ANSKE"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LVPilih)
        Me.Panel2.Location = New System.Drawing.Point(170, 139)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(386, 114)
        Me.Panel2.TabIndex = 329
        '
        'LVPilih
        '
        Me.LVPilih.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader5})
        Me.LVPilih.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LVPilih.FullRowSelect = True
        Me.LVPilih.GridLines = True
        Me.LVPilih.HideSelection = False
        Me.LVPilih.Location = New System.Drawing.Point(0, 0)
        Me.LVPilih.Margin = New System.Windows.Forms.Padding(2)
        Me.LVPilih.Name = "LVPilih"
        Me.LVPilih.Size = New System.Drawing.Size(386, 114)
        Me.LVPilih.TabIndex = 197
        Me.LVPilih.UseCompatibleStateImageBehavior = False
        Me.LVPilih.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Kode Sparepart"
        Me.ColumnHeader1.Width = 110
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Item Description/Sparepart"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 270
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Location = New System.Drawing.Point(278, 59)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(215, 69)
        Me.Panel1.TabIndex = 330
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(2, 3)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(76, 20)
        Me.TextBox4.TabIndex = 12
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(2, 24)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(209, 41)
        Me.TextBox3.TabIndex = 11
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(146, 3)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(68, 17)
        Me.CheckBox1.TabIndex = 10
        Me.CheckBox1.Text = "Terpakai"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'LVLama
        '
        Me.LVLama.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.LVLama.GridLines = True
        Me.LVLama.HideSelection = False
        Me.LVLama.Location = New System.Drawing.Point(375, 72)
        Me.LVLama.Margin = New System.Windows.Forms.Padding(2)
        Me.LVLama.Name = "LVLama"
        Me.LVLama.Size = New System.Drawing.Size(381, 153)
        Me.LVLama.TabIndex = 330
        Me.LVLama.UseCompatibleStateImageBehavior = False
        Me.LVLama.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Type Code"
        Me.ColumnHeader6.Width = 100
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Item Code"
        Me.ColumnHeader7.Width = 150
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Item Description"
        Me.ColumnHeader8.Width = 300
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Query"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(586, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 331
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(498, 13)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 335
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'BtnEdit
        '
        Me.BtnEdit.Image = Global.SIANSKE.My.Resources.Resources.icons8_edit_30__2_
        Me.BtnEdit.Location = New System.Drawing.Point(406, 41)
        Me.BtnEdit.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(22, 24)
        Me.BtnEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnEdit.TabIndex = 325
        Me.BtnEdit.TabStop = False
        '
        'BtnTambah
        '
        Me.BtnTambah.Image = CType(resources.GetObject("BtnTambah.Image"), System.Drawing.Image)
        Me.BtnTambah.Location = New System.Drawing.Point(383, 41)
        Me.BtnTambah.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(22, 24)
        Me.BtnTambah.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnTambah.TabIndex = 324
        Me.BtnTambah.TabStop = False
        '
        'BtnBack
        '
        Me.BtnBack.Image = CType(resources.GetObject("BtnBack.Image"), System.Drawing.Image)
        Me.BtnBack.Location = New System.Drawing.Point(725, 18)
        Me.BtnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(30, 33)
        Me.BtnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnBack.TabIndex = 323
        Me.BtnBack.TabStop = False
        '
        'BtnSave
        '
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(686, 13)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(36, 43)
        Me.BtnSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnSave.TabIndex = 322
        Me.BtnSave.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(549, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 13)
        Me.Label3.TabIndex = 336
        Me.Label3.Text = "Daftar Barang Baru"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(546, 227)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 13)
        Me.Label6.TabIndex = 337
        Me.Label6.Text = "Daftar Barang Lama"
        '
        'PengambilanBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(798, 407)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LVBaru)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtCodePickUp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtKode)
        Me.Controls.Add(Me.LVLama)
        Me.Controls.Add(Me.Label6)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "PengambilanBarang"
        Me.Text = "z"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BtnEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnTambah, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents TxtKode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtCodePickUp As TextBox
    Friend WithEvents LVBaru As ListView
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents BtnBack As PictureBox
    Friend WithEvents BtnSave As PictureBox
    Friend WithEvents BtnTambah As PictureBox
    Friend WithEvents BtnEdit As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LVPilih As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents LVLama As ListView
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
End Class
