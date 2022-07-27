<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Booking
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Booking))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxBookingID = New System.Windows.Forms.TextBox()
        Me.TextBoxCustomerID = New System.Windows.Forms.TextBox()
        Me.TextBoxPaymentID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBoxRoomtype = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBoxRoom = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.MonthCalendarStartDate = New System.Windows.Forms.MonthCalendar()
        Me.MonthCalendarEndDate = New System.Windows.Forms.MonthCalendar()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(509, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Booking"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(195, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Booking ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(195, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Customer ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(195, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(181, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Start Date Booking"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(776, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(178, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "End Date Booking"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(195, 546)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 24)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Payment ID"
        '
        'TextBoxBookingID
        '
        Me.TextBoxBookingID.Location = New System.Drawing.Point(447, 80)
        Me.TextBoxBookingID.Name = "TextBoxBookingID"
        Me.TextBoxBookingID.Size = New System.Drawing.Size(271, 20)
        Me.TextBoxBookingID.TabIndex = 6
        '
        'TextBoxCustomerID
        '
        Me.TextBoxCustomerID.Location = New System.Drawing.Point(447, 135)
        Me.TextBoxCustomerID.Name = "TextBoxCustomerID"
        Me.TextBoxCustomerID.Size = New System.Drawing.Size(271, 20)
        Me.TextBoxCustomerID.TabIndex = 7
        '
        'TextBoxPaymentID
        '
        Me.TextBoxPaymentID.Location = New System.Drawing.Point(447, 546)
        Me.TextBoxPaymentID.Name = "TextBoxPaymentID"
        Me.TextBoxPaymentID.Size = New System.Drawing.Size(271, 20)
        Me.TextBoxPaymentID.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(195, 456)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 24)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Room Type"
        '
        'ComboBoxRoomtype
        '
        Me.ComboBoxRoomtype.FormattingEnabled = True
        Me.ComboBoxRoomtype.Items.AddRange(New Object() {"Queen of Queens", "Standard room", "Twin room"})
        Me.ComboBoxRoomtype.Location = New System.Drawing.Point(447, 456)
        Me.ComboBoxRoomtype.Name = "ComboBoxRoomtype"
        Me.ComboBoxRoomtype.Size = New System.Drawing.Size(271, 21)
        Me.ComboBoxRoomtype.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(195, 388)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 24)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Room"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1117, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 29)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Logout"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(258, 643)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(109, 44)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Add Booking"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(868, 23)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(205, 29)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Register New Customer"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBoxRoom
        '
        Me.TextBoxRoom.Location = New System.Drawing.Point(447, 392)
        Me.TextBoxRoom.Name = "TextBoxRoom"
        Me.TextBoxRoom.Size = New System.Drawing.Size(271, 20)
        Me.TextBoxRoom.TabIndex = 20
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(502, 643)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(131, 44)
        Me.Button4.TabIndex = 23
        Me.Button4.Text = "Update Booking"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(725, 643)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(132, 44)
        Me.Button5.TabIndex = 24
        Me.Button5.Text = "Delete booking"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(956, 643)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(100, 44)
        Me.Button6.TabIndex = 25
        Me.Button6.Text = "View booking"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'MonthCalendarStartDate
        '
        Me.MonthCalendarStartDate.Location = New System.Drawing.Point(447, 210)
        Me.MonthCalendarStartDate.Name = "MonthCalendarStartDate"
        Me.MonthCalendarStartDate.TabIndex = 26
        '
        'MonthCalendarEndDate
        '
        Me.MonthCalendarEndDate.Location = New System.Drawing.Point(977, 210)
        Me.MonthCalendarEndDate.Name = "MonthCalendarEndDate"
        Me.MonthCalendarEndDate.TabIndex = 27
        '
        'Booking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1216, 710)
        Me.Controls.Add(Me.MonthCalendarEndDate)
        Me.Controls.Add(Me.MonthCalendarStartDate)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TextBoxRoom)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ComboBoxRoomtype)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBoxPaymentID)
        Me.Controls.Add(Me.TextBoxCustomerID)
        Me.Controls.Add(Me.TextBoxBookingID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Booking"
        Me.Text = "Booking"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxBookingID As TextBox
    Friend WithEvents TextBoxCustomerID As TextBox
    Friend WithEvents TextBoxPaymentID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBoxRoomtype As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBoxRoom As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents MonthCalendarStartDate As MonthCalendar
    Friend WithEvents MonthCalendarEndDate As MonthCalendar
End Class
