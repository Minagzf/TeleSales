<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_MeetTowDate
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
        Me.DGV_TowDate = New System.Windows.Forms.DataGridView()
        Me.Dt_Date1 = New System.Windows.Forms.DateTimePicker()
        Me.Dt_Date2 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_Show = New System.Windows.Forms.Button()
        CType(Me.DGV_TowDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_TowDate
        '
        Me.DGV_TowDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_TowDate.Location = New System.Drawing.Point(12, 85)
        Me.DGV_TowDate.Name = "DGV_TowDate"
        Me.DGV_TowDate.Size = New System.Drawing.Size(715, 342)
        Me.DGV_TowDate.TabIndex = 0
        '
        'Dt_Date1
        '
        Me.Dt_Date1.Location = New System.Drawing.Point(82, 46)
        Me.Dt_Date1.Name = "Dt_Date1"
        Me.Dt_Date1.Size = New System.Drawing.Size(200, 20)
        Me.Dt_Date1.TabIndex = 1
        '
        'Dt_Date2
        '
        Me.Dt_Date2.Location = New System.Drawing.Point(415, 45)
        Me.Dt_Date2.Name = "Dt_Date2"
        Me.Dt_Date2.Size = New System.Drawing.Size(200, 20)
        Me.Dt_Date2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "التاريخ الاول :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(337, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "التاريخ الثاني :"
        '
        'Btn_Show
        '
        Me.Btn_Show.Location = New System.Drawing.Point(640, 40)
        Me.Btn_Show.Name = "Btn_Show"
        Me.Btn_Show.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Show.TabIndex = 3
        Me.Btn_Show.Text = "عرض"
        Me.Btn_Show.UseVisualStyleBackColor = True
        '
        'Frm_MeetTowDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 439)
        Me.Controls.Add(Me.Btn_Show)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Dt_Date2)
        Me.Controls.Add(Me.Dt_Date1)
        Me.Controls.Add(Me.DGV_TowDate)
        Me.Name = "Frm_MeetTowDate"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "مواعين المقابلات بين تاريخين"
        CType(Me.DGV_TowDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV_TowDate As DataGridView
    Friend WithEvents Dt_Date1 As DateTimePicker
    Friend WithEvents Dt_Date2 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Btn_Show As Button
End Class
