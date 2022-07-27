<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Room
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Room))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxRoomID = New System.Windows.Forms.TextBox()
        Me.TextBoxBookingID = New System.Windows.Forms.TextBox()
        Me.TextBoxRoom = New System.Windows.Forms.TextBox()
        Me.ComboBoxRoomType = New System.Windows.Forms.ComboBox()
        Me.ComboBoxBedChoice = New System.Windows.Forms.ComboBox()
        Me.TextBoxRoomPrice = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBoxRoomAvailable = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(356, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ROOM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(74, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Room ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(74, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Booking ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(75, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Room"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(74, 279)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Room type"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(78, 356)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 24)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Bed choice"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(78, 423)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 24)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Room price"
        '
        'TextBoxRoomID
        '
        Me.TextBoxRoomID.Location = New System.Drawing.Point(361, 77)
        Me.TextBoxRoomID.Name = "TextBoxRoomID"
        Me.TextBoxRoomID.Size = New System.Drawing.Size(249, 20)
        Me.TextBoxRoomID.TabIndex = 7
        '
        'TextBoxBookingID
        '
        Me.TextBoxBookingID.Location = New System.Drawing.Point(361, 144)
        Me.TextBoxBookingID.Name = "TextBoxBookingID"
        Me.TextBoxBookingID.Size = New System.Drawing.Size(249, 20)
        Me.TextBoxBookingID.TabIndex = 8
        '
        'TextBoxRoom
        '
        Me.TextBoxRoom.Location = New System.Drawing.Point(361, 210)
        Me.TextBoxRoom.Name = "TextBoxRoom"
        Me.TextBoxRoom.Size = New System.Drawing.Size(249, 20)
        Me.TextBoxRoom.TabIndex = 9
        '
        'ComboBoxRoomType
        '
        Me.ComboBoxRoomType.FormattingEnabled = True
        Me.ComboBoxRoomType.Items.AddRange(New Object() {"Queen of Queens", "Standard room", "Twin room"})
        Me.ComboBoxRoomType.Location = New System.Drawing.Point(361, 279)
        Me.ComboBoxRoomType.Name = "ComboBoxRoomType"
        Me.ComboBoxRoomType.Size = New System.Drawing.Size(249, 21)
        Me.ComboBoxRoomType.TabIndex = 10
        '
        'ComboBoxBedChoice
        '
        Me.ComboBoxBedChoice.FormattingEnabled = True
        Me.ComboBoxBedChoice.Items.AddRange(New Object() {"Double bed", "Single bed", "2 Double beds", "2 Single beds"})
        Me.ComboBoxBedChoice.Location = New System.Drawing.Point(361, 356)
        Me.ComboBoxBedChoice.Name = "ComboBoxBedChoice"
        Me.ComboBoxBedChoice.Size = New System.Drawing.Size(249, 21)
        Me.ComboBoxBedChoice.TabIndex = 11
        '
        'TextBoxRoomPrice
        '
        Me.TextBoxRoomPrice.Location = New System.Drawing.Point(361, 423)
        Me.TextBoxRoomPrice.Name = "TextBoxRoomPrice"
        Me.TextBoxRoomPrice.Size = New System.Drawing.Size(249, 20)
        Me.TextBoxRoomPrice.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(101, 540)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 42)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Add room"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(78, 500)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(166, 24)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Room availability"
        '
        'ComboBoxRoomAvailable
        '
        Me.ComboBoxRoomAvailable.FormattingEnabled = True
        Me.ComboBoxRoomAvailable.Items.AddRange(New Object() {"Available", "Not available"})
        Me.ComboBoxRoomAvailable.Location = New System.Drawing.Point(361, 500)
        Me.ComboBoxRoomAvailable.Name = "ComboBoxRoomAvailable"
        Me.ComboBoxRoomAvailable.Size = New System.Drawing.Size(249, 21)
        Me.ComboBoxRoomAvailable.TabIndex = 15
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(361, 540)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(130, 42)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Update room"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(579, 540)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(115, 42)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Delete room"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(782, 540)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(97, 42)
        Me.Button4.TabIndex = 18
        Me.Button4.Text = "View room"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(782, 25)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(106, 46)
        Me.Button5.TabIndex = 19
        Me.Button5.Text = "Admin homepage"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Room
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(965, 605)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ComboBoxRoomAvailable)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBoxRoomPrice)
        Me.Controls.Add(Me.ComboBoxBedChoice)
        Me.Controls.Add(Me.ComboBoxRoomType)
        Me.Controls.Add(Me.TextBoxRoom)
        Me.Controls.Add(Me.TextBoxBookingID)
        Me.Controls.Add(Me.TextBoxRoomID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Room"
        Me.Text = "Room"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxRoomID As TextBox
    Friend WithEvents TextBoxBookingID As TextBox
    Friend WithEvents TextBoxRoom As TextBox
    Friend WithEvents ComboBoxRoomType As ComboBox
    Friend WithEvents ComboBoxBedChoice As ComboBox
    Friend WithEvents TextBoxRoomPrice As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboBoxRoomAvailable As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
