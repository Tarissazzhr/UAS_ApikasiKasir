<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim Kode_SupplierLabel As System.Windows.Forms.Label
        Dim Nama_SupplierLabel As System.Windows.Forms.Label
        Dim Alamat_SupplierLabel As System.Windows.Forms.Label
        Dim Telepon_SupplierLabel As System.Windows.Forms.Label
        Dim Fax_SupplierLabel As System.Windows.Forms.Label
        Dim Email_SupplierLabel As System.Windows.Forms.Label
        Dim Contact_Person_SupplierLabel As System.Windows.Forms.Label
        Me.DataSet1 = New uass.DataSet1()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierTableAdapter = New uass.DataSet1TableAdapters.supplierTableAdapter()
        Me.TableAdapterManager = New uass.DataSet1TableAdapters.TableAdapterManager()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Kode_SupplierTextBox = New System.Windows.Forms.TextBox()
        Me.Nama_SupplierTextBox = New System.Windows.Forms.TextBox()
        Me.Alamat_SupplierTextBox = New System.Windows.Forms.TextBox()
        Me.Telepon_SupplierTextBox = New System.Windows.Forms.TextBox()
        Me.Fax_SupplierTextBox = New System.Windows.Forms.TextBox()
        Me.Email_SupplierTextBox = New System.Windows.Forms.TextBox()
        Me.Contact_Person_SupplierTextBox = New System.Windows.Forms.TextBox()
        Me.SupplierDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Kode_SupplierLabel = New System.Windows.Forms.Label()
        Nama_SupplierLabel = New System.Windows.Forms.Label()
        Alamat_SupplierLabel = New System.Windows.Forms.Label()
        Telepon_SupplierLabel = New System.Windows.Forms.Label()
        Fax_SupplierLabel = New System.Windows.Forms.Label()
        Email_SupplierLabel = New System.Windows.Forms.Label()
        Contact_Person_SupplierLabel = New System.Windows.Forms.Label()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SupplierBindingSource
        '
        Me.SupplierBindingSource.DataMember = "supplier"
        Me.SupplierBindingSource.DataSource = Me.DataSet1
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.barangTableAdapter = Nothing
        Me.TableAdapterManager.detailpembelianTableAdapter = Nothing
        Me.TableAdapterManager.detailpenjualanTableAdapter = Nothing
        Me.TableAdapterManager.pembelianTableAdapter = Nothing
        Me.TableAdapterManager.penjualanTableAdapter = Nothing
        Me.TableAdapterManager.sementarajualTableAdapter = Nothing
        Me.TableAdapterManager.sementaraTableAdapter = Nothing
        Me.TableAdapterManager.supplierTableAdapter = Me.SupplierTableAdapter
        Me.TableAdapterManager.UpdateOrder = uass.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.userTableAdapter = Nothing
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(674, 324)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 53)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Keluar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(123, 324)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 53)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Tambah"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(270, 325)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(89, 53)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Simpan"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(408, 324)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(89, 53)
        Me.Button4.TabIndex = 18
        Me.Button4.Text = "Hapus"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(549, 324)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(89, 53)
        Me.Button5.TabIndex = 19
        Me.Button5.Text = "Batal"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Kode_SupplierLabel
        '
        Kode_SupplierLabel.AutoSize = True
        Kode_SupplierLabel.Location = New System.Drawing.Point(71, 109)
        Kode_SupplierLabel.Name = "Kode_SupplierLabel"
        Kode_SupplierLabel.Size = New System.Drawing.Size(112, 20)
        Kode_SupplierLabel.TabIndex = 19
        Kode_SupplierLabel.Text = "Kode Supplier:"
        '
        'Kode_SupplierTextBox
        '
        Me.Kode_SupplierTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "Kode_Supplier", True))
        Me.Kode_SupplierTextBox.Location = New System.Drawing.Point(216, 109)
        Me.Kode_SupplierTextBox.Name = "Kode_SupplierTextBox"
        Me.Kode_SupplierTextBox.Size = New System.Drawing.Size(660, 26)
        Me.Kode_SupplierTextBox.TabIndex = 20
        '
        'Nama_SupplierLabel
        '
        Nama_SupplierLabel.AutoSize = True
        Nama_SupplierLabel.Location = New System.Drawing.Point(71, 145)
        Nama_SupplierLabel.Name = "Nama_SupplierLabel"
        Nama_SupplierLabel.Size = New System.Drawing.Size(117, 20)
        Nama_SupplierLabel.TabIndex = 20
        Nama_SupplierLabel.Text = "Nama Supplier:"
        '
        'Nama_SupplierTextBox
        '
        Me.Nama_SupplierTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "Nama_Supplier", True))
        Me.Nama_SupplierTextBox.Location = New System.Drawing.Point(216, 145)
        Me.Nama_SupplierTextBox.Name = "Nama_SupplierTextBox"
        Me.Nama_SupplierTextBox.Size = New System.Drawing.Size(660, 26)
        Me.Nama_SupplierTextBox.TabIndex = 21
        '
        'Alamat_SupplierLabel
        '
        Alamat_SupplierLabel.AutoSize = True
        Alamat_SupplierLabel.Location = New System.Drawing.Point(71, 187)
        Alamat_SupplierLabel.Name = "Alamat_SupplierLabel"
        Alamat_SupplierLabel.Size = New System.Drawing.Size(125, 20)
        Alamat_SupplierLabel.TabIndex = 21
        Alamat_SupplierLabel.Text = "Alamat Supplier:"
        '
        'Alamat_SupplierTextBox
        '
        Me.Alamat_SupplierTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "Alamat_Supplier", True))
        Me.Alamat_SupplierTextBox.Location = New System.Drawing.Point(216, 184)
        Me.Alamat_SupplierTextBox.Name = "Alamat_SupplierTextBox"
        Me.Alamat_SupplierTextBox.Size = New System.Drawing.Size(660, 26)
        Me.Alamat_SupplierTextBox.TabIndex = 22
        '
        'Telepon_SupplierLabel
        '
        Telepon_SupplierLabel.AutoSize = True
        Telepon_SupplierLabel.Location = New System.Drawing.Point(71, 225)
        Telepon_SupplierLabel.Name = "Telepon_SupplierLabel"
        Telepon_SupplierLabel.Size = New System.Drawing.Size(132, 20)
        Telepon_SupplierLabel.TabIndex = 22
        Telepon_SupplierLabel.Text = "Telepon Supplier:"
        '
        'Telepon_SupplierTextBox
        '
        Me.Telepon_SupplierTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "Telepon_Supplier", True))
        Me.Telepon_SupplierTextBox.Location = New System.Drawing.Point(216, 222)
        Me.Telepon_SupplierTextBox.Name = "Telepon_SupplierTextBox"
        Me.Telepon_SupplierTextBox.Size = New System.Drawing.Size(234, 26)
        Me.Telepon_SupplierTextBox.TabIndex = 23
        '
        'Fax_SupplierLabel
        '
        Fax_SupplierLabel.AutoSize = True
        Fax_SupplierLabel.Location = New System.Drawing.Point(456, 258)
        Fax_SupplierLabel.Name = "Fax_SupplierLabel"
        Fax_SupplierLabel.Size = New System.Drawing.Size(101, 20)
        Fax_SupplierLabel.TabIndex = 23
        Fax_SupplierLabel.Text = "Fax Supplier:"
        '
        'Fax_SupplierTextBox
        '
        Me.Fax_SupplierTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "Fax_Supplier", True))
        Me.Fax_SupplierTextBox.Location = New System.Drawing.Point(644, 255)
        Me.Fax_SupplierTextBox.Name = "Fax_SupplierTextBox"
        Me.Fax_SupplierTextBox.Size = New System.Drawing.Size(241, 26)
        Me.Fax_SupplierTextBox.TabIndex = 24
        '
        'Email_SupplierLabel
        '
        Email_SupplierLabel.AutoSize = True
        Email_SupplierLabel.Location = New System.Drawing.Point(71, 262)
        Email_SupplierLabel.Name = "Email_SupplierLabel"
        Email_SupplierLabel.Size = New System.Drawing.Size(114, 20)
        Email_SupplierLabel.TabIndex = 24
        Email_SupplierLabel.Text = "Email Supplier:"
        '
        'Email_SupplierTextBox
        '
        Me.Email_SupplierTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "Email_Supplier", True))
        Me.Email_SupplierTextBox.Location = New System.Drawing.Point(216, 259)
        Me.Email_SupplierTextBox.Name = "Email_SupplierTextBox"
        Me.Email_SupplierTextBox.Size = New System.Drawing.Size(234, 26)
        Me.Email_SupplierTextBox.TabIndex = 25
        '
        'Contact_Person_SupplierLabel
        '
        Contact_Person_SupplierLabel.AutoSize = True
        Contact_Person_SupplierLabel.Location = New System.Drawing.Point(453, 228)
        Contact_Person_SupplierLabel.Name = "Contact_Person_SupplierLabel"
        Contact_Person_SupplierLabel.Size = New System.Drawing.Size(185, 20)
        Contact_Person_SupplierLabel.TabIndex = 25
        Contact_Person_SupplierLabel.Text = "Contact Person Supplier:"
        '
        'Contact_Person_SupplierTextBox
        '
        Me.Contact_Person_SupplierTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "Contact_Person_Supplier", True))
        Me.Contact_Person_SupplierTextBox.Location = New System.Drawing.Point(644, 225)
        Me.Contact_Person_SupplierTextBox.Name = "Contact_Person_SupplierTextBox"
        Me.Contact_Person_SupplierTextBox.Size = New System.Drawing.Size(241, 26)
        Me.Contact_Person_SupplierTextBox.TabIndex = 26
        '
        'SupplierDataGridView
        '
        Me.SupplierDataGridView.AutoGenerateColumns = False
        Me.SupplierDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SupplierDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.SupplierDataGridView.DataSource = Me.SupplierBindingSource
        Me.SupplierDataGridView.Location = New System.Drawing.Point(35, 394)
        Me.SupplierDataGridView.Name = "SupplierDataGridView"
        Me.SupplierDataGridView.RowHeadersWidth = 62
        Me.SupplierDataGridView.RowTemplate.Height = 28
        Me.SupplierDataGridView.Size = New System.Drawing.Size(867, 220)
        Me.SupplierDataGridView.TabIndex = 26
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Kode_Supplier"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Kode_Supplier"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nama_Supplier"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nama_Supplier"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Alamat_Supplier"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Alamat_Supplier"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Telepon_Supplier"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Telepon_Supplier"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Fax_Supplier"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Fax_Supplier"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Email_Supplier"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Email_Supplier"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 150
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Contact_Person_Supplier"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Contact_Person_Supplier"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 150
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(366, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 20)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Supplier's Master"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(966, 647)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SupplierDataGridView)
        Me.Controls.Add(Contact_Person_SupplierLabel)
        Me.Controls.Add(Me.Contact_Person_SupplierTextBox)
        Me.Controls.Add(Email_SupplierLabel)
        Me.Controls.Add(Me.Email_SupplierTextBox)
        Me.Controls.Add(Fax_SupplierLabel)
        Me.Controls.Add(Me.Fax_SupplierTextBox)
        Me.Controls.Add(Telepon_SupplierLabel)
        Me.Controls.Add(Me.Telepon_SupplierTextBox)
        Me.Controls.Add(Alamat_SupplierLabel)
        Me.Controls.Add(Me.Alamat_SupplierTextBox)
        Me.Controls.Add(Nama_SupplierLabel)
        Me.Controls.Add(Me.Nama_SupplierTextBox)
        Me.Controls.Add(Kode_SupplierLabel)
        Me.Controls.Add(Me.Kode_SupplierTextBox)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents SupplierBindingSource As BindingSource
    Friend WithEvents SupplierTableAdapter As DataSet1TableAdapters.supplierTableAdapter
    Friend WithEvents TableAdapterManager As DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Kode_SupplierTextBox As TextBox
    Friend WithEvents Nama_SupplierTextBox As TextBox
    Friend WithEvents Alamat_SupplierTextBox As TextBox
    Friend WithEvents Telepon_SupplierTextBox As TextBox
    Friend WithEvents Fax_SupplierTextBox As TextBox
    Friend WithEvents Email_SupplierTextBox As TextBox
    Friend WithEvents Contact_Person_SupplierTextBox As TextBox
    Friend WithEvents SupplierDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
End Class
