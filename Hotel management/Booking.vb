Imports System.Data
Imports System.Data.SqlClient

Public Class Booking
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Welcome.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Customer.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader
            con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\allot\OneDrive\Desktop\Hotel management\Hotel management\Database2.mdf;Integrated Security=True"
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from booking where bookingid='" & TextBoxBookingID.Text & "' "
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                MsgBox("Booking Already Registered", MsgBoxStyle.Critical)
                con.Close()
            Else
                con.Close()
                con.Open()

                cmd = New SqlCommand("insert into booking values('" & TextBoxBookingID.Text & "','" & TextBoxCustomerID.Text & "','" & TextBoxPaymentID.Text & "','" & MonthCalendarStartDate.SelectionStart.ToString("MM/dd/yyyy") & "','" & MonthCalendarEndDate.SelectionStart.ToString("MM/dd/yyyy") & "','" & TextBoxRoom.Text & "','" & ComboBoxRoomtype.SelectedItem.ToString() & "')", con)
                If (TextBoxBookingID.Text = "" And TextBoxCustomerID.Text = "" And TextBoxPaymentID.Text = "" And MonthCalendarStartDate.SelectionStart.ToString("MM/dd/yyyy") = "" And MonthCalendarEndDate.SelectionStart.ToString("MM/dd/yyyy") = "" And TextBoxRoom.Text = "" And ComboBoxRoomtype.SelectedItem.ToString() = "") Then
                    MessageBox.Show("Please enter the details")
                Else
                    cmd.ExecuteNonQuery()
                    MsgBox("Booking stored successfully.", MsgBoxStyle.Information, "Success")
                End If
                con.Close()
            End If
            con.Close()
        Catch ex As Exception
            MsgBox("Error")

        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\allot\OneDrive\Desktop\Hotel management\Hotel management\Database2.mdf;Integrated Security=True")
        If TextBoxBookingID.Text = "" Then
            MessageBox.Show("Empty Id")

        Else

            Dim command As New SqlCommand("UPDATE booking SET CustomerID = @customerid ,PaymentID = @payid ,StartDateBooking = @startbook, EndDateBooking= @endbook, Room =@room, Roomtype=@roomtype WHERE bookingid = @id", connection)

            command.Parameters.Add("@customerid", SqlDbType.VarChar).Value = TextBoxCustomerID.Text
            command.Parameters.Add("@payid", SqlDbType.VarChar).Value = TextBoxPaymentID.Text
            command.Parameters.Add("@startbook", SqlDbType.VarChar).Value = MonthCalendarStartDate.SelectionStart.ToString("MM/dd/yyyy")
            command.Parameters.Add("@endbook", SqlDbType.VarChar).Value = MonthCalendarEndDate.SelectionStart.ToString("MM/dd/yyyy")
            command.Parameters.Add("@room", SqlDbType.VarChar).Value = TextBoxRoom.Text
            command.Parameters.Add("@roomtype", SqlDbType.VarChar).Value = ComboBoxRoomtype.SelectedItem.ToString()
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = TextBoxBookingID.Text

            connection.Open()

            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Booking Updated")
            Else
                MessageBox.Show("Booking Not Updated")
            End If

            connection.Close()

        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\allot\OneDrive\Desktop\Hotel management\Hotel management\Database2.mdf;Integrated Security=True")
        Dim command As New SqlCommand("DELETE FROM booking WHERE bookingid = @id", connection)
        command.Parameters.Add("@id", SqlDbType.VarChar).Value = TextBoxBookingID.Text
        connection.Open()

        If command.ExecuteNonQuery() = 1 Then

            MessageBox.Show("Booking Deleted")

        Else

            MessageBox.Show("Booking Not Deleted")

        End If

        connection.Close()

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Booking_grid_view.Show()
    End Sub
End Class