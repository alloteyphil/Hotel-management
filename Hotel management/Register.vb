Imports System.Data.SqlClient
Public Class Register
    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader
            con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\allot\OneDrive\Desktop\Hotel management\Hotel management\Database1.mdf;Integrated Security=True"
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from register where username='" & TextBoxUName.Text & "' "
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                MsgBox("User Already Registered", MsgBoxStyle.Critical)
                con.Close()
            Else
                con.Close()
                con.Open()

                cmd = New SqlCommand("INSERT INTO register values('" & TextBoxFName.Text & "','" & TextBoxLName.Text & "','" & ComboBoxGender.SelectedItem.ToString() & "','" & TextBoxNumber.Text & "','" & TextBoxUName.Text & "','" & TextBoxPassword.Text & "')", con)
                If (TextBoxFName.Text = "" And TextBoxLName.Text = "" And ComboBoxGender.SelectedItem.ToString() = "" And TextBoxNumber.Text = "" And TextBoxUName.Text = "" And TextBoxPassword.Text = "") Then
                    MessageBox.Show("Please enter the details")
                Else
                    cmd.ExecuteNonQuery()
                    MsgBox("Succerssfully Registered.", MsgBoxStyle.Information, "Success")
                    Me.Hide()
                    login.show()
                End If
                con.Close()
            End If
            con.Close()
        Catch ex As Exception
            MsgBox("Error")

        End Try
    End Sub
End Class