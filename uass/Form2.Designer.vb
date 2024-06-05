<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim Kode_UserLabel As System.Windows.Forms.Label
        Dim Nama_UserLabel As System.Windows.Forms.Label
        Dim Pwd_UserLabel As System.Windows.Forms.Label
        Dim Status_UserLabel As System.Windows.Forms.Label
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New uass.DataSet1()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.UserTableAdapter = New uass.DataSet1TableAdapters.userTableAdapter()
        Me.TableAdapterManager = New uass.DataSet1TableAdapters.TableAdapterManager()
        Me.Kode_UserTextBox = New System.Windows.Forms.TextBox()
        Me.Nama_UserTextBox = New System.Windows.Forms.TextBox()
        Me.Pwd_UserTextBox = New System.Windows.Forms.TextBox()
        Me.UserDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status_UserComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Kode_UserLabel = New System.Windows.Forms.Label()
        Nama_UserLabel = New System.Windows.Forms.Label()
        Pwd_UserLabel = New System.Windows.Forms.Label()
        Status_UserLabel = New System.Windows.Forms.Label()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Kode_UserLabel
        '
        Kode_UserLabel.AutoSize = True
        Kode_UserLabel.Location = New System.Drawing.Point(135, 114)
        Kode_UserLabel.Name = "Kode_UserLabel"
        Kode_UserLabel.Size = New System.Drawing.Size(88, 20)
        Kode_UserLabel.TabIndex = 14
        Kode_UserLabel.Text = "Kode User:"
        '
        'Nama_UserLabel
        '
        Nama_UserLabel.AutoSize = True
        Nama_UserLabel.Location = New System.Drawing.Point(135, 146)
        Nama_UserLabel.Name = "Nama_UserLabel"
        Nama_UserLabel.Size = New System.Drawing.Size(93, 20)
        Nama_UserLabel.TabIndex = 15
        Nama_UserLabel.Text = "Nama User:"
        '
        'Pwd_UserLabel
        '
        Pwd_UserLabel.AutoSize = True
        Pwd_UserLabel.Location = New System.Drawing.Point(135, 180)
        Pwd_UserLabel.Name = "Pwd_UserLabel"
        Pwd_UserLabel.Size = New System.Drawing.Size(81, 20)
        Pwd_UserLabel.TabIndex = 17
        Pwd_UserLabel.Text = "Pwd User:"
        '
        'UserBindingSource
        '
        Me.UserBindingSource.DataMember = "user"
        Me.UserBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(607, 249)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 48)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Keluar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(164, 249)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 48)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Tambah"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(275, 249)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(84, 48)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Simpan"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(384, 249)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(84, 48)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Hapus"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(495, 249)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(84, 48)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "Batal"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'UserTableAdapter
        '
        Me.UserTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.supplierTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = uass.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.userTableAdapter = Me.UserTableAdapter
        '
        'Kode_UserTextBox
        '
        Me.Kode_UserTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "Kode_User", True))
        Me.Kode_UserTextBox.Location = New System.Drawing.Point(259, 114)
        Me.Kode_UserTextBox.Name = "Kode_UserTextBox"
        Me.Kode_UserTextBox.Size = New System.Drawing.Size(528, 26)
        Me.Kode_UserTextBox.TabIndex = 15
        '
        'Nama_UserTextBox
        '
        Me.Nama_UserTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "Nama_User", True))
        Me.Nama_UserTextBox.Location = New System.Drawing.Point(259, 143)
        Me.Nama_UserTextBox.Name = "Nama_UserTextBox"
        Me.Nama_UserTextBox.Size = New System.Drawing.Size(528, 26)
        Me.Nama_UserTextBox.TabIndex = 16
        '
        'Pwd_UserTextBox
        '
        Me.Pwd_UserTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "Pwd_User", True))
        Me.Pwd_UserTextBox.Location = New System.Drawing.Point(259, 175)
        Me.Pwd_UserTextBox.Name = "Pwd_UserTextBox"
        Me.Pwd_UserTextBox.Size = New System.Drawing.Size(216, 26)
        Me.Pwd_UserTextBox.TabIndex = 18
        '
        'UserDataGridView
        '
        Me.UserDataGridView.AutoGenerateColumns = False
        Me.UserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UserDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.UserDataGridView.DataSource = Me.UserBindingSource
        Me.UserDataGridView.Location = New System.Drawing.Point(116, 333)
        Me.UserDataGridView.Name = "UserDataGridView"
        Me.UserDataGridView.RowHeadersWidth = 62
        Me.UserDataGridView.RowTemplate.Height = 28
        Me.UserDataGridView.Size = New System.Drawing.Size(696, 220)
        Me.UserDataGridView.TabIndex = 18
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Kode_User"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Kode_User"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nama_User"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nama_User"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Pwd_User"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Pwd_User"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Status_User"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Status_User"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'Status_UserLabel
        '
        Status_UserLabel.AutoSize = True
        Status_UserLabel.Location = New System.Drawing.Point(481, 175)
        Status_UserLabel.Name = "Status_UserLabel"
        Status_UserLabel.Size = New System.Drawing.Size(98, 20)
        Status_UserLabel.TabIndex = 18
        Status_UserLabel.Text = "Status User:"
        '
        'Status_UserComboBox
        '
        Me.Status_UserComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "Status_User", True))
        Me.Status_UserComboBox.FormattingEnabled = True
        Me.Status_UserComboBox.Items.AddRange(New Object() {"ADMIN", "USER"})
        Me.Status_UserComboBox.Location = New System.Drawing.Point(585, 172)
        Me.Status_UserComboBox.Name = "Status_UserComboBox"
        Me.Status_UserComboBox.Size = New System.Drawing.Size(202, 28)
        Me.Status_UserComboBox.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(380, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 20)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "User's Master"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 583)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Status_UserLabel)
        Me.Controls.Add(Me.Status_UserComboBox)
        Me.Controls.Add(Me.UserDataGridView)
        Me.Controls.Add(Pwd_UserLabel)
        Me.Controls.Add(Me.Pwd_UserTextBox)
        Me.Controls.Add(Nama_UserLabel)
        Me.Controls.Add(Me.Nama_UserTextBox)
        Me.Controls.Add(Kode_UserLabel)
        Me.Controls.Add(Me.Kode_UserTextBox)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents UserBindingSource As BindingSource
    Friend WithEvents UserTableAdapter As DataSet1TableAdapters.userTableAdapter
    Friend WithEvents TableAdapterManager As DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Kode_UserTextBox As TextBox
    Friend WithEvents Nama_UserTextBox As TextBox
    Friend WithEvents Pwd_UserTextBox As TextBox
    Friend WithEvents UserDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Status_UserComboBox As ComboBox
    Friend WithEvents Label1 As Label
End Class
