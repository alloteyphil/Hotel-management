Imports System.Data.SqlClient
Public Class Customer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader
            con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\allot\OneDrive\Desktop\Hotel management\Hotel management\Database2.mdf;Integrated Security=True"
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from customer where id='" & TextBoxID.Text & "' "
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                MsgBox("Customer Already Registered", MsgBoxStyle.Critical)
                con.Close()
            Else
                con.Close()
                con.Open()

                cmd = New SqlCommand("INSERT INTO customer values('" & TextBoxID.Text & "','" & TextBoxFName.Text & "','" & TextBoxLName.Text & "','" & ComboBoxGender.SelectedItem.ToString() & "','" & TextBoxAddress.Text & "','" & TextBoxCity.Text & "','" & TextBoxPostcode.Text & "' ,'" & TextBoxNumber.Text & "','" & TextBoxEmail.Text & "','" & MonthCalendarDOB.SelectionStart.ToString("MM/dd/yyyy") & "')", con)
                If (TextBoxID.Text = "" And TextBoxFName.Text = "" And TextBoxLName.Text = "" And ComboBoxGender.SelectedItem.ToString() = "" And TextBoxAddress.Text = "" And TextBoxCity.Text = "" And TextBoxPostcode.Text = "" And TextBoxNumber.Text = "" And TextBoxEmail.Text = "" And MonthCalendarDOB.SelectionStart.ToString("MM/dd/yyyy") = "") Then
                    MessageBox.Show("Please enter the details")
                Else
                    cmd.ExecuteNonQuery()
                    MsgBox("Succerssfully Registered.", MsgBoxStyle.Information, "Success")
                End If
                con.Close()
            End If
            con.Close()
        Catch ex As Exception
            MsgBox("Error")

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Welcome.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\allot\OneDrive\Desktop\Hotel management\Hotel management\Database2.mdf;Integrated Security=True")
        If TextBoxID.Text = "" Then
            MessageBox.Show("Empty Id")

        Else

            Dim command As New SqlCommand("UPDATE customer SET FirstName = @fname ,LastName = @lname , Gender= @gender, Address= @address,  City=@city, Postcode=@postcode, Phonenumber=@pnumber, Email=@email, DateofBirth= @dob WHERE ID = @id", connection)

            command.Parameters.Add("@fname", SqlDbType.VarChar).Value = TextBoxFName.Text
            command.Parameters.Add("@lname", SqlDbType.VarChar).Value = TextBoxLName.Text
            command.Parameters.Add("@gender", SqlDbType.VarChar).Value = ComboBoxGender.SelectedItem.ToString()
            command.Parameters.Add("@address", SqlDbType.VarChar).Value = TextBoxAddress.Text
            command.Parameters.Add("@city", SqlDbType.VarChar).Value = TextBoxCity.Text
            command.Parameters.Add("@postcode", SqlDbType.VarChar).Value = TextBoxPostcode.Text
            command.Parameters.Add("@pnumber", SqlDbType.VarChar).Value = TextBoxNumber.Text
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = TextBoxEmail.Text
            command.Parameters.Add("@dob", SqlDbType.VarChar).Value = MonthCalendarDOB.SelectionStart.ToString("MM/dd/yyyy")
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = TextBoxID.Text

            connection.Open()

            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Customer Details Updated")
            Else
                MessageBox.Show("Customer Details Not Updated")
            End If

            connection.Close()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\allot\OneDrive\Desktop\Hotel management\Hotel management\Database2.mdf;Integrated Security=True")
        Dim command As New SqlCommand("DELETE FROM customer WHERE ID = @id", connection)
        command.Parameters.Add("@id", SqlDbType.VarChar).Value = TextBoxID.Text
        connection.Open()

        If command.ExecuteNonQuery() = 1 Then

            MessageBox.Show("Customer Details Deleted")

        Else

            MessageBox.Show("Customer Details Not Deleted")

        End If

        connection.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Customer_grid_view.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        Booking.Show()
    End Sub
End Class