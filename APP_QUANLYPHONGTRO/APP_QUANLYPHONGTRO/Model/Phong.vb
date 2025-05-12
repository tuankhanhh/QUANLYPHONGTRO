Public Class Phong

    Private tenPhong As String
    Private dienTich As Double
    Private giaPhong As Decimal
    Private trangThai As String

    ' Constructor
    Public Sub New(v As Object, tenPhong As String, dienTich As Double, giaPhong As Decimal, trangThai As String)
        Me.tenPhong = tenPhong
        Me.dienTich = dienTich
        Me.giaPhong = giaPhong
        Me.trangThai = trangThai
    End Sub


    Public Property TenPhongProp As String
        Get
            Return tenPhong
        End Get
        Set(value As String)
            tenPhong = value
        End Set
    End Property

    Public Property DienTichProp As Double
        Get
            Return dienTich
        End Get
        Set(value As Double)
            dienTich = value
        End Set
    End Property

    Public Property GiaPhongProp As Decimal
        Get
            Return giaPhong
        End Get
        Set(value As Decimal)
            giaPhong = value
        End Set
    End Property

    Public Property TrangThaiProp As String
        Get
            Return trangThai
        End Get
        Set(value As String)
            trangThai = value
        End Set
    End Property

    Private Sub Phong_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' TODO: Initialize data here if needed
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim phongViewForm As New Phong_view()
        phongViewForm.Show()
    End Sub
End Class
