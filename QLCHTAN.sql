USE [master]
GO
/****** Object:  Database [QuanLyCuaHangThucAnNhanh]    Script Date: 06/11/2021 11:14:27 ******/
CREATE DATABASE [QuanLyCuaHangThucAnNhanh] ON  PRIMARY 
( NAME = N'QuanLyCuaHangThucAnNhanh', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\QuanLyCuaHangThucAnNhanh.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLyCuaHangThucAnNhanh_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\QuanLyCuaHangThucAnNhanh_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLyCuaHangThucAnNhanh] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyCuaHangThucAnNhanh].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyCuaHangThucAnNhanh] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [QuanLyCuaHangThucAnNhanh] SET ANSI_NULLS OFF
GO
ALTER DATABASE [QuanLyCuaHangThucAnNhanh] SET ANSI_PADDING OFF
GO
ALTER DATABASE [QuanLyCuaHangThucAnNhanh] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [QuanLyCuaHangThucAnNhanh] SET ARITHABORT OFF
GO
ALTER DATABASE [QuanLyCuaHangThucAnNhanh] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [QuanLyCuaHangThucAnNhanh] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [QuanLyCuaHangThucAnNhanh] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [QuanLyCuaHangThucAnNhanh] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [QuanLyCuaHangThucAnNhanh] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [QuanLyCuaHangThucAnNhanh] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [QuanLyCuaHangThucAnNhanh] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [QuanLyCuaHangThucAnNhanh] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [QuanLyCuaHangThucAnNhanh] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [QuanLyCuaHangThucAnNhanh] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [QuanLyCuaHangThucAnNhanh] SET  DISABLE_BROKER
GO
ALTER DATABASE [QuanLyCuaHangThucAnNhanh] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [QuanLyCuaHangThucAnNhanh] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [QuanLyCuaHangThucAnNhanh] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [QuanLyCuaHangThucAnNhanh] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [QuanLyCuaHangThucAnNhanh] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [QuanLyCuaHangThucAnNhanh] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [QuanLyCuaHangThucAnNhanh] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [QuanLyCuaHangThucAnNhanh] SET  READ_WRITE
GO
ALTER DATABASE [QuanLyCuaHangThucAnNhanh] SET RECOVERY SIMPLE
GO
ALTER DATABASE [QuanLyCuaHangThucAnNhanh] SET  MULTI_USER
GO
ALTER DATABASE [QuanLyCuaHangThucAnNhanh] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [QuanLyCuaHangThucAnNhanh] SET DB_CHAINING OFF
GO
USE [QuanLyCuaHangThucAnNhanh]
GO
/****** Object:  Table [dbo].[LOAIMONAN]    Script Date: 06/11/2021 11:14:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIMONAN](
	[MaLoaiMonAn] [int] NOT NULL,
	[TenLoaiMonAN] [nvarchar](20) NULL,
 CONSTRAINT [PK_LOAIMONAN] PRIMARY KEY CLUSTERED 
(
	[MaLoaiMonAn] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[LOAIMONAN] ([MaLoaiMonAn], [TenLoaiMonAN]) VALUES (1, N'Thức ăn nhanh')
INSERT [dbo].[LOAIMONAN] ([MaLoaiMonAn], [TenLoaiMonAN]) VALUES (2, N'Đồ nóng')
INSERT [dbo].[LOAIMONAN] ([MaLoaiMonAn], [TenLoaiMonAN]) VALUES (3, N'Đồ ăn lạnh')
INSERT [dbo].[LOAIMONAN] ([MaLoaiMonAn], [TenLoaiMonAN]) VALUES (4, N'Nước ngọt')
INSERT [dbo].[LOAIMONAN] ([MaLoaiMonAn], [TenLoaiMonAN]) VALUES (5, N'Đồ cay')
INSERT [dbo].[LOAIMONAN] ([MaLoaiMonAn], [TenLoaiMonAN]) VALUES (6, N'Đồ ăn nhanh')
/****** Object:  Table [dbo].[QUYEN]    Script Date: 06/11/2021 11:14:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[QUYEN](
	[MaQuyen] [char](20) NOT NULL,
	[TenQuyen] [nvarchar](20) NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_QUYEN] PRIMARY KEY CLUSTERED 
(
	[MaQuyen] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[QUYEN] ([MaQuyen], [TenQuyen], [GhiChu]) VALUES (N'Admin               ', N'admin', N'admin')
INSERT [dbo].[QUYEN] ([MaQuyen], [TenQuyen], [GhiChu]) VALUES (N'ADMIN1              ', N'ADMIN1', N'true')
INSERT [dbo].[QUYEN] ([MaQuyen], [TenQuyen], [GhiChu]) VALUES (N'boss                ', N'boss', N'true')
INSERT [dbo].[QUYEN] ([MaQuyen], [TenQuyen], [GhiChu]) VALUES (N'nhanvien2           ', N'nhanvien2', N'admin')
INSERT [dbo].[QUYEN] ([MaQuyen], [TenQuyen], [GhiChu]) VALUES (N'NV                  ', N'Nhân viên', N'dif')
INSERT [dbo].[QUYEN] ([MaQuyen], [TenQuyen], [GhiChu]) VALUES (N'QL                  ', N'Quản lý', N'true')
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 06/11/2021 11:14:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNhanVien] [char](20) NOT NULL,
	[HoNhanVien] [nvarchar](20) NULL,
	[TenNhanVien] [nvarchar](20) NULL,
	[SDT] [char](20) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](20) NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoNhanVien], [TenNhanVien], [SDT], [NgaySinh], [GioiTinh]) VALUES (N'NV01                ', N'Tăng', N'Long', N'0903158633          ', CAST(0xAD240B00 AS Date), N'Nam')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoNhanVien], [TenNhanVien], [SDT], [NgaySinh], [GioiTinh]) VALUES (N'NV02                ', N'a', N'b', N'32131321321         ', CAST(0x0B240B00 AS Date), N'Nữ')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoNhanVien], [TenNhanVien], [SDT], [NgaySinh], [GioiTinh]) VALUES (N'NV03                ', N'faf', N'fdasf', N'32132323412         ', CAST(0xA7240B00 AS Date), N'Nam')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoNhanVien], [TenNhanVien], [SDT], [NgaySinh], [GioiTinh]) VALUES (N'NV04                ', N'Quốc', N'Tiễn', N'014944458           ', CAST(0x8B240B00 AS Date), N'Nam')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoNhanVien], [TenNhanVien], [SDT], [NgaySinh], [GioiTinh]) VALUES (N'NV05                ', N'Minh', N'Nam', N'0434456467          ', CAST(0xC4210B00 AS Date), N'Nữ')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoNhanVien], [TenNhanVien], [SDT], [NgaySinh], [GioiTinh]) VALUES (N'NV06                ', N'Minh Long', N'Long', N'164544498           ', CAST(0xA2240B00 AS Date), N'Nam')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoNhanVien], [TenNhanVien], [SDT], [NgaySinh], [GioiTinh]) VALUES (N'NV07                ', N'Quốc', N'đâ', N'34545               ', CAST(0x9F240B00 AS Date), N'Nam')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoNhanVien], [TenNhanVien], [SDT], [NgaySinh], [GioiTinh]) VALUES (N'NV08                ', N'Quốc', N'Hiếu', N'0146689897          ', CAST(0x27240B00 AS Date), N'Nam')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoNhanVien], [TenNhanVien], [SDT], [NgaySinh], [GioiTinh]) VALUES (N'NV10                ', N'Minhhhh', N'Hiếu', N'05669889            ', CAST(0xA1240B00 AS Date), N'Nữ')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoNhanVien], [TenNhanVien], [SDT], [NgaySinh], [GioiTinh]) VALUES (N'NV11                ', N'Quốc', N'Hiếu PC', N'05669889            ', CAST(0xC7210B00 AS Date), N'Nữ')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoNhanVien], [TenNhanVien], [SDT], [NgaySinh], [GioiTinh]) VALUES (N'NV12                ', N'Trần Văn', N'Trinh', N'0434456467          ', CAST(0xA8210B00 AS Date), NULL)
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoNhanVien], [TenNhanVien], [SDT], [NgaySinh], [GioiTinh]) VALUES (N'NV13                ', N'Quốc', N'Tiễn', N'05669889            ', CAST(0xCE210B00 AS Date), N'Nữ')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoNhanVien], [TenNhanVien], [SDT], [NgaySinh], [GioiTinh]) VALUES (N'NV15                ', N'Minh', N'chó', N'266464              ', CAST(0xA2240B00 AS Date), N'Nam')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoNhanVien], [TenNhanVien], [SDT], [NgaySinh], [GioiTinh]) VALUES (N'NV16                ', N'Dương', N'Quốc', N'069854645           ', CAST(0x9F240B00 AS Date), N'Nam')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoNhanVien], [TenNhanVien], [SDT], [NgaySinh], [GioiTinh]) VALUES (N'NV17                ', N'Nguyễn Văn', N'Anh', N'066498989           ', CAST(0xA7240B00 AS Date), N'Nữ')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoNhanVien], [TenNhanVien], [SDT], [NgaySinh], [GioiTinh]) VALUES (N'NV18                ', N'Quốc', N'Tiễn', N'06469996            ', CAST(0xA2240B00 AS Date), N'Nam')
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 06/11/2021 11:14:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[ID] [char](20) NOT NULL,
	[TenTaiKhoan] [char](20) NULL,
	[MatKhau] [char](20) NULL,
	[MaQuyen] [char](20) NULL,
	[MaNhanVien] [char](20) NULL,
 CONSTRAINT [PK_TAIKHOAN] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[TAIKHOAN] ([ID], [TenTaiKhoan], [MatKhau], [MaQuyen], [MaNhanVien]) VALUES (N'TK1                 ', N'minhlong            ', N'minhlong            ', N'Admin               ', N'NV01                ')
INSERT [dbo].[TAIKHOAN] ([ID], [TenTaiKhoan], [MatKhau], [MaQuyen], [MaNhanVien]) VALUES (N'TK2                 ', N'nhanvien            ', N'nhanvien            ', N'NV                  ', N'NV02                ')
INSERT [dbo].[TAIKHOAN] ([ID], [TenTaiKhoan], [MatKhau], [MaQuyen], [MaNhanVien]) VALUES (N'TK3                 ', N'quanly              ', N'quanly              ', N'QL                  ', N'NV02                ')
INSERT [dbo].[TAIKHOAN] ([ID], [TenTaiKhoan], [MatKhau], [MaQuyen], [MaNhanVien]) VALUES (N'TK4                 ', N'nhanvien01          ', N'nhanvien01          ', N'Admin               ', N'NV11                ')
INSERT [dbo].[TAIKHOAN] ([ID], [TenTaiKhoan], [MatKhau], [MaQuyen], [MaNhanVien]) VALUES (N'TK5                 ', N'nhanvien16          ', N'nhanvien16          ', N'NV                  ', N'NV16                ')
INSERT [dbo].[TAIKHOAN] ([ID], [TenTaiKhoan], [MatKhau], [MaQuyen], [MaNhanVien]) VALUES (N'TK6                 ', N'Nhanvien18          ', N'Nhanvien18          ', N'NV                  ', N'NV18                ')
/****** Object:  Table [dbo].[MONAN]    Script Date: 06/11/2021 11:14:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MONAN](
	[MaMonAn] [char](20) NOT NULL,
	[TenMonAn] [nvarchar](20) NULL,
	[GiaTien] [float] NULL,
	[Anh] [nvarchar](max) NULL,
	[MaLoaiMonAn] [int] NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_MONAN] PRIMARY KEY CLUSTERED 
(
	[MaMonAn] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[MONAN] ([MaMonAn], [TenMonAn], [GiaTien], [Anh], [MaLoaiMonAn], [SoLuong]) VALUES (N'MA01                ', N'Mỳ chua cay', 25000, N'Images/Mỳ.png', 2, 50)
INSERT [dbo].[MONAN] ([MaMonAn], [TenMonAn], [GiaTien], [Anh], [MaLoaiMonAn], [SoLuong]) VALUES (N'MA02                ', N'Mỳ trứng', 25000, N'Images/MyTrung.png', 2, 20)
INSERT [dbo].[MONAN] ([MaMonAn], [TenMonAn], [GiaTien], [Anh], [MaLoaiMonAn], [SoLuong]) VALUES (N'MA03                ', N'Mỳ rau thơm', 20000, N'Images/MyGoiRauThom.png', 2, 28)
INSERT [dbo].[MONAN] ([MaMonAn], [TenMonAn], [GiaTien], [Anh], [MaLoaiMonAn], [SoLuong]) VALUES (N'MA04                ', N'Trà sữa socola', 25000, N'Images/Trasua.jpg', 4, 5)
INSERT [dbo].[MONAN] ([MaMonAn], [TenMonAn], [GiaTien], [Anh], [MaLoaiMonAn], [SoLuong]) VALUES (N'MA05                ', N'Kem quế', 20000, N'Images/kem.jpg', 3, 45)
INSERT [dbo].[MONAN] ([MaMonAn], [TenMonAn], [GiaTien], [Anh], [MaLoaiMonAn], [SoLuong]) VALUES (N'MA07                ', N'Burrito', 60000, N'Images/borito.webp', 1, 50)
INSERT [dbo].[MONAN] ([MaMonAn], [TenMonAn], [GiaTien], [Anh], [MaLoaiMonAn], [SoLuong]) VALUES (N'MA08                ', N'Hamburger', 40000, N'Images/food3.png', 1, 50)
INSERT [dbo].[MONAN] ([MaMonAn], [TenMonAn], [GiaTien], [Anh], [MaLoaiMonAn], [SoLuong]) VALUES (N'MA09                ', N'Salad', 30000, N'Images/MyTrung.png', 3, 50)
INSERT [dbo].[MONAN] ([MaMonAn], [TenMonAn], [GiaTien], [Anh], [MaLoaiMonAn], [SoLuong]) VALUES (N'MA10                ', N'Khoai tây chiên', 20000, N'Images/food4.png', 1, 50)
INSERT [dbo].[MONAN] ([MaMonAn], [TenMonAn], [GiaTien], [Anh], [MaLoaiMonAn], [SoLuong]) VALUES (N'MA11                ', N'nước ngọt', 25000, N'Images/Mỳ.png', 4, 58)
INSERT [dbo].[MONAN] ([MaMonAn], [TenMonAn], [GiaTien], [Anh], [MaLoaiMonAn], [SoLuong]) VALUES (N'MA12                ', N'Mỳ chua cay', 45000, N'Images/Nuoccam.jpg', 1, 45)
INSERT [dbo].[MONAN] ([MaMonAn], [TenMonAn], [GiaTien], [Anh], [MaLoaiMonAn], [SoLuong]) VALUES (N'MA13                ', N'Sushi', 40000, N'Images/Mỳ.png', 2, 41)
INSERT [dbo].[MONAN] ([MaMonAn], [TenMonAn], [GiaTien], [Anh], [MaLoaiMonAn], [SoLuong]) VALUES (N'MA14                ', N'Gà rán', 40000, N'Images/Trasua.jpg', 1, 50)
INSERT [dbo].[MONAN] ([MaMonAn], [TenMonAn], [GiaTien], [Anh], [MaLoaiMonAn], [SoLuong]) VALUES (N'MA15                ', N'Pepsi', 20000, N'Images/coca.png', 4, 50)
INSERT [dbo].[MONAN] ([MaMonAn], [TenMonAn], [GiaTien], [Anh], [MaLoaiMonAn], [SoLuong]) VALUES (N'MA16                ', N'Coca cola', 20000, N'Images/coca.png', 4, 50)
INSERT [dbo].[MONAN] ([MaMonAn], [TenMonAn], [GiaTien], [Anh], [MaLoaiMonAn], [SoLuong]) VALUES (N'MA17                ', N'Sting', 20000, N'Images/food12.png', 4, 45)
INSERT [dbo].[MONAN] ([MaMonAn], [TenMonAn], [GiaTien], [Anh], [MaLoaiMonAn], [SoLuong]) VALUES (N'MA18                ', N'7 up', 20000, N'Images/food13.png', 4, 50)
INSERT [dbo].[MONAN] ([MaMonAn], [TenMonAn], [GiaTien], [Anh], [MaLoaiMonAn], [SoLuong]) VALUES (N'MA19                ', N'Mì quảng', 40000, N'Images/food14.png', 2, 50)
INSERT [dbo].[MONAN] ([MaMonAn], [TenMonAn], [GiaTien], [Anh], [MaLoaiMonAn], [SoLuong]) VALUES (N'MA22                ', N'Bánh bao', 50000, N'Images/banhbao.jpg', 1, 50)
INSERT [dbo].[MONAN] ([MaMonAn], [TenMonAn], [GiaTien], [Anh], [MaLoaiMonAn], [SoLuong]) VALUES (N'MA23                ', N'Bánh trứng', 30000, N'Images/food18.png', 2, 50)
INSERT [dbo].[MONAN] ([MaMonAn], [TenMonAn], [GiaTien], [Anh], [MaLoaiMonAn], [SoLuong]) VALUES (N'MA24                ', N'Bánh trung thu', 30000, N'Images/food19.png', 1, 50)
INSERT [dbo].[MONAN] ([MaMonAn], [TenMonAn], [GiaTien], [Anh], [MaLoaiMonAn], [SoLuong]) VALUES (N'MA25                ', N'Mỳ rau', 25000, N'Images/Mỳ.png', 2, 45)
INSERT [dbo].[MONAN] ([MaMonAn], [TenMonAn], [GiaTien], [Anh], [MaLoaiMonAn], [SoLuong]) VALUES (N'MA26                ', N'Mỳ rau bò', 25000, N'Images/MyGoiRauThom.png', 3, 50)
/****** Object:  Table [dbo].[HD]    Script Date: 06/11/2021 11:14:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HD](
	[MaHD] [int] IDENTITY(1,1) NOT NULL,
	[MaNhanVien] [char](20) NULL,
	[ThoiGian] [datetime] NULL,
 CONSTRAINT [PK_HD] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[HD] ON
INSERT [dbo].[HD] ([MaHD], [MaNhanVien], [ThoiGian]) VALUES (16, N'NV02                ', CAST(0x0000AD430182A527 AS DateTime))
INSERT [dbo].[HD] ([MaHD], [MaNhanVien], [ThoiGian]) VALUES (17, N'NV02                ', CAST(0x0000AD430183044C AS DateTime))
INSERT [dbo].[HD] ([MaHD], [MaNhanVien], [ThoiGian]) VALUES (18, N'NV02                ', CAST(0x0000AD4301830950 AS DateTime))
INSERT [dbo].[HD] ([MaHD], [MaNhanVien], [ThoiGian]) VALUES (19, N'NV02                ', CAST(0x0000AD4301830D45 AS DateTime))
INSERT [dbo].[HD] ([MaHD], [MaNhanVien], [ThoiGian]) VALUES (20, N'NV02                ', CAST(0x0000AD4301831162 AS DateTime))
INSERT [dbo].[HD] ([MaHD], [MaNhanVien], [ThoiGian]) VALUES (21, N'NV02                ', CAST(0x0000AD43018754D5 AS DateTime))
INSERT [dbo].[HD] ([MaHD], [MaNhanVien], [ThoiGian]) VALUES (22, N'NV02                ', CAST(0x0000AD430187E91F AS DateTime))
INSERT [dbo].[HD] ([MaHD], [MaNhanVien], [ThoiGian]) VALUES (23, N'NV02                ', CAST(0x0000AD4400B50468 AS DateTime))
INSERT [dbo].[HD] ([MaHD], [MaNhanVien], [ThoiGian]) VALUES (24, N'NV18                ', CAST(0x0000AD4400B68651 AS DateTime))
SET IDENTITY_INSERT [dbo].[HD] OFF
/****** Object:  Table [dbo].[CTHD]    Script Date: 06/11/2021 11:14:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CTHD](
	[MaCTHD] [int] IDENTITY(1,1) NOT NULL,
	[MaHD] [int] NULL,
	[MaMonAn] [char](20) NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_CTHD] PRIMARY KEY CLUSTERED 
(
	[MaCTHD] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[CTHD] ON
INSERT [dbo].[CTHD] ([MaCTHD], [MaHD], [MaMonAn], [SoLuong]) VALUES (20, 16, N'MA13                ', 5)
INSERT [dbo].[CTHD] ([MaCTHD], [MaHD], [MaMonAn], [SoLuong]) VALUES (21, 17, N'MA03                ', 1)
INSERT [dbo].[CTHD] ([MaCTHD], [MaHD], [MaMonAn], [SoLuong]) VALUES (22, 17, N'MA04                ', 1)
INSERT [dbo].[CTHD] ([MaCTHD], [MaHD], [MaMonAn], [SoLuong]) VALUES (23, 17, N'MA17                ', 1)
INSERT [dbo].[CTHD] ([MaCTHD], [MaHD], [MaMonAn], [SoLuong]) VALUES (24, 17, N'MA11                ', 1)
INSERT [dbo].[CTHD] ([MaCTHD], [MaHD], [MaMonAn], [SoLuong]) VALUES (25, 18, N'MA17                ', 1)
INSERT [dbo].[CTHD] ([MaCTHD], [MaHD], [MaMonAn], [SoLuong]) VALUES (26, 19, N'MA11                ', 1)
INSERT [dbo].[CTHD] ([MaCTHD], [MaHD], [MaMonAn], [SoLuong]) VALUES (27, 20, N'MA03                ', 1)
INSERT [dbo].[CTHD] ([MaCTHD], [MaHD], [MaMonAn], [SoLuong]) VALUES (28, 21, N'MA04                ', 4)
INSERT [dbo].[CTHD] ([MaCTHD], [MaHD], [MaMonAn], [SoLuong]) VALUES (29, 22, N'MA13                ', 3)
INSERT [dbo].[CTHD] ([MaCTHD], [MaHD], [MaMonAn], [SoLuong]) VALUES (30, 23, N'MA04                ', 4)
INSERT [dbo].[CTHD] ([MaCTHD], [MaHD], [MaMonAn], [SoLuong]) VALUES (31, 23, N'MA17                ', 3)
INSERT [dbo].[CTHD] ([MaCTHD], [MaHD], [MaMonAn], [SoLuong]) VALUES (32, 24, N'MA04                ', 1)
INSERT [dbo].[CTHD] ([MaCTHD], [MaHD], [MaMonAn], [SoLuong]) VALUES (33, 24, N'MA13                ', 1)
SET IDENTITY_INSERT [dbo].[CTHD] OFF
/****** Object:  Check [NHANVIEN_GioiTinh_C]    Script Date: 06/11/2021 11:14:29 ******/
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [NHANVIEN_GioiTinh_C] CHECK  (([GioiTinh]=N'Nam' OR [GioiTinh]=N'Nữ'))
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [NHANVIEN_GioiTinh_C]
GO
/****** Object:  ForeignKey [FK_TAIKHOAN_NHANVIEN]    Script Date: 06/11/2021 11:14:29 ******/
ALTER TABLE [dbo].[TAIKHOAN]  WITH CHECK ADD  CONSTRAINT [FK_TAIKHOAN_NHANVIEN] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NHANVIEN] ([MaNhanVien])
GO
ALTER TABLE [dbo].[TAIKHOAN] CHECK CONSTRAINT [FK_TAIKHOAN_NHANVIEN]
GO
/****** Object:  ForeignKey [FK_TAIKHOAN_QUYEN]    Script Date: 06/11/2021 11:14:29 ******/
ALTER TABLE [dbo].[TAIKHOAN]  WITH CHECK ADD  CONSTRAINT [FK_TAIKHOAN_QUYEN] FOREIGN KEY([MaQuyen])
REFERENCES [dbo].[QUYEN] ([MaQuyen])
GO
ALTER TABLE [dbo].[TAIKHOAN] CHECK CONSTRAINT [FK_TAIKHOAN_QUYEN]
GO
/****** Object:  ForeignKey [FK_MONAN_LOAIMONAN]    Script Date: 06/11/2021 11:14:29 ******/
ALTER TABLE [dbo].[MONAN]  WITH CHECK ADD  CONSTRAINT [FK_MONAN_LOAIMONAN] FOREIGN KEY([MaLoaiMonAn])
REFERENCES [dbo].[LOAIMONAN] ([MaLoaiMonAn])
GO
ALTER TABLE [dbo].[MONAN] CHECK CONSTRAINT [FK_MONAN_LOAIMONAN]
GO
/****** Object:  ForeignKey [FK_HD_NHANVIEN]    Script Date: 06/11/2021 11:14:29 ******/
ALTER TABLE [dbo].[HD]  WITH CHECK ADD  CONSTRAINT [FK_HD_NHANVIEN] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NHANVIEN] ([MaNhanVien])
GO
ALTER TABLE [dbo].[HD] CHECK CONSTRAINT [FK_HD_NHANVIEN]
GO
/****** Object:  ForeignKey [FK_CTHD_HD]    Script Date: 06/11/2021 11:14:29 ******/
ALTER TABLE [dbo].[CTHD]  WITH CHECK ADD  CONSTRAINT [FK_CTHD_HD] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HD] ([MaHD])
GO
ALTER TABLE [dbo].[CTHD] CHECK CONSTRAINT [FK_CTHD_HD]
GO
/****** Object:  ForeignKey [FK_CTHD_MONAN]    Script Date: 06/11/2021 11:14:29 ******/
ALTER TABLE [dbo].[CTHD]  WITH CHECK ADD  CONSTRAINT [FK_CTHD_MONAN] FOREIGN KEY([MaMonAn])
REFERENCES [dbo].[MONAN] ([MaMonAn])
GO
ALTER TABLE [dbo].[CTHD] CHECK CONSTRAINT [FK_CTHD_MONAN]
GO
