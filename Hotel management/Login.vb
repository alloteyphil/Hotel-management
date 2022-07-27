Imports System.Data.SqlClient
Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\allot\OneDrive\Desktop\Hotel management\Hotel management\Database1.mdf;Integrated Security=True "
        Dim objcon As SqlConnection = Nothing
        Dim objcmd As SqlCommand = Nothing

        Try
            objcon = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\allot\OneDrive\Desktop\Hotel management\Hotel management\Database1.mdf;Integrated Security=True")
            objcon.Open()
            Dim stmt As String = "select * from register where username ='" & TextBoxUName.Text & "' AND password ='" & TextBoxPassword.Text & "' "
            objcmd = New SqlCommand(stmt, objcon)
            Dim reader As SqlDataReader = objcmd.ExecuteReader
            If reader.Read Then
                MessageBox.Show("Login successfully")
                Me.Hide()
                Customer.Show()
            Else
                MessageBox.Show("Invalid Login Please Check!")
                Welcome.Show()
            End If
        Catch ex As Exception
            MsgBox("MSSQL ERROR")
        End Try
    End Sub
End Class