Imports System.Data.SqlClient
Public Class User_login_homepage
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\allot\OneDrive\Desktop\Hotel management\Hotel management\Database1.mdf;Integrated Security=True"
        If TextBoxUName.Text = "" Then
            MessageBox.Show("Empty Id")

        Else

            Dim command As New SqlCommand("UPDATE register SET Firstname = @fname ,Lastname = @lname , Gender= @gender, Phonenumber= @pnumber,  Password=@password WHERE Username = @username", con)

            command.Parameters.Add("@fname", SqlDbType.VarChar).Value = TextBoxFName.Text
            command.Parameters.Add("@lname", SqlDbType.VarChar).Value = TextBoxLName.Text
            command.Parameters.Add("@gender", SqlDbType.VarChar).Value = ComboBoxGender.SelectedItem.ToString()
            command.Parameters.Add("@pnumber", SqlDbType.VarChar).Value = TextBoxNumber.Text
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = TextBoxPassword.Text
            command.Parameters.Add("@username", SqlDbType.VarChar).Value = TextBoxUName.Text


            con.Open()

            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("User Login Details Updated")
            Else
                MessageBox.Show("User login Details Not Updated")
            End If

            con.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\allot\OneDrive\Desktop\Hotel management\Hotel management\Database1.mdf;Integrated Security=True")
        Dim command As New SqlCommand("DELETE FROM register WHERE Username = @username", connection)
        command.Parameters.Add("@username", SqlDbType.VarChar).Value = TextBoxUName.Text
        connection.Open()

        If command.ExecuteNonQuery() = 1 Then

            MessageBox.Show("User login details Deleted")

        Else

            MessageBox.Show("User login details Not Deleted")

        End If

        connection.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        User_login_grid_view.Show()
    End Sub
End Class