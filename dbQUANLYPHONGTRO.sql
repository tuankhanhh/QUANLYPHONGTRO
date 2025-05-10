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
ADD CONSTRAINT CK_ThanhToan CHECK (ThanhToan IN (N'Chưa thanh toán', N'Đã thanh toán'));
GO
USE dbQUANLYPHONGTRO;
GO

-- Thêm dữ liệu vào bảng Phong
INSERT INTO Phong (TenPhong, DienTich, GiaPhong, TrangThai)
VALUES 
    (N'Phòng 101', 25.5, 3500000.00, N'Đã thuê'),
    (N'Phòng 102', 20.0, 3000000.00, N'Đã thuê'),
    (N'Phòng 103', 30.0, 4000000.00, N'Trống'),
    (N'Phòng 201', 22.5, 3200000.00, N'Đã thuê'),
    (N'Phòng 202', 18.0, 2800000.00, N'Đã thuê'),
    (N'Phòng 203', 28.0, 3800000.00, N'Trống'),
    (N'Phòng 301', 35.0, 4500000.00, N'Đã thuê'),
    (N'Phòng 302', 32.0, 4200000.00, N'Đã thuê'),
    (N'Phòng 303', 26.5, 3600000.00, N'Trống'),
    (N'Phòng 401', 40.0, 5000000.00, N'Đã thuê');
GO
set dateformat ymd
-- Thêm dữ liệu vào bảng NguoiThue
INSERT INTO NguoiThue (HoTen, CCCD, SoDienThoai, DiaChi)
VALUES 
    (N'Nguyễn Văn An', '036098001234', '0912345678', N'123 Đường Lê Lợi, Quận 1, TP.HCM'),
    (N'Trần Thị Bình', '036098005678', '0923456789', N'456 Đường Nguyễn Huệ, Quận 3, TP.HCM'),
    (N'Lê Văn Cường', '036098009012', '0934567890', N'789 Đường Cách Mạng Tháng 8, Quận 10, TP.HCM'),
    (N'Phạm Thị Dung', '036098003456', '0945678901', N'321 Đường Võ Văn Tần, Quận 3, TP.HCM'),
    (N'Hoàng Văn Em', '036098007890', '0956789012', N'654 Đường 3/2, Quận 10, TP.HCM'),
    (N'Ngô Thị Phương', '036098001235', '0967890123', N'987 Đường Điện Biên Phủ, Quận Bình Thạnh, TP.HCM'),
    (N'Đỗ Văn Giang', '036098005679', '0978901234', N'159 Đường Phan Xích Long, Phú Nhuận, TP.HCM'),
    (N'Vũ Thị Hương', '036098009013', '0989012345', N'357 Đường Nguyễn Đình Chiểu, Quận 3, TP.HCM'),
    (N'Lý Văn Ích', '036098003457', '0990123456', N'852 Đường Hoàng Sa, Quận 1, TP.HCM'),
    (N'Đinh Thị Kim', '036098007891', '0901234567', N'741 Đường Xô Viết Nghệ Tĩnh, Bình Thạnh, TP.HCM');
GO
set dateformat ymd
-- Thêm dữ liệu vào bảng HopDong
INSERT INTO HopDong (MaPhong, MaNguoiThue, NgayBatDau, NgayKetThuc, TienCoc)
VALUES 
    (1, 1, '2023-01-01', '2024-01-01', 7000000.00),
    (2, 2, '2023-02-15', '2024-02-15', 6000000.00),
    (4, 3, '2023-03-10', '2024-03-10', 6400000.00),
    (5, 4, '2023-04-05', '2024-04-05', 5600000.00),
    (7, 5, '2023-05-20', '2024-05-20', 9000000.00),
    (8, 6, '2023-06-15', '2024-06-15', 8400000.00),
    (10, 7, '2023-07-01', '2024-07-01', 10000000.00),
    (1, 8, '2022-12-01', '2023-12-01', 7000000.00),
    (2, 9, '2022-11-15', '2023-11-15', 6000000.00),
    (4, 10, '2022-10-10', '2023-10-10', 6400000.00);
GO

-- Thêm dữ liệu vào bảng ChiSoDienNuoc
INSERT INTO ChiSoDienNuoc (MaPhong, Thang, Nam, ChiSoDienCu, ChiSoDienMoi, ChiSoNuocCu, ChiSoNuocMoi)
VALUES 
    (1, 1, 2023, 1200, 1350, 50, 58),
    (2, 1, 2023, 800, 920, 30, 36),
    (4, 1, 2023, 950, 1100, 40, 48),
    (5, 1, 2023, 1000, 1120, 35, 42),
    (7, 1, 2023, 1500, 1680, 60, 70),
    (8, 1, 2023, 1300, 1450, 55, 64),
    (10, 1, 2023, 1700, 1880, 65, 76),
    (1, 2, 2023, 1350, 1490, 58, 66),
    (2, 2, 2023, 920, 1050, 36, 43),
    (4, 2, 2023, 1100, 1240, 48, 56);
GO

-- Thêm dữ liệu vào bảng HoaDon
INSERT INTO HoaDon (MaPhong, Thang, Nam, TienPhong, TienDien, TienNuoc, TongTien, ThanhToan)
VALUES 
    (1, 1, 2023, 3500000.00, 300000.00, 80000.00, 3880000.00, N'Đã thanh toán'),
    (2, 1, 2023, 3000000.00, 240000.00, 60000.00, 3300000.00, N'Đã thanh toán'),
    (4, 1, 2023, 3200000.00, 300000.00, 80000.00, 3580000.00, N'Đã thanh toán'),
    (5, 1, 2023, 2800000.00, 240000.00, 70000.00, 3110000.00, N'Đã thanh toán'),
    (7, 1, 2023, 4500000.00, 360000.00, 100000.00, 4960000.00, N'Đã thanh toán'),
    (8, 1, 2023, 4200000.00, 300000.00, 90000.00, 4590000.00, N'Đã thanh toán'),
    (10, 1, 2023, 5000000.00, 360000.00, 110000.00, 5470000.00, N'Đã thanh toán'),
    (1, 2, 2023, 3500000.00, 280000.00, 80000.00, 3860000.00, N'Đã thanh toán'),
    (2, 2, 2023, 3000000.00, 260000.00, 70000.00, 3330000.00, N'Chưa thanh toán'),
    (4, 2, 2023, 3200000.00, 280000.00, 80000.00, 3560000.00, N'Chưa thanh toán');
GO