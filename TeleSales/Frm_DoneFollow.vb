Imports System.Data.SqlClient

Public Class Frm_DoneFollow
    Private Sub Frm_DoneFollow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "Sp_CustFollowSelectCustName"
        cmd.Parameters.Clear()
        dr = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(dr)
        dr.Close()
        Cmb_Customers.DataSource = dt
        Cmb_Customers.DisplayMember = "Cust_Name"
        Cmb_Customers.ValueMember = "cust_id"

    End Sub

    Private Sub Btn_Ok_Click(sender As Object, e As EventArgs) Handles Btn_Ok.Click
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "Sp_Cust_FollowUpdateFlag"
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("cust_id", Cmb_Customers.SelectedValue.ToString())
        cmd.Parameters.AddWithValue("@notes", Txt_Notes.Text)
        Dim aff As Integer
        aff = cmd.ExecuteNonQuery
        If aff > 0 Then
            MessageBox.Show("تم تأكيد الاتصال بالعميل")
        End If
    End Sub
End Class