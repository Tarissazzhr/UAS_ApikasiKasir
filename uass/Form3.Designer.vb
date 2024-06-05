<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.components = New System.ComponentModel.Container()
        Dim Kode_barangLabel As System.Windows.Forms.Label
        Dim Nama_barangLabel As System.Windows.Forms.Label
        Dim SatuanLabel As System.Windows.Forms.Label
        Dim JenisLabel As System.Windows.Forms.Label
        Dim Harga_beliLabel As System.Windows.Forms.Label
        Dim Harga_JualLabel As System.Windows.Forms.Label
        Dim StokLabel As System.Windows.Forms.Label
        Me.DataSet1 = New uass.DataSet1()
        Me.BarangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BarangTableAdapter = New uass.DataSet1TableAdapters.barangTableAdapter()
        Me.TableAdapterManager = New uass.DataSet1TableAdapters.TableAdapterManager()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Kode_barangTextBox = New System.Windows.Forms.TextBox()
        Me.Nama_barangTextBox = New System.Windows.Forms.TextBox()
        Me.SatuanComboBox = New System.Windows.Forms.ComboBox()
        Me.JenisComboBox = New System.Windows.Forms.ComboBox()
        Me.Harga_beliTextBox = New System.Windows.Forms.TextBox()
        Me.Harga_JualTextBox = New System.Windows.Forms.TextBox()
        Me.StokTextBox = New System.Windows.Forms.TextBox()
        Me.BarangDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Kode_barangLabel = New System.Windows.Forms.Label()
        Nama_barangLabel = New System.Windows.Forms.Label()
        SatuanLabel = New System.Windows.Forms.Label()
        JenisLabel = New System.Windows.Forms.Label()
        Harga_beliLabel = New System.Windows.Forms.Label()
        Harga_JualLabel = New System.Windows.Forms.Label()
        StokLabel = New System.Windows.Forms.Label()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarangDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Kode_barangLabel
        '
        Kode_barangLabel.AutoSize = True
        Kode_barangLabel.Location = New System.Drawing.Point(86, 119)
        Kode_barangLabel.Name = "Kode_barangLabel"
        Kode_barangLabel.Size = New System.Drawing.Size(104, 20)
        Kode_barangLabel.TabIndex = 19
        Kode_barangLabel.Text = "Kode barang:"
        '
        'Nama_barangLabel
        '
        Nama_barangLabel.AutoSize = True
        Nama_barangLabel.Location = New System.Drawing.Point(86, 151)
        Nama_barangLabel.Name = "Nama_barangLabel"
        Nama_barangLabel.Size = New System.Drawing.Size(109, 20)
        Nama_barangLabel.TabIndex = 20
        Nama_barangLabel.Text = "Nama barang:"
        '
        'SatuanLabel
        '
        SatuanLabel.AutoSize = True
        SatuanLabel.Location = New System.Drawing.Point(86, 183)
        SatuanLabel.Name = "SatuanLabel"
        SatuanLabel.Size = New System.Drawing.Size(65, 20)
        SatuanLabel.TabIndex = 21
        SatuanLabel.Text = "Satuan:"
        AddHandler SatuanLabel.Click, AddressOf Me.SatuanLabel_Click
        '
        'JenisLabel
        '
        JenisLabel.AutoSize = True
        JenisLabel.Location = New System.Drawing.Point(468, 186)
        JenisLabel.Name = "JenisLabel"
        JenisLabel.Size = New System.Drawing.Size(50, 20)
        JenisLabel.TabIndex = 22
        JenisLabel.Text = "Jenis:"
        '
        'Harga_beliLabel
        '
        Harga_beliLabel.AutoSize = True
        Harga_beliLabel.Location = New System.Drawing.Point(86, 218)
        Harga_beliLabel.Name = "Harga_beliLabel"
        Harga_beliLabel.Size = New System.Drawing.Size(85, 20)
        Harga_beliLabel.TabIndex = 23
        Harga_beliLabel.Text = "Harga beli:"
        AddHandler Harga_beliLabel.Click, AddressOf Me.Harga_beliLabel_Click
        '
        'Harga_JualLabel
        '
        Harga_JualLabel.AutoSize = True
        Harga_JualLabel.Location = New System.Drawing.Point(468, 218)
        Harga_JualLabel.Name = "Harga_JualLabel"
        Harga_JualLabel.Size = New System.Drawing.Size(90, 20)
        Harga_JualLabel.TabIndex = 24
        Harga_JualLabel.Text = "Harga Jual:"
        '
        'StokLabel
        '
        StokLabel.AutoSize = True
        StokLabel.Location = New System.Drawing.Point(86, 250)
        StokLabel.Name = "StokLabel"
        StokLabel.Size = New System.Drawing.Size(46, 20)
        StokLabel.TabIndex = 25
        StokLabel.Text = "Stok:"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BarangBindingSource
        '
        Me.BarangBindingSource.DataMember = "barang"
        Me.BarangBindingSource.DataSource = Me.DataSet1
        '
        'BarangTableAdapter
        '
        Me.BarangTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.barangTableAdapter = Me.BarangTableAdapter
        Me.TableAdapterManager.detailpembelianTableAdapter = Nothing
        Me.TableAdapterManager.detailpenjualanTableAdapter = Nothing
        Me.TableAdapterManager.pembelianTableAdapter = Nothing
        Me.TableAdapterManager.penjualanTableAdapter = Nothing
        Me.TableAdapterManager.sementarajualTableAdapter = Nothing
        Me.TableAdapterManager.sementaraTableAdapter = Nothing
        Me.TableAdapterManager.supplierTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = uass.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.userTableAdapter = Nothing
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(652, 301)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 54)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Keluar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(126, 301)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 54)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Tambah"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(259, 301)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(85, 54)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Simpan"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(387, 301)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(85, 54)
        Me.Button4.TabIndex = 18
        Me.Button4.Text = "Hapus"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(516, 301)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(85, 54)
        Me.Button5.TabIndex = 19
        Me.Button5.Text = "Batal"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Kode_barangTextBox
        '
        Me.Kode_barangTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BarangBindingSource, "Kode_barang", True))
        Me.Kode_barangTextBox.Location = New System.Drawing.Point(224, 116)
        Me.Kode_barangTextBox.Name = "Kode_barangTextBox"
        Me.Kode_barangTextBox.Size = New System.Drawing.Size(566, 26)
        Me.Kode_barangTextBox.TabIndex = 20
        '
        'Nama_barangTextBox
        '
        Me.Nama_barangTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BarangBindingSource, "Nama_barang", True))
        Me.Nama_barangTextBox.Location = New System.Drawing.Point(224, 148)
        Me.Nama_barangTextBox.Name = "Nama_barangTextBox"
        Me.Nama_barangTextBox.Size = New System.Drawing.Size(566, 26)
        Me.Nama_barangTextBox.TabIndex = 21
        '
        'SatuanComboBox
        '
        Me.SatuanComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BarangBindingSource, "Satuan", True))
        Me.SatuanComboBox.FormattingEnabled = True
        Me.SatuanComboBox.Items.AddRange(New Object() {"DUS", "PCS", "LUSIN"})
        Me.SatuanComboBox.Location = New System.Drawing.Point(224, 183)
        Me.SatuanComboBox.Name = "SatuanComboBox"
        Me.SatuanComboBox.Size = New System.Drawing.Size(222, 28)
        Me.SatuanComboBox.TabIndex = 22
        '
        'JenisComboBox
        '
        Me.JenisComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BarangBindingSource, "Jenis", True))
        Me.JenisComboBox.FormattingEnabled = True
        Me.JenisComboBox.Items.AddRange(New Object() {"MAKANAN", "MINUMAN"})
        Me.JenisComboBox.Location = New System.Drawing.Point(564, 183)
        Me.JenisComboBox.Name = "JenisComboBox"
        Me.JenisComboBox.Size = New System.Drawing.Size(226, 28)
        Me.JenisComboBox.TabIndex = 23
        '
        'Harga_beliTextBox
        '
        Me.Harga_beliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BarangBindingSource, "Harga_beli", True))
        Me.Harga_beliTextBox.Location = New System.Drawing.Point(224, 215)
        Me.Harga_beliTextBox.Name = "Harga_beliTextBox"
        Me.Harga_beliTextBox.Size = New System.Drawing.Size(222, 26)
        Me.Harga_beliTextBox.TabIndex = 24
        '
        'Harga_JualTextBox
        '
        Me.Harga_JualTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BarangBindingSource, "Harga_Jual", True))
        Me.Harga_JualTextBox.Location = New System.Drawing.Point(564, 215)
        Me.Harga_JualTextBox.Name = "Harga_JualTextBox"
        Me.Harga_JualTextBox.Size = New System.Drawing.Size(226, 26)
        Me.Harga_JualTextBox.TabIndex = 25
        '
        'StokTextBox
        '
        Me.StokTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BarangBindingSource, "Stok", True))
        Me.StokTextBox.Location = New System.Drawing.Point(224, 247)
        Me.StokTextBox.Name = "StokTextBox"
        Me.StokTextBox.Size = New System.Drawing.Size(566, 26)
        Me.StokTextBox.TabIndex = 26
        '
        'BarangDataGridView
        '
        Me.BarangDataGridView.AutoGenerateColumns = False
        Me.BarangDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BarangDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.BarangDataGridView.DataSource = Me.BarangBindingSource
        Me.BarangDataGridView.Location = New System.Drawing.Point(37, 379)
        Me.BarangDataGridView.Name = "BarangDataGridView"
        Me.BarangDataGridView.RowHeadersWidth = 62
        Me.BarangDataGridView.RowTemplate.Height = 28
        Me.BarangDataGridView.Size = New System.Drawing.Size(848, 220)
        Me.BarangDataGridView.TabIndex = 26
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Kode_barang"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Kode_barang"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nama_barang"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nama_barang"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Satuan"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Satuan"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Jenis"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Jenis"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Harga_beli"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Harga_beli"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Harga_Jual"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Harga_Jual"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 150
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Stok"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Stok"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 150
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(370, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 20)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Barang's Master"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 692)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BarangDataGridView)
        Me.Controls.Add(StokLabel)
        Me.Controls.Add(Me.StokTextBox)
        Me.Controls.Add(Harga_JualLabel)
        Me.Controls.Add(Me.Harga_JualTextBox)
        Me.Controls.Add(Harga_beliLabel)
        Me.Controls.Add(Me.Harga_beliTextBox)
        Me.Controls.Add(JenisLabel)
        Me.Controls.Add(Me.JenisComboBox)
        Me.Controls.Add(SatuanLabel)
        Me.Controls.Add(Me.SatuanComboBox)
        Me.Controls.Add(Nama_barangLabel)
        Me.Controls.Add(Me.Nama_barangTextBox)
        Me.Controls.Add(Kode_barangLabel)
        Me.Controls.Add(Me.Kode_barangTextBox)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarangDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents BarangBindingSource As BindingSource
    Friend WithEvents BarangTableAdapter As DataSet1TableAdapters.barangTableAdapter
    Friend WithEvents TableAdapterManager As DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Kode_barangTextBox As TextBox
    Friend WithEvents Nama_barangTextBox As TextBox
    Friend WithEvents SatuanComboBox As ComboBox
    Friend WithEvents JenisComboBox As ComboBox
    Friend WithEvents Harga_beliTextBox As TextBox
    Friend WithEvents Harga_JualTextBox As TextBox
    Friend WithEvents StokTextBox As TextBox
    Friend WithEvents BarangDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
End Class
