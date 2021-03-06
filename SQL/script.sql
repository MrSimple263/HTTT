USE [master]
GO
/****** Object:  Database [CUAHANGSACH]    Script Date: 4/18/2018 10:38:58 PM ******/
CREATE DATABASE [CUAHANGSACH]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CUAHANGSACH', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\CUAHANGSACH.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CUAHANGSACH_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\CUAHANGSACH_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [CUAHANGSACH] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CUAHANGSACH].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CUAHANGSACH] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CUAHANGSACH] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CUAHANGSACH] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CUAHANGSACH] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CUAHANGSACH] SET ARITHABORT OFF 
GO
ALTER DATABASE [CUAHANGSACH] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CUAHANGSACH] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CUAHANGSACH] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CUAHANGSACH] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CUAHANGSACH] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CUAHANGSACH] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CUAHANGSACH] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CUAHANGSACH] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CUAHANGSACH] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CUAHANGSACH] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CUAHANGSACH] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CUAHANGSACH] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CUAHANGSACH] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CUAHANGSACH] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CUAHANGSACH] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CUAHANGSACH] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CUAHANGSACH] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CUAHANGSACH] SET RECOVERY FULL 
GO
ALTER DATABASE [CUAHANGSACH] SET  MULTI_USER 
GO
ALTER DATABASE [CUAHANGSACH] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CUAHANGSACH] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CUAHANGSACH] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CUAHANGSACH] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CUAHANGSACH] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'CUAHANGSACH', N'ON'
GO
ALTER DATABASE [CUAHANGSACH] SET QUERY_STORE = OFF
GO
USE [CUAHANGSACH]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [CUAHANGSACH]
GO
/****** Object:  UserDefinedFunction [dbo].[checkexist]    Script Date: 4/18/2018 10:38:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[checkexist](@sach int)
returns BIT
as
begin
if exists(select sach from KHO where sach=@sach)
 return 1;
return 0
end
GO
/****** Object:  Table [dbo].[CTHD]    Script Date: 4/18/2018 10:38:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTHD](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[sach] [int] NULL,
	[dongia] [real] NULL,
	[hoadon] [int] NULL,
 CONSTRAINT [PK_CTHD] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 4/18/2018 10:38:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[id] [int] NOT NULL,
	[ngaylap] [date] NULL,
	[tongtien] [real] NULL,
	[infor] [text] NULL,
 CONSTRAINT [PK_HOADON] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHO]    Script Date: 4/18/2018 10:38:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHO](
	[sach] [int] NOT NULL,
	[soluong] [int] NULL,
 CONSTRAINT [PK_KHO] PRIMARY KEY CLUSTERED 
(
	[sach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 4/18/2018 10:38:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50) NULL,
	[password] [nvarchar](50) NULL,
	[hoten] [nvarchar](50) NULL,
	[ngaysinh] [nvarchar](50) NULL,
	[sdt] [nvarchar](50) NULL,
	[role] [int] NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NXB]    Script Date: 4/18/2018 10:38:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NXB](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ten] [nvarchar](50) NULL,
	[infor] [text] NULL,
 CONSTRAINT [PK_NXB] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUNHAPKHO]    Script Date: 4/18/2018 10:38:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUNHAPKHO](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[sach] [int] NULL,
	[soluong] [int] NULL,
	[ngaynhap] [date] NULL,
 CONSTRAINT [PK_PHIEUNHAPKHO] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PXK]    Script Date: 4/18/2018 10:38:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PXK](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[sach] [int] NULL,
	[soluong] [int] NULL,
	[ngayxuat] [date] NULL,
 CONSTRAINT [PK_PXK] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ROLE]    Script Date: 4/18/2018 10:38:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ROLE](
	[id] [int] NOT NULL,
	[name] [nvarchar](50) NULL,
 CONSTRAINT [PK_ROLE] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SACH]    Script Date: 4/18/2018 10:38:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SACH](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[dongia] [real] NULL,
	[nxb] [int] NULL,
 CONSTRAINT [PK_SACH] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SACH-TACGIA]    Script Date: 4/18/2018 10:38:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SACH-TACGIA](
	[sach] [int] NOT NULL,
	[tacgia] [int] NOT NULL,
 CONSTRAINT [PK_SACH-TACGIA] PRIMARY KEY CLUSTERED 
(
	[sach] ASC,
	[tacgia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SACH-THELOAI]    Script Date: 4/18/2018 10:38:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SACH-THELOAI](
	[sach] [int] NOT NULL,
	[theloai] [int] NOT NULL,
 CONSTRAINT [PK_SACH-THELOAI] PRIMARY KEY CLUSTERED 
(
	[sach] ASC,
	[theloai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TACGIA]    Script Date: 4/18/2018 10:38:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TACGIA](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[hoten] [nvarchar](50) NULL,
	[infor] [text] NULL,
 CONSTRAINT [PK_TACGIA] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THELOAI]    Script Date: 4/18/2018 10:38:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THELOAI](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ten] [nvarchar](50) NULL,
 CONSTRAINT [PK_THELOAI] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CTHD]  WITH CHECK ADD  CONSTRAINT [FK_CTHD_HOADON] FOREIGN KEY([hoadon])
REFERENCES [dbo].[HOADON] ([id])
GO
ALTER TABLE [dbo].[CTHD] CHECK CONSTRAINT [FK_CTHD_HOADON]
GO
ALTER TABLE [dbo].[CTHD]  WITH CHECK ADD  CONSTRAINT [FK_CTHD_SACH] FOREIGN KEY([sach])
REFERENCES [dbo].[SACH] ([id])
GO
ALTER TABLE [dbo].[CTHD] CHECK CONSTRAINT [FK_CTHD_SACH]
GO
ALTER TABLE [dbo].[KHO]  WITH CHECK ADD  CONSTRAINT [FK_KHO_SACH] FOREIGN KEY([sach])
REFERENCES [dbo].[SACH] ([id])
GO
ALTER TABLE [dbo].[KHO] CHECK CONSTRAINT [FK_KHO_SACH]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_ROLE] FOREIGN KEY([role])
REFERENCES [dbo].[ROLE] ([id])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_ROLE]
GO
ALTER TABLE [dbo].[PHIEUNHAPKHO]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAPKHO_SACH] FOREIGN KEY([sach])
REFERENCES [dbo].[SACH] ([id])
GO
ALTER TABLE [dbo].[PHIEUNHAPKHO] CHECK CONSTRAINT [FK_PHIEUNHAPKHO_SACH]
GO
ALTER TABLE [dbo].[PXK]  WITH CHECK ADD  CONSTRAINT [FK_PXK_SACH] FOREIGN KEY([sach])
REFERENCES [dbo].[SACH] ([id])
GO
ALTER TABLE [dbo].[PXK] CHECK CONSTRAINT [FK_PXK_SACH]
GO
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [FK_SACH_NXB] FOREIGN KEY([nxb])
REFERENCES [dbo].[NXB] ([id])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [FK_SACH_NXB]
GO
ALTER TABLE [dbo].[SACH-TACGIA]  WITH CHECK ADD  CONSTRAINT [FK_SACH-TACGIA_SACH] FOREIGN KEY([sach])
REFERENCES [dbo].[SACH] ([id])
GO
ALTER TABLE [dbo].[SACH-TACGIA] CHECK CONSTRAINT [FK_SACH-TACGIA_SACH]
GO
ALTER TABLE [dbo].[SACH-TACGIA]  WITH CHECK ADD  CONSTRAINT [FK_SACH-TACGIA_TACGIA] FOREIGN KEY([tacgia])
REFERENCES [dbo].[TACGIA] ([id])
GO
ALTER TABLE [dbo].[SACH-TACGIA] CHECK CONSTRAINT [FK_SACH-TACGIA_TACGIA]
GO
ALTER TABLE [dbo].[SACH-THELOAI]  WITH CHECK ADD  CONSTRAINT [FK_SACH-THELOAI_SACH] FOREIGN KEY([sach])
REFERENCES [dbo].[SACH] ([id])
GO
ALTER TABLE [dbo].[SACH-THELOAI] CHECK CONSTRAINT [FK_SACH-THELOAI_SACH]
GO
ALTER TABLE [dbo].[SACH-THELOAI]  WITH CHECK ADD  CONSTRAINT [FK_SACH-THELOAI_THELOAI] FOREIGN KEY([theloai])
REFERENCES [dbo].[THELOAI] ([id])
GO
ALTER TABLE [dbo].[SACH-THELOAI] CHECK CONSTRAINT [FK_SACH-THELOAI_THELOAI]
GO
/****** Object:  StoredProcedure [dbo].[cthd_selectidhoadon]    Script Date: 4/18/2018 10:38:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[cthd_selectidhoadon](@id int)
as
begin
select * from CTHD
where hoadon=@id
end
GO
/****** Object:  StoredProcedure [dbo].[hoadon_delete]    Script Date: 4/18/2018 10:38:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[hoadon_delete](@id int)
as
begin
delete from HOADON where id =@id
end
GO
/****** Object:  StoredProcedure [dbo].[hoadon_insert]    Script Date: 4/18/2018 10:38:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[hoadon_insert](@ngaylap date,@tontien real,@infor text)
as
begin
insert into HOADON(ngaylap,tongtien,infor) values(@ngaylap,@tontien,@infor)
end
GO
/****** Object:  StoredProcedure [dbo].[hoadon_selectall]    Script Date: 4/18/2018 10:38:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[hoadon_selectall]
as
begin
select * from HOADON
end
GO
/****** Object:  StoredProcedure [dbo].[hoadon_selectid]    Script Date: 4/18/2018 10:38:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[hoadon_selectid](@id int)
as
begin
select * from HOADON
where id=@id
end
GO
/****** Object:  StoredProcedure [dbo].[kho_nhap]    Script Date: 4/18/2018 10:38:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[kho_nhap](@sach int,@sl int)
as
begin
declare @check bit;
select @check=dbo.checkexist(@sach);
if(@check=1)
update KHO set soluong=soluong+@sl
where sach=@sach;
else 
insert KHO values(@sach,@sl);
end
GO
/****** Object:  StoredProcedure [dbo].[kho_xuat]    Script Date: 4/18/2018 10:38:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[kho_xuat](@sach int,@sl int)
as
begin
declare @slhientai int;
if (@slhientai >=@sl)
update KHO set soluong=soluong-@sl
where sach=@sach;
else
raiserror(N'Sách không đủ để xuất kho',11,1);

end
GO
/****** Object:  StoredProcedure [dbo].[nhanvien_delete]    Script Date: 4/18/2018 10:38:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[nhanvien_delete](@id int)
as
begin
delete from NHANVIEN where id=@id
end
GO
/****** Object:  StoredProcedure [dbo].[nhanvien_insert]    Script Date: 4/18/2018 10:38:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[nhanvien_insert](@username nvarchar(50),
							@pass nvarchar(50),
							@hoten nvarchar(50),
							@ngaysinh date,
							@sdt nvarchar(50),
							@role int)
as
begin
insert into NHANVIEN values(@username,@pass,@hoten,@ngaysinh,@sdt,@role);
end
GO
/****** Object:  StoredProcedure [dbo].[nhanvien_selectall]    Script Date: 4/18/2018 10:38:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[nhanvien_selectall]
as 
begin
select NHANVIEN.id,hoten,ngaysinh,username,password,ROLE.name
from NHANVIEN inner join ROLE on role=ROLE.id
end
GO
/****** Object:  StoredProcedure [dbo].[nhanvien_selectid]    Script Date: 4/18/2018 10:38:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[nhanvien_selectid] (@id int)
as
begin
select NHANVIEN.id,hoten,ngaysinh,username,password,ROLE.name
from NHANVIEN inner join ROLE on role=ROLE.id
where NHANVIEN.id=@id
end
GO
/****** Object:  StoredProcedure [dbo].[nhanvien_update]    Script Date: 4/18/2018 10:38:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[nhanvien_update](@username nvarchar(50),
							@pass nvarchar(50),
							@hoten nvarchar(50),
							@ngaysinh date,
							@sdt nvarchar(50),
							@role int,
							@id int)
as
begin
update NHANVIEN set username=@username,password=@pass,hoten=@hoten,ngaysinh=@ngaysinh,sdt=@sdt 
where id=@id
end
GO
/****** Object:  StoredProcedure [dbo].[nxb_delete]    Script Date: 4/18/2018 10:38:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[nxb_delete](@id int)
as
begin
delete from NXB
where id=@id
end
GO
/****** Object:  StoredProcedure [dbo].[nxb_insert]    Script Date: 4/18/2018 10:38:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[nxb_insert](@ten nvarchar(50),@infor text)
as
begin
insert into NXB(ten,infor) values(@ten,@infor)
end
GO
/****** Object:  StoredProcedure [dbo].[nxb_selectall]    Script Date: 4/18/2018 10:38:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[nxb_selectall]
as
begin
select * from NXB
end
GO
/****** Object:  StoredProcedure [dbo].[nxb_selectid]    Script Date: 4/18/2018 10:38:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[nxb_selectid](@id int)
as
begin
select * from NXB
where id=@id
end
GO
/****** Object:  StoredProcedure [dbo].[nxb_update]    Script Date: 4/18/2018 10:38:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[nxb_update](@id int,@ten nvarchar(50),@infor text)
as
begin
update NXB set ten=@ten,infor=@infor
where id=@id
end
GO
/****** Object:  StoredProcedure [dbo].[pnk_delete]    Script Date: 4/18/2018 10:38:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[pnk_delete](@id int)
as
begin
delete from PHIEUNHAPKHO
where id=@id
end
GO
/****** Object:  StoredProcedure [dbo].[pnk_insert]    Script Date: 4/18/2018 10:38:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[pnk_insert](@sach int,@soluong int,@ngaynhap date)
as
begin
insert into PHIEUNHAPKHO(sach,soluong,ngaynhap) values(@sach,@soluong,@ngaynhap)
end
GO
/****** Object:  StoredProcedure [dbo].[pnk_selectid]    Script Date: 4/18/2018 10:38:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[pnk_selectid](@id int)
as
begin
select * from PHIEUNHAPKHO
where id=@id
end
GO
/****** Object:  StoredProcedure [dbo].[pnk_update]    Script Date: 4/18/2018 10:38:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[pnk_update](@id int,@sach int,@soluong int,@ngaynhap date)
as
begin
update PHIEUNHAPKHO set sach=@sach,soluong=@soluong,ngaynhap=@ngaynhap
where id=@id
end;
GO
/****** Object:  StoredProcedure [dbo].[sach_delete]    Script Date: 4/18/2018 10:38:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sach_delete](@id int)
as
begin
delete from SACH
where id=@id
end
GO
/****** Object:  StoredProcedure [dbo].[sach_insert]    Script Date: 4/18/2018 10:38:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sach_insert](@name nvarchar(50),@dongia real,@nxb int)
as
begin
insert into SACH values(@name,@dongia,@nxb)
end
GO
/****** Object:  StoredProcedure [dbo].[sach_selectid]    Script Date: 4/18/2018 10:38:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sach_selectid](@id int)
as
begin
select SACH.id,name,dongia,NXB.ten
from SACH inner join NXB on SACH.nxb=NXB.id
where SACH.id=@id
end
GO
/****** Object:  StoredProcedure [dbo].[sach_update]    Script Date: 4/18/2018 10:38:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sach_update](@name nvarchar(50),@dongia real,@nxb int,@id int)
as
begin
update SACH set name=@name,dongia=@dongia,nxb=@nxb
where id=@id
end
GO
/****** Object:  StoredProcedure [dbo].[tacgia_delete]    Script Date: 4/18/2018 10:38:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[tacgia_delete](@id int)
as
begin
delete from TACGIA
where id=@id
end;
GO
/****** Object:  StoredProcedure [dbo].[tacgia_insert]    Script Date: 4/18/2018 10:38:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[tacgia_insert](@hoten nvarchar(50),@infor text)
as
begin
insert into TACGIA values(@hoten,@infor)
end;
GO
/****** Object:  StoredProcedure [dbo].[tacgia_selectall]    Script Date: 4/18/2018 10:38:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[tacgia_selectall]
as
begin
select *from TACGIA
end;
GO
/****** Object:  StoredProcedure [dbo].[tacgia_selectid]    Script Date: 4/18/2018 10:38:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[tacgia_selectid](@id int)
as
begin
select * from TACGIA
where id=@id
end;
GO
/****** Object:  StoredProcedure [dbo].[tacgia_update]    Script Date: 4/18/2018 10:38:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[tacgia_update](@id int,@hoten nvarchar(50),@infor text)
as
begin
update TACGIA set hoten=@hoten,infor=@infor
where id=@id
end;
GO
/****** Object:  StoredProcedure [dbo].[tacgiasach]    Script Date: 4/18/2018 10:38:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[tacgiasach](@idsach int)
as
begin
select TACGIA.hoten 
from (select tacgia from [SACH-TACGIA] where sach=@idsach ) as SA inner join TACGIA on SA.tacgia=TACGIA.id
end
GO
/****** Object:  StoredProcedure [dbo].[theloai_delete]    Script Date: 4/18/2018 10:38:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[theloai_delete](@id int)
as
begin
delete from THELOAI 
where id=@id
end
GO
/****** Object:  StoredProcedure [dbo].[theloai_insert]    Script Date: 4/18/2018 10:38:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[theloai_insert](@ten nvarchar(50))
as
begin
insert into THELOAI values(@ten)
end
GO
/****** Object:  StoredProcedure [dbo].[theloai_selectall]    Script Date: 4/18/2018 10:38:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[theloai_selectall]
as
begin
select * from THELOAI
end
GO
/****** Object:  StoredProcedure [dbo].[theloai_selectid]    Script Date: 4/18/2018 10:38:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[theloai_selectid](@id int)
as
begin
select * from THELOAI
where id=@id
end
GO
/****** Object:  StoredProcedure [dbo].[theloai_update]    Script Date: 4/18/2018 10:38:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[theloai_update](@ten nvarchar(50),@id int)
as
begin 
update THELOAI set ten=@ten
where id=@id
end
GO
/****** Object:  StoredProcedure [dbo].[theloaisach]    Script Date: 4/18/2018 10:38:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[theloaisach](@idsach int)
as
begin 
select  THELOAI.ten
from (select theloai from [SACH-THELOAI] where sach=@idsach) as SA inner join THELOAI on theloai=id
end
GO
USE [master]
GO
ALTER DATABASE [CUAHANGSACH] SET  READ_WRITE 
GO
