Public Class Customer_grid_view
    Private Sub CustomerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CustomerBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database2DataSet1)

    End Sub

    Private Sub Customer_grid_view_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database2DataSet1.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.Database2DataSet1.Customer)

    End Sub
End Class