USE [QL_sach_nam]
GO
/****** Object:  Table [dbo].[GiaoDichMuonTra]    Script Date: 26/10/2024 23:05:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiaoDichMuonTra](
	[MaGiaoDich] [varchar](50) NOT NULL,
	[MaSach] [varchar](50) NULL,
	[MaKhachHang] [varchar](50) NULL,
	[NgayMuon] [datetime] NOT NULL,
	[NgayTra] [datetime] NULL,
	[TinhTrang] [nvarchar](255) NULL,
	[MaNhanVien] [varchar](50) NULL,
 CONSTRAINT [PK__GiaoDich__0A2A24EB3584AC5E] PRIMARY KEY CLUSTERED 
(
	[MaGiaoDich] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 26/10/2024 23:05:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKhachHang] [varchar](50) NOT NULL,
	[TenKhachHang] [nvarchar](255) NOT NULL,
	[ThongTinLienLac] [nvarchar](50) NULL,
 CONSTRAINT [PK__KhachHan__88D2F0E59C2B6852] PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 26/10/2024 23:05:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [varchar](50) NOT NULL,
	[HoTen] [nvarchar](255) NOT NULL,
	[ChucVu] [nvarchar](100) NULL,
 CONSTRAINT [PK__NhanVien__77B2CA4718930329] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sach]    Script Date: 26/10/2024 23:05:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sach](
	[MaSach] [varchar](50) NOT NULL,
	[TenSach] [nvarchar](255) NOT NULL,
	[TacGia] [nvarchar](255) NULL,
	[NhaXuatBan] [nvarchar](255) NULL,
	[NamXuatBan] [int] NULL,
	[TheLoai] [nvarchar](100) NULL,
 CONSTRAINT [PK__Sach__B235742D993FF435] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[GiaoDichMuonTra] ([MaGiaoDich], [MaSach], [MaKhachHang], [NgayMuon], [NgayTra], [TinhTrang], [MaNhanVien]) VALUES (N'GD0003', N'S0003', N'KH0003', CAST(N'2024-03-01T00:00:00.000' AS DateTime), CAST(N'2024-03-11T00:00:00.000' AS DateTime), N'Đã trả', N'NV0003')
GO
INSERT [dbo].[GiaoDichMuonTra] ([MaGiaoDich], [MaSach], [MaKhachHang], [NgayMuon], [NgayTra], [TinhTrang], [MaNhanVien]) VALUES (N'GD0004', N'S0004', N'KH0004', CAST(N'2024-04-12T00:00:00.000' AS DateTime), CAST(N'2024-04-22T00:00:00.000' AS DateTime), N'Chưa trả', N'NV0004')
GO
INSERT [dbo].[GiaoDichMuonTra] ([MaGiaoDich], [MaSach], [MaKhachHang], [NgayMuon], [NgayTra], [TinhTrang], [MaNhanVien]) VALUES (N'GD0005', N'S0005', N'KH0005', CAST(N'2024-05-20T00:00:00.000' AS DateTime), CAST(N'2024-05-30T00:00:00.000' AS DateTime), N'Đã trả', N'NV0005')
GO
INSERT [dbo].[GiaoDichMuonTra] ([MaGiaoDich], [MaSach], [MaKhachHang], [NgayMuon], [NgayTra], [TinhTrang], [MaNhanVien]) VALUES (N'GD0006', N'S0006', N'KH0006', CAST(N'2024-06-25T00:00:00.000' AS DateTime), CAST(N'2024-07-05T00:00:00.000' AS DateTime), N'Chưa trả', N'NV0006')
GO
INSERT [dbo].[GiaoDichMuonTra] ([MaGiaoDich], [MaSach], [MaKhachHang], [NgayMuon], [NgayTra], [TinhTrang], [MaNhanVien]) VALUES (N'GD0007', N'S0007', N'KH0007', CAST(N'2024-07-15T00:00:00.000' AS DateTime), CAST(N'2024-07-25T00:00:00.000' AS DateTime), N'Đã trả', N'NV0007')
GO
INSERT [dbo].[GiaoDichMuonTra] ([MaGiaoDich], [MaSach], [MaKhachHang], [NgayMuon], [NgayTra], [TinhTrang], [MaNhanVien]) VALUES (N'GD0008', N'S0008', N'KH0008', CAST(N'2024-08-01T00:00:00.000' AS DateTime), CAST(N'2024-08-11T00:00:00.000' AS DateTime), N'Chưa trả', N'NV0008')
GO
INSERT [dbo].[GiaoDichMuonTra] ([MaGiaoDich], [MaSach], [MaKhachHang], [NgayMuon], [NgayTra], [TinhTrang], [MaNhanVien]) VALUES (N'GD0009', N'S0009', N'KH0009', CAST(N'2024-09-10T00:00:00.000' AS DateTime), CAST(N'2024-09-20T00:00:00.000' AS DateTime), N'Đã trả', N'NV0009')
GO
INSERT [dbo].[GiaoDichMuonTra] ([MaGiaoDich], [MaSach], [MaKhachHang], [NgayMuon], [NgayTra], [TinhTrang], [MaNhanVien]) VALUES (N'GD0010', N'S0010', N'KH0010', CAST(N'2024-10-05T00:00:00.000' AS DateTime), CAST(N'2024-10-15T00:00:00.000' AS DateTime), N'Chưa trả', N'NV0010')
GO
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [ThongTinLienLac]) VALUES (N'KH0002', N'Phạm Thị B', N'09876543211')
GO
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [ThongTinLienLac]) VALUES (N'KH0003', N'Lê Văn C', N'0934567890')
GO
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [ThongTinLienLac]) VALUES (N'KH0004', N'Trần Thị D', N'0701234567')
GO
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [ThongTinLienLac]) VALUES (N'KH0005', N'Hoàng Văn E', N'0908765432')
GO
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [ThongTinLienLac]) VALUES (N'KH0006', N'Phạm Văn F', N'0912345678')
GO
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [ThongTinLienLac]) VALUES (N'KH0007', N'Lê Thị G', N'0321456789')
GO
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [ThongTinLienLac]) VALUES (N'KH0008', N'Nguyễn Văn H', N'0888888888')
GO
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [ThongTinLienLac]) VALUES (N'KH0009', N'Hoàng Thị I', N'0777777777')
GO
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [ThongTinLienLac]) VALUES (N'KH0010', N'Bùi Văn J', N'0999999999')
GO
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [ThongTinLienLac]) VALUES (N'KH09999', N'999', N'9999999999')
GO
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [ChucVu]) VALUES (N'NV0003', N'Phạm Văn M', N'Thủ thư')
GO
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [ChucVu]) VALUES (N'NV0004', N'Lê Anh N', N'Bảo vệ')
GO
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [ChucVu]) VALUES (N'NV0005', N'Nguyễn Văn O', N'Thủ thư')
GO
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [ChucVu]) VALUES (N'NV0006', N'Hoàng Thị P', N'Thu ngân')
GO
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [ChucVu]) VALUES (N'NV0007', N'Bùi Văn Q', N'Bảo vệ')
GO
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [ChucVu]) VALUES (N'NV0008', N'Trần Thị R', N'Quản lý')
GO
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [ChucVu]) VALUES (N'NV0009', N'Nguyễn Văn S', N'Thủ thư')
GO
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [ChucVu]) VALUES (N'NV0010', N'Phạm Thị T', N'Thu ngân')
GO
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [NhaXuatBan], [NamXuatBan], [TheLoai]) VALUES (N'S0002', N'Chí Phèo', N'Nam Cao', N'NXB Trẻ', 2005, N'Văn học 1')
GO
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [NhaXuatBan], [NamXuatBan], [TheLoai]) VALUES (N'S0003', N'Lão Hạc', N'Nam Cao', N'NXB Giáo dục', 2003, N'Văn học')
GO
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [NhaXuatBan], [NamXuatBan], [TheLoai]) VALUES (N'S0004', N'Số Đỏ', N'Vũ Trọng Phụng', N'NXB Thanh Niên', 2010, N'Văn học')
GO
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [NhaXuatBan], [NamXuatBan], [TheLoai]) VALUES (N'S0005', N'Đất Rừng Phương Nam', N'Đoàn Giỏi', N'NXB Kim Đồng', 2000, N'Thiếu nhi')
GO
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [NhaXuatBan], [NamXuatBan], [TheLoai]) VALUES (N'S0006', N'Tắt Đèn', N'Ngô Tất Tố', N'NXB Hội Nhà Văn', 2008, N'Văn học')
GO
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [NhaXuatBan], [NamXuatBan], [TheLoai]) VALUES (N'S0007', N'Tôi Thấy Hoa Vàng Trên Cỏ Xanh', N'Nguyễn Nhật Ánh', N'NXB Trẻ', 2015, N'Tiểu thuyết')
GO
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [NhaXuatBan], [NamXuatBan], [TheLoai]) VALUES (N'S0008', N'Người Trong Bao', N'Sê-khốp', N'NXB Văn Học', 1999, N'Truyện ngắn')
GO
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [NhaXuatBan], [NamXuatBan], [TheLoai]) VALUES (N'S0009', N'Túp Lều Bác Tôm', N'Harriet Beecher Stowe', N'NXB Thanh Niên', 2007, N'Tiểu thuyết')
GO
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [NhaXuatBan], [NamXuatBan], [TheLoai]) VALUES (N'S0010', N'Cuốn Theo Chiều Gió', N'Margaret Mitchell', N'NXB Văn Học', 2004, N'Tiểu thuyết')
GO
ALTER TABLE [dbo].[GiaoDichMuonTra]  WITH CHECK ADD  CONSTRAINT [FK__GiaoDichM__MaNgu__4222D4EF] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[GiaoDichMuonTra] CHECK CONSTRAINT [FK__GiaoDichM__MaNgu__4222D4EF]
GO
ALTER TABLE [dbo].[GiaoDichMuonTra]  WITH CHECK ADD  CONSTRAINT [FK__GiaoDichM__MaNha__4316F928] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[GiaoDichMuonTra] CHECK CONSTRAINT [FK__GiaoDichM__MaNha__4316F928]
GO
ALTER TABLE [dbo].[GiaoDichMuonTra]  WITH CHECK ADD  CONSTRAINT [FK__GiaoDichM__MaSac__412EB0B6] FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([MaSach])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[GiaoDichMuonTra] CHECK CONSTRAINT [FK__GiaoDichM__MaSac__412EB0B6]
GO
/****** Object:  StoredProcedure [dbo].[SP_API]    Script Date: 26/10/2024 23:05:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author Name>
-- Create date: <Create Date>
-- Description:	Stored procedure for CRUD operations and retrieving information for multiple tables
-- =============================================
CREATE PROCEDURE [dbo].[SP_API] 
	@action varchar(50),

	@MaSach varchar(50) = NULL,
	@TenSach nvarchar(255) = NULL,
	@TacGia nvarchar(255) = NULL,
	@NhaXuatBan nvarchar(255) = NULL,
	@NamXuatBan int = NULL,
	@TheLoai nvarchar(100) = NULL,

    @MaNhanVien varchar(50) = NULL,
    @HoTen nvarchar(255) = NULL,
	@ChucVu nvarchar(100) = NULL,

	@MaKhachHang varchar(50) = NULL,
    @TenKhachHang nvarchar(255) = NULL,
	@ThongTinLienLac nvarchar(50) = NULL,

	@MaGiaoDich varchar(50) = NULL,
	@NgayMuon datetime = NULL,
	@NgayTra datetime = NULL,
	@TinhTrang nvarchar(255) = NULL
AS
BEGIN
	DECLARE @json nvarchar(max) = '';

	IF (@action = 'get_nhan_vien')
	BEGIN        
		SELECT @json = (
			SELECT
				'get_nhan_vien' AS status,
				*
			FROM 
				NhanVien
			FOR JSON PATH
		);

		SELECT @json AS [json];
	END

	IF (@action = 'get_sach')
	BEGIN        
		SELECT @json = (
			SELECT
				'get_sach' AS status,
				*
			FROM 
				Sach
			FOR JSON PATH
		);

		SELECT @json AS [json];
	END

	IF (@action = 'get_khach_hang')
	BEGIN        
		SELECT @json = (
			SELECT
				'get_khach_hang' AS status,
				*
			FROM 
				KhachHang
			FOR JSON PATH
		);

		SELECT @json AS [json];
	END

	-- Add Sach 
	ELSE IF (@action = 'add_sach')
	BEGIN
		INSERT INTO Sach (MaSach, TenSach, TacGia, NhaXuatBan, NamXuatBan, TheLoai)
		VALUES (@MaSach, @TenSach, @TacGia, @NhaXuatBan, @NamXuatBan, @TheLoai);
		SELECT 'ok' AS ok, 'Thêm sách thành công' AS message FOR JSON PATH, WITHOUT_ARRAY_WRAPPER;
	END

	-- Add NhanVien 
	ELSE IF (@action = 'add_nhanvien')
	BEGIN
		INSERT INTO NhanVien (MaNhanVien, HoTen, ChucVu)
		VALUES (@MaNhanVien, @HoTen, @ChucVu);
		SELECT 'ok' AS ok, 'Thêm nhân viên thành công' AS message FOR JSON PATH, WITHOUT_ARRAY_WRAPPER;
	END

	-- Add KhachHang 
	ELSE IF (@action = 'add_khachhang')
	BEGIN
		INSERT INTO KhachHang (MaKhachHang, TenKhachHang, ThongTinLienLac)
		VALUES (@MaKhachHang, @TenKhachHang, @ThongTinLienLac);
		SELECT 'ok' AS ok, 'Thêm khách hàng thành công' AS message FOR JSON PATH, WITHOUT_ARRAY_WRAPPER;
	END

	-- Add GiaoDichMuonTra 
	ELSE IF (@action = 'add_giaodich')
	BEGIN
		INSERT INTO GiaoDichMuonTra (MaGiaoDich, MaSach, MaKhachHang, NgayMuon, NgayTra, TinhTrang, MaNhanVien)
		VALUES (@MaGiaoDich, @MaSach, @MaKhachHang, @NgayMuon, @NgayTra, @TinhTrang, @MaNhanVien);
		SELECT 'ok' AS ok, 'Thêm giao dịch thành công' AS message FOR JSON PATH, WITHOUT_ARRAY_WRAPPER;
	END

	-- Update Sach 
	ELSE IF (@action = 'update_sach')
	BEGIN
		UPDATE Sach
		SET TenSach = @TenSach, TacGia = @TacGia, NhaXuatBan = @NhaXuatBan, NamXuatBan = @NamXuatBan, TheLoai = @TheLoai
		WHERE MaSach = @MaSach;
		SELECT 'ok' AS ok, 'Cập nhật sách thành công' AS message FOR JSON PATH, WITHOUT_ARRAY_WRAPPER;
	END

	-- Update NhanVien 
	ELSE IF (@action = 'update_nhanvien')
	BEGIN
		UPDATE NhanVien
		SET HoTen = @HoTen, ChucVu = @ChucVu
		WHERE MaNhanVien = @MaNhanVien;
		SELECT 'ok' AS ok, 'Cập nhật nhân viên thành công' AS message FOR JSON PATH, WITHOUT_ARRAY_WRAPPER;
	END

	-- Update KhachHang 
	ELSE IF (@action = 'update_khachhang')
	BEGIN
		UPDATE KhachHang
		SET TenKhachHang = @TenKhachHang, ThongTinLienLac = @ThongTinLienLac
		WHERE MaKhachHang = @MaKhachHang;
		SELECT 'ok' AS ok, 'Cập nhật khách hàng thành công' AS message FOR JSON PATH, WITHOUT_ARRAY_WRAPPER;
	END

	-- Update GiaoDichMuonTra 
	ELSE IF (@action = 'update_giaodich')
	BEGIN
		UPDATE GiaoDichMuonTra
		SET NgayMuon = @NgayMuon, NgayTra = @NgayTra, TinhTrang = @TinhTrang
		WHERE MaGiaoDich = @MaGiaoDich;
		SELECT 'ok' AS ok, 'Cập nhật giao dịch thành công' AS message FOR JSON PATH, WITHOUT_ARRAY_WRAPPER;
	END

	-- Delete Sach 
	ELSE IF (@action = 'delete_sach')
	BEGIN
		DELETE FROM Sach WHERE MaSach = @MaSach;
		SELECT 'ok' AS ok, 'Xóa sách thành công' AS message FOR JSON PATH, WITHOUT_ARRAY_WRAPPER;
	END

	-- Delete NhanVien 
	ELSE IF (@action = 'delete_nhanvien')
	BEGIN
		DELETE FROM NhanVien WHERE MaNhanVien = @MaNhanVien;
		SELECT 'ok' AS ok, 'Xóa nhân viên thành công' AS message FOR JSON PATH, WITHOUT_ARRAY_WRAPPER;
	END

	-- Delete KhachHang 
	ELSE IF (@action = 'delete_khachhang')
	BEGIN
		DELETE FROM KhachHang WHERE MaKhachHang = @MaKhachHang;
		SELECT 'ok' AS ok, 'Xóa khách hàng thành công' AS message FOR JSON PATH, WITHOUT_ARRAY_WRAPPER;
	END

	-- Delete GiaoDichMuonTra 
	ELSE IF (@action = 'delete_giaodich')
	BEGIN
		DELETE FROM GiaoDichMuonTra WHERE MaGiaoDich = @MaGiaoDich;
		SELECT 'ok' AS ok, 'Xóa giao dịch thành công' AS message FOR JSON PATH, WITHOUT_ARRAY_WRAPPER;
	END
END
GO
