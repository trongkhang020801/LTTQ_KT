Imports System.Data.SqlClient

Public Class YoungManage_11_11
    Private con As SqlConnection
    Private Sub KetNoi()
        Dim connection As String = "Data Source=TRONG-KHANG\TRANTHITHULUYEN;Initial Catalog=Manage_Young;Integrated Security=True"
        Try
            con = New SqlConnection(connection)
            '   con.Open()
            '  MessageBox.Show("Ket noi thanh cong!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Khong the ket noi duoc!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        'con.Close()
    End Sub
    Private WithEvents danhsach As BindingManagerBase
    Public lenh As String
    Private Sub hienthi()
        Dim lenh As String
        lenh = "select * from tblQuanLiTre"
        Dim dr As New SqlCommand(lenh, con)
        con.Open()
        Dim hienthi As SqlDataReader = dr.ExecuteReader()
        Dim dttable As New DataTable("tblquanlitre")
        dttable.Load(hienthi, LoadOption.OverwriteChanges)
        con.Close()
        table.DataSource = dttable
        danhsach = Me.BindingContext(dttable)
    End Sub
    Public Sub TimKiem(ByRef tentre$)
        Dim lenh As String
        lenh = "select * from tblQuanLiTre where Hoten like concat('%','" & tentre & "','%')"
        Dim connect As New SqlCommand(lenh, con)
        con.Open()
        Dim hienthi As SqlDataReader = connect.ExecuteReader()
        Dim dttable As New DataTable("tblQuanLiTre")
        dttable.Load(hienthi, LoadOption.OverwriteChanges)
        con.Close()
        table.DataSource = dttable
        danhsach = Me.BindingContext(dttable)
    End Sub

    Private Sub YoungManage_11_11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KetNoi()
        hienthi()
        matre.Enabled = True
        edit.Enabled = False
        delete.Enabled = False
        luu.Visible = False
        matre.Visible = False
        hotentre.Visible = False
        ngaysinh.Visible = False
        gioitinh.Visible = False
        diachi.Visible = False
        lophientai.Visible = False
        maphuhuynh.Visible = False
        sdt.Visible = False
        hotencha.Visible = False
        hotenme.Visible = False
        cmndcha.Visible = False
        cmndme.Visible = False
    End Sub
    Private Sub Add_Click(sender As Object, e As EventArgs) Handles add.Click
        hotentre.Text = ""
        maphuhuynh.Text = ""
        gioitinh.Text = ""
        ngaysinh.Text = ""
        diachi.Text = ""
        cmndcha.Text = ""
        cmndme.Text = ""
        sdt.Text = ""
        lophientai.Text = ""
        gioitinh.Text = ""
        hotencha.Text = ""
        hotenme.Text = ""
        matre.Visible = False
        hotentre.Visible = True
        ngaysinh.Visible = True
        gioitinh.Visible = True
        diachi.Visible = True
        lophientai.Visible = True
        maphuhuynh.Visible = True
        sdt.Visible = True
        hotencha.Visible = True
        hotenme.Visible = True
        cmndcha.Visible = True
        cmndme.Visible = True
        luu.Visible = True
        add.Visible = False
        edit.Enabled = False
        delete.Enabled = False

        tiemkiem.Enabled = False
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Visible = False
    End Sub
    Private Sub edit_Click_1(sender As Object, e As EventArgs) Handles edit.Click
        If MsgBox("Ban co muon sua khong?", vbYesNo, "Luu") = MsgBoxResult.Yes Then
            If hotentre.Text = "" Or ngaysinh.Text = "" Or gioitinh.Text = "" Or diachi.Text = "" Or lophientai.Text = "" Then
                MsgBox("Chua nhap du thong tin sinh vien !!!")
            Else
                Dim edityoung As New ChucNang_11_11(matre.Text, hotentre.Text, ngaysinh.Text, gioitinh.Text, diachi.Text, lophientai.Text, maphuhuynh.Text, sdt.Text, hotencha.Text, hotenme.Text, cmndcha.Text, cmndme.Text)
                edityoung.Edit_Young(lenh)
                Dim cmd As New SqlCommand(lenh, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                hienthi()
                MsgBox("Da sua thanh cong !")
                add.Visible = True
                luu.Visible = False
                matre.Text = ""
                maphuhuynh.Text = ""
                gioitinh.Text = ""
                ngaysinh.Text = ""
                diachi.Text = ""
                cmndcha.Text = ""
                cmndme.Text = ""
                sdt.Text = ""
                lophientai.Text = ""
                gioitinh.Text = ""
                hotencha.Text = ""
                hotenme.Text = ""
                hotentre.Text = ""
            End If
        End If
    End Sub

    Private Sub luu_Click_1(sender As Object, e As EventArgs) Handles luu.Click
        If MsgBox("Ban co muon luu khong?", vbYesNo, "Luu") = MsgBoxResult.Yes Then
            If hotentre.Text = "" Or ngaysinh.Text = "" Or gioitinh.Text = "" Or diachi.Text = "" Or lophientai.Text = "" Then
                MsgBox("Chua nhap du thong tin sinh vien !!!")
            Else
                Dim addyoung As New ChucNang_11_11(matre.Text, hotentre.Text, ngaysinh.Text, gioitinh.Text, diachi.Text, lophientai.Text, maphuhuynh.Text, sdt.Text, hotencha.Text, hotenme.Text, cmndcha.Text, cmndme.Text)
                addyoung.Add_Young(lenh)
                Dim cmd As New SqlCommand(lenh, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                hienthi()
                MsgBox("Da them")
                add.Visible = True
                luu.Visible = False

                tiemkiem.Enabled = True
                matre.Text = ""
                maphuhuynh.Text = ""
                gioitinh.Text = ""
                ngaysinh.Text = ""
                diachi.Text = ""
                cmndcha.Text = ""
                cmndme.Text = ""
                sdt.Text = ""
                lophientai.Text = ""
                gioitinh.Text = ""
                hotencha.Text = ""
                hotenme.Text = ""
                hotentre.Text = ""
            End If
        End If

    End Sub

    Private Sub delete_Click_1(sender As Object, e As EventArgs) Handles delete.Click
        If MsgBox("Ban co muon xoa khong?", vbYesNo, "Luu") = MsgBoxResult.Yes Then
            If hotentre.Text = "" Then
                MsgBox("Vui lòng chọn trẻ cần xóa")
            Else
                Dim edityoung As New ChucNang_11_11(matre.Text, hotentre.Text, ngaysinh.Text, gioitinh.Text, diachi.Text, lophientai.Text, maphuhuynh.Text, sdt.Text, hotencha.Text, hotenme.Text, cmndcha.Text, cmndme.Text)
                edityoung.Delete_Young(lenh)
                Dim cmd As New SqlCommand(lenh, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                hienthi()
                MsgBox("Da xoa thanh cong !")
                add.Visible = True
                luu.Visible = False
                matre.Text = ""
                maphuhuynh.Text = ""
                gioitinh.Text = ""
                ngaysinh.Text = ""
                diachi.Text = ""
                cmndcha.Text = ""
                cmndme.Text = ""
                sdt.Text = ""
                lophientai.Text = ""
                gioitinh.Text = ""
                hotencha.Text = ""
                hotenme.Text = ""
                hotentre.Text = ""
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles table.CellClick
        edit.Enabled = True
        delete.Enabled = True
        tiemkiem.Enabled = True

        Dim row As Integer
        row = e.RowIndex
        hotentre.Text = Me.table.Rows(row).Cells(2).Value.ToString
        ngaysinh.Text = Me.table.Rows(row).Cells(3).Value.ToString
        gioitinh.Text = Me.table.Rows(row).Cells(4).Value.ToString
        maphuhuynh.Text = Me.table.Rows(row).Cells(1).Value.ToString
        diachi.Text = Me.table.Rows(row).Cells(5).Value.ToString
        lophientai.Text = Me.table.Rows(row).Cells(6).Value.ToString
        matre.Text = Me.table.Rows(row).Cells(0).Value.ToString
        matre.Visible = True
        matre.Enabled = False
        hotentre.Visible = True
        ngaysinh.Visible = True
        gioitinh.Visible = True
        diachi.Visible = True
        lophientai.Visible = True
        maphuhuynh.Visible = True
        sdt.Visible = True
        hotencha.Visible = True
        hotenme.Visible = True
        cmndcha.Visible = True
        cmndme.Visible = True
    End Sub

    Private Sub tiemkiem_Click(sender As Object, e As EventArgs) Handles tiemkiem.Click
        Dim str$
        str = InputBox("Nhập vào tên trẻ cần tìm", "Nhập dữ liệu vào bên dưới")
        TimKiem(str)
    End Sub
End Class