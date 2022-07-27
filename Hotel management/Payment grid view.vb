Public Class Payment_grid_view
    Private Sub RegisterBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles RegisterBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RegisterBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub Payment_grid_view_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database2DataSet2.Payments' table. You can move, or remove it, as needed.
        Me.PaymentsTableAdapter.Fill(Me.Database2DataSet2.Payments)
        'TODO: This line of code loads data into the 'Database1DataSet.Register' table. You can move, or remove it, as needed.
        Me.RegisterTableAdapter.Fill(Me.Database1DataSet.Register)

    End Sub
End Class