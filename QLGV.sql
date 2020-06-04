create database QLGV
use QLGV

create table COSO
(
  MaCoSo nvarchar(20) not null primary key,
  TenCoSo nvarchar(150) not null,

)
create table DONVI
(
  MaDonVi nchar(10) not null primary key,
  TenDonVi nvarchar(150) not null, 
  MaCoso nvarchar(20) not null,
  FOREIGN KEY (MaCoso) 
  REFERENCES COSO(MaCoso),
)
create table GiaoVien
(
  MaGV nvarchar(10) not null primary key ,
  HoTen nvarchar(150) not null, 
  SoDT varchar(20) not null, 
  GhiChu nvarchar(150) null, 
  MaDonVi nchar(10) not null,
  FOREIGN KEY (MaDonVi) 
  REFERENCES DONVI(MaDonVi),
   )
   
  
  insert into COSO values ('CS01',N'PHƯỚC LONG ') -- nvarchar can co N truoc moi nhan du dau
  insert into COSO values ('CS02',N'PHƯỚC ĐỒNG')
  
 
 
  
insert into DONVI values ('DV01',N'Lê Qúy Đôn ',N'CS01') -- nhung cai duoi e sua tuong tu
insert into DONVI values ('DV02',N'Cao đẳng Nghề',N'CS02')
insert into DONVI values ('DV03',N'Cao đẳng Nghề',N'CS01')
insert into DONVI values ('DV04',N'Lê Qúy Đôn',N'CS02')

insert into GiaoVien values (N'GV01',N'ĐẶNG HỮU DUYÊN',7564353,N'Trưởng khoa','DV01')
insert into GiaoVien values (N'GV02',N'TẠ VĂN BẰNG',34363353,N'Chủ nhiệm','DV02')
insert into GiaoVien values (N'GV03',N'PHƯƠNG THẾ ANH',543345353,N'Hiệu trường','DV03')
insert into GiaoVien values (N'GV04',N'NGUYỄN TUẤN ĐẠT ',63535333,N'Bộ môn','DV04')