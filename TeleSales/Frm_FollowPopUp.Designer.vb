<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_FollowPopUp
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
        Me.DGV_Follow = New System.Windows.Forms.DataGridView()
        CType(Me.DGV_Follow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_Follow
        '
        Me.DGV_Follow.AllowUserToAddRows = False
        Me.DGV_Follow.AllowUserToDeleteRows = False
        Me.DGV_Follow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Follow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_Follow.Location = New System.Drawing.Point(0, 0)
        Me.DGV_Follow.Name = "DGV_Follow"
        Me.DGV_Follow.ReadOnly = True
        Me.DGV_Follow.Size = New System.Drawing.Size(712, 453)
        Me.DGV_Follow.TabIndex = 0
        '
        'Frm_FollowPopUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 453)
        Me.Controls.Add(Me.DGV_Follow)
        Me.Name = "Frm_FollowPopUp"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تقرير بمواعيد المتابعة"
        CType(Me.DGV_Follow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGV_Follow As DataGridView
End Class
