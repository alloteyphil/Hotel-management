Imports System.Data.SqlClient
Public Class Room
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader
            con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\allot\OneDrive\Desktop\Hotel management\Hotel management\Database2.mdf;Integrated Security=True"
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from room where roomid='" & TextBoxRoomID.Text & "' "
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                MsgBox("Room Already Registered", MsgBoxStyle.Critical)
                con.Close()
            Else
                con.Close()
                con.Open()

                cmd = New SqlCommand("insert into room values('" & TextBoxRoomID.Text & "','" & TextBoxBookingID.Text & "','" & TextBoxRoom.Text & "','" & ComboBoxRoomType.SelectedItem.ToString() & "','" & ComboBoxBedChoice.SelectedItem.ToString() & "','" & TextBoxRoomPrice.Text & "','" & ComboBoxRoomAvailable.SelectedItem.ToString() & "')", con)
                If (TextBoxRoomID.Text = "" And TextBoxBookingID.Text = "" And TextBoxRoom.Text = "" And ComboBoxRoomType.SelectedItem.ToString() = "" And ComboBoxBedChoice.SelectedItem.ToString() = "" And TextBoxRoomPrice.Text = "" And ComboBoxRoomAvailable.SelectedItem.ToString() = "") Then
                    MessageBox.Show("Please enter the details")
                Else
                    cmd.ExecuteNonQuery()
                    MsgBox("Succerssfully added.", MsgBoxStyle.Information, "Success")
                End If
                con.Close()
            End If
            con.Close()
        Catch ex As Exception
            MsgBox("Error")

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\allot\OneDrive\Desktop\Hotel management\Hotel management\Database2.mdf;Integrated Security=True")
        If TextBoxRoomID.Text = "" Then
            MessageBox.Show("Empty Id")

        Else

            Dim command As New SqlCommand("UPDATE room SET BookingID = @bookingid ,Room = @room ,Roomtype = @roomtype, Bedchoice= @bedchoice, Roomprice =@roomprice, Roomavailability=@roomavailability WHERE roomid = @id", connection)

            command.Parameters.Add("@bookingid", SqlDbType.VarChar).Value = TextBoxBookingID.Text
            command.Parameters.Add("@room", SqlDbType.VarChar).Value = TextBoxRoom.Text
            command.Parameters.Add("@roomtype", SqlDbType.VarChar).Value = ComboBoxRoomType.SelectedItem.ToString()
            command.Parameters.Add("@bedchoice", SqlDbType.VarChar).Value = ComboBoxBedChoice.SelectedItem.ToString()
            command.Parameters.Add("@roomprice", SqlDbType.VarChar).Value = TextBoxRoomPrice.Text
            command.Parameters.Add("@roomavailability", SqlDbType.VarChar).Value = ComboBoxRoomAvailable.SelectedItem.ToString()
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = TextBoxRoomID.Text

            connection.Open()

            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Room Updated")
            Else
                MessageBox.Show("Room Not Updated")
            End If

            connection.Close()

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\allot\OneDrive\Desktop\Hotel management\Hotel management\Database2.mdf;Integrated Security=True")
        Dim command As New SqlCommand("DELETE FROM room WHERE roomid = @id", connection)
        command.Parameters.Add("@id", SqlDbType.VarChar).Value = TextBoxRoomID.Text
        connection.Open()

        If command.ExecuteNonQuery() = 1 Then

            MessageBox.Show("Room Deleted")

        Else

            MessageBox.Show("Room Not Deleted")

        End If

        connection.Close()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Admin_Hmepage.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Room_grid_view.Show()
    End Sub
End Class