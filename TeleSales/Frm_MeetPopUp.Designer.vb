<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_MeetPopUp
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
        Me.DGV_Meet = New System.Windows.Forms.DataGridView()
        CType(Me.DGV_Meet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_Meet
        '
        Me.DGV_Meet.AllowUserToAddRows = False
        Me.DGV_Meet.AllowUserToDeleteRows = False
        Me.DGV_Meet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Meet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_Meet.Location = New System.Drawing.Point(0, 0)
        Me.DGV_Meet.Name = "DGV_Meet"
        Me.DGV_Meet.ReadOnly = True
        Me.DGV_Meet.Size = New System.Drawing.Size(717, 429)
        Me.DGV_Meet.TabIndex = 0
        '
        'Frm_MeetPopUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(717, 429)
        Me.Controls.Add(Me.DGV_Meet)
        Me.Name = "Frm_MeetPopUp"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تقرير بمواعيد المقابلات"
        CType(Me.DGV_Meet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGV_Meet As DataGridView
End Class
