Imports System.Data.SqlClient

Public Class HopDongController
    Private connectionString As String = "Data Source=localhost;Initial Catalog=dbQUANLYPHONGTRO;User ID=sa;Password=1234"

    ' Lấy tất cả hợp đồng
    Public Function GetAllHopDong() As List(Of HopDong)
        Dim list As New List(Of HopDong)()

        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim sql As String = "SELECT * FROM HopDong"
            Using cmd As New SqlCommand(sql, conn)
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Dim hd As New HopDong(
                        Convert.ToInt32(reader("MaHopDong")),
                        Convert.ToInt32(reader("MaPhong")),
                        Convert.ToInt32(reader("MaNguoiThue")),
                        Convert.ToDateTime(reader("NgayBatDau")),
                        Convert.ToDateTime(reader("NgayKetThuc")),
                        Convert.ToDecimal(reader("TienCoc"))
                    )
                    list.Add(hd)
                End While
                reader.Close()
            End Using
        End Using
        Return list
    End Function

    ' Thêm hợp đồng mới
    Public Function AddHopDong(hd As HopDong) As Boolean
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim sql As String = "INSERT INTO HopDong (MaPhong, MaNguoiThue, NgayBatDau, NgayKetThuc, TienCoc) VALUES (@maPhong, @maNguoiThue, @ngayBatDau, @ngayKetThuc, @tienCoc)"
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@maPhong", hd.MaPhong)
                cmd.Parameters.AddWithValue("@maNguoiThue", hd.MaNguoiThue)
                cmd.Parameters.AddWithValue("@ngayBatDau", hd.NgayBatDau)
                cmd.Parameters.AddWithValue("@ngayKetThuc", hd.NgayKetThuc)
                cmd.Parameters.AddWithValue("@tienCoc", hd.TienCoc)
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    ' Xóa hợp đồng theo mã
    Public Function DeleteHopDong(maHopDong As Integer) As Boolean
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim sql As String = "DELETE FROM HopDong WHERE MaHopDong = @maHopDong"
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@maHopDong", maHopDong)
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function
    Private Sub HopDongController_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class