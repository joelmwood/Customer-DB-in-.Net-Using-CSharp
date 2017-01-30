Imports LTACustomersDatabase.CustomersDatabaseDataSetTableAdapters

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CustomersDatabaseDataSet.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.CustomersDatabaseDataSet.Customers)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Me.CustomersDatabaseDataSet.Customers.Rows.Add(Me.CustomersDatabaseDataSet.Customers.Rows.Count + 1, txtFirstName.Text, txtLastName.Text, txtStreet.Text, txtZip.Text, txtBalance.Text)

        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtStreet.Text = ""
        txtZip.Text = ""
        txtBalance.Text = ""



    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.Validate()
        Me.CustomersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CustomersDatabaseDataSet)
        
        
    End Sub
End Class
