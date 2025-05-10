if exists (select * from sys.databases where name = 'dbQUANLYPHONGTRO')
begin 
	use master
	alter database dbQUANLYPHONGTRO set single_user with rollback immediate 
	drop database dbQUANLYPHONGTRO
end
-- Tạo database
CREATE DATABASE dbQUANLYPHONGTRO;
GO
USE dbQUANLYPHONGTRO;
GO
-- Tạo bảng Phòng
CREATE TABLE Phong (
    MaPhong INT PRIMARY KEY IDENTITY,        -- Khóa chính
    TenPhong NVARCHAR(50),                    -- Tên phòng
    DienTich FLOAT,                           -- Diện tích phòng
    GiaPhong DECIMAL(18, 2),                  -- Giá phòng
    TrangThai NVARCHAR(20)                    -- Trạng thái phòng (Trống / Đã thuê)
);
GO

-- Tạo bảng Người Thuê
CREATE TABLE NguoiThue (
    MaNguoiThue INT PRIMARY KEY IDENTITY,     -- Khóa chính
    HoTen NVARCHAR(100),                      -- Họ và tên người thuê
    CCCD NVARCHAR(12),                        -- Số CMND/CCCD
    SoDienThoai NVARCHAR(15),                 -- Số điện thoại
    DiaChi NVARCHAR(255)                      -- Địa chỉ
);
GO

-- Tạo bảng Hợp Đồng Thuê
CREATE TABLE HopDong (
    MaHopDong INT PRIMARY KEY IDENTITY,       -- Khóa chính
    MaPhong INT,                              -- Khóa ngoại tham chiếu tới Phong
    MaNguoiThue INT,                          -- Khóa ngoại tham chiếu tới NguoiThue
    NgayBatDau DATE,                          -- Ngày bắt đầu hợp đồng
    NgayKetThuc DATE,                         -- Ngày kết thúc hợp đồng
    TienCoc DECIMAL(18, 2),                   -- Tiền cọc
    FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong) 
		ON DELETE 
			CASCADE 
		ON UPDATE 
			CASCADE,  -- Ràng buộc khóa ngoại với Phong
    FOREIGN KEY (MaNguoiThue) REFERENCES NguoiThue(MaNguoiThue) 
		ON DELETE 
			CASCADE 
		ON UPDATE 
			CASCADE  -- Ràng buộc khóa ngoại với NguoiThue
);
GO

-- Tạo bảng Chỉ Số Điện & Nước
CREATE TABLE ChiSoDienNuoc (
    MaChiSo INT PRIMARY KEY IDENTITY,        -- Khóa chính
    MaPhong INT,                              -- Khóa ngoại tham chiếu tới Phong
    Thang INT,                                -- Tháng ghi chỉ số
    Nam INT,                                  -- Năm ghi chỉ số
    ChiSoDienCu INT,                          -- Chỉ số điện cũ
    ChiSoDienMoi INT,                         -- Chỉ số điện mới
    ChiSoNuocCu INT,                          -- Chỉ số nước cũ
    ChiSoNuocMoi INT,                         -- Chỉ số nước mới
    FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong) 
		ON DELETE 
			CASCADE 
		ON UPDATE 
			CASCADE  -- Ràng buộc khóa ngoại với Phong
);
GO

-- Tạo bảng Hóa Đơn
CREATE TABLE HoaDon (
    MaHoaDon INT PRIMARY KEY IDENTITY,       -- Khóa chính
    MaPhong INT,                              -- Khóa ngoại tham chiếu tới Phong
    Thang INT,                                -- Tháng xuất hóa đơn
    Nam INT,                                  -- Năm xuất hóa đơn
    TienPhong DECIMAL(18, 2),                 -- Tiền phòng
    TienDien DECIMAL(18, 2),                  -- Tiền điện
    TienNuoc DECIMAL(18, 2),                  -- Tiền nước
    TongTien DECIMAL(18, 2),                  -- Tổng tiền
    ThanhToan NVARCHAR(20),						-- Đã thanh toán (1: thanh toán, 0: chưa thanh toán)
    NgayTao DATETIME DEFAULT GETDATE(),       -- Ngày tạo hóa đơn
    FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong) 
		ON DELETE 
			CASCADE 
		ON UPDATE 
			CASCADE  -- Ràng buộc khóa ngoại với Phong
);
GO

-- Thêm ràng buộc CHECK để chỉ cho phép giá trị 'Chưa thanh toán' hoặc 'Đã thanh toán'
ALTER TABLE HoaDon
ADD CONSTRAINT CK_ThanhToan CHECK (ThanhToan IN ('Chưa thanh toán', 'Đã thanh toán'));
GO
