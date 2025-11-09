Imports System.Data.SqlClient

Public Class Frm_Customers


    Public _Addnew As New Boolean
    Public _EditDelete As New Boolean

    Private Sub Frm_Customers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        _Addnew = False
        _EditDelete = False
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "Sp_Customer_Select"
        cmd.Parameters.Clear()

        dr = cmd.ExecuteReader
        Dim dt1 As New DataTable
        dt1.Load(dr)
        Cmb_Search.DataSource = dt1
        Cmb_Search.DisplayMember = "Cust_Name"
        Cmb_Search.ValueMember = "Cust_id"
        dr.Close()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "Sp_Status_Select"
        dr = cmd.ExecuteReader
        Dim dt2 As New DataTable
        dt2.Load(dr)
        Cmb_Status.DataSource = dt2
        Cmb_Status.DisplayMember = "Status_Name"
        Cmb_Status.ValueMember = "Status_ID"
        dr.Close()

    End Sub

    Private Sub Btn_New_Click(sender As Object, e As EventArgs) Handles Btn_New.Click

        If MessageBox.Show("هل تريد اضافة عميل جديد", "اضافة عملاء", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
            Txt_Name.Clear()
            Txt_Notes.Clear()
            Txt_Phone1.Clear()
            Txt_Phone2.Clear()
            Txt_Phone3.Clear()
            Cmb_Status.Text = ""
            _Addnew = True
        End If

    End Sub

    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        If _Addnew = False Then
            MessageBox.Show("من فضلك اضغط على جديد اولا")
            Exit Sub
        End If
        If Txt_Name.Text = "" Then
            MessageBox.Show("من فضلك ادخل اسم لعميل ")
            Exit Sub

        End If
        If Txt_Phone1.Text = "" Then
            MessageBox.Show("من فضلك ادخل رقم تليفون العميل")
            Exit Sub
        End If
        cmd.Parameters.Clear()
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "Sp_Customer_Insert"
        cmd.Parameters.AddWithValue("@Cust_Name", Txt_Name.Text)
        cmd.Parameters.AddWithValue("@Phone1", Txt_Phone1.Text)
        cmd.Parameters.AddWithValue("@Phone2", Txt_Phone2.Text)
        cmd.Parameters.AddWithValue("@Phone3", Txt_Phone3.Text)
        cmd.Parameters.AddWithValue("@Status_ID", Cmb_Status.SelectedValue.ToString())
        cmd.Parameters.AddWithValue("@Notes", Txt_Notes.Text)
        Dim affected As Integer
        affected = cmd.ExecuteNonQuery
        If affected > 0 Then
            MessageBox.Show("تمت عملية تسجيل العميل بنجاح")
            _Addnew = False
        End If

    End Sub

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click

        Me.Close()

    End Sub

    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click
        If Cmb_Search.Text <> "" Then
            cmd.Connection = con
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "Sp_Customer_SelectByID"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Cust_ID", Cmb_Search.SelectedValue.ToString())
            dr = cmd.ExecuteReader()
            dr.Read()
            Txt_Name.Text = dr("Cust_Name")
            Txt_Notes.Text = dr("Notes")
            Txt_Phone1.Text = dr("Phone1")
            Txt_Phone2.Text = dr("Phone2")
            Txt_Phone3.Text = dr("Phone3")
            Cmb_Status.SelectedValue = dr("Status_ID")
            _EditDelete = True
            dr.Close()
        End If
    End Sub

    Private Sub Btn_Edit_Click(sender As Object, e As EventArgs) Handles Btn_Edit.Click
        If _EditDelete = True Then
            If Txt_Name.Text = "" Then
                MessageBox.Show("من فضلك ادخل اسم لعميل")
                Exit Sub
            End If
            If Cmb_Status.Text = "" Then
                MessageBox.Show("من فضلك اختر حالة المكالمة")
                Exit Sub
            End If
            cmd.Connection = con
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "Sp_Customer_Update"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Cust_ID", Cmb_Search.SelectedValue.ToString())
            cmd.Parameters.AddWithValue("@Cust_Name", Txt_Name.Text)
            cmd.Parameters.AddWithValue("@Phone1", Txt_Phone1.Text)
            cmd.Parameters.AddWithValue("@Phone2", Txt_Phone2.Text)
            cmd.Parameters.AddWithValue("@Phone3", Txt_Phone3.Text)
            cmd.Parameters.AddWithValue("@Notes", Txt_Notes.Text)
            cmd.Parameters.AddWithValue("@Status_ID", Cmb_Status.SelectedValue.ToString())
            Dim aff As Integer = cmd.ExecuteNonQuery()
            If aff > 0 Then
                MessageBox.Show("تم التعديل بنجاح")
                _EditDelete = False
            End If
        End If
    End Sub

    Private Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click
        If _EditDelete = True Then
            If MessageBox.Show("هل تريد حذف هذا العميل", "تأكيد", MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question) = DialogResult.Yes Then
                cmd.Connection = con
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "Sp_Customer_Delete"
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@Cust_ID", Cmb_Search.SelectedValue.ToString())
                Dim aff As Integer = cmd.ExecuteNonQuery()
                If aff > 0 Then
                    MessageBox.Show("تم الحذف")
                    _EditDelete = False
                End If
            End If
        End If
    End Sub
End Class