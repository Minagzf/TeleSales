Imports System.Data.SqlClient

Public Class Frm_Follow
    Public _AddNew As New Boolean
    Public _EditDelete As New Boolean


    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click

        Me.Close()

    End Sub

    Private Sub Btn_New_Click(sender As Object, e As EventArgs) Handles Btn_New.Click
        If MessageBox.Show("هل تريد تأجيل موعد", "جديد", MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) = DialogResult.Yes Then
            cmb_Customers.Text = ""
            Txt_Notes.Clear()
            _AddNew = True
        End If
    End Sub

    Private Sub Frm_Follow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "Sp_CustFollowSelectCustName"
        cmd.Parameters.Clear()
        dr = cmd.ExecuteReader()
        Dim dt As New DataTable
        dt.Load(dr)
        dr.Close()
        Cmb_Search.DataSource = dt
        Cmb_Search.DisplayMember = "Cust_Name"
        cmb_Customers.ValueMember = "Cust_ID"
        cmd.CommandText = "Sp_CustomerSelectWait"
        dr = cmd.ExecuteReader()
        Dim dt1 As New DataTable
        dt1.Load(dr)
        dr.Close()
        cmb_Customers.DataSource = dt1
        cmb_Customers.DisplayMember = "Cust_Name"
        cmb_Customers.ValueMember = "Cust_ID"
        _AddNew = False
        _EditDelete = False
        cmb_Customers.Enabled = True
    End Sub

    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click

        If Cmb_Search.Text <> "" Then
            cmd.Connection = con
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "Sp_Cust_FollowSelectByID"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("Cust_Id", Cmb_Search.SelectedItem(0).ToString())
            dr = cmd.ExecuteReader()
            dr.Read()
            cmb_Customers.SelectedValue = dr("Cust_ID")
            Dt_Date.Value = dr("follow_Date")
            Txt_Notes.Text = dr("Notes")
            dr.Close()
            _EditDelete = True
            cmb_Customers.Enabled = False
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
            cmd.CommandText = "Sp_Cust_FollowInsert"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Cust_ID", Cmb_Search.SelectedValue.ToString())
            cmd.Parameters.AddWithValue("@Follow_Date", Dt_Date.Value.Date)
            cmd.Parameters.AddWithValue("@Notes", Txt_Notes.Text)
            Dim aff As Integer
            aff = cmd.ExecuteNonQuery()
            If aff > 0 Then
                MessageBox.Show("تم تحديد موعد للمتابعة")
                _AddNew = False
            End If
        End If
    End Sub

    Private Sub Btn_Edit_Click(sender As Object, e As EventArgs) Handles Btn_Edit.Click
        If _EditDelete = True Then
            cmd.Connection = con
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "Sp_Cust_FollowUpdate"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Cust_ID", cmb_Customers.SelectedValue.ToString())
            cmd.Parameters.AddWithValue("@Follow_Date", Dt_Date.Value.Date)
            cmd.Parameters.AddWithValue("@Notes", Txt_Notes.Text)
            Dim aff As Integer
            aff = cmd.ExecuteNonQuery()
            If aff > 0 Then
                MessageBox.Show("تم تعديل موعد المقابلة بنجاح")
            End If
        End If
    End Sub

    Private Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click
        If _EditDelete = True Then
            cmd.Connection = con
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "Sp_Cust_FollowDelete"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@cust_id", cmb_Customers.SelectedValue.ToString())
            Dim aff As Integer
            aff = cmd.ExecuteNonQuery()
            If aff > 0 Then
                MessageBox.Show("تم حذف المتابعة بنجاح")
            End If
        End If
    End Sub
End Class