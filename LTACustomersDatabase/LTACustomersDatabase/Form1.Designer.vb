﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AccountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StreetDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZipDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BalanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersDatabaseDataSet = New LTACustomersDatabase.CustomersDatabaseDataSet()
        Me.CustomersTableAdapter = New LTACustomersDatabase.CustomersDatabaseDataSetTableAdapters.CustomersTableAdapter()
        Me.TableAdapterManager = New LTACustomersDatabase.CustomersDatabaseDataSetTableAdapters.TableAdapterManager()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Last Name"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(75, 9)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstName.TabIndex = 2
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(76, 31)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(100, 20)
        Me.txtLastName.TabIndex = 3
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(242, 31)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(100, 20)
        Me.txtZip.TabIndex = 11
        '
        'txtStreet
        '
        Me.txtStreet.Location = New System.Drawing.Point(242, 9)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.Size = New System.Drawing.Size(100, 20)
        Me.txtStreet.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(186, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Zip Code"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(201, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Street"
        '
        'txtBalance
        '
        Me.txtBalance.Location = New System.Drawing.Point(405, 12)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.Size = New System.Drawing.Size(100, 20)
        Me.txtBalance.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(353, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Balance"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(15, 66)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(142, 23)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "Add Customer"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Location = New System.Drawing.Point(163, 66)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(141, 23)
        Me.btnDelete.TabIndex = 16
        Me.btnDelete.Text = "Delete Selected Customer"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        Me.btnLoad.Enabled = False
        Me.btnLoad.Location = New System.Drawing.Point(310, 66)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(141, 23)
        Me.btnLoad.TabIndex = 17
        Me.btnLoad.Text = "Load Database"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(457, 66)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(141, 23)
        Me.btnSave.TabIndex = 18
        Me.btnSave.Text = "Save Database"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AccountDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.StreetDataGridViewTextBoxColumn, Me.ZipDataGridViewTextBoxColumn, Me.BalanceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CustomersBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(16, 96)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(646, 379)
        Me.DataGridView1.TabIndex = 19
        '
        'AccountDataGridViewTextBoxColumn
        '
        Me.AccountDataGridViewTextBoxColumn.DataPropertyName = "Account#"
        Me.AccountDataGridViewTextBoxColumn.HeaderText = "Account#"
        Me.AccountDataGridViewTextBoxColumn.Name = "AccountDataGridViewTextBoxColumn"
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        '
        'StreetDataGridViewTextBoxColumn
        '
        Me.StreetDataGridViewTextBoxColumn.DataPropertyName = "Street"
        Me.StreetDataGridViewTextBoxColumn.HeaderText = "Street"
        Me.StreetDataGridViewTextBoxColumn.Name = "StreetDataGridViewTextBoxColumn"
        '
        'ZipDataGridViewTextBoxColumn
        '
        Me.ZipDataGridViewTextBoxColumn.DataPropertyName = "Zip"
        Me.ZipDataGridViewTextBoxColumn.HeaderText = "Zip"
        Me.ZipDataGridViewTextBoxColumn.Name = "ZipDataGridViewTextBoxColumn"
        '
        'BalanceDataGridViewTextBoxColumn
        '
        Me.BalanceDataGridViewTextBoxColumn.DataPropertyName = "Balance"
        Me.BalanceDataGridViewTextBoxColumn.HeaderText = "Balance"
        Me.BalanceDataGridViewTextBoxColumn.Name = "BalanceDataGridViewTextBoxColumn"
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "Customers"
        Me.CustomersBindingSource.DataSource = Me.CustomersDatabaseDataSet
        '
        'CustomersDatabaseDataSet
        '
        Me.CustomersDatabaseDataSet.DataSetName = "CustomersDatabaseDataSet"
        Me.CustomersDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = True
        Me.TableAdapterManager.CustomersTableAdapter = Me.CustomersTableAdapter
        Me.TableAdapterManager.UpdateOrder = LTACustomersDatabase.CustomersDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 487)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtBalance)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.txtStreet)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Customers Database"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtZip As System.Windows.Forms.TextBox
    Friend WithEvents txtStreet As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtBalance As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CustomersDatabaseDataSet As LTACustomersDatabase.CustomersDatabaseDataSet
    Friend WithEvents CustomersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomersTableAdapter As LTACustomersDatabase.CustomersDatabaseDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents AccountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StreetDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ZipDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BalanceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TableAdapterManager As LTACustomersDatabase.CustomersDatabaseDataSetTableAdapters.TableAdapterManager

End Class
