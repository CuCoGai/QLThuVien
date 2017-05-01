use master
create database QLThuVien
go
use QLThuVien
go
-----
create table Khosach
(
ma varchar(10) primary key not null,
ten nvarchar(100),
ghichu nvarchar(100)
)
go
-----
create table Nhaxuatban
(
ma varchar(10) primary key not null,
ten nvarchar(100),
diachi nvarchar(100),
sodienthoai varchar(15)
)
go
-----
create table Docgia
(
sothe varchar(10) primary key not null,
hoten nvarchar(100),
ngaysinh datetime,
gioitinh bit,
email varchar(50),
donvi varchar(50),
chucvu nvarchar(50),
anh varchar(100),
ngaycapthe datetime,
hanthe datetime
)
go
-----
create table Sach
(
ma varchar(10) primary key not null,
ten nvarchar(100),
tacgia nvarchar(100),
loaisach nvarchar(50),
nhaxuatbanma varchar(10) references Nhaxuatban(ma),
sotrang int,
solanxuatban int,
soluong int,
noidung nvarchar(100),
giatien varchar(20),
ngonngu nvarchar(20),
khoma varchar(10) references Khosach(ma)
)
go
-----
create table Thuthu
(
ma varchar(10) primary key not null,
ten nvarchar(100),
diachi nvarchar(100),
sodienthoai varchar(15),
chucvu nvarchar(20),
email varchar(50),
tendangnhap nvarchar(20),
matkhau varchar(10)
)
go
-----
create table Dangkycabiet
(
sachma varchar(10) references Sach(ma),
sodangky varchar(10) primary key not null,
ngayvaoso datetime,
khoma varchar(10) references Khosach(ma)
)
go
-----
create table Muontra
(
sothutu varchar(10) primary key not null,
sothema varchar(10) references Docgia(sothe),
sachma varchar(10) references Sach(ma),
thuthuma varchar(10) references Thuthu(ma),
ngaymuon datetime,
ngaytra datetime,
ngayphaitra datetime,
tinhtrangmuon nvarchar(50),
tinhtrangtra nvarchar(50)
)
go
-----
--Insert into all table
-----
insert into Khosach(ma,ten,ghichu)
values('K01',N'Kho sách khoa Công nghệ thông tin',null),
      ('K02',N'Kho sách khoa Công nghệ hóa',null),
	  ('K03',N'Kho sách khoa Điện tử y sinh',null),
	  ('K04',N'Kho sách khoa Xây dựng dân dụng',null),
	  ('K05',N'Kho sách khoa Kỹ thuật điều khiển',null),
	  ('K06',N'Kho sách khoa Xây dựng cầu đường',null)
go
-----
insert into Nhaxuatban(ma,ten,diachi,sodienthoai)
values('NXB01',N'NXB Giáo dục','','0982486486'),
      ('NXB02',N'NXB Tổng hợp HCM','','098235864'),
	  ('NXB03',N'NXB Trẻ','','0982485196'),
	  ('NXB04',N'NXB Chính trị quốc gia','','0982453888'),
	  ('NXB05',N'NXB Tri thức','','0965001169')
go
-----
insert into Docgia(sothe,hoten,ngaysinh,gioitinh,email,donvi,chucvu,anh,ngaycapthe,hanthe)
values('196001',N'Nguyễn Thị Trang',4/1/1996,0,'trangt@gmail.com','CNH','SV',null,9/2/2015,6/24/2019),
      ('196002',N'Nguyễn Thị Hoa',4/16/1994,0,'hoamta@gmail.com','TH13C','SV',null,9/2/2015,6/24/2019),
	  ('196003',N'Cấn Hồng Ngọc',9/14/1996,0,'ngocmta@gmail.com','TH13C','SV',null,9/2/2015,6/24/2019),
	  ('196004',N'Nguyễn Thị Mỹ Linh',9/1/1996,0,'linhmin@gmail.com','TH13C','SV',null,9/2/2015,6/24/2019),
	  ('196005',N'Nguyễn Phương Thảo',6/1/1996,0,'thaojapan@gmail.com','CNH','SV',null,9/2/2015,6/24/2019),
	  ('196006',N'Đỗ Phương Ly',10/1/1996,0,'lylun@gmail.com','CNH','SV',null,9/2/2015,6/24/2019),
	  ('196007',N'Nguyễn Thị Việt Hà',8/2/1996,0,'hamom@gmail.com','DTVT','SV',null,9/2/2015,6/24/2019),
	  ('196008',N'Phạm Hồng Tú Anh',10/18/1996,0,'tutt@gmail.com','CNH','SV',null,9/2/2015,6/24/2019),
	  ('196009',N'Bạch Quang Thắng',3/26/1996,1,'thangqt@gmail.com','DTVT','SV',null,9/2/2015,6/24/2019),
	  ('196010',N'Nguyễn Đức Thắng',6/1/1996,1,'thangtl@gmail.com','DTVT','SV',null,9/2/2015,6/24/2019),
	  ('196011',N'Nguyễn Quang Hợp',1/5/1995,1,'hopcann@gmail.com','XDDD','SV',null,9/2/2015,6/24/2019),
	  ('196012',N'Nguyễn Thị Nga',4/16/1996,0,'ngapig@gmail.com','DTVT','SV',null,9/2/2015,6/24/2019),
	  ('196013',N'Nguyễn Thị Thùy Anh',10/28/1995,0,'thuyammy@gmail.com','TH13C','SV',null,9/2/2015,6/24/2019),
	  ('196014',N'Dương Hồng Sơn',4/16/1996,1,'sonsin@gmail.com','OTO','SV',null,9/2/2015,6/24/2019),
	  ('196015',N'Nguyễn Duy Hưng',6/9/1996,1,'hungsoi@gmail.com','OTO','SV',null,9/2/2015,6/24/2019)
go
-----
insert into Sach(ma,ten,tacgia,loaisach,nhaxuatbanma,sotrang,solanxuatban,soluong,noidung,giatien,ngonngu,khoma)
values('S01',N'Phân tích thiết kế và giải thuật',N'Nguyễn Xuân Lôi','NXB01',126,2,18,null,'92000đ',N'Tiếng Việt','K01'),
      ('S02',N'Toeic 450+',N'Nguyễn Thị Nguyệt','NXB04',226,4,16,null,'135000đ',N'Tiếng Anh','K01'),
	  ('S03',N'Phân tích thiết kế và giải thuật',N'Nguyễn Xuân Lôi','NXB01',126,2,18,null,'92000đ',N'Tiếng Việt','K01'),
	  ('S04',N'Phân tích thiết kế và giải thuật',N'Nguyễn Xuân Lôi','NXB01',126,2,18,null,'92000đ',N'Tiếng Việt','K01'),
	  ('S05',N'Phân tích thiết kế và giải thuật',N'Nguyễn Xuân Lôi','NXB01',126,2,18,null,'92000đ',N'Tiếng Việt','K01'),
	  ('S06',N'Phân tích thiết kế và giải thuật',N'Nguyễn Xuân Lôi','NXB01',126,2,18,null,'92000đ',N'Tiếng Việt','K01'),
	  ('S07',N'Phân tích thiết kế và giải thuật',N'Nguyễn Xuân Lôi','NXB01',126,2,18,null,'92000đ',N'Tiếng Việt','K01'),
	  ('S08',N'Phân tích thiết kế và giải thuật',N'Nguyễn Xuân Lôi','NXB01',126,2,18,null,'92000đ',N'Tiếng Việt','K01'),
	  ('S09',N'Phân tích thiết kế và giải thuật',N'Nguyễn Xuân Lôi','NXB01',126,2,18,null,'92000đ',N'Tiếng Việt','K01'),
	  ('S10',N'Phân tích thiết kế và giải thuật',N'Nguyễn Xuân Lôi','NXB01',126,2,18,null,'92000đ',N'Tiếng Việt','K01'),
	  ('S11',N'Phân tích thiết kế và giải thuật',N'Nguyễn Xuân Lôi','NXB01',126,2,18,null,'92000đ',N'Tiếng Việt','K01'),
	  ('S12',N'Phân tích thiết kế và giải thuật',N'Nguyễn Xuân Lôi','NXB01',126,2,18,null,'92000đ',N'Tiếng Việt','K01'),
	  ('S13',N'Phân tích thiết kế và giải thuật',N'Nguyễn Xuân Lôi','NXB01',126,2,18,null,'92000đ',N'Tiếng Việt','K01'),
	  ('S14',N'Phân tích thiết kế và giải thuật',N'Nguyễn Xuân Lôi','NXB01',126,2,18,null,'92000đ',N'Tiếng Việt','K01'),
	  ('S15',N'Phân tích thiết kế và giải thuật',N'Nguyễn Xuân Lôi','NXB01',126,2,18,null,'92000đ',N'Tiếng Việt','K01'),
	  ('S16',N'Phân tích thiết kế và giải thuật',N'Nguyễn Xuân Lôi','NXB01',126,2,18,null,'92000đ',N'Tiếng Việt','K01'),
	  ('S17',N'Phân tích thiết kế và giải thuật',N'Nguyễn Xuân Lôi','NXB01',126,2,18,null,'92000đ',N'Tiếng Việt','K01'),
	  ('S18',N'Phân tích thiết kế và giải thuật',N'Nguyễn Xuân Lôi','NXB01',126,2,18,null,'92000đ',N'Tiếng Việt','K01')
go
-----
insert into Thuthu(ma,ten,diachi,sodienthoai,chucvu,email,tendangnhap,matkhau)
values('T01',N'Bùi Phương Thúy',N'Thư Viện S1',0968787076,null,'abcd123@gmail.com',N'Thúy Bùi','1234'),
      ('T02',N'Bùi Phương Thúy',N'Thư Viện S1',0968787076,null,'abcd123@gmail.com',N'Thúy Bùi','1234'),
	  ('T03',N'Bùi Phương Thúy',N'Thư Viện S1',0968787076,null,'abcd123@gmail.com',N'Thúy Bùi','1234'),
	  ('T04',N'Bùi Phương Thúy',N'Thư Viện S1',0968787076,null,'abcd123@gmail.com',N'Thúy Bùi','1234'),
	  ('T05',N'Bùi Phương Thúy',N'Thư Viện S1',0968787076,null,'abcd123@gmail.com',N'Thúy Bùi','1234'),
	  ('T06',N'Bùi Phương Thúy',N'Thư Viện S1',0968787076,null,'abcd123@gmail.com',N'Thúy Bùi','1234')
go
-----
insert into Dangkycabiet(sachma,sodangky,ngayvaoso,khoma)
values('S01','C01',8/14/2016,'K02')
go
-----
insert into Muontra(sothutu,sothema,sachma,thuthuma,ngaymuon,ngaytra,ngayphaitra,tinhtrangmuon,tinhtrangtra)
values('01','196003','S14','T03',1/14/2016,6/12/2016,7/18/2016,N'nguyên vẹn',N'nguyên vẹn')
go
-----