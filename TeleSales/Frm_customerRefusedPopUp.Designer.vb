<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_customerRefusedPopUp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DGV_Refused = New System.Windows.Forms.DataGridView()
        CType(Me.DGV_Refused, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_Refused
        '
        Me.DGV_Refused.AllowUserToAddRows = False
        Me.DGV_Refused.AllowUserToDeleteRows = False
        Me.DGV_Refused.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Refused.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_Refused.Location = New System.Drawing.Point(0, 0)
        Me.DGV_Refused.Name = "DGV_Refused"
        Me.DGV_Refused.ReadOnly = True
        Me.DGV_Refused.Size = New System.Drawing.Size(705, 427)
        Me.DGV_Refused.TabIndex = 0
        '
        'Frm_customerRefusedPopUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 427)
        Me.Controls.Add(Me.DGV_Refused)
        Me.Name = "Frm_customerRefusedPopUp"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تقرير بالعملاء الغير موافقين"
        CType(Me.DGV_Refused, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGV_Refused As DataGridView
End Class
