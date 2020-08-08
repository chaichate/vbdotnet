<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.txtTernOfPay = New System.Windows.Forms.TextBox()
        Me.txtCounter = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtTernOfPay
        '
        Me.txtTernOfPay.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTernOfPay.Location = New System.Drawing.Point(187, 156)
        Me.txtTernOfPay.Name = "txtTernOfPay"
        Me.txtTernOfPay.Size = New System.Drawing.Size(100, 20)
        Me.txtTernOfPay.TabIndex = 23
        '
        'txtCounter
        '
        Me.txtCounter.AllowDrop = True
        Me.txtCounter.BackColor = System.Drawing.SystemColors.Control
        Me.txtCounter.Location = New System.Drawing.Point(187, 86)
        Me.txtCounter.Name = "txtCounter"
        Me.txtCounter.Size = New System.Drawing.Size(100, 20)
        Me.txtCounter.TabIndex = 22
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(187, 20)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtAmount.TabIndex = 21
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(212, 225)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 20
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(67, 225)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 19
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(64, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "เงินชำระแต่ละงวด"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "จำนวนงวด"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "จำนวนเงินกู้"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 269)
        Me.Controls.Add(Me.txtTernOfPay)
        Me.Controls.Add(Me.txtCounter)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form4"
        Me.Text = "เงินชำระแต่ละงวด"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTernOfPay As TextBox
    Friend WithEvents txtCounter As TextBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
