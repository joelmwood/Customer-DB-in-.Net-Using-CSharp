Imports LTACustomersDatabase.CustomersDatabaseDataSetTableAdapters

Public Class Form1

    ' This is a class level variable that represents the customer data table adapter
    Dim CustomerTA As New CustomersDatabaseDataSetTableAdapters.CustomersTableAdapter

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CustomersDatabaseDataSet.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.CustomersDatabaseDataSet.Customers)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If txtFirstName.Text <> String.Empty And txtLastName.Text <> String.Empty Then
            'Make sure there are no other empty fields
            If txtStreet.Text = String.Empty Then txtStreet.Text = "Uknown"
            If txtZip.Text = String.Empty Then txtZip.Text = "00000"
            If txtBalance.Text = String.Empty Then txtBalance.Text = "0.00"


            ' Insert the new Record and refresh the dataset and therefore gridview
            CustomerTA.Insert(txtFirstName.Text, txtLastName.Text, txtStreet.Text, CType(txtZip.Text, Int32), CType(txtBalance.Text, Decimal?))
            CustomerTA.Fill(Me.CustomersDatabaseDataSet.Customers)

            ' Clear the text fields
            resetUIFields()

            ' turn off Update and Delete buttons
            turnOffButtons()
        Else
            MessageBox.Show("You must enter first and lastname, at miminum", "DATA ENTRY ERROR", MessageBoxButtons.OK)
        End If

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If lblAccountNumber.Text <> String.Empty Then

            ' turn off Update and Delete buttons
            turnOffButtons()

            ' Delete the customer record, using the Account Number, which is Unique and refresh the datagridview
            CustomerTA.Delete(CType(lblAccountNumber.Text, Integer))
            CustomerTA.Fill(Me.CustomersDatabaseDataSet.Customers)

            ' Clear the text fields
            resetUIFields()
        Else
            MessageBox.Show("There are no records to delete", "DATA ERROR", MessageBoxButtons.OK)
        End If

    End Sub

    Private Sub DataGridView1_RowEnter_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.RowEnter
        ' Fill in the UI with the selected record
        If DataGridView1.SelectedRows.Count > 0 Then

            lblAccountNumber.Text = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
            txtFirstName.Text = DataGridView1.SelectedRows(0).Cells(1).Value.ToString()
            txtLastName.Text = DataGridView1.SelectedRows(0).Cells(2).Value.ToString()
            txtStreet.Text = DataGridView1.SelectedRows(0).Cells(3).Value.ToString()
            txtZip.Text = DataGridView1.SelectedRows(0).Cells(4).Value.ToString()
            txtBalance.Text = DataGridView1.SelectedRows(0).Cells(5).Value.ToString()

            btnUpdateRecord.Enabled = True
            btnDelete.Enabled = True

        End If
    End Sub

    Private Sub btnUpdateRecord_Click(sender As Object, e As EventArgs) Handles btnUpdateRecord.Click
        If txtFirstName.Text <> String.Empty And txtLastName.Text <> String.Empty Then
            'Make sure there are no other empty fields
            If txtStreet.Text = String.Empty Then txtStreet.Text = "Uknown"
            If txtZip.Text = String.Empty Then txtZip.Text = "00000"
            If txtBalance.Text = String.Empty Then txtBalance.Text = "0.00"

            ' Update the record and then refresh the datagrid
            CustomerTA.Update(txtFirstName.Text, txtLastName.Text, txtStreet.Text, CType(txtZip.Text, Integer?), CType(txtBalance.Text, Decimal?), CType(lblAccountNumber.Text, Integer), CType(lblAccountNumber.Text, Integer))
            CustomerTA.Fill(Me.CustomersDatabaseDataSet.Customers)

            ' Clear the text fields
            resetUIFields()

            ' turn off the update button
            btnUpdateRecord.Enabled = False
        Else
            MessageBox.Show("You must enter first and lastname, at miminum", "DATA ENTRY ERROR", MessageBoxButtons.OK)
        End If

    End Sub

    Private Sub resetUIFields()
        ' Clear the text fields
        txtFirstName.ResetText()
        txtLastName.ResetText()
        txtStreet.ResetText()
        txtZip.ResetText()
        txtBalance.ResetText()
        lblAccountNumber.ResetText()

    End Sub

    Private Sub turnOffButtons()
        ' turn off Update and Delete buttons
        btnDelete.Enabled = False
        btnUpdateRecord.Enabled = False

    End Sub

End Class
