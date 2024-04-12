CREATE TABLE Nhan_Vien1 (
    ID INT NOT NULL PRIMARY KEY IDENTITY,
    HoTen nvarchar(50) NOT NULL,
    NgaySinh datetime NOT NULL,
    GioiTinh nvarchar(10) NOT NULL,
	Trinhdo nvarchar(50) NOT NULL,
    Luong int NOT NULL,
    LoaiNV nvarchar(20) NOT NULL,
)

SET IDENTITY_INSERT [dbo].[Nhan_Vien1] ON 

INSERT [dbo].[Nhan_Vien1] ([Id], [HoTen], [NgaySinh], [GioiTinh], [TrinhDo], [Luong], [LoaiNV]) VALUES (1, N'Trần Thị Thúy Vi', 6/2/2000, N'Nữ', N'Đại học', 12000000, N'Quản lý')
INSERT [dbo].[Nhan_Vien1] ([Id], [HoTen], [NgaySinh], [GioiTinh], [TrinhDo], [Luong], [LoaiNV]) VALUES (2,N'Nguyễn Vũ Phương Loan', 6/10/2000, N'Nữ', N'Đại học', 12000000, N'Văn phòng')
INSERT [dbo].[Nhan_Vien1] ([Id], [HoTen], [NgaySinh], [GioiTinh], [TrinhDo], [Luong], [LoaiNV]) VALUES (3, N'Nguyễn Thị Nguyệt Quế', 6/9/2000, N'Nữ', N'Đại học', 12000000, N'Công Nhân')
SET IDENTITY_INSERT [dbo].[Nhan_Vien1] OFF
