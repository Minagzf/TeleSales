<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Follow
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
        Me.Btn_Search = New System.Windows.Forms.Button()
        Me.Cmb_Search = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Grb_Meet = New System.Windows.Forms.GroupBox()
        Me.Txt_Notes = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Dt_Date = New System.Windows.Forms.DateTimePicker()
        Me.cmb_Customers = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btn_Close = New System.Windows.Forms.Button()
        Me.Btn_Delete = New System.Windows.Forms.Button()
        Me.Btn_Edit = New System.Windows.Forms.Button()
        Me.Btn_Save = New System.Windows.Forms.Button()
        Me.Btn_New = New System.Windows.Forms.Button()
        Me.Grb_Search.SuspendLayout()
        Me.Grb_Meet.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Grb_Search
        '
        Me.Grb_Search.Controls.Add(Me.Btn_Search)
        Me.Grb_Search.Controls.Add(Me.Cmb_Search)
        Me.Grb_Search.Controls.Add(Me.Label1)
        Me.Grb_Search.Location = New System.Drawing.Point(106, 12)
        Me.Grb_Search.Name = "Grb_Search"
        Me.Grb_Search.Size = New System.Drawing.Size(347, 81)
        Me.Grb_Search.TabIndex = 4
        Me.Grb_Search.TabStop = False
        Me.Grb_Search.Text = "بحث"
        '
        'Btn_Search
        '
        Me.Btn_Search.Location = New System.Drawing.Point(138, 46)
        Me.Btn_Search.Name = "Btn_Search"
        Me.Btn_Search.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Search.TabIndex = 2
        Me.Btn_Search.Text = "بحث"
        Me.Btn_Search.UseVisualStyleBackColor = True
        '
        'Cmb_Search
        '
        Me.Cmb_Search.FormattingEnabled = True
        Me.Cmb_Search.Location = New System.Drawing.Point(10, 19)
        Me.Cmb_Search.Name = "Cmb_Search"
        Me.Cmb_Search.Size = New System.Drawing.Size(253, 21)
        Me.Cmb_Search.TabIndex = 1
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
        'Grb_Meet
        '
        Me.Grb_Meet.Controls.Add(Me.Txt_Notes)
        Me.Grb_Meet.Controls.Add(Me.Label4)
        Me.Grb_Meet.Controls.Add(Me.Dt_Date)
        Me.Grb_Meet.Controls.Add(Me.cmb_Customers)
        Me.Grb_Meet.Controls.Add(Me.Label3)
        Me.Grb_Meet.Controls.Add(Me.Label2)
        Me.Grb_Meet.Location = New System.Drawing.Point(66, 118)
        Me.Grb_Meet.Name = "Grb_Meet"
        Me.Grb_Meet.Size = New System.Drawing.Size(438, 209)
        Me.Grb_Meet.TabIndex = 5
        Me.Grb_Meet.TabStop = False
        Me.Grb_Meet.Text = "تحديد مقابلة"
        '
        'Txt_Notes
        '
        Me.Txt_Notes.Location = New System.Drawing.Point(114, 104)
        Me.Txt_Notes.Multiline = True
        Me.Txt_Notes.Name = "Txt_Notes"
        Me.Txt_Notes.Size = New System.Drawing.Size(200, 99)
        Me.Txt_Notes.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(320, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "ملاحظات"
        '
        'Dt_Date
        '
        Me.Dt_Date.Location = New System.Drawing.Point(114, 65)
        Me.Dt_Date.Name = "Dt_Date"
        Me.Dt_Date.Size = New System.Drawing.Size(200, 20)
        Me.Dt_Date.TabIndex = 2
        '
        'cmb_Customers
        '
        Me.cmb_Customers.FormattingEnabled = True
        Me.cmb_Customers.Location = New System.Drawing.Point(114, 28)
        Me.cmb_Customers.Name = "cmb_Customers"
        Me.cmb_Customers.Size = New System.Drawing.Size(200, 21)
        Me.cmb_Customers.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(320, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ميعاد المقابلة"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(320, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "إسم العميل"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Btn_Close)
        Me.Panel1.Controls.Add(Me.Btn_Delete)
        Me.Panel1.Controls.Add(Me.Btn_Edit)
        Me.Panel1.Controls.Add(Me.Btn_Save)
        Me.Panel1.Controls.Add(Me.Btn_New)
        Me.Panel1.Location = New System.Drawing.Point(12, 333)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(510, 65)
        Me.Panel1.TabIndex = 6
        '
        'Btn_Close
        '
        Me.Btn_Close.Location = New System.Drawing.Point(16, 12)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.Size = New System.Drawing.Size(85, 39)
        Me.Btn_Close.TabIndex = 4
        Me.Btn_Close.Text = "اغلاق"
        Me.Btn_Close.UseVisualStyleBackColor = True
        '
        'Btn_Delete
        '
        Me.Btn_Delete.Location = New System.Drawing.Point(116, 12)
        Me.Btn_Delete.Name = "Btn_Delete"
        Me.Btn_Delete.Size = New System.Drawing.Size(85, 39)
        Me.Btn_Delete.TabIndex = 3
        Me.Btn_Delete.Text = "حذف"
        Me.Btn_Delete.UseVisualStyleBackColor = True
        '
        'Btn_Edit
        '
        Me.Btn_Edit.Location = New System.Drawing.Point(216, 12)
        Me.Btn_Edit.Name = "Btn_Edit"
        Me.Btn_Edit.Size = New System.Drawing.Size(85, 39)
        Me.Btn_Edit.TabIndex = 2
        Me.Btn_Edit.Text = "تعديل"
        Me.Btn_Edit.UseVisualStyleBackColor = True
        '
        'Btn_Save
        '
        Me.Btn_Save.Location = New System.Drawing.Point(316, 13)
        Me.Btn_Save.Name = "Btn_Save"
        Me.Btn_Save.Size = New System.Drawing.Size(85, 39)
        Me.Btn_Save.TabIndex = 1
        Me.Btn_Save.Text = "حفظ"
        Me.Btn_Save.UseVisualStyleBackColor = True
        '
        'Btn_New
        '
        Me.Btn_New.Location = New System.Drawing.Point(416, 13)
        Me.Btn_New.Name = "Btn_New"
        Me.Btn_New.Size = New System.Drawing.Size(85, 39)
        Me.Btn_New.TabIndex = 0
        Me.Btn_New.Text = "جديد"
        Me.Btn_New.UseVisualStyleBackColor = True
        '
        'Frm_Follow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(522, 410)
        Me.Controls.Add(Me.Grb_Search)
        Me.Controls.Add(Me.Grb_Meet)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Frm_Follow"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "متابعة العملاء"
        Me.Grb_Search.ResumeLayout(False)
        Me.Grb_Search.PerformLayout()
        Me.Grb_Meet.ResumeLayout(False)
        Me.Grb_Meet.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Grb_Search As GroupBox
    Friend WithEvents Btn_Search As Button
    Friend WithEvents Cmb_Search As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Grb_Meet As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Dt_Date As DateTimePicker
    Friend WithEvents cmb_Customers As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Btn_Close As Button
    Friend WithEvents Btn_Delete As Button
    Friend WithEvents Btn_Edit As Button
    Friend WithEvents Btn_Save As Button
    Friend WithEvents Btn_New As Button
    Friend WithEvents Txt_Notes As TextBox
End Class
