<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.txtNetPrice = New System.Windows.Forms.TextBox()
        Me.txtVat = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtNetPrice
        '
        Me.txtNetPrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNetPrice.Location = New System.Drawing.Point(192, 157)
        Me.txtNetPrice.Name = "txtNetPrice"
        Me.txtNetPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtNetPrice.TabIndex = 15
        '
        'txtVat
        '
        Me.txtVat.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtVat.Location = New System.Drawing.Point(192, 87)
        Me.txtVat.Name = "txtVat"
        Me.txtVat.ReadOnly = True
        Me.txtVat.Size = New System.Drawing.Size(100, 20)
        Me.txtVat.TabIndex = 14
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(192, 21)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(100, 20)
        Me.txtPhone.TabIndex = 13
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(217, 226)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(72, 226)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 11
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(69, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "ยอดเงินชำระ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "ภาษี 7 %"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "ค่าโทรศัพท์"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(361, 270)
        Me.Controls.Add(Me.txtNetPrice)
        Me.Controls.Add(Me.txtVat)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "คำนวณค่าโทรศัพท์"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNetPrice As TextBox
    Friend WithEvents txtVat As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
