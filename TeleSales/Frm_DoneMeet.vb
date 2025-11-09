Imports System.Data.SqlClient

Public Class Frm_DoneMeet
    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Ok.Click
        If Cmb_Customers.Text = "" Then
            MessageBox.Show("من فضلك اختر عميل اولا")
            Exit Sub
        End If
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "Sp_Cust_Meetspdateflag"
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@Cust_ID", Cmb_Customers.SelectedValue.ToString())

        Dim aff As Integer
        aff = cmd.ExecuteNonQuery
        If aff > 0 Then
            MessageBox.Show("تم حضور المقابلة بنجاح")
        End If
    End Sub

    Private Sub Frm_DoneMeet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "Sp_CustMeetSelectCustName"
        cmd.Parameters.Clear()
        Dim dt As New DataTable
        dr = cmd.ExecuteReader()
        dt.Load(dr)
        dr.Close()
        Cmb_Customers.DataSource = dt
        Cmb_Customers.DisplayMember = "Cust_name"
        Cmb_Customers.ValueMember = "Cust_id"

    End Sub
End Class