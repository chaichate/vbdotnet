<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.txtVat = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtVat
        '
        Me.txtVat.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtVat.Location = New System.Drawing.Point(215, 158)
        Me.txtVat.Name = "txtVat"
        Me.txtVat.Size = New System.Drawing.Size(100, 20)
        Me.txtVat.TabIndex = 31
        '
        'txtPrice
        '
        Me.txtPrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPrice.Location = New System.Drawing.Point(215, 88)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.ReadOnly = True
        Me.txtPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice.TabIndex = 30
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Location = New System.Drawing.Point(215, 22)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalPrice.TabIndex = 29
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(240, 227)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 28
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(82, 227)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 27
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "ภาษี 7 % จากราคาสินค้าที่แท้จริง"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "ราคาสินค้าที่แท้จริง"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "ยอดราคาสินค้า"
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 273)
        Me.Controls.Add(Me.txtVat)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtTotalPrice)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form6"
        Me.Text = "โปรแกรมคำนวณหาราคาสินค้าที่แท้จริง"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtVat As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtTotalPrice As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
