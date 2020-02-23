<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransaksiPR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TransaksiPR))
        Me.ComboReqShipment = New System.Windows.Forms.ComboBox()
        Me.ComboReqBy = New System.Windows.Forms.ComboBox()
        Me.ComboSubPR = New System.Windows.Forms.ComboBox()
        Me.ComboPRType = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtCatatan = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtKode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TxtDatePicker = New System.Windows.Forms.TextBox()
        Me.hidden = New System.Windows.Forms.TextBox()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.PictureBox()
        Me.BtnSimpan = New System.Windows.Forms.PictureBox()
        Me.BtnBack = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSimpan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboReqShipment
        '
        Me.ComboReqShipment.FormattingEnabled = True
        Me.ComboReqShipment.Items.AddRange(New Object() {"AIR FREIGHT", "HAND CARRY", "LOCAL", "OCEAN FREIGHT"})
        Me.ComboReqShipment.Location = New System.Drawing.Point(478, 93)
        Me.ComboReqShipment.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboReqShipment.Name = "ComboReqShipment"
        Me.ComboReqShipment.Size = New System.Drawing.Size(188, 21)
        Me.ComboReqShipment.TabIndex = 5
        '
        'ComboReqBy
        '
        Me.ComboReqBy.FormattingEnabled = True
        Me.ComboReqBy.Items.AddRange(New Object() {"GA", "IT", "MAINTAINANCE", "PPIC"})
        Me.ComboReqBy.Location = New System.Drawing.Point(478, 69)
        Me.ComboReqBy.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboReqBy.Name = "ComboReqBy"
        Me.ComboReqBy.Size = New System.Drawing.Size(188, 21)
        Me.ComboReqBy.TabIndex = 4
        '
        'ComboSubPR
        '
        Me.ComboSubPR.FormattingEnabled = True
        Me.ComboSubPR.Items.AddRange(New Object() {"SPAREPART"})
        Me.ComboSubPR.Location = New System.Drawing.Point(478, 45)
        Me.ComboSubPR.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboSubPR.Name = "ComboSubPR"
        Me.ComboSubPR.Size = New System.Drawing.Size(188, 21)
        Me.ComboSubPR.TabIndex = 3
        '
        'ComboPRType
        '
        Me.ComboPRType.AllowDrop = True
        Me.ComboPRType.BackColor = System.Drawing.SystemColors.Window
        Me.ComboPRType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboPRType.FormattingEnabled = True
        Me.ComboPRType.Items.AddRange(New Object() {"SPAREPART"})
        Me.ComboPRType.Location = New System.Drawing.Point(478, 19)
        Me.ComboPRType.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboPRType.Name = "ComboPRType"
        Me.ComboPRType.Size = New System.Drawing.Size(188, 21)
        Me.ComboPRType.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(368, 96)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 13)
        Me.Label12.TabIndex = 211
        Me.Label12.Text = "Req. Shippment"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(368, 47)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 210
        Me.Label7.Text = "Sub PR Type"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(370, 21)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 209
        Me.Label6.Text = "PR Type"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(368, 72)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 13)
        Me.Label11.TabIndex = 208
        Me.Label11.Text = "Request By"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.DataGridView1.Location = New System.Drawing.Point(9, 136)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(794, 178)
        Me.DataGridView1.TabIndex = 217
        '
        'Column1
        '
        Me.Column1.HeaderText = "Item Code"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "Item Description"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 300
        '
        'Column3
        '
        Me.Column3.HeaderText = "PR Qty-1"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "UOM"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "PR Qty-2"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "UOM"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Description"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 300
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 327)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 221
        Me.Label1.Text = "Remark"
        '
        'TxtCatatan
        '
        Me.TxtCatatan.Location = New System.Drawing.Point(70, 327)
        Me.TxtCatatan.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtCatatan.Multiline = True
        Me.TxtCatatan.Name = "TxtCatatan"
        Me.TxtCatatan.Size = New System.Drawing.Size(656, 83)
        Me.TxtCatatan.TabIndex = 222
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(685, 423)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(118, 13)
        Me.Label20.TabIndex = 223
        Me.Label20.Text = "© Made by. ANSKE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 32)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 17)
        Me.Label4.TabIndex = 230
        Me.Label4.Text = "Transaction Code"
        '
        'TxtKode
        '
        Me.TxtKode.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.TxtKode.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.TxtKode.Location = New System.Drawing.Point(158, 25)
        Me.TxtKode.Name = "TxtKode"
        Me.TxtKode.ReadOnly = True
        Me.TxtKode.Size = New System.Drawing.Size(184, 27)
        Me.TxtKode.TabIndex = 1
        Me.TxtKode.Text = "Transaction Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 67)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 17)
        Me.Label2.TabIndex = 233
        Me.Label2.Text = "Date"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(158, 67)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(87, 20)
        Me.DateTimePicker1.TabIndex = 231
        '
        'TxtDatePicker
        '
        Me.TxtDatePicker.Location = New System.Drawing.Point(158, 67)
        Me.TxtDatePicker.Name = "TxtDatePicker"
        Me.TxtDatePicker.ReadOnly = True
        Me.TxtDatePicker.Size = New System.Drawing.Size(62, 20)
        Me.TxtDatePicker.TabIndex = 232
        Me.TxtDatePicker.Visible = False
        '
        'hidden
        '
        Me.hidden.Location = New System.Drawing.Point(698, 85)
        Me.hidden.Margin = New System.Windows.Forms.Padding(2)
        Me.hidden.Name = "hidden"
        Me.hidden.Size = New System.Drawing.Size(68, 20)
        Me.hidden.TabIndex = 234
        Me.hidden.Visible = False
        '
        'BtnPrint
        '
        Me.BtnPrint.Location = New System.Drawing.Point(710, 57)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(75, 23)
        Me.BtnPrint.TabIndex = 235
        Me.BtnPrint.Text = "Print"
        Me.BtnPrint.UseVisualStyleBackColor = True
        Me.BtnPrint.Visible = False
        '
        'BtnAdd
        '
        Me.BtnAdd.Image = CType(resources.GetObject("BtnAdd.Image"), System.Drawing.Image)
        Me.BtnAdd.Location = New System.Drawing.Point(778, 105)
        Me.BtnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(25, 28)
        Me.BtnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnAdd.TabIndex = 226
        Me.BtnAdd.TabStop = False
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Image = CType(resources.GetObject("BtnSimpan.Image"), System.Drawing.Image)
        Me.BtnSimpan.Location = New System.Drawing.Point(730, 9)
        Me.BtnSimpan.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(36, 43)
        Me.BtnSimpan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnSimpan.TabIndex = 219
        Me.BtnSimpan.TabStop = False
        '
        'BtnBack
        '
        Me.BtnBack.Image = CType(resources.GetObject("BtnBack.Image"), System.Drawing.Image)
        Me.BtnBack.Location = New System.Drawing.Point(768, 13)
        Me.BtnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(30, 33)
        Me.BtnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnBack.TabIndex = 218
        Me.BtnBack.TabStop = False
        '
        'TransaksiPR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(812, 445)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.hidden)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TxtDatePicker)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtKode)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.TxtCatatan)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ComboReqShipment)
        Me.Controls.Add(Me.ComboReqBy)
        Me.Controls.Add(Me.ComboSubPR)
        Me.Controls.Add(Me.ComboPRType)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label11)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "TransaksiPR"
        Me.Text = "TransaksiPR"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSimpan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboReqShipment As ComboBox
    Friend WithEvents ComboReqBy As ComboBox
    Friend WithEvents ComboSubPR As ComboBox
    Friend WithEvents ComboPRType As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnSimpan As PictureBox
    Friend WithEvents BtnBack As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtCatatan As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents BtnAdd As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtKode As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TxtDatePicker As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents hidden As TextBox
    Friend WithEvents BtnPrint As Button
End Class
