CREATE TABLE CoSo (
   	MaCoSo varchar(50) NOT NULL,
	TenCoSo nvarchar(255) NULL
    CONSTRAINT PK_CoSo PRIMARY KEY (MaCoSo)
)

CREATE TABLE DonVi (
   MaDonVi varchar(50) NOT NULL,
	TenDonVi nvarchar(255) NULL,
	MaCoSo varchar(50) NULL
    CONSTRAINT PK_DonVi PRIMARY KEY (MaDonVi)
)

CREATE TABLE GiaoVien (
    MaGV varchar(50) NOT NULL,
	HoTen nvarchar(255) NULL,
	SoDT varchar(20) NULL,
	MaDonVi varchar(50) NULL,
	GhiChu nvarchar(255) NULL,
    CONSTRAINT PK_GiaoVien PRIMARY KEY (MaGV)
)

INSERT INTO CoSo (MaCoSo, TenCoSo) VALUES (N'CS001', N'Cơ sở 1')
INSERT INTO CoSo (MaCoSo, TenCoSo) VALUES (N'CS002', N'Cơ sở 2')
INSERT INTO DonVi (MaDonVi, TenDonVi, MaCoSo) VALUES (N'DV001', N'Đơn vị 1 - Cơ sở 1', N'CS001')
INSERT INTO DonVi (MaDonVi, TenDonVi, MaCoSo) VALUES (N'DV002', N'Đơn vị 2 - Cơ sở 1', N'CS001')
INSERT INTO DonVi (MaDonVi, TenDonVi, MaCoSo) VALUES (N'DV003', N'Đơn vị 1 - Cơ sở 2', N'CS002')
INSERT INTO DonVi (MaDonVi, TenDonVi, MaCoSo) VALUES (N'DV004', N'Đơn vị 2 - Cơ sở 2', N'CS002')
INSERT INTO GiaoVien (MaGV, HoTen, SoDT, MaDonVi, GhiChu) VALUES (N'GV001', N'Nguyễn Văn A', N'09876543215', N'DV001', NULL)
INSERT INTO GiaoVien (MaGV, HoTen, SoDT, MaDonVi, GhiChu) VALUES (N'GV002', N'Nguyễn Thị B', N'09284284824', N'DV001', NULL)
INSERT INTO GiaoVien (MaGV, HoTen, SoDT, MaDonVi, GhiChu) VALUES (N'GV003', N'Nguyễn Văn C', N'09234848224', N'DV002', NULL)
INSERT INTO GiaoVien (MaGV, HoTen, SoDT, MaDonVi, GhiChu) VALUES (N'GV004', N'Nguyễn Thị D', N'09734737433', N'DV002', NULL)
INSERT INTO GiaoVien (MaGV, HoTen, SoDT, MaDonVi, GhiChu) VALUES (N'GV005', N'Nguyễn Văn E', N'09284284242', N'DV003', NULL)
INSERT INTO GiaoVien (MaGV, HoTen, SoDT, MaDonVi, GhiChu) VALUES (N'GV006', N'Nguyễn Văn F', N'09284284242', N'DV003', NULL)
INSERT INTO GiaoVien (MaGV, HoTen, SoDT, MaDonVi, GhiChu) VALUES (N'GV007', N'Nguyễn Văn G', N'09384838434', N'DV004', NULL)
INSERT INTO GiaoVien (MaGV, HoTen, SoDT, MaDonVi, GhiChu) VALUES (N'GV008', N'Nguyễn Thị H', N'09373743433', N'DV004', NULL)
