
Imports System.Data.SqlClient
Public Class PhongController
    Private connectionString As String = "Data Source=localhost;Initial Catalog=dbQUANLYPHONGTRO;User ID=sa;Password=1234"

    ' Lấy tất cả phòng từ cơ sở dữ liệu
    Public Function GetAllPhong() As List(Of Phong)
        Dim list As New List(Of Phong)()
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim sql As String = "SELECT MaPhong, TenPhong, DienTich, GiaPhong, TrangThai FROM Phong"
            Dim cmd As New SqlCommand(sql, conn)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                Dim phong As New Phong(
                    reader("MaPhong"),
                    reader("TenPhong").ToString(),
                    Convert.ToDouble(reader("DienTich")),
                    Convert.ToDecimal(reader("GiaPhong")),
                    reader("TrangThai").ToString()
                )
                list.Add(phong)
            End While
            reader.Close()
        End Using
        Return list
    End Function
    Public Function GetAllMaPhong() As List(Of Integer)
        Dim listMaPhong As New List(Of Integer)()
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim sql As String = "SELECT MaPhong FROM Phong"
            Dim cmd As New SqlCommand(sql, conn)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                listMaPhong.Add(Convert.ToInt32(reader("MaPhong")))
            End While
            reader.Close()
        End Using
        Return listMaPhong
    End Function

    ' Thêm phòng mới vào cơ sở dữ liệu
    Public Function AddPhong(p As Phong) As Boolean
        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim sql As String = "INSERT INTO Phong (TenPhong, DienTich, GiaPhong, TrangThai) VALUES (@ten, @dientich, @gia, @trangthai)"
                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@ten", p.TenPhongProp)
                    cmd.Parameters.AddWithValue("@dientich", p.DienTichProp)
                    cmd.Parameters.AddWithValue("@gia", p.GiaPhongProp)
                    cmd.Parameters.AddWithValue("@trangthai", p.TrangThaiProp)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    Return rowsAffected > 0
                End Using
            Catch ex As Exception
                ' Xử lý lỗi (nếu có)
                Return False
            End Try
        End Using
    End Function

    ' Xóa phòng khỏi cơ sở dữ liệu
    Public Function DeletePhong(maPhong As Integer) As Boolean
        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim sql As String = "DELETE FROM Phong WHERE MaPhong = @maPhong"
                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@maPhong", maPhong)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    Return rowsAffected > 0
                End Using
            Catch ex As Exception
                Return False
            End Try
        End Using
    End Function

    Private Sub PhongController_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
