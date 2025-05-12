Imports System.Data.SqlClient

Public Class Phong_view
    Private phongController As New PhongController()

    Private Sub PhongView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPhong()
    End Sub

    Private Sub LoadPhong()
        Dim danhSachPhong As List(Of Phong) = phongController.GetAllPhong()
        DataGridView1.DataSource = danhSachPhong
    End Sub

    Private Sub Button_Luu_Click(sender As Object, e As EventArgs) Handles Button_Luu.Click
        ' Lấy dữ liệu từ form
        Dim tenPhong As String = TextBox_TenPhong.Text.Trim()
        Dim dienTich As Double = Convert.ToDouble(TextBox_DienTich.Text.Trim())
        Dim giaPhong As Decimal = Convert.ToDecimal(TextBox_GiaPhong.Text.Trim())
        Dim trangThai As String = TextBox_TrangThai.Text.Trim()

        ' Tạo đối tượng Phong từ dữ liệu form
        Dim phong As New Phong(0, tenPhong, dienTich, giaPhong, trangThai)

        ' Gọi hàm thêm phòng từ controller
        If phongController.AddPhong(phong) Then
            LoadPhong()
            MessageBox.Show("Thêm phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Có lỗi khi thêm phòng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button_Xoa_Click(sender As Object, e As EventArgs) Handles Button_Xoa.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            ' Lấy mã phòng từ dòng đã chọn
            Dim maPhong As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("MaPhong").Value)

            ' Gọi hàm xóa phòng từ controller
            If phongController.DeletePhong(maPhong) Then
                MessageBox.Show("Xóa phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadPhong()
            Else
                MessageBox.Show("Có lỗi khi xóa phòng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Vui lòng chọn phòng cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Button_Nhap_Click(sender As Object, e As EventArgs) Handles Button_Nhap.Click
        TextBox_TenPhong.Text = ""
        TextBox_DienTich.Text = ""
        TextBox_GiaPhong.Text = ""
        TextBox_TrangThai.Text = ""
    End Sub

End Class
