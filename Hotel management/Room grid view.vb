Public Class Room_grid_view
    Private Sub RoomBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles RoomBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RoomBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database2DataSet3)

    End Sub

    Private Sub Room_grid_view_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database2DataSet3.Room' table. You can move, or remove it, as needed.
        Me.RoomTableAdapter.Fill(Me.Database2DataSet3.Room)

    End Sub
End Class