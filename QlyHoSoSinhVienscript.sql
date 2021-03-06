USE [master]
GO
/****** Object:  Database [QuanLyHoSoSinhVien]    Script Date: 6/5/2019 6:20:55 PM ******/
CREATE DATABASE [QuanLyHoSoSinhVien]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyHoSoSinhVien', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QuanLyHoSoSinhVien.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLyHoSoSinhVien_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QuanLyHoSoSinhVien_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLyHoSoSinhVien] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyHoSoSinhVien].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyHoSoSinhVien] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyHoSoSinhVien] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyHoSoSinhVien] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyHoSoSinhVien] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyHoSoSinhVien] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyHoSoSinhVien] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyHoSoSinhVien] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyHoSoSinhVien] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyHoSoSinhVien] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyHoSoSinhVien] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyHoSoSinhVien] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyHoSoSinhVien] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyHoSoSinhVien] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyHoSoSinhVien] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyHoSoSinhVien] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyHoSoSinhVien] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyHoSoSinhVien] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyHoSoSinhVien] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyHoSoSinhVien] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyHoSoSinhVien] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyHoSoSinhVien] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyHoSoSinhVien] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyHoSoSinhVien] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyHoSoSinhVien] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyHoSoSinhVien] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyHoSoSinhVien] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyHoSoSinhVien] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyHoSoSinhVien] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyHoSoSinhVien] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QuanLyHoSoSinhVien]
GO
/****** Object:  StoredProcedure [dbo].[new_TaiKhoan]    Script Date: 6/5/2019 6:20:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[new_TaiKhoan] (@tdn nvarchar(10),@mk nvarchar(30),@ngaylap date, @han date,@quyen int)
as
begin

if exists ( select  MaSV,MaGV
           from DSSinhVien,DSGiaoVien
		   where MaSV=@tdn or MaGV=@tdn
		  )
insert into TaiKhoan values(@tdn,@mk,@ngaylap,@han,@quyen)

end

GO
/****** Object:  StoredProcedure [dbo].[Sua_SinhVien_Diem]    Script Date: 6/5/2019 6:20:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--2.GiaoVienSuaDiem
CREATE proc [dbo].[Sua_SinhVien_Diem] (@masv nvarchar(10),@lophp nvarchar(50),@dcc float,@dtx float,@dt float)
as
begin
update ChiTietBangDiem
set DiemChuyenCan=@dcc,DiemThuongXuyen=@dtx,DiemThi=@dt
from ChiTietBangDiem
inner join DSBangDiem on ChiTietBangDiem.MaBangDiem=DSBangDiem.MaBangDiem 
inner join DSMonHoc on ChiTietBangDiem.MaMonHoc=DSMonHoc.MaMonHoc 
inner join DSLopHocPhan on DSMonHoc.MaMonHoc=DSLopHocPhan.MaMonHoc and DSLopHocPhan.MaLopHocPhan=@lophp
inner join SinhVien_LopHocPhan on DSBangDiem.MaSV=SinhVien_LopHocPhan.MaSV and SinhVien_LopHocPhan.MaLopHocPhan=DSLopHocPhan.MaLopHocPhan and SinhVien_LopHocPhan.MaSV=@masv

end

GO
/****** Object:  StoredProcedure [dbo].[Sua_SinhVien_HoSo]    Script Date: 6/5/2019 6:20:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Sua_SinhVien_HoSo] (@masv nvarchar(10),@ten nvarchar(50),@dob date, @sdt nvarchar(10),@gt nvarchar(10),@qq nvarchar(50),@mail nvarchar(255),@lop nvarchar(10))
as
begin

update DSSinhVien
set HoTen=@ten,NgaySinh=@dob,SDT=@sdt,GioiTinh=@gt,QueQuan=@qq,Email=@mail,MaLop=@lop
where MaSV=@masv

end

GO
/****** Object:  StoredProcedure [dbo].[sua_TaiKhoan]    Script Date: 6/5/2019 6:20:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sua_TaiKhoan] (@tdn nvarchar(10),@mk nvarchar(30),@ngaylap date, @han date,@quyen int)
as
begin

update TaiKhoan
set MatKhau=@mk,NgayLap=@ngaylap,NgayHetHan=@han,QuyenHan=@quyen
where TenDangNhap=@tdn
end

GO
/****** Object:  StoredProcedure [dbo].[tk_TaiKhoan]    Script Date: 6/5/2019 6:20:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[tk_TaiKhoan] (@search nvarchar(255))
as
begin
select TenDangNhap,MatKhau,NgayLap,NgayHetHan,QuyenHan
from TaiKhoan
where (TenDangNhap LIKE N'%' + @search +'%')
		OR (MatKhau LIKE N'%' + @search+ '%')
		OR (NgayLap LIKE N'%' + @search + '%')
		OR (NgayHetHan LIKE N'%' + @search + '%')
		OR (QuyenHan LIKE N'%' + @search + '%')
end

GO
/****** Object:  StoredProcedure [dbo].[xoa_TaiKhoan]    Script Date: 6/5/2019 6:20:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xoa_TaiKhoan] (@tdn nvarchar(10))
as
begin

update DSSinhVien
set TenDangNhap=null
where TenDangNhap=@tdn
update DSGiaoVien
set TenDangNhap=null
where TenDangNhap=null
delete TaiKhoan
where TenDangNhap=@tdn
end

GO
/****** Object:  StoredProcedure [dbo].[xuat_AllSinhVien]    Script Date: 6/5/2019 6:20:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xuat_AllSinhVien]
as
begin
select MaSV,HoTen,NgaySinh,GioiTinh,SDT,Email,QueQuan,tenlop,NienKhoa 
from DSSinhVien
inner join DSLop on MaLop=id
end

GO
/****** Object:  StoredProcedure [dbo].[xuat_AllSinhVien_DiemTB_CaKi]    Script Date: 6/5/2019 6:20:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xuat_AllSinhVien_DiemTB_CaKi] (@ki int)
as 
begin
select DSSinhVien.MaSV,AVG(tb)
from ( select MaSV,TenMonHoc tmh1,ChiTietBangDiem.MaMonHoc,avg((3*DiemThuongXuyen)/10+(DiemChuyenCan)/10+(6*DiemThi)/10) tb
       from ChiTietBangDiem
       inner join DSBangDiem on ChiTietBangDiem.MaBangDiem=DSBangDiem.MaBangDiem 	and HocKi=@ki		                          
	   inner join DSMonHoc on ChiTietBangDiem.MaMonHoc=DSMonHoc.MaMonHoc 
	   group by TenMonHoc,MaSV,ChiTietBangDiem.MaMonHoc
      ) as diemtb
inner join DSSinhVien on DSSinhVien.MaSV=diemtb.MaSV 
group by DSSinhVien.MaSV
end

GO
/****** Object:  StoredProcedure [dbo].[xuat_DSDiem_SinhVien_Ki]    Script Date: 6/5/2019 6:20:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[xuat_DSDiem_SinhVien_Ki](@masv nvarchar(10),@ki int)
as
begin
select tmh,dtx,dcc,dt,tb
from(
          select TenMonHoc tmh, DiemThuongXuyen dtx,DiemChuyenCan dcc,DiemThi dt
          from ChiTietBangDiem
          inner join DSBangDiem on ChiTietBangDiem.MaBangDiem=DSBangDiem.MaBangDiem  and MaSV=@masv and HocKi=@ki
          inner join DSMonHoc on ChiTietBangDiem.MaMonHoc=DSMonHoc.MaMonHoc
		 -- group by ChiTietBangDiem.MaBangDiem
		  ) as dsdiem
inner join (
             select TenMonHoc tmh1,avg((3*DiemThuongXuyen)/10+(DiemChuyenCan)/10+(6*DiemThi)/10) tb
             from ChiTietBangDiem
             inner join DSBangDiem on ChiTietBangDiem.MaBangDiem=DSBangDiem.MaBangDiem  and MaSV=@masv and HocKi=@ki
			 inner join DSMonHoc on ChiTietBangDiem.MaMonHoc=DSMonHoc.MaMonHoc
			 group by TenMonHoc
            ) as diemtb
on dsdiem.tmh=diemtb.tmh1
end

GO
/****** Object:  StoredProcedure [dbo].[xuat_GiaoVien_DSHocPhan_TaiKhoan]    Script Date: 6/5/2019 6:20:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- xuat_GiaoVien_TaiKhoan 'GV01'
--1.6.1 Danh Sách lớp học phần giáo viên giảng dạy theo tên đăng nhập
create proc [dbo].[xuat_GiaoVien_DSHocPhan_TaiKhoan] (@taikhoan nvarchar(50))
as
begin

select MaLopHocPhan,TenMonHoc
from DSLopHocPhan
inner join DSMonHoc on DSLopHocPhan.MaMonHoc=DSMonHoc.MaMonHoc
inner join DSGiaoVien on DSLopHocPhan.GiaoVienGiangDay=DSGiaoVien.MaGV
inner join TaiKhoan on DSGiaoVien.TenDangNhap=TaiKhoan.TenDangNhap and TaiKhoan.TenDangNhap=@taikhoan
--inner join TaiKhoan on DSGiaoVien.TenDangNhap=TaiKhoan.TenDangNhap and DSGiaoVien.TenDangNhap=@taikhoan

end

GO
/****** Object:  StoredProcedure [dbo].[xuat_GiaoVien_TaiKhoan]    Script Date: 6/5/2019 6:20:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xuat_GiaoVien_TaiKhoan] (@taikhoan nvarchar(50))
as
begin

select HoTen
from DSGiaoVien
inner join TaiKhoan on DSGiaoVien.TenDangNhap=TaiKhoan.TenDangNhap and DSGiaoVien.TenDangNhap=@taikhoan

end

GO
/****** Object:  StoredProcedure [dbo].[xuat_Lop]    Script Date: 6/5/2019 6:20:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[xuat_Lop](@ma nvarchar(10))
as
begin
select TenKhoa,tenlop,HoTen,NienKhoa,count(sv.MaSV) slsv
from DSLop
inner join DSKhoa on DSLop.ThuocKhoa=DSKhoa.MaKhoa
inner join DSGiaoVien on DSLop.MaGvChuNhiem=DSGiaoVien.MaGV
inner join (select MaSV,MaLop
            from DSSinhVien) as sv on DSLop.id=sv.MaLop    
where id=@ma
group by TenKhoa,tenlop,HoTen,NienKhoa
end

GO
/****** Object:  StoredProcedure [dbo].[xuat_LopHP]    Script Date: 6/5/2019 6:20:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--xuat_LopHP_GiaoVien 'GV01'

--1.9 Xuat thông tin lớp học phần

CREATE proc [dbo].[xuat_LopHP](@mahp nvarchar(10))
as
begin
select TenMonHoc,HocKi,SoLuongSV, count(SinhVien_LopHocPhan.MaSV) slsv  ,HoTen
from DSLopHocPhan
inner join DSMonHoc on DSLopHocPhan.MaMonHoc=DSMonHoc.MaMonHoc and DSLopHocPhan.MaLopHocPhan=@mahp
inner join SinhVien_LopHocPhan on DSLopHocPhan.MaLopHocPhan=SinhVien_LopHocPhan.MaLopHocPhan
inner join DSGiaoVien on DSLopHocPhan.GiaoVienGiangDay=DSGiaoVien.MaGV
group by DSLopHocPhan.MaLopHocPhan,TenMonHoc,HocKi,SoLuongSV,HoTen
          

end

GO
/****** Object:  StoredProcedure [dbo].[xuat_LopHP_GiaoVien]    Script Date: 6/5/2019 6:20:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xuat_LopHP_GiaoVien](@magiaovien nvarchar(10))
as
begin
select DSLopHocPhan.MaLopHocPhan,TenMonHoc,HocKi,SoLuongSV, count(SinhVien_LopHocPhan.MaSV) slsv  
from DSLopHocPhan
inner join DSMonHoc on DSLopHocPhan.MaMonHoc=DSMonHoc.MaMonHoc and DSLopHocPhan.GiaoVienGiangDay=@magiaovien
inner join SinhVien_LopHocPhan on DSLopHocPhan.MaLopHocPhan=SinhVien_LopHocPhan.MaLopHocPhan
group by DSLopHocPhan.MaLopHocPhan,TenMonHoc,HocKi,SoLuongSV
          

end

GO
/****** Object:  StoredProcedure [dbo].[xuat_SinhVien_Diem_CaKi_LopHocPhan]    Script Date: 6/5/2019 6:20:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xuat_SinhVien_Diem_CaKi_LopHocPhan](@masv nvarchar(10),@lop nvarchar(10),@ki int)
as
begin
select DSSinhVien.MaSV,DSSinhVien.HoTen ,dsdiem.dtx,dsdiem.dcc,dsdiem.dt,diemtb.tb
from(
          select MaSV,MaMonHoc mmh, DiemThuongXuyen dtx,DiemChuyenCan dcc,DiemThi dt
          from ChiTietBangDiem
          inner join DSBangDiem on ChiTietBangDiem.MaBangDiem=DSBangDiem.MaBangDiem 
      
		 -- group by ChiTietBangDiem.MaBangDiem
		  ) as dsdiem
inner join (
             select MaSV,MaMonHoc mmh1,avg((3*DiemThuongXuyen)/10+(DiemChuyenCan)/10+(6*DiemThi)/10) tb
             from ChiTietBangDiem
             inner join DSBangDiem on ChiTietBangDiem.MaBangDiem=DSBangDiem.MaBangDiem 
			
			 group by MaMonHoc,MaSV
            ) as diemtb on dsdiem.mmh=diemtb.mmh1 and dsdiem.MaSV=diemtb.MaSV
inner join DSSinhVien on DSSinhVien.MaSV=diemtb.MaSV
inner join SinhVien_LopHocPhan on DSSinhVien.MaSV=SinhVien_LopHocPhan.MaSV and SinhVien_LopHocPhan.MaSV=@masv
inner join DSLopHocPhan on SinhVien_LopHocPhan.MaLopHocPhan=DSLopHocPhan.MaLopHocPhan 
           and DSLopHocPhan.MaMonHoc=diemtb.mmh1 and DSLopHocPhan.MaLopHocPhan=@lop 
group by DSSinhVien.MaSV,DSSinhVien.HoTen,dsdiem.dtx,dsdiem.dcc,dsdiem.dt,diemtb.tb
end

GO
/****** Object:  StoredProcedure [dbo].[xuat_SinhVien_Diem_HocPhan]    Script Date: 6/5/2019 6:20:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xuat_SinhVien_Diem_HocPhan] (@masv nvarchar(10),@mahocphan nvarchar(10))
as
begin
select DiemThuongXuyen,DiemChuyenCan,DiemThi
from ChiTietBangDiem
inner join DSBangDiem on ChiTietBangDiem.MaBangDiem=DSBangDiem.MaBangDiem and MaSV=@masv and MaMonHoc=@mahocphan
end

GO
/****** Object:  StoredProcedure [dbo].[xuat_SinhVien_Diem_Ki]    Script Date: 6/5/2019 6:20:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xuat_SinhVien_Diem_Ki] (@masv nvarchar(10),@ki int)
as
begin
select TenMonHoc,DiemThuongXuyen,DiemChuyenCan,DiemThi
from ChiTietBangDiem
inner join DSBangDiem on ChiTietBangDiem.MaBangDiem=DSBangDiem.MaBangDiem and MaSV=@masv and HocKi=@ki
inner join DSMonHoc on ChiTietBangDiem.MaMonHoc=DSMonHoc.MaMonHoc
end
GO
/****** Object:  StoredProcedure [dbo].[xuat_SinhVien_DiemTB_CaKi]    Script Date: 6/5/2019 6:20:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--xuat_DSDiem_SinhVien_Ki'16150201',2

--1.4.4 điểm trung bình cả kì của của 1 sinh viên LẤY

CREATE proc [dbo].[xuat_SinhVien_DiemTB_CaKi](@masv nvarchar(10),@ki int)
as
begin
select avg(tb) tb
from ( select TenMonHoc tmh1,avg((3*DiemThuongXuyen)/10+(DiemChuyenCan)/10+(6*DiemThi)/10) tb
             from ChiTietBangDiem
             inner join DSBangDiem on ChiTietBangDiem.MaBangDiem=DSBangDiem.MaBangDiem  and MaSV=@masv and HocKi=@ki
			 inner join DSMonHoc on ChiTietBangDiem.MaMonHoc=DSMonHoc.MaMonHoc
			 group by TenMonHoc) as diemtb
end

GO
/****** Object:  StoredProcedure [dbo].[xuat_SinhVien_DiemTB_CaKi_Lop]    Script Date: 6/5/2019 6:20:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- xuat_AllSinhVien_DiemTB_CaKi 2

--1.4.6diem trung bình của 1 lớp trong kì Lấy
CREATE proc [dbo].[xuat_SinhVien_DiemTB_CaKi_Lop](@lop nvarchar(10),@ki int)
as
begin

select DSSinhVien.MaSV,DSSinhVien.HoTen,DSSinhVien.NgaySinh,AVG(tb)
from ( select MaSV,TenMonHoc tmh1,ChiTietBangDiem.MaMonHoc,AVG((3*DiemThuongXuyen)/10+(DiemChuyenCan)/10+(6*DiemThi)/10) tb
       from ChiTietBangDiem
       inner join DSBangDiem on ChiTietBangDiem.MaBangDiem=DSBangDiem.MaBangDiem 	and HocKi=@ki		                          
	   inner join DSMonHoc on ChiTietBangDiem.MaMonHoc=DSMonHoc.MaMonHoc 
	   group by TenMonHoc,MaSV,ChiTietBangDiem.MaMonHoc
      ) as diemtb
inner join DSSinhVien on DSSinhVien.MaSV=diemtb.MaSV  and DSSinhVien.MaLop=@lop
group by DSSinhVien.MaSV,DSSinhVien.HoTen,DSSinhVien.NgaySinh  

end

GO
/****** Object:  StoredProcedure [dbo].[xuat_SinhVien_DiemTB_CaKi_LopHocPhan]    Script Date: 6/5/2019 6:20:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xuat_SinhVien_DiemTB_CaKi_LopHocPhan](@lop nvarchar(10),@ki int)
as
begin
select DSSinhVien.MaSV,DSSinhVien.HoTen ,dsdiem.dtx,dsdiem.dcc,dsdiem.dt,diemtb.tb
from(
          select MaSV,MaMonHoc mmh, DiemThuongXuyen dtx,DiemChuyenCan dcc,DiemThi dt
          from ChiTietBangDiem
          inner join DSBangDiem on ChiTietBangDiem.MaBangDiem=DSBangDiem.MaBangDiem 
      
		 -- group by ChiTietBangDiem.MaBangDiem
		  ) as dsdiem
inner join (
             select MaSV,MaMonHoc mmh1,avg((3*DiemThuongXuyen)/10+(DiemChuyenCan)/10+(6*DiemThi)/10) tb
             from ChiTietBangDiem
             inner join DSBangDiem on ChiTietBangDiem.MaBangDiem=DSBangDiem.MaBangDiem 
			
			 group by MaMonHoc,MaSV
            ) as diemtb on dsdiem.mmh=diemtb.mmh1 and dsdiem.MaSV=diemtb.MaSV
inner join DSSinhVien on DSSinhVien.MaSV=diemtb.MaSV
inner join SinhVien_LopHocPhan on DSSinhVien.MaSV=SinhVien_LopHocPhan.MaSV
inner join DSLopHocPhan on SinhVien_LopHocPhan.MaLopHocPhan=DSLopHocPhan.MaLopHocPhan 
           and DSLopHocPhan.MaMonHoc=diemtb.mmh1 and DSLopHocPhan.MaLopHocPhan=@lop 
group by DSSinhVien.MaSV,DSSinhVien.HoTen,dsdiem.dtx,dsdiem.dcc,dsdiem.dt,diemtb.tb
end

GO
/****** Object:  StoredProcedure [dbo].[xuat_SinhVien_DiemTB_HocPhan]    Script Date: 6/5/2019 6:20:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xuat_SinhVien_DiemTB_HocPhan] (@masv nvarchar(10),@mahocphan nvarchar(10))
as
begin
select AVG((3*DiemThuongXuyen)/10+(DiemChuyenCan)/10+(6*DiemThi)/10)
from ChiTietBangDiem
inner join DSBangDiem on ChiTietBangDiem.MaBangDiem=DSBangDiem.MaBangDiem and MaSV=@masv and MaMonHoc=@mahocphan
end

GO
/****** Object:  StoredProcedure [dbo].[xuat_SinhVien_DiemTB_TaiKhoan]    Script Date: 6/5/2019 6:20:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[xuat_SinhVien_DiemTB_TaiKhoan](@taikhoan nvarchar(50))
as
begin
select hk ,avg(tb) tb
from ( select TenMonHoc tmh1,HocKi hk,avg((3*DiemThuongXuyen)/10+(DiemChuyenCan)/10+(6*DiemThi)/10) tb
             from ChiTietBangDiem
             inner join DSBangDiem on ChiTietBangDiem.MaBangDiem=DSBangDiem.MaBangDiem  
			 inner join DSMonHoc on ChiTietBangDiem.MaMonHoc=DSMonHoc.MaMonHoc
			 inner join DSSinhVien on DSBangDiem.MaSV=DSSinhVien.MaSV and DSSinhVien.TenDangNhap=@taikhoan
			 group by TenMonHoc,HocKi) as diemtb
group by hk
end 

GO
/****** Object:  StoredProcedure [dbo].[xuat_SinhVien_DSDiem_ki_TaiKhoan]    Script Date: 6/5/2019 6:20:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--1.5.1 xuất bảng điểm sinh viên qua tài khoản
CREATE proc [dbo].[xuat_SinhVien_DSDiem_ki_TaiKhoan](@taikhoan nvarchar(50),@ki int)
as
begin
select tmh,dtx,dcc,dt,tb
from(
          select TenMonHoc tmh, DiemThuongXuyen dtx,DiemChuyenCan dcc,DiemThi dt
          from ChiTietBangDiem
          inner join DSBangDiem on ChiTietBangDiem.MaBangDiem=DSBangDiem.MaBangDiem  and HocKi=@ki
          inner join DSMonHoc on ChiTietBangDiem.MaMonHoc=DSMonHoc.MaMonHoc
		  inner join DSSinhVien on DSBangDiem.MaSV=DSSinhVien.MaSV and DSSinhVien.TenDangNhap=@taikhoan
		 -- group by ChiTietBangDiem.MaBangDiem
		  ) as dsdiem
inner join (
             select TenMonHoc tmh1,avg((3*DiemThuongXuyen)/10+(DiemChuyenCan)/10+(6*DiemThi)/10) tb
             from ChiTietBangDiem
             inner join DSBangDiem on ChiTietBangDiem.MaBangDiem=DSBangDiem.MaBangDiem and HocKi=@ki
			 inner join DSMonHoc on ChiTietBangDiem.MaMonHoc=DSMonHoc.MaMonHoc
			 inner join DSSinhVien on DSBangDiem.MaSV=DSSinhVien.MaSV and DSSinhVien.TenDangNhap=@taikhoan
			 group by TenMonHoc
            ) as diemtb
on dsdiem.tmh=diemtb.tmh1

end

GO
/****** Object:  StoredProcedure [dbo].[xuat_SinhVien_Lop]    Script Date: 6/5/2019 6:20:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xuat_SinhVien_Lop] (@lophocphan nvarchar(10))
as
begin
select  DSSinhVien.MaSV,HoTen,NgaySinh,GioiTinh,SDT,Email,QueQuan 
from  DSSinhVien
inner join DSLop on MaLop=id and MaLop=@lophocphan
end

GO
/****** Object:  StoredProcedure [dbo].[xuat_SinhVien_LopHocPhan]    Script Date: 6/5/2019 6:20:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xuat_SinhVien_LopHocPhan] (@lophocphan nvarchar(10))
as
begin
select  DSSinhVien.MaSV,HoTen,NgaySinh,GioiTinh,SDT,Email,QueQuan,tenlop,NienKhoa 
from  DSSinhVien
inner join DSLop on MaLop=id
inner join SinhVien_LopHocPhan on DSSinhVien.MaSV= SinhVien_LopHocPhan.MaSV and MaLopHocPhan=@lophocphan
end

GO
/****** Object:  StoredProcedure [dbo].[xuat_SinhVien_LopHocPhan_GiaoVien]    Script Date: 6/5/2019 6:20:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xuat_SinhVien_LopHocPhan_GiaoVien] (@GiaoVien nvarchar(10))
as
begin
select  DSSinhVien.MaSV,HoTen,NgaySinh,GioiTinh,SDT,Email,QueQuan,tenlop,NienKhoa 
from  DSSinhVien
inner join DSLop on MaLop=id
inner join SinhVien_LopHocPhan on DSSinhVien.MaSV= SinhVien_LopHocPhan.MaSV
inner join DSLopHocPhan on SinhVien_LopHocPhan.MaLopHocPhan=DSLopHocPhan.MaLopHocPhan and GiaoVienGiangDay=@GiaoVien
end

GO
/****** Object:  StoredProcedure [dbo].[xuat_SinhVien_LopHocPhan_GiaoVien2]    Script Date: 6/5/2019 6:20:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xuat_SinhVien_LopHocPhan_GiaoVien2] (@GiaoVien nvarchar(10),@lophocphan nvarchar(10))
as
begin
select  DSSinhVien.MaSV,HoTen,NgaySinh,GioiTinh,SDT,Email,QueQuan,tenlop,NienKhoa 
from  DSSinhVien
inner join DSLop on MaLop=id
inner join SinhVien_LopHocPhan on DSSinhVien.MaSV= SinhVien_LopHocPhan.MaSV and SinhVien_LopHocPhan.MaLopHocPhan=@lophocphan
inner join DSLopHocPhan on SinhVien_LopHocPhan.MaLopHocPhan=DSLopHocPhan.MaLopHocPhan and GiaoVienGiangDay=@GiaoVien
end

GO
/****** Object:  StoredProcedure [dbo].[xuat_SinhVien_TaiKhoan]    Script Date: 6/5/2019 6:20:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- xuat_SinhVien_DiemTB_CaKi_LopHocPhan'HP01',2

--1.5 xuất ra sinh viên dựa theo tài khoản

CREATE proc [dbo].[xuat_SinhVien_TaiKhoan] (@taikhoan nvarchar(50))
as
begin
select MaSV,HoTen,NgaySinh,SDT,GioiTinh,QueQuan,Email,tenlop,MaLop
from DSSinhVien
inner join TaiKhoan on DSSinhVien.TenDangNhap=TaiKhoan.TenDangNhap and TaiKhoan.TenDangNhap=@taikhoan
inner join DSLop on DSSinhVien.MaLop=DSLop.id
end

GO
/****** Object:  StoredProcedure [dbo].[xuat_SinhVien_TinChi]    Script Date: 6/5/2019 6:20:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--xuat_GiaoVien_DSHocPhan_TaiKhoan 'GV02'

--1.7đưa ra tổng tín chỉ đăng kí 
CREATE proc [dbo].[xuat_SinhVien_TinChi] (@masv nvarchar(10))
as
begin
select sum(tc2) tctl
from(select TenMonHoc tmh, DiemThuongXuyen dtx,DiemChuyenCan dcc,DiemThi dt
          from ChiTietBangDiem
          inner join DSBangDiem on ChiTietBangDiem.MaBangDiem=DSBangDiem.MaBangDiem  and MaSV=@masv
          inner join DSMonHoc on ChiTietBangDiem.MaMonHoc=DSMonHoc.MaMonHoc
		 -- group by ChiTietBangDiem.MaBangDiem
		  ) as dsdiem
inner join (
             select TenMonHoc tmh1,avg((3*DiemThuongXuyen)/10+(DiemChuyenCan)/10+(6*DiemThi)/10) tb,SoTinChi tc2
             from ChiTietBangDiem
             inner join DSBangDiem on ChiTietBangDiem.MaBangDiem=DSBangDiem.MaBangDiem  and MaSV=@masv 
			 inner join DSMonHoc on ChiTietBangDiem.MaMonHoc=DSMonHoc.MaMonHoc
			 group by TenMonHoc,SoTinChi
            ) as diemtb on dsdiem.tmh=diemtb.tmh1

end

GO
/****** Object:  StoredProcedure [dbo].[xuat_SinhVien_TinChiTL]    Script Date: 6/5/2019 6:20:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--xuat_SinhVien_TinChi '16150216'
--xuat_SinhVien_TinChiTL'16150229'
CREATE proc [dbo].[xuat_SinhVien_TinChiTL] (@masv nvarchar(10))
as
begin
select  sum(tc2) tctl
from(select TenMonHoc tmh, DiemThuongXuyen dtx,DiemChuyenCan dcc,DiemThi dt
          from ChiTietBangDiem
          inner join DSBangDiem on ChiTietBangDiem.MaBangDiem=DSBangDiem.MaBangDiem  and MaSV=@masv
          inner join DSMonHoc on ChiTietBangDiem.MaMonHoc=DSMonHoc.MaMonHoc
		 -- group by ChiTietBangDiem.MaBangDiem
		  ) as dsdiem
inner join (
             select TenMonHoc tmh1,avg((3*DiemThuongXuyen)/10+(DiemChuyenCan)/10+(6*DiemThi)/10) tb,SoTinChi tc2
             from ChiTietBangDiem
             inner join DSBangDiem on ChiTietBangDiem.MaBangDiem=DSBangDiem.MaBangDiem  and MaSV=@masv 
			 inner join DSMonHoc on ChiTietBangDiem.MaMonHoc=DSMonHoc.MaMonHoc
			 group by TenMonHoc,SoTinChi
			 having avg((3*DiemThuongXuyen)/10+(DiemChuyenCan)/10+(6*DiemThi)/10) >4
            ) as diemtb on dsdiem.tmh=diemtb.tmh1

end

GO
/****** Object:  StoredProcedure [dbo].[xuat_TaiKhoan]    Script Date: 6/5/2019 6:20:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xuat_TaiKhoan]
as
begin
select TenDangNhap,MatKhau,NgayLap,NgayHetHan,QuyenHan
from TaiKhoan
end

GO
/****** Object:  StoredProcedure [dbo].[xuat_TenSinhVien_TaiKhoan]    Script Date: 6/5/2019 6:20:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xuat_TenSinhVien_TaiKhoan] (@taikhoan nvarchar(50))
as
begin
select HoTen
from DSSinhVien
inner join TaiKhoan on DSSinhVien.TenDangNhap=TaiKhoan.TenDangNhap and TaiKhoan.TenDangNhap=@taikhoan
end

GO
/****** Object:  Table [dbo].[ChiTietBangDiem]    Script Date: 6/5/2019 6:20:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietBangDiem](
	[MaBangDiem] [nvarchar](10) NOT NULL,
	[MaMonHoc] [nvarchar](10) NOT NULL,
	[DiemChuyenCan] [float] NULL,
	[DiemThuongXuyen] [float] NULL,
	[DiemThi] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBangDiem] ASC,
	[MaMonHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DSBangDiem]    Script Date: 6/5/2019 6:20:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DSBangDiem](
	[MaBangDiem] [nvarchar](10) NOT NULL,
	[MaSV] [nvarchar](10) NULL,
	[HocKi] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBangDiem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DSGiaoVien]    Script Date: 6/5/2019 6:20:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DSGiaoVien](
	[MaGV] [nvarchar](10) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[SDT] [nvarchar](10) NULL,
	[QueQuan] [nvarchar](30) NULL,
	[Email] [nvarchar](255) NULL,
	[MaKhoa] [nvarchar](10) NULL,
	[QuanHam] [nvarchar](50) NULL,
	[TenDangNhap] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DSKhoa]    Script Date: 6/5/2019 6:20:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DSKhoa](
	[MaKhoa] [nvarchar](10) NOT NULL,
	[TenKhoa] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DSLop]    Script Date: 6/5/2019 6:20:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DSLop](
	[id] [nvarchar](10) NOT NULL,
	[ThuocKhoa] [nvarchar](10) NULL,
	[NienKhoa] [int] NULL,
	[tenlop] [nvarchar](50) NULL,
	[MaGvChuNhiem] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DSLopHocPhan]    Script Date: 6/5/2019 6:20:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DSLopHocPhan](
	[MaLopHocPhan] [nvarchar](10) NOT NULL,
	[MaMonHoc] [nvarchar](10) NULL,
	[SoLuongSV] [int] NULL,
	[HocKi] [int] NULL,
	[GiaoVienGiangDay] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLopHocPhan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DSMonHoc]    Script Date: 6/5/2019 6:20:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DSMonHoc](
	[MaMonHoc] [nvarchar](10) NOT NULL,
	[TenMonHoc] [nvarchar](50) NULL,
	[SoTinChi] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMonHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DSSinhVien]    Script Date: 6/5/2019 6:20:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DSSinhVien](
	[MaSV] [nvarchar](10) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[SDT] [nvarchar](10) NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[QueQuan] [nvarchar](30) NULL,
	[Email] [nvarchar](255) NULL,
	[MaLop] [nvarchar](10) NULL,
	[TenDangNhap] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SinhVien_LopHocPhan]    Script Date: 6/5/2019 6:20:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien_LopHocPhan](
	[MaLopHocPhan] [nvarchar](10) NOT NULL,
	[MaSV] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLopHocPhan] ASC,
	[MaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 6/5/2019 6:20:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TenDangNhap] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](50) NULL,
	[NgayLap] [date] NULL,
	[NgayHetHan] [date] NULL,
	[QuyenHan] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[ChiTietBangDiem]  WITH CHECK ADD FOREIGN KEY([MaBangDiem])
REFERENCES [dbo].[DSBangDiem] ([MaBangDiem])
GO
ALTER TABLE [dbo].[ChiTietBangDiem]  WITH CHECK ADD FOREIGN KEY([MaMonHoc])
REFERENCES [dbo].[DSMonHoc] ([MaMonHoc])
GO
ALTER TABLE [dbo].[DSBangDiem]  WITH CHECK ADD FOREIGN KEY([MaSV])
REFERENCES [dbo].[DSSinhVien] ([MaSV])
GO
ALTER TABLE [dbo].[DSGiaoVien]  WITH CHECK ADD FOREIGN KEY([MaKhoa])
REFERENCES [dbo].[DSKhoa] ([MaKhoa])
GO
ALTER TABLE [dbo].[DSGiaoVien]  WITH CHECK ADD FOREIGN KEY([TenDangNhap])
REFERENCES [dbo].[TaiKhoan] ([TenDangNhap])
GO
ALTER TABLE [dbo].[DSLop]  WITH CHECK ADD FOREIGN KEY([MaGvChuNhiem])
REFERENCES [dbo].[DSGiaoVien] ([MaGV])
GO
ALTER TABLE [dbo].[DSLop]  WITH CHECK ADD FOREIGN KEY([ThuocKhoa])
REFERENCES [dbo].[DSKhoa] ([MaKhoa])
GO
ALTER TABLE [dbo].[DSLopHocPhan]  WITH CHECK ADD FOREIGN KEY([GiaoVienGiangDay])
REFERENCES [dbo].[DSGiaoVien] ([MaGV])
GO
ALTER TABLE [dbo].[DSLopHocPhan]  WITH CHECK ADD FOREIGN KEY([MaMonHoc])
REFERENCES [dbo].[DSMonHoc] ([MaMonHoc])
GO
ALTER TABLE [dbo].[DSSinhVien]  WITH CHECK ADD FOREIGN KEY([MaLop])
REFERENCES [dbo].[DSLop] ([id])
GO
ALTER TABLE [dbo].[DSSinhVien]  WITH CHECK ADD FOREIGN KEY([TenDangNhap])
REFERENCES [dbo].[TaiKhoan] ([TenDangNhap])
GO
ALTER TABLE [dbo].[SinhVien_LopHocPhan]  WITH CHECK ADD FOREIGN KEY([MaLopHocPhan])
REFERENCES [dbo].[DSLopHocPhan] ([MaLopHocPhan])
GO
ALTER TABLE [dbo].[SinhVien_LopHocPhan]  WITH CHECK ADD FOREIGN KEY([MaSV])
REFERENCES [dbo].[DSSinhVien] ([MaSV])
GO
ALTER TABLE [dbo].[DSBangDiem]  WITH CHECK ADD CHECK  (([HocKi]=(8) OR [HocKi]=(7) OR [HocKi]=(6) OR [HocKi]=(5) OR [HocKi]=(4) OR [HocKi]=(3) OR [HocKi]=(2) OR [HocKi]=(1)))
GO
ALTER TABLE [dbo].[DSLopHocPhan]  WITH CHECK ADD CHECK  (([HocKi]=(8) OR [HocKi]=(7) OR [HocKi]=(6) OR [HocKi]=(5) OR [HocKi]=(4) OR [HocKi]=(3) OR [HocKi]=(2) OR [HocKi]=(1)))
GO
ALTER TABLE [dbo].[DSSinhVien]  WITH CHECK ADD CHECK  (([GioiTinh]=N'Nữ' OR [GioiTinh]=N'Nam'))
GO
USE [master]
GO
ALTER DATABASE [QuanLyHoSoSinhVien] SET  READ_WRITE 
GO
