Public Class Booking_grid_view
    Private Sub BookingBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BookingBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BookingBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database2DataSet)

    End Sub

    Private Sub Booking_grid_view_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database2DataSet.Booking' table. You can move, or remove it, as needed.
        Me.BookingTableAdapter.Fill(Me.Database2DataSet.Booking)

    End Sub
End Class