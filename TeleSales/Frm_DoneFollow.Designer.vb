<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_DoneFollow
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
        Me.Grb_Search = New System.Windows.Forms.GroupBox()
        Me.Btn_Ok = New System.Windows.Forms.Button()
        Me.Cmb_Customers = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_Notes = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Grb_Search.SuspendLayout()
        Me.SuspendLayout()
        '
        'Grb_Search
        '
        Me.Grb_Search.Controls.Add(Me.Txt_Notes)
        Me.Grb_Search.Controls.Add(Me.Label7)
        Me.Grb_Search.Controls.Add(Me.Btn_Ok)
        Me.Grb_Search.Controls.Add(Me.Cmb_Customers)
        Me.Grb_Search.Controls.Add(Me.Label1)
        Me.Grb_Search.Location = New System.Drawing.Point(28, 21)
        Me.Grb_Search.Name = "Grb_Search"
        Me.Grb_Search.Size = New System.Drawing.Size(347, 170)
        Me.Grb_Search.TabIndex = 6
        Me.Grb_Search.TabStop = False
        Me.Grb_Search.Text = "عرض العملاء"
        '
        'Btn_Ok
        '
        Me.Btn_Ok.Location = New System.Drawing.Point(108, 136)
        Me.Btn_Ok.Name = "Btn_Ok"
        Me.Btn_Ok.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Ok.TabIndex = 2
        Me.Btn_Ok.Text = "تأكيد"
        Me.Btn_Ok.UseVisualStyleBackColor = True
        '
        'Cmb_Customers
        '
        Me.Cmb_Customers.FormattingEnabled = True
        Me.Cmb_Customers.Location = New System.Drawing.Point(10, 19)
        Me.Cmb_Customers.Name = "Cmb_Customers"
        Me.Cmb_Customers.Size = New System.Drawing.Size(253, 21)
        Me.Cmb_Customers.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(269, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "اسم العميل :"
        '
        'Txt_Notes
        '
        Me.Txt_Notes.Location = New System.Drawing.Point(10, 46)
        Me.Txt_Notes.Multiline = True
        Me.Txt_Notes.Name = "Txt_Notes"
        Me.Txt_Notes.Size = New System.Drawing.Size(253, 84)
        Me.Txt_Notes.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(269, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "ملاحظات :"
        '
        'Frm_DoneFollow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 207)
        Me.Controls.Add(Me.Grb_Search)
        Me.Name = "Frm_DoneFollow"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تأكيد الاتصال بالعميل"
        Me.Grb_Search.ResumeLayout(False)
        Me.Grb_Search.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Grb_Search As GroupBox
    Friend WithEvents Btn_Ok As Button
    Friend WithEvents Cmb_Customers As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_Notes As TextBox
    Friend WithEvents Label7 As Label
End Class
