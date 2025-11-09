
Imports System.Data.SqlClient

Public Class Frm_Main

    Private Sub Frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()

    End Sub

    Private Sub NewCustomerMenuItem_Click(sender As Object, e As EventArgs) Handles NewCustomerMenuItem.Click
        Frm_Customers.MdiParent = Me
        Frm_Customers.Show()
    End Sub

    Private Sub ReserveInterviewMenuItem_Click(sender As Object, e As EventArgs) Handles ReserveInterviewMenuItem.Click
        Frm_CustMeet.MdiParent = Me
        Frm_CustMeet.Show()

    End Sub

    Private Sub DelayInterviewMenuItem_Click(sender As Object, e As EventArgs) Handles DelayInterviewMenuItem.Click
        Frm_Follow.MdiParent = Me
        Frm_Follow.Show()

    End Sub

    Private Sub ConfirmInterviewMenuItem_Click(sender As Object, e As EventArgs) Handles ConfirmInterviewMenuItem.Click
        Frm_DoneMeet.MdiParent = Me

        Frm_DoneMeet.Show()


    End Sub

    Private Sub FollowInterviewMenuItem_Click(sender As Object, e As EventArgs) Handles FollowInterviewStripMenuItem.Click
        Frm_DoneFollow.MdiParent = Me
        Frm_DoneFollow.Show()
    End Sub

    Private Sub AllCustomersReportMenuItem_Click(sender As Object, e As EventArgs) Handles AllCustomersReportMenuItem.Click
        Frm_CustomersPopUp.MdiParent = Me
        Frm_CustomersPopUp.Show()

    End Sub

    Private Sub RefusedCustomersReportMenuItem_Click(sender As Object, e As EventArgs) Handles RefusedCustomersReportToolStripMenuItem.Click
        Frm_customerRefusedPopUp.MdiParent = Me
        Frm_customerRefusedPopUp.Show()

    End Sub

    Private Sub InterviewDatesReportMenuItem_Click(sender As Object, e As EventArgs) Handles InterviewDatesReportMenuItem.Click
        Frm_MeetTowDate.MdiParent = Me
        Frm_MeetTowDate.Show()

    End Sub

    Private Sub AllInterviewsReportMenuItem_Click(sender As Object, e As EventArgs) Handles AllInterviewsReportMenuItem.Click
        Frm_MeetPopUp.MdiParent = Me
        Frm_MeetPopUp.Show()

    End Sub

    Private Sub AllFollowRportMenuItem_Click(sender As Object, e As EventArgs) Handles AllFollowReportMenuItem.Click
        Frm_FollowPopUp.MdiParent = Me
        Frm_FollowPopUp.Show()

    End Sub

    Private Sub ExitMenuItem_Click(sender As Object, e As EventArgs) Handles ExitMenuItem.Click
        Application.Exit()

    End Sub


End Class
