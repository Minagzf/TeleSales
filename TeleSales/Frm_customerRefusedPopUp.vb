Imports System.Data.SqlClient

Public Class Frm_customerRefusedPopUp
    Private Sub Frm_customerRefusedPopUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Clear()
        cmd.CommandText = "Sp_CustomerRefused"
        dr = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(dr)
        dr.Close()
        DGV_Refused.DataSource = dt

    End Sub
End Class