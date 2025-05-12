Public Class HopDongView
    Private hopDongController As New HopDongController()
    Private phongController As New PhongController() ' Tạo instance của PhongController

    Private Sub HopDongView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadHopDong()
        LoadMaPhongComboBox() ' Gọi hàm load mã phòng
    End Sub

    ' Hàm tải danh sách mã phòng từ database và hiển thị lên ComboBox
    Private Sub LoadMaPhongComboBox()
        Dim danhSachPhong As List(Of Integer) = phongController.GetAllMaPhong()
        ComboBox1.DisplayMember = "MaPhong" ' Thuộc tính hiển thị trong ComboBox
        ComboBox1.ValueMember = "MaPhong"   ' Giá trị thực tế khi chọn
        ComboBox1.DataSource = danhSachPhong
    End Sub

    ' Hàm tải danh sách hợp đồng từ database
    Private Sub LoadHopDong()
        Dim danhSachHopDong As List(Of HopDong) = hopDongController.GetAllHopDong()
        DataGridView1.DataSource = danhSachHopDong
    End Sub

    ' Sự kiện thêm hợp đồng mới
    Private Sub Button_Luu_Click(sender As Object, e As EventArgs)
        ' Lấy dữ liệu từ form
        ' Lấy mã phòng từ ComboBox đã chọn
        Dim maPhong = Convert.ToInt32(ComboBox1.SelectedValue)
        Dim maNguoiThue = Convert.ToInt32(TextBox_MaNguoiThue.Text.Trim())
        Dim ngayBatDau As Date = DateTimePicker1.Value
        Dim ngayKetThuc As Date = DateTimePicker2.Value
        Dim tienCoc = Convert.ToDecimal(TextBox_TienCoc.Text.Trim())

        ' Tạo đối tượng HopDong từ dữ liệu form
        Dim hopDong As New HopDong(0, maPhong, maNguoiThue, ngayBatDau, ngayKetThuc, tienCoc)

        ' Gọi hàm thêm hợp đồng từ controller
        If hopDongController.AddHopDong(hopDong) Then
            LoadHopDong()
            MessageBox.Show("Thêm hợp đồng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Có lỗi khi thêm hợp đồng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Các sự kiện khác (xóa, nhập lại, đóng) giữ nguyên

    Private Sub Button_Nhap_Click(sender As Object, e As EventArgs) Handles Button_Nhap.Click
        ComboBox1.SelectedIndex = -1 ' Reset lựa chọn trong ComboBox
        TextBox_MaNguoiThue.Text = ""
        TextBox_TienCoc.Text = ""
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ' Bạn có thể thêm logic xử lý khi người dùng chọn một mã phòng (nếu cần)
    End Sub
End Class