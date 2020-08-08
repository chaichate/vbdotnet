<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtHour = New System.Windows.Forms.TextBox()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtPrice
        '
        Me.txtPrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPrice.Location = New System.Drawing.Point(218, 174)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice.TabIndex = 23
        '
        'txtHour
        '
        Me.txtHour.BackColor = System.Drawing.Color.White
        Me.txtHour.Location = New System.Drawing.Point(218, 104)
        Me.txtHour.Name = "txtHour"
        Me.txtHour.Size = New System.Drawing.Size(100, 20)
        Me.txtHour.TabIndex = 22
        '
        'txtSalary
        '
        Me.txtSalary.Location = New System.Drawing.Point(218, 38)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(100, 20)
        Me.txtSalary.TabIndex = 21
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(243, 243)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 20
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(98, 243)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 19
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(95, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "เงินค่าล่วงเวลา"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(95, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "จำนวนชัวโมง"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(95, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "เงินเดือน"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(413, 304)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtHour)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form5"
        Me.Text = "โปรแกรมคิดค่าล่วงเวลา"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtHour As TextBox
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
