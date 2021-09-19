Public Class ChucNang_11_11
    Private matre$
    Private hotentre$
    Private ngsinh$
    Private gioitinh$
    Private Diachitamtru$
    Private lophientai$
    Private maphuhuynh$
    Private sdt$
    Private hotencha$
    Private hotenme$
    Private cmndcha$
    Private cmndme$
    Public Sub New(matre As String, hotentre As String, ngsinh As String, gioitinh As String,
                   diachitamtru As String, lophientai As String, maphuhuynh As String, sdt As String,
                   hotencha As String, hotenme As String, cmndcha As String, cmndme As String)
        Me.matre = matre
        Me.hotentre = hotentre
        Me.ngsinh = ngsinh
        Me.gioitinh = gioitinh
        Me.Diachitamtru = diachitamtru
        Me.lophientai = lophientai
        Me.maphuhuynh = maphuhuynh
        Me.sdt = sdt
        Me.hotencha = hotencha
        Me.hotenme = hotenme
        Me.cmndcha = cmndcha
        Me.cmndme = cmndme
    End Sub
    Public Property p_Matre$()
        Get
            Return matre
        End Get
        Set(value$)
            matre = value
        End Set
    End Property
    Public Property p_NgSinh$()
        Get
            Return ngsinh
        End Get
        Set(value$)
            ngsinh = value
        End Set
    End Property
    Public Property p_Hotentre$()
        Get
            Return hotentre
        End Get
        Set(value$)
            hotentre = value
        End Set
    End Property
    Public Property p_Gioitinh$()
        Get
            Return gioitinh
        End Get
        Set(value$)
            gioitinh = value
        End Set
    End Property
    Public Property p_Diachitamtru$()
        Get
            Return Diachitamtru
        End Get
        Set(value$)
            Diachitamtru = value
        End Set
    End Property
    Public Property p_Lophientai$()
        Get
            Return lophientai
        End Get
        Set(value$)
            lophientai = value
        End Set
    End Property
    Public Property p_Maphuhuynh$()
        Get
            Return maphuhuynh
        End Get
        Set(value$)
            maphuhuynh = value
        End Set
    End Property
    Public Property p_Sdt$()
        Get
            Return sdt
        End Get
        Set(value$)
            sdt = value
        End Set
    End Property
    Public Property p_Hotencha$()
        Get
            Return hotencha
        End Get
        Set(value$)
            hotencha = value
        End Set
    End Property
    Public Property p_Hotenme$()
        Get
            Return hotenme
        End Get
        Set(value$)
            hotenme = value
        End Set
    End Property
    Public Property p_cmndcha$()
        Get
            Return cmndcha
        End Get
        Set(value$)
            cmndcha = value
        End Set
    End Property
    Public Property p_cmndme$()
        Get
            Return cmndme
        End Get
        Set(value$)
            cmndme = value
        End Set
    End Property
    Public Sub Add_Young(ByRef lenh$)
        lenh = "EXECUTE spInsert_tblQuanLiTre '" & maphuhuynh & "', N'" & hotentre & "','" & ngsinh & "', N'" & gioitinh & "', N'" & Diachitamtru & "', '" & lophientai & "'"
    End Sub
    Public Sub Delete_Young(ByRef lenh$)
        lenh = "delete from tblQuanLiTre where Matre = '" & matre.Trim & "'"
    End Sub
    Public Sub Edit_Young(ByRef lenh$)
        lenh = "update tblQuanLiTre set Maphuhuynh = '" & maphuhuynh & "', Hoten = N'" & hotentre & "', NgaySinh = '" & ngsinh & "', gioiTinh = N'" & gioitinh & "', Diachitamtru = N'" & Diachitamtru & "', Lophientai = '" & lophientai & "' where Matre= '" & matre & "'"
    End Sub
End Class
