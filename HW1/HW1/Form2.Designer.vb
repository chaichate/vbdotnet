<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtHour = New System.Windows.Forms.TextBox()
        Me.txtMunute = New System.Windows.Forms.TextBox()
        Me.txtSecond = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ชัวโมง"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "นาที"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "วินาที"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(54, 239)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(199, 239)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtHour
        '
        Me.txtHour.Location = New System.Drawing.Point(174, 34)
        Me.txtHour.Name = "txtHour"
        Me.txtHour.Size = New System.Drawing.Size(100, 20)
        Me.txtHour.TabIndex = 5
        '
        'txtMunute
        '
        Me.txtMunute.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMunute.Location = New System.Drawing.Point(174, 100)
        Me.txtMunute.Name = "txtMunute"
        Me.txtMunute.ReadOnly = True
        Me.txtMunute.Size = New System.Drawing.Size(100, 20)
        Me.txtMunute.TabIndex = 6
        '
        'txtSecond
        '
        Me.txtSecond.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSecond.Location = New System.Drawing.Point(174, 170)
        Me.txtSecond.Name = "txtSecond"
        Me.txtSecond.Size = New System.Drawing.Size(100, 20)
        Me.txtSecond.TabIndex = 7
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(362, 304)
        Me.Controls.Add(Me.txtSecond)
        Me.Controls.Add(Me.txtMunute)
        Me.Controls.Add(Me.txtHour)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "โปรแกรมแปลงชัวโมง เป็นนาทีวินาที"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnOK As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtHour As TextBox
    Friend WithEvents txtMunute As TextBox
    Friend WithEvents txtSecond As TextBox
End Class
