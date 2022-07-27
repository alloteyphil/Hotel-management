<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payments
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Payments))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxPaymentID = New System.Windows.Forms.TextBox()
        Me.TextBoxBankName = New System.Windows.Forms.TextBox()
        Me.TextBoxCardNumber = New System.Windows.Forms.TextBox()
        Me.TextBoxBranch = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBoxCustomerName = New System.Windows.Forms.TextBox()
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
        Me.Label1.Location = New System.Drawing.Point(422, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PAYMENTS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(78, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Payment ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(78, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Customer Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(78, 262)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Bank Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(78, 343)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Card Number"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(82, 419)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 24)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Bank Branch"
        '
        'TextBoxPaymentID
        '
        Me.TextBoxPaymentID.Location = New System.Drawing.Point(396, 115)
        Me.TextBoxPaymentID.Name = "TextBoxPaymentID"
        Me.TextBoxPaymentID.Size = New System.Drawing.Size(249, 20)
        Me.TextBoxPaymentID.TabIndex = 6
        '
        'TextBoxBankName
        '
        Me.TextBoxBankName.Location = New System.Drawing.Point(396, 262)
        Me.TextBoxBankName.Name = "TextBoxBankName"
        Me.TextBoxBankName.Size = New System.Drawing.Size(249, 20)
        Me.TextBoxBankName.TabIndex = 8
        '
        'TextBoxCardNumber
        '
        Me.TextBoxCardNumber.Location = New System.Drawing.Point(396, 343)
        Me.TextBoxCardNumber.Name = "TextBoxCardNumber"
        Me.TextBoxCardNumber.Size = New System.Drawing.Size(249, 20)
        Me.TextBoxCardNumber.TabIndex = 9
        '
        'TextBoxBranch
        '
        Me.TextBoxBranch.Location = New System.Drawing.Point(396, 419)
        Me.TextBoxBranch.Name = "TextBoxBranch"
        Me.TextBoxBranch.Size = New System.Drawing.Size(249, 20)
        Me.TextBoxBranch.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(128, 552)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 54)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Add Payments"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBoxCustomerName
        '
        Me.TextBoxCustomerName.Location = New System.Drawing.Point(396, 189)
        Me.TextBoxCustomerName.Name = "TextBoxCustomerName"
        Me.TextBoxCustomerName.Size = New System.Drawing.Size(249, 20)
        Me.TextBoxCustomerName.TabIndex = 12
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(383, 552)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(153, 54)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Update Payments"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(659, 552)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(149, 54)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Delete Payments"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(927, 558)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(131, 48)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "View Booking"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(913, 37)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(117, 47)
        Me.Button5.TabIndex = 16
        Me.Button5.Text = "Admin homepage"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Payments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1090, 702)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBoxCustomerName)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBoxBranch)
        Me.Controls.Add(Me.TextBoxCardNumber)
        Me.Controls.Add(Me.TextBoxBankName)
        Me.Controls.Add(Me.TextBoxPaymentID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Payments"
        Me.Text = " "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxPaymentID As TextBox
    Friend WithEvents TextBoxBankName As TextBox
    Friend WithEvents TextBoxCardNumber As TextBox
    Friend WithEvents TextBoxBranch As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBoxCustomerName As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
