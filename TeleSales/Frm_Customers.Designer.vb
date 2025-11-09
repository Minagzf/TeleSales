<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Customers
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
        Me.Grb_Data = New System.Windows.Forms.GroupBox()
        Me.Txt_Notes = New System.Windows.Forms.TextBox()
        Me.Cmb_Status = New System.Windows.Forms.ComboBox()
        Me.Txt_Phone3 = New System.Windows.Forms.TextBox()
        Me.Txt_Phone2 = New System.Windows.Forms.TextBox()
        Me.Txt_Phone1 = New System.Windows.Forms.TextBox()
        Me.Txt_Name = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btn_Close = New System.Windows.Forms.Button()
        Me.Btn_Delete = New System.Windows.Forms.Button()
        Me.Btn_Edit = New System.Windows.Forms.Button()
        Me.Btn_Save = New System.Windows.Forms.Button()
        Me.Btn_New = New System.Windows.Forms.Button()
        Me.Grb_Search.SuspendLayout()
        Me.Grb_Data.SuspendLayout()
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
        Me.Grb_Search.TabIndex = 0
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
        'Grb_Data
        '
        Me.Grb_Data.Controls.Add(Me.Txt_Notes)
        Me.Grb_Data.Controls.Add(Me.Cmb_Status)
        Me.Grb_Data.Controls.Add(Me.Txt_Phone3)
        Me.Grb_Data.Controls.Add(Me.Txt_Phone2)
        Me.Grb_Data.Controls.Add(Me.Txt_Phone1)
        Me.Grb_Data.Controls.Add(Me.Txt_Name)
        Me.Grb_Data.Controls.Add(Me.Label7)
        Me.Grb_Data.Controls.Add(Me.Label6)
        Me.Grb_Data.Controls.Add(Me.Label5)
        Me.Grb_Data.Controls.Add(Me.Label4)
        Me.Grb_Data.Controls.Add(Me.Label3)
        Me.Grb_Data.Controls.Add(Me.Label2)
        Me.Grb_Data.Location = New System.Drawing.Point(30, 99)
        Me.Grb_Data.Name = "Grb_Data"
        Me.Grb_Data.Size = New System.Drawing.Size(474, 202)
        Me.Grb_Data.TabIndex = 0
        Me.Grb_Data.TabStop = False
        Me.Grb_Data.Text = "بيانات العميل"
        '
        'Txt_Notes
        '
        Me.Txt_Notes.Location = New System.Drawing.Point(6, 108)
        Me.Txt_Notes.Multiline = True
        Me.Txt_Notes.Name = "Txt_Notes"
        Me.Txt_Notes.Size = New System.Drawing.Size(357, 84)
        Me.Txt_Notes.TabIndex = 6
        '
        'Cmb_Status
        '
        Me.Cmb_Status.FormattingEnabled = True
        Me.Cmb_Status.Location = New System.Drawing.Point(6, 81)
        Me.Cmb_Status.Name = "Cmb_Status"
        Me.Cmb_Status.Size = New System.Drawing.Size(129, 21)
        Me.Cmb_Status.TabIndex = 5
        '
        'Txt_Phone3
        '
        Me.Txt_Phone3.Location = New System.Drawing.Point(234, 81)
        Me.Txt_Phone3.Name = "Txt_Phone3"
        Me.Txt_Phone3.Size = New System.Drawing.Size(129, 20)
        Me.Txt_Phone3.TabIndex = 4
        '
        'Txt_Phone2
        '
        Me.Txt_Phone2.Location = New System.Drawing.Point(6, 50)
        Me.Txt_Phone2.Name = "Txt_Phone2"
        Me.Txt_Phone2.Size = New System.Drawing.Size(129, 20)
        Me.Txt_Phone2.TabIndex = 3
        '
        'Txt_Phone1
        '
        Me.Txt_Phone1.Location = New System.Drawing.Point(234, 50)
        Me.Txt_Phone1.Name = "Txt_Phone1"
        Me.Txt_Phone1.Size = New System.Drawing.Size(129, 20)
        Me.Txt_Phone1.TabIndex = 2
        '
        'Txt_Name
        '
        Me.Txt_Name.Location = New System.Drawing.Point(6, 19)
        Me.Txt_Name.Name = "Txt_Name"
        Me.Txt_Name.Size = New System.Drawing.Size(357, 20)
        Me.Txt_Name.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(374, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "ملاحظات :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(141, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "حالة المكالمة :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(374, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "الموبايل :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(141, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "تليفون المكتب :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(374, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "تليفون المنزل :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(374, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "اسم العميل :"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Btn_Close)
        Me.Panel1.Controls.Add(Me.Btn_Delete)
        Me.Panel1.Controls.Add(Me.Btn_Edit)
        Me.Panel1.Controls.Add(Me.Btn_Save)
        Me.Panel1.Controls.Add(Me.Btn_New)
        Me.Panel1.Location = New System.Drawing.Point(30, 307)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(474, 68)
        Me.Panel1.TabIndex = 1
        '
        'Btn_Close
        '
        Me.Btn_Close.Location = New System.Drawing.Point(6, 14)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.Size = New System.Drawing.Size(84, 40)
        Me.Btn_Close.TabIndex = 4
        Me.Btn_Close.Text = "اغلاق"
        Me.Btn_Close.UseVisualStyleBackColor = True
        '
        'Btn_Delete
        '
        Me.Btn_Delete.Location = New System.Drawing.Point(101, 14)
        Me.Btn_Delete.Name = "Btn_Delete"
        Me.Btn_Delete.Size = New System.Drawing.Size(84, 40)
        Me.Btn_Delete.TabIndex = 3
        Me.Btn_Delete.Text = "حذف"
        Me.Btn_Delete.UseVisualStyleBackColor = True
        '
        'Btn_Edit
        '
        Me.Btn_Edit.Location = New System.Drawing.Point(196, 14)
        Me.Btn_Edit.Name = "Btn_Edit"
        Me.Btn_Edit.Size = New System.Drawing.Size(84, 40)
        Me.Btn_Edit.TabIndex = 2
        Me.Btn_Edit.Text = "تعديل"
        Me.Btn_Edit.UseVisualStyleBackColor = True
        '
        'Btn_Save
        '
        Me.Btn_Save.Location = New System.Drawing.Point(291, 14)
        Me.Btn_Save.Name = "Btn_Save"
        Me.Btn_Save.Size = New System.Drawing.Size(84, 40)
        Me.Btn_Save.TabIndex = 1
        Me.Btn_Save.Text = "حفظ"
        Me.Btn_Save.UseVisualStyleBackColor = True
        '
        'Btn_New
        '
        Me.Btn_New.Location = New System.Drawing.Point(386, 14)
        Me.Btn_New.Name = "Btn_New"
        Me.Btn_New.Size = New System.Drawing.Size(84, 40)
        Me.Btn_New.TabIndex = 0
        Me.Btn_New.Text = "جديد"
        Me.Btn_New.UseVisualStyleBackColor = True
        '
        'Frm_Customers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(522, 413)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Grb_Data)
        Me.Controls.Add(Me.Grb_Search)
        Me.Name = "Frm_Customers"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تسجيل بيانات العملاء"
        Me.Grb_Search.ResumeLayout(False)
        Me.Grb_Search.PerformLayout()
        Me.Grb_Data.ResumeLayout(False)
        Me.Grb_Data.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Grb_Search As GroupBox
    Friend WithEvents Btn_Search As Button
    Friend WithEvents Cmb_Search As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Grb_Data As GroupBox
    Friend WithEvents Txt_Notes As TextBox
    Friend WithEvents Cmb_Status As ComboBox
    Friend WithEvents Txt_Phone3 As TextBox
    Friend WithEvents Txt_Phone2 As TextBox
    Friend WithEvents Txt_Phone1 As TextBox
    Friend WithEvents Txt_Name As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Btn_Close As Button
    Friend WithEvents Btn_Delete As Button
    Friend WithEvents Btn_Edit As Button
    Friend WithEvents Btn_Save As Button
    Friend WithEvents Btn_New As Button
End Class
