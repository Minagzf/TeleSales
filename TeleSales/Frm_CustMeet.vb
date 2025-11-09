Imports System.Data.SqlClient


Public Class Frm_CustMeet
    Public _AddNew As New Boolean
    Public _EditDelete As New Boolean


    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Close()

    End Sub

    Private Sub Frm_CustMeet_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "Sp_CustMeetSelectCustName"
        Dim dt As New DataTable
        cmd.Parameters.Clear()
        dr = cmd.ExecuteReader
        dt.Load(dr)
        dr.Close()
        Cmb_Search.DataSource = dt
        Cmb_Search.DisplayMember = "Cust_Name"
        Cmb_Search.ValueMember = "Cust_ID"
        cmd.CommandText = "Sp_CustomerSelectAccept"
        dr = cmd.ExecuteReader
        Dim dt1 As New DataTable
        dt1.Load(dr)
        dr.Close()
        cmb_Customers.DataSource = dt1
        cmb_Customers.DisplayMember = "Cust_Name"
        cmb_Customers.ValueMember = "Cust_id"
        _AddNew = False
        _EditDelete = False

    End Sub

    Private Sub Btn_New_Click(sender As Object, e As EventArgs) Handles Btn_New.Click
        If MessageBox.Show("هل تريد تحديد ميعاد مقابلة", "جديد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            cmb_Customers.Text = ""
            _AddNew = True

        End If
    End Sub

    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click

        If Cmb_Search.Text <> "" Then
            cmd.Connection = con
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "Sp_Cust_MeetsSelectByID"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Cust_ID", Cmb_Search.SelectedValue.ToString())
            dr = cmd.ExecuteReader()
            dr.Read()
            cmb_Customers.SelectedValue = dr("cust_id")
            Dt_Date.Value = dr("Meet_Date")
            dr.Close()
            cmb_Customers.Enabled = False

            _EditDelete = True
        End If


    End Sub

    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        If _AddNew = True Then
            If cmb_Customers.Text = "" Then
                MessageBox.Show("من فضلك اختر اسم العميل")
                Exit Sub
            End If
            cmd.Connection = con
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "Sp_Cust_MeetsInsert"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Cust_ID", cmb_Customers.SelectedValue.ToString())
            cmd.Parameters.AddWithValue("@Meet_Date", Dt_Date.Value.Date)
            Dim aff As Integer
            aff = cmd.ExecuteNonQuery()
            If aff > 0 Then
                MessageBox.Show("تم تحديد مقابلة للعميل")
                _AddNew = False
                cmb_Customers.Enabled = True

            End If
        End If
    End Sub

    Private Sub Btn_Edit_Click(sender As Object, e As EventArgs) Handles Btn_Edit.Click
        If _EditDelete = True Then
            cmd.Connection = con
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "Sp_Cust_MeetsUpdate"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Cust_Id", cmb_Customers.SelectedValue.ToString())
            cmd.Parameters.AddWithValue("@Meet_Date", Dt_Date.Value.Date)
            Dim aff As Integer
            aff = cmd.ExecuteNonQuery()
            If aff > 0 Then
                MessageBox.Show("تم تعديل ميعاد المقابلة")
                cmb_Customers.Enabled = True
                _EditDelete = False


            End If
        End If
    End Sub

    Private Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click
        If _EditDelete = True Then
            If MessageBox.Show("هل تريد حذف المقابلة", "تأكيد",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                cmd.Connection = con
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "Sp_Cust_MeetsDelete"
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@cus_id", Cmb_Search.SelectedValue.ToString())
                Dim aff As Integer = cmd.ExecuteNonQuery()
                If aff > 0 Then
                    MessageBox.Show("تم حذف الموعد")
                    cmb_Customers.Enabled = True
                    _EditDelete = False

                End If
            End If
        End If
    End Sub
End Class