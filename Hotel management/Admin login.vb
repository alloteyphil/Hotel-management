Imports System.Data.SqlClient
Public Class Admin_login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\allot\OneDrive\Desktop\Hotel management\Hotel management\Admin login.mdf;Integrated Security=True"
        Dim objcon As SqlConnection = Nothing
        Dim objcmd As SqlCommand = Nothing

        Try
            objcon = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\allot\OneDrive\Desktop\Hotel management\Hotel management\Admin login.mdf;Integrated Security=True")
            objcon.Open()
            Dim stmt As String = "select * from admin login where username ='" & TextBoxUName.Text & "' AND password ='" & TextBoxPassword.Text & "' "
            objcmd = New SqlCommand(stmt, objcon)
            Dim reader As SqlDataReader = objcmd.ExecuteReader
            If reader.Read Then
                MessageBox.Show("Login successfully")
                Me.Hide()
                Admin_Hmepage.Show()
            Else
                MessageBox.Show("Invalid Login Please Check!")
                Welcome.Show()
            End If
        Catch ex As Exception
            MsgBox("MSSQL ERROR")
        End Try
    End Sub

    Private Sub Admin_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class