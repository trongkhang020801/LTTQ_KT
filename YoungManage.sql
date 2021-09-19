use Manage_Young
go
create table tblQuanLiTre(
	Matre char(6) primary key,
	Maphuhuynh char(6),
	Hoten nvarchar(100) not null,
	NgaySinh varchar(20) not null,
	gioiTinh nvarchar(100) not null,
	Diachitamtru nvarchar(100) not null,
	Lophientai nvarchar(20)
)
go
create table tblQuanLyPhuHuynh(
	Maphuhuynh char(6) primary key,
	SDT varchar(11),
	Hotencha nvarchar(100),
	Hotenme nvarchar(100),
	CMNDcha varchar(10),
	CMNDme varchar(10)
)
go
CREATE PROCEDURE spInsert_tblQuanLiTre
	@maphuhuynh CHAR(6),
	@tentre NVARCHAR(50),
	@ngaySinh VARCHAR(20),
	@gioiTinh NVARCHAR(5),
	@diaChi NVARCHAR(100),
	@lophientai varchar(10)
AS
BEGIN
	DECLARE @id CHAR(6);
	DECLARE @idNew CHAR(6);
	DECLARE @stt INT;
	SELECT TOP 1 @id = Matre FROM tblQuanLiTre ORDER BY Matre DESC;
	SET @stt = CAST(SUBSTRING(@id, 3, LEN(@id)) AS INT) + 1;
	SET @idNew = 'T' + FORMAT(@stt, '0000#')
	INSERT INTO tblQuanLiTre
	VALUES (@idNew, @maphuhuynh, @tentre, @ngaySinh, @gioiTinh, @diaChi, @lophientai)
END
drop proc spInsert_tblQuanLiTre
go 
EXECUTE spInsert_tblQuanLiTre 'P00004', 'Nguyen trong khang','02/08/2001','Nam','01-tran cao van - da nang','choi01' 
go 
insert into tblQuanLyPhuHuynh values('P00004','1234567890','Tran Van A','Nguyen thi b','123456171','1234123')