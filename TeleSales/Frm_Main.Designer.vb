<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Main
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CustomersMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewCustomerMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReserveInterviewMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DelayInterviewMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InterviewsMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfirmInterviewMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FollowInterviewStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllCustomersReportMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefusedCustomersReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllInterviewsReportMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllFollowReportMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InterviewDatesReportMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomersMenuItem, Me.InterviewsMenuItem, Me.ReportsMenuItem, Me.ExitMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(881, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CustomersMenuItem
        '
        Me.CustomersMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewCustomerMenuItem, Me.ReserveInterviewMenuItem, Me.DelayInterviewMenuItem})
        Me.CustomersMenuItem.Name = "CustomersMenuItem"
        Me.CustomersMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.CustomersMenuItem.Text = "بيانات العملاء"
        '
        'NewCustomerMenuItem
        '
        Me.NewCustomerMenuItem.Name = "NewCustomerMenuItem"
        Me.NewCustomerMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.NewCustomerMenuItem.Text = "تسجيل بيانات عميل"
        '
        'ReserveInterviewMenuItem
        '
        Me.ReserveInterviewMenuItem.Name = "ReserveInterviewMenuItem"
        Me.ReserveInterviewMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.ReserveInterviewMenuItem.Text = "تحديد ميعاد للمقابلة"
        '
        'DelayInterviewMenuItem
        '
        Me.DelayInterviewMenuItem.Name = "DelayInterviewMenuItem"
        Me.DelayInterviewMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.DelayInterviewMenuItem.Text = "تأجيل الميعاد"
        '
        'InterviewsMenuItem
        '
        Me.InterviewsMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfirmInterviewMenuItem, Me.FollowInterviewStripMenuItem})
        Me.InterviewsMenuItem.Name = "InterviewsMenuItem"
        Me.InterviewsMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.InterviewsMenuItem.Text = "المواعيد"
        '
        'ConfirmInterviewMenuItem
        '
        Me.ConfirmInterviewMenuItem.Name = "ConfirmInterviewMenuItem"
        Me.ConfirmInterviewMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ConfirmInterviewMenuItem.Text = "تأكيد ميعاد المقابلة"
        '
        'FollowInterviewStripMenuItem
        '
        Me.FollowInterviewStripMenuItem.Name = "FollowInterviewStripMenuItem"
        Me.FollowInterviewStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.FollowInterviewStripMenuItem.Text = "متابعة ميعاد المتابعة"
        '
        'ReportsMenuItem
        '
        Me.ReportsMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllCustomersReportMenuItem, Me.RefusedCustomersReportToolStripMenuItem, Me.AllInterviewsReportMenuItem, Me.AllFollowReportMenuItem, Me.InterviewDatesReportMenuItem})
        Me.ReportsMenuItem.Name = "ReportsMenuItem"
        Me.ReportsMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ReportsMenuItem.Text = "التقارير"
        '
        'AllCustomersReportMenuItem
        '
        Me.AllCustomersReportMenuItem.Name = "AllCustomersReportMenuItem"
        Me.AllCustomersReportMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.AllCustomersReportMenuItem.Text = "تقرير بكافة العملاء"
        '
        'RefusedCustomersReportToolStripMenuItem
        '
        Me.RefusedCustomersReportToolStripMenuItem.Name = "RefusedCustomersReportToolStripMenuItem"
        Me.RefusedCustomersReportToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.RefusedCustomersReportToolStripMenuItem.Text = "تقرير بالعملاء الغير موافقين"
        '
        'AllInterviewsReportMenuItem
        '
        Me.AllInterviewsReportMenuItem.Name = "AllInterviewsReportMenuItem"
        Me.AllInterviewsReportMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.AllInterviewsReportMenuItem.Text = "تقرير بمواعيد المقابلات"
        '
        'AllFollowReportMenuItem
        '
        Me.AllFollowReportMenuItem.Name = "AllFollowReportMenuItem"
        Me.AllFollowReportMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.AllFollowReportMenuItem.Text = "تقرير بمواعيد المتابعة"
        '
        'InterviewDatesReportMenuItem
        '
        Me.InterviewDatesReportMenuItem.Name = "InterviewDatesReportMenuItem"
        Me.InterviewDatesReportMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.InterviewDatesReportMenuItem.Text = "مواعيد المقابلات بين تاريخين"
        '
        'ExitMenuItem
        '
        Me.ExitMenuItem.Name = "ExitMenuItem"
        Me.ExitMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ExitMenuItem.Text = "خروج"
        '
        'Frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(881, 541)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Frm_Main"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "برنامج التسويق عن طريق التليفون"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CustomersMenuItem As ToolStripMenuItem
    Friend WithEvents NewCustomerMenuItem As ToolStripMenuItem
    Friend WithEvents ReserveInterviewMenuItem As ToolStripMenuItem
    Friend WithEvents DelayInterviewMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsMenuItem As ToolStripMenuItem
    Friend WithEvents AllCustomersReportMenuItem As ToolStripMenuItem
    Friend WithEvents RefusedCustomersReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AllInterviewsReportMenuItem As ToolStripMenuItem
    Friend WithEvents AllFollowReportMenuItem As ToolStripMenuItem
    Friend WithEvents InterviewsMenuItem As ToolStripMenuItem
    Friend WithEvents ConfirmInterviewMenuItem As ToolStripMenuItem
    Friend WithEvents FollowInterviewStripMenuItem As ToolStripMenuItem
    Friend WithEvents InterviewDatesReportMenuItem As ToolStripMenuItem
    Friend WithEvents ExitMenuItem As ToolStripMenuItem
End Class
