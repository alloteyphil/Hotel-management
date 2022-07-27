Imports System.Data
Imports System.Data.SqlClient
Public Class Payments
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader
            con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\allot\OneDrive\Desktop\Hotel management\Hotel management\Database2.mdf;Integrated Security=True"
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from payments where paymentid='" & TextBoxPaymentID.Text & "' "
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                MsgBox("Payment Already Registered", MsgBoxStyle.Critical)
                con.Close()
            Else
                con.Close()
                con.Open()

                cmd = New SqlCommand("insert into payments values('" & TextBoxPaymentID.Text & "','" & TextBoxCustomerName.Text & "','" & TextBoxBankName.Text & "','" & TextBoxCardNumber.Text & "','" & TextBoxBranch.Text & "')", con)
                If (TextBoxPaymentID.Text = "" And TextBoxCustomerName.Text = "" And TextBoxBankName.Text = "" And TextBoxCardNumber.Text = "" And TextBoxBranch.Text = "") Then
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
        Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\allot\OneDrive\Desktop\Hotel management\Hotel management\Database2.mdf;Integrated Security=True")
        If TextBoxPaymentID.Text = "" Then
            MessageBox.Show("Empty Id")

        Else

            Dim command As New SqlCommand("UPDATE payments SET CustomerName = @cn ,Bankname = @bn ,CardNumber = @cardnum, BankBranch =@Bankb WHERE paymentid = @id", connection)

            command.Parameters.Add("@cn", SqlDbType.VarChar).Value = TextBoxCustomerName.Text
            command.Parameters.Add("@bn", SqlDbType.VarChar).Value = TextBoxBankName.Text
            command.Parameters.Add("@cardnum", SqlDbType.VarChar).Value = TextBoxCardNumber.Text
            command.Parameters.Add("@bankb", SqlDbType.VarChar).Value = TextBoxBranch.Text
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = TextBoxPaymentID.Text

            connection.Open()

            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Data Updated")
            Else
                MessageBox.Show("Data Not Updated")
            End If

            connection.Close()

        End If


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Admin_Hmepage.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\allot\OneDrive\Desktop\Hotel management\Hotel management\Database2.mdf;Integrated Security=True")
        Dim command As New SqlCommand("DELETE FROM payments WHERE PaymentID = @id", connection)
        command.Parameters.Add("@id", SqlDbType.VarChar).Value = TextBoxPaymentID.Text
        connection.Open()

        If command.ExecuteNonQuery() = 1 Then

            MessageBox.Show("Payment Deleted")

        Else

            MessageBox.Show("Payment Deleted")

        End If

        connection.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Payment_grid_view.Show()
    End Sub
End Class