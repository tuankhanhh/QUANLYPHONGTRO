Public Class HopDong
    Public Property MaHopDong As Integer
    Public Property MaPhong As Integer
    Public Property MaNguoiThue As Integer
    Public Property NgayBatDau As DateTime
    Public Property NgayKetThuc As DateTime
    Public Property TienCoc As Decimal

    Public Sub New(maHopDong As Integer, maPhong As Integer, maNguoiThue As Integer, ngayBatDau As DateTime, ngayKetThuc As DateTime, tienCoc As Decimal)
        Me.MaHopDong = maHopDong
        Me.MaPhong = maPhong
        Me.MaNguoiThue = maNguoiThue
        Me.NgayBatDau = ngayBatDau
        Me.NgayKetThuc = ngayKetThuc
        Me.TienCoc = tienCoc
    End Sub

    Public Sub New()
    End Sub
    Private Sub HopDong_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class