Imports System.Data.SqlClient

Public Class Frm_MeetTowDate
    Private Sub Btn_Show_Click(sender As Object, e As EventArgs) Handles Btn_Show.Click
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "Cust_MeetTowDate"
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@Date1", Dt_Date1.Value.Date)
        cmd.Parameters.AddWithValue("@Date2", Dt_Date2.Value.Date)
        dr = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(dr)
        dr.Close()
        DGV_TowDate.DataSource = dt

    End Sub
End Class