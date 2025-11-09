<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_CustomersPopUp
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
        Me.DGV_Customers = New System.Windows.Forms.DataGridView()
        Me.col_1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DGV_Customers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_Customers
        '
        Me.DGV_Customers.AllowUserToAddRows = False
        Me.DGV_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Customers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_1, Me.col_2, Me.col_3, Me.col_4, Me.col_5, Me.col_6, Me.col_7})
        Me.DGV_Customers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_Customers.Location = New System.Drawing.Point(0, 0)
        Me.DGV_Customers.Name = "DGV_Customers"
        Me.DGV_Customers.ReadOnly = True
        Me.DGV_Customers.Size = New System.Drawing.Size(632, 366)
        Me.DGV_Customers.TabIndex = 0
        '
        'col_1
        '
        Me.col_1.DataPropertyName = "cust_id"
        Me.col_1.HeaderText = "رقم العميل"
        Me.col_1.Name = "col_1"
        Me.col_1.ReadOnly = True
        Me.col_1.Visible = False
        '
        'col_2
        '
        Me.col_2.DataPropertyName = "Cust_Name"
        Me.col_2.HeaderText = "اسم العميل"
        Me.col_2.Name = "col_2"
        Me.col_2.ReadOnly = True
        '
        'col_3
        '
        Me.col_3.DataPropertyName = "phone1"
        Me.col_3.HeaderText = "الموبايل"
        Me.col_3.Name = "col_3"
        Me.col_3.ReadOnly = True
        '
        'col_4
        '
        Me.col_4.DataPropertyName = "phone2"
        Me.col_4.HeaderText = "تليفون المنزل"
        Me.col_4.Name = "col_4"
        Me.col_4.ReadOnly = True
        '
        'col_5
        '
        Me.col_5.DataPropertyName = "phone3"
        Me.col_5.HeaderText = "تليفون المكتب"
        Me.col_5.Name = "col_5"
        Me.col_5.ReadOnly = True
        '
        'col_6
        '
        Me.col_6.DataPropertyName = "Status_Name"
        Me.col_6.HeaderText = "حالة المكالمة"
        Me.col_6.Name = "col_6"
        Me.col_6.ReadOnly = True
        '
        'col_7
        '
        Me.col_7.DataPropertyName = "Notes"
        Me.col_7.HeaderText = "ملاحطات"
        Me.col_7.Name = "col_7"
        Me.col_7.ReadOnly = True
        '
        'Frm_CustomersPopUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 366)
        Me.Controls.Add(Me.DGV_Customers)
        Me.Name = "Frm_CustomersPopUp"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تقرير بكافة العملاء"
        CType(Me.DGV_Customers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGV_Customers As DataGridView
    Friend WithEvents col_1 As DataGridViewTextBoxColumn
    Friend WithEvents col_2 As DataGridViewTextBoxColumn
    Friend WithEvents col_3 As DataGridViewTextBoxColumn
    Friend WithEvents col_4 As DataGridViewTextBoxColumn
    Friend WithEvents col_5 As DataGridViewTextBoxColumn
    Friend WithEvents col_6 As DataGridViewTextBoxColumn
    Friend WithEvents col_7 As DataGridViewTextBoxColumn
End Class
