Imports System.Data.SqlClient

Public Class Frm_FollowPopUp
    Private Sub Frm_FollowPopUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "Sp_Cust_FollowSelect"
        cmd.Parameters.Clear()
        dr = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(dr)
        dr.Close()
        DGV_Follow.DataSource = dt

    End Sub
End Class