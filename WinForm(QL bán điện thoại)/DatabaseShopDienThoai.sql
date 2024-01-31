create database QuanLyBanDienThoai
go

use QuanLyBanDienThoai
go

create table KhachHang
(
   MaKH varchar(10) primary key ,
   HoKH  nvarchar(20) not null  ,
   TenKH nvarchar(50) not null ,
   SDT Char(10),
   DiaChi nvarchar(50),
   Email varchar(30),
   TrangThai int -- 0:hoạt động || 1 ngừng hoạt động
)
go

create table NhanVien
( 
  MaNV varchar(10)primary key,
  HoNV nvarchar(20),
  TenNV nvarchar(50),
  ChucVu nvarchar(20),
  SDT Char(10),
  DiaChi nvarchar(50),
  Email varchar(30),
  TrangThai int
)
go
Create table NhaSanXuat
(
  MaNSX varchar(10) primary key,
  TenNhaSX nvarchar(50),
  XuatSu nvarchar(50),
  TrangThai int
)
go

create table NhaCungCap
(
  MaNCC varchar(10)primary key,
  TenNCC nvarchar(50),
  SDT Char(10),
  DiaChi nvarchar(50),
  Email varchar(30),
  TrangThai int
)

create table BaoHanh
(
   MaBH varchar(10) primary key,
   TenBH nvarchar(50),
   ThoiHan int,
   GhiChu nvarchar(100),
   TrangThai int
)
go

create table MauSac 
(
  MaMau VARCHAR(10) primary key,
  TenMau nvarchar(50),
  TrangThai int
)
go 

--create table LoaiDT
--(
--  MaLoaiDT varchar(10) primary key,
--  TenLoaiDT nvarchar(50) not null,
--  MaNSX varchar(10),
--  TrangThai int 
--  constraint FK_MaNSX_LoaiDT foreign key (MaNSX) references NhaSanXuat(MaNSX)
--)
--go

create table DienThoai
(
  MaDT varchar(10) primary key,
  TenDT nvarchar(50),
  MaNSX varchar(10),
  GiaNhap int,
  Giabanle int,
  SoLuong int,
  Hinh VARCHAR(200),
  TrangThai INT
  constraint FK_MaNSX_DT foreign key (MaNSX) references NhaSanXuat(MaNSX),
  
)
--delete from DienThoai
go
create table CTDienThoai
(
  MaCTDT VARCHAR(50) NOT NULL,
  MaDT VARCHAR(10)NOT NULL,
  MaBH VARCHAR(10) NOT NULL,
  MaMau varchar(10),
  DungLuongBoNho int,
  GiaBan int,
  SoLuong int,
  Hinh varchar(200)
  CONSTRAINT PK_CTDienThoai_CTDT primary key (MaDT, MaMau, MaBH),
  constraint  FK_MaDT_CTDT foreign key (MaDT) references DienThoai(MaDT),
  constraint  FK_MaMau_CTDT foreign key (MaMau) references MauSac(MaMau),
  constraint  FK_MaBH_CTDT foreign key (MaBH) references BaoHanh(MaBH)

)
go
--delete from CTDienThoai

create table HoaDonBan
(
   MaHDBan varchar(10) primary key,
   MaKH varchar(10),
   MaNV varCHAR(10),
   NgLapHD datetime,
   TrangThai int
   constraint FK_MaKH_HDBan foreign key(MaKH) references KhachHang(MaKH),
   constraint FK_MaNV_HDBan foreign key(MaNV) references NhanVien(MaNV),
)
go
create table CTHoaDonBan
(
  MaCTHoaDonBan varchar(10),
  MaHDBan varchar(10),
  MaDT VARCHAR(10),
  MaMau varchar(10),
  SoLuong int,
  DonGia int,
  ChietKhau float,
  MaVC varchar(20),
  DonViVanChuyen nvarchar(50),
  TrangThaiDonHang int,
  TongTien int
  constraint PK_CTHoaDonBan primary key(MaHDBan, MaDT,MaMau),
  constraint FK_MaHDBan_CTHDBan foreign key (MaHDBan) references HoaDonBan(MaHDBan),
  constraint FK_MaCTDT_CTHDBan foreign key (MaDT) references DienThoai(MaDT)
)
go
--delete from CTHoaDonBan


create table HoaDonNhap
(
   MaHDNhap varchar(10) primary key,
   MaNCC varchar(10),
   MaNV varCHAR(10),
   NgLapHD datetime,
   SoLuong int,
   DonGia int,
   ChietKhau float,
   TrangThai int
   constraint FK_MaNCC_HDNhap foreign key(MaNCC) references NhaCungCap(MaNCC),
   constraint  FK_MaNV_HDNhap foreign key (MaNV) references Nhanvien(MaNV)
)
go

CREATE TABLE CTHoaDonNhap
(
  MaCTHoaDonNhap VARCHAR(10),
  MaHDNhap VARCHAR(10),
  MaDT VARCHAR(10),
  MaNCC VARCHAR(10),
  SoLuong int,
  DonGia int,
  ChietKhau float,
  TongTien int
  constraint PK_CTHoaDonNhap primary key(MaHDNhap, MaDT,MaNCC),
  constraint FK_MaHDNhap_CTHDNhap foreign key (MaHDNhap) references HoaDonNhap(MaHDNhap),
  constraint  FK_MaDT_CTHDNhap foreign key (MaDT) references DienThoai(MaDT),
  constraint  FK_MaNCC_CTHDNhap foreign key (MaDT) references NhaCungCap(MaNCC)
)
go






-- Màu sắc
insert MauSac
values('M01',N'Đen',0)
insert MauSac
values('M02',N'Đỏ',0)
insert MauSac
values('M03',N'Xanh dương',0)
insert MauSac
values('M04',N'Trắng',0)
insert MauSac
values('M05',N'Tím',0)
insert MauSac
values('M06',N'Vàng',0)
insert MauSac
values('M07',N'Xanh lá',0)
insert MauSac
values('M08',N'Xám',0)
-- Bảo hành
insert BaoHanh
values('BH01',N'Bảo hành loại 1',24,null,0)
insert BaoHanh
values('BH02',N'Bảo hành loại 2',12,null,0)
insert BaoHanh
values('BH03',N'Bảo hành loại 3',6,null,0)

-- nhà sản xuất
INSERT NhaSanXuat
VALUES ('NSX01',N'Apple',N'Mỹ',0)
INSERT NhaSanXuat
VALUES ('NSX02',N'Nokia',N'Phần Lan',0)
INSERT NhaSanXuat
VALUES ('NSX03',N'SamSung',N'Hàn Quốc',0)
INSERT NhaSanXuat
VALUES ('NSX04',N'OPPO',N'Trung Quốc',0)
INSERT NhaSanXuat
VALUES ('NSX05',N'Realme',N'Trung Quốc',0)
-- ĐIỆN THOẠI
insert DienThoai
values ('DT01',N'Iphone 12','NSX01',10000000,14990000,32,'iphone-12-do-1-1-org.jpg',0)
insert DienThoai
values ('DT02',N'Iphone14 Pro Max','NSX01',23000000,26990000,40,'iphone-14-pro-max-purple.jpg',0)
insert DienThoai
values ('DT03',N'Samsung Galaxy A23 5G','NSX03',4000000,5490000,50,'samsung-galaxy-a23-1-1.jpg',0)
insert DienThoai
values ('DT04',N'Nokia G22','NSX02',2500000,3690000,50,'nokia-g22-xam-1-1.jpg',0)
insert DienThoai
values ('DT05',N'Realme C55','NSX05',4000000,5390000,60,'realme-c55-black-1.jpg',0)
insert DienThoai
values ('DT06',N'Oppo Reno8 T 5G','NSX04',9000000,10990000,30,'oppo-reno8-t-5g-den-1.jpg',0)



-- CT Điện thoại
 -- Iphone
insert into CTDienThoai
values('DT01-BH02-M02','DT01','BH02','M02',128,14990000,16,'iphone-12-do-1-1-org.jpg')
insert into CTDienThoai
values('DT01-BH02-M01','DT01','BH02','M01',2,14990000,16,'iphone-12-den-1-1-org.jpg')
insert into CTDienThoai
values('DT02-BH02-M05','DT01','BH02','M05',2,26990000,16,'iphone-14-pro-max-purple.jpg')
insert into CTDienThoai
values('DT02-BH02-M06','DT01','BH02','M06',128,26990000,16,'iphone-14-pro-max-vang.jpg')
 -- samsung
insert into CTDienThoai
values('DT03-BH02-M06','DT03','BH02','M01',128,5490000,23,'nokia-g22-xam-1-1.jpg')
insert into CTDienThoai
values('DT03-BH02-M03','DT03','BH02','M03',128,5490000,27,'nokia-g22-xanh-1-1.jpg')
 -- Nokia
insert into CTDienThoai
values('DT04-BH02-M08','DT04','BH02','M08',128,3690000,25,'samsung-galaxy-a23-1.jpg')
insert into CTDienThoai
values('DT04-BH02-M03','DT04','BH02','M03',128,3690000,25,'samsung-galaxy-a23-1.jpg')
  --Realme
insert into CTDienThoai
values('DT05-BH02-M01','DT05','BH02','M01',256,5390000,30,'realme-c55-black-1.jpg')
insert into CTDienThoai
values('DT05-BH02-M06','DT05','BH02','M06',256,5390000,30,'realme-c55-gold-1.jpg')
  -- oppo
insert into CTDienThoai
values('DT06-BH02-M01','DT06','BH02','M01',256,10990000,15,'oppo-reno8-t-5g-den-1.jpg')
insert into CTDienThoai
values('DT06-BH02-M06','DT06','BH02','M06',256,10990000,15,'oppo-reno8-t-vang-5g-1.jpg')

--Khách hàng
insert KhachHang
values('kh001',N'Tran',N'Van A','	',N'15 Tran Dinh Xu,Q1,TP HCM','a@gmail.com',0)
insert KhachHang
values('kh002',N'Tran',N'Van b','0908983712',N'16 Tran Dinh Xu,Q1,TP HCM','b@gmail.com',0)
insert KhachHang
values('kh003',N'Tran',N'Van c','0908983712',N'17 Tran Dinh Xu,Q1,TP HCM','c@gmail.com',0)
insert KhachHang
values('kh004',N'Nguyễn ',N'Quan Nam','0908983712',N'17 Trần Hưng Đạo,Phường 3,tỉnh Đồng Nai','Quangnam@gmail.com',0)

-- Nhân viên
insert NhanVien
values('NV01',N'Nguyễn',N'Văn Mạnh',N'Nhân viên bán hàng','0911111111',N'17, Đường Thẳng, Tháp Mười, Đồng Tháp','manh@gmail.com',0)
insert NhanVien
values('NV02',N'Trần',N'Văn Cường',N'Quản lý','0911111112',N'17, Nguyễn Cư Trinh, Q1, TP HCM','cuong@gmail.com',0)
insert NhanVien
values('NV03',N'Nguyễn',N'Thị Tuyết Mai',N'Nhân viên bán hàng','0911111113',N'105, Nguyễn Chí Thanh, Q5, TP HCM','tuyetmai@gmail.com',0)
insert NhanVien
values('NV04',N'Nguyễn',N'Thị Ánh Tuyết',N'Nhân viên bán hàng','0911111114',N'17, Phan Đình Phùng, An Thới, Đồng Nai','tuyet@gmail.com',0)
insert NhanVien
values('NV05',N'Huỳnh',N'Thị Tuyết Nhung',N'Nhân viên bán hàng','0911111115',N'195 ấp 1 Mỹ Tân Cái Bè Tiền Giang','nhung@gmail.com',0)
insert NhanVien
values('NV06',N'Lê',N'Văn Hán',N'Nhân viên bán hàng','0911111116',N'17, Cao Thắng, Q5, TP HCM','han@gmail.com',0)


-- Nhà Cung Cấp
insert NhaCungCap
values('NCC01',N'công ty TNHH Bao La','0283511906',N'38 Đinh Bô Lĩnh, P24, Q Bình Thạnh, Tp Hồ Chí Minh','baola@gmail.com',0)
insert NhaCungCap
values('NCC02',N'doanh nghiệp tư nhân An Khang','0283514906',N'261 Trần Hưng Đạo, Mỹ Xuyên, Long Xuyên, An Giang','ankhang@gmail.com',0)
insert NhaCungCap
values('NCC03',N'Công Ty Cổ Phần Thế Giới Số','0383514907',N'73-75-77-79 Nguyễn Đình Chiểu, P1, Bến Tre','tgs@gmail.com',0)
insert NhaCungCap
values('NCC04',N'Công Ty TNHH Viễn Thông Xuyên Á','0383414807',N'382 Minh Phụng, P. 9, Q. 11, Tp. Hồ Chí Minh','xuyena@gmail.com',0)

--Hóa đơn bán
insert into HoaDonBan
values('HDB01','kh002','NV01','01/02/2021',0)
insert into HoaDonBan
values('HDB02','kh003','NV01','01/03/2021',0)
insert into HoaDonBan
values('HDB03','kh001','NV02','05/02/2021',0)
insert into HoaDonBan
values('HDB04','kh002','NV01','5/6/2023 12:00:00 AM',0)
--ct hóa đơn bán
insert into CTHoaDonBan 
values('HDB01-DT01','HDB01','DT01','M01',3,1499000,0.01,'VC01',N'Shopee',1,44547030)
insert into CTHoaDonBan 
values('HDB02-DT01','HDB02' ,'DT01',1,5000000,0,'VC01',N'Shopee',N'đang giao',5000000)
--select a.MaMau, a.TenMau from MauSac a, CTDienThoai b  where MaDT = 'DT01' AND A.MaMau = B.MaMau


select * from DienThoai  where TenDT like N' S%'

select * from DienThoai where MaNSX = 'NSX03' and (Giabanle between 2000000 and 6000000)
insert CTHoaDonBan values('HDB06-DT01','HDB06','DT01',2,4500000,0.05,'vd05','shopee',8550000)

insert CTHoaDonBan values('HDB01-DT05','HDB01','DT05',2,563453,0.1,'vsdv','vsdvsdvsd',0,1014216)
select a.MaHDBan ,b.NgLapHD,SUM(a.TongTien)  from CTHoaDonBan a, HoaDonBan b where a.MaHDBan = b.MaHDBan
group by a.MaHDBan ,b.NgLapHD
having MONTH(NgLapHD) =5 and YEAR(NgLapHD) = 2023
select top 5 b.MaKH, c.HoKH, c.TenKH, sum(TongTien) as tongtienmua from CTHoaDonBan a, HoaDonBan b,KhachHang c  where a.MaHDBan = b.MaHDBan AND b.MaKH = c.MaKH
group by b.MaKH, c.HoKH, c.TenKH
order by tongtienmua desc
insert DienThoai values ('DT07',N'Iphone 14 Pro','NSX01',20000000,23000000,'Screenshot (1).png',0 )
update CTHoaDonBan set SoLuong = ,DonGia = ,ChietKhau = ,MaVC = '', DonViVanChuyen = N'',TrangThaiDonHang  = , TongTien =x
update CTDienThoai set SoLuong += where MaDT = '' and MaMau = ''

insert KhachHang values('kh005',N'Nguyễn ',N'Văn F','0989884587',N'Tiền Giang','A@gmail.com',0)
