Imports System.Data.SqlClient

Public Class Frm_MeetPopUp
    Private Sub Frm_MeetPopUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "Sp_Cust_MeetsSelect"
        cmd.Parameters.Clear()
        dr = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(dr)
        dr.Close()
        DGV_Meet.DataSource = dt

    End Sub
End Class