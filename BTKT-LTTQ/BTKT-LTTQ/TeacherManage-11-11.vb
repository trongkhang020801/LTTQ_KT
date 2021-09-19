Imports System.Data.SqlClient

Public Class TeacherManage_11_11
    Private con As SqlConnection
    Private Sub KetNoi()
        Dim connection As String = "Data Source=TRONG-KHANG\TRANTHITHULUYEN;Initial Catalog=Manage_Young;Integrated Security=True"
        Try
            con = New SqlConnection(connection)
            'con.Open()
            'MessageBox.Show("Ket noi thanh cong!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Khong the ket noi duoc!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        'con.Close()
    End Sub
    Private WithEvents danhsach As BindingManagerBase
    Public lenh As String
    Private Sub hienthi()
        Dim lenh As String
        lenh = "select * from TeacherManage"
        Dim dr As New SqlCommand(lenh, con)
        con.Open()
        Dim hienthi As SqlDataReader = dr.ExecuteReader()
        Dim dttable As New DataTable("tblquanligiavien")
        dttable.Load(hienthi, LoadOption.OverwriteChanges)
        con.Close()
        DataGridView1.DataSource = dttable
        danhsach = Me.BindingContext(dttable)
    End Sub


    Private Sub luu_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub edit_Click(sender As Object, e As EventArgs) Handles edit.Click

    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click

    End Sub

    Private Sub refresh_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub tiemkiem_Click(sender As Object, e As EventArgs) Handles tiemkiem.Click

    End Sub

    Private Sub TeacherManage_11_11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KetNoi()
        hienthi()
        magv.Enabled = False
        hoten.Enabled = False
        gioitinh.Enabled = False
        ngaysinh.Enabled = False
        diachi.Enabled = False
        sdt.Enabled = False
        macv.Enabled = False
        luu.Visible = False
        cmnd.Enabled = False
        delete.Enabled = False
        edit.Enabled = False

        tiemkiem.Enabled = False
    End Sub

    Private Sub quaylai_Click(sender As Object, e As EventArgs) Handles quaylai.Click
        Me.Visible = False
    End Sub

    Private Sub add_Click(sender As Object, e As EventArgs) Handles add.Click
        luu.Visible = True
        add.Visible = False
        magv.Enabled = True
        hoten.Enabled = True
        gioitinh.Enabled = True
        ngaysinh.Enabled = True
        diachi.Enabled = True
        sdt.Enabled = True
        macv.Enabled = True
        cmnd.Enabled = True
    End Sub
End Class