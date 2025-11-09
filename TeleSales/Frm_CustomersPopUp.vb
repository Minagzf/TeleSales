Imports System.Data.SqlClient

Public Class Frm_CustomersPopUp
    Private Sub Frm_CustomersPopUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "Sp_Customer_Select"
        cmd.Parameters.Clear()
        Dim dt As New DataTable
        dr = cmd.ExecuteReader()
        dt.Load(dr)
        dr.Close()
        DGV_Customers.DataSource = dt

    End Sub


End Class