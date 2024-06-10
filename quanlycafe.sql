CREATE DATABASE QuanLyQuanCafe
GO

USE QuanLyQuanCafe
GO

-- Food
-- Table
-- FoodCategory
-- Account
-- Bill
-- BillInfo

CREATE TABLE TableFood
(
	id INT IDENTITY PRIMARY KEY,
	name nvarchar(100) not null default N'Chưa đặt tên',
	status nvarchar(100) not null default N'Trống'  -- trống || có người
)
GO

create TABLE Account
(
	UserName nvarchar(100) PRIMARY KEY,
	DisplayName nvarchar(100) NOT NULL default N'USER',
	PassWord nvarchar(1000) not null default 0,
	Type int not null default 0		 -- 1: admin || 0: staff
)
GO

CREATE TABLE FoodCategory
(
	id INT IDENTITY PRIMARY KEY,
	name nvarchar(100) not null default N'Chưa đặt tên'
)
GO

CREATE TABLE Food
(
	id INT IDENTITY PRIMARY KEY,
	name nvarchar(100) not null default N'Chưa đặt tên',
	idCategory int not null,
	price float not null default 0

	foreign key (idCategory) references dbo.FoodCategory(id)
)
GO

CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	DateCheckIn date not null default getdate(),
	DateCheckOut date,
	idTable int not null,
	status int not null	default 0		-- 1: đã thanh toán || 0: chưa thanh toán

	foreign key (idTable) references dbo.TableFood(id)
)
GO

CREATE TABLE BillInfo
(
	id INT IDENTITY PRIMARY KEY,
	idBill int not null,
	idFood int not null,
	count int not null default 0

	foreign key (idBill) references dbo.Bill(id),
	foreign key (idFood) references dbo.Food(id)
)
GO

INSERT INTO dbo.Account
			( UserName,
			  DisplayName,
			  PassWord,
			  Type
			)
VALUES	( N'linhtikay',
		  N'VanLinh',
		  N'1',
		  1
		)

insert into dbo.Account
			( UserName,
			  DisplayName,
			  PassWord,
			  Type
			)
values	( N'staff' ,
		  N'staff' ,
		  N'1' ,
		  0
		)
go

create proc USP_GetAccountByUserName
@userName nvarchar(100)
as
begin
	select * from Account where UserName = @userName
end
go

exec USP_GetAccountByUserName @userName = N'linhtikay'
go

create proc USP_Login
@userName nvarchar(100), @passWord nvarchar(100)
as
begin
	select * from Account where UserName = @userName and PassWord = @passWord
end
go

-- thêm bàn
declare @i int = 1
while @i <= 20
begin
	insert TableFood (name) values (N'Bàn ' + CAST(@i as nvarchar(100)))
	set @i = @i + 1
end
go

update TableFood set status = N'Có người' where id = 14
go

create proc USP_GetTableList
as select * from TableFood
go

-- thêm category
insert FoodCategory (name)
values ( N'Cà phê')
insert FoodCategory (name)
values ( N'Trà trái cây')
insert FoodCategory (name)
values ( N'Trà sữa')
insert FoodCategory (name)
values ( N'Sinh tố')
insert FoodCategory (name)
values ( N'Nước ép')

-- thêm món
insert Food (name, idCategory, price)
values ( N'Bạc xỉu', 1, 20000)
insert Food (name, idCategory, price)
values ( N'Capuchino', 1, 35000)
insert Food (name, idCategory, price)
values ( N'Trà đào cam xả', 2, 25000)
insert Food (name, idCategory, price)
values ( N'Trà chanh', 2, 20000)
insert Food (name, idCategory, price)
values ( N'Trà sữa truyền thống', 3, 25000)
insert Food (name, idCategory, price)
values ( N'Sữa tươi trân châu đường đen', 3, 25000)
insert Food (name, idCategory, price)
values ( N'Sinh tố xoài', 4, 30000)
insert Food (name, idCategory, price)
values ( N'Sinh tố dâu', 4, 30000)
insert Food (name, idCategory, price)
values ( N'Nước ép dứa', 5, 25000)
insert Food (name, idCategory, price)
values ( N'Nước ép cà rốt', 5, 25000)
insert Food (name, idCategory, price)
values ( N'Nước ép dưa hấu', 5, 25000)

-- thêm bill
insert Bill (DateCheckIn, DateCheckOut, idTable, status)
values ( GETDATE(), null, 14, 0)
insert Bill (DateCheckIn, DateCheckOut, idTable, status)
values ( GETDATE(), GETDATE(), 3, 1)

-- thêm bill info
insert BillInfo ( idBill, idFood, count)
values ( 1, 1, 2)
insert BillInfo ( idBill, idFood, count)
values ( 1, 2, 1)
insert BillInfo ( idBill, idFood, count)
values ( 2, 4, 5)
insert BillInfo ( idBill, idFood, count)
values ( 2, 3, 3)

go


create proc USP_InsertBill
@idTable int
as
begin
	insert Bill ( DateCheckIn, DateCheckOut, idTable, status, discount)
	values ( GETDATE(), null, @idTable, 0, 0 )
end
go


create proc USP_InsertBillInfo
@idBill int, @idFood int, @count int
as
begin
	declare @isExitsBillInfo int
	declare @foodCount int = 1
	select @isExitsBillInfo = id, @foodCount = b.count from BillInfo as b where idBill = @idBill and idFood = @idFood

	if (@isExitsBillInfo > 0)
		begin
			declare @newCount int = @foodCount + @count
			if (@newCount > 0)
				update BillInfo set count = @foodCount + @count where idFood = @idFood
			else
				delete BillInfo where idBill = @idBill and idFood = @idFood
		end

	else
		begin
			insert BillInfo ( idBill, idFood, count )
			values ( @idBill, @idFood, @count )
		end
end
go


create trigger UTG_UpdateBillInfo
on BillInfo for insert, update	
as
begin
	declare @idBill int
	select @idBill = idBill from inserted

	declare @idTable int
	select @idTable = idTable from Bill where id = @idBill and status = 0

	declare @count int
	select @count = count(*) from BillInfo where idBill = @idBill

	if (@count > 0)
		update TableFood set status = N'Có người' where id = @idTable
	else
		update TableFood set status = N'Trống' where id = @idTable
end
go


create trigger UTG_UpdateBill
on Bill for update
as
begin
	declare @idBill int
	select @idBill = id from inserted
	declare @idTable int
	select @idTable = idTable from Bill where id = @idBill
	declare @count int = 0
	select @count = count(*) from Bill where idTable = @idTable and status = 0
	
	if (@count = 0)
		update TableFood set status = N'Trống' where id = @idTable
end
go

alter table Bill
add discount int

update Bill set discount = 0
go

create proc USP_SwitchTable
@idTable1 int, @idTable2 int
as
begin
	declare @idFirstBill int
	declare @idSecondBill int
	declare @isFirstTableEmty int = 1
	declare @isSecondTableEmty int = 1

	select @idSecondBill = id from Bill where idTable = @idTable2 and status = 0
	select @idFirstBill = id from Bill where idTable = @idTable1 and status = 0

	if (@idFirstBill is null)
		begin
			insert Bill (DateCheckIn, DateCheckOut, idTable, status)
			values (GETDATE(), null, @idTable1, 0)
			select @idFirstBill = max(id) from Bill where idTable = @idTable1 and status = 0
		end

	select @isFirstTableEmty = count(*) from BillInfo where idBill = @idFirstBill

	if (@idSecondBill is null)
		begin
			insert Bill (DateCheckIn, DateCheckOut, idTable, status)
			values (GETDATE(), null, @idTable2, 0)
			select @idSecondBill = max(id) from Bill where idTable = @idTable2 and status = 0
		end
	
	select @isSecondTableEmty = count(*) from BillInfo where idBill = @idSecondBill

	select id into IDBillInfoTable from BillInfo where idBill = @idSecondBill
	update BillInfo set idBill = @idSecondBill where idBill = @idFirstBill
	update BillInfo set idBill = @idFirstBill where id in (select * from IDBillInfoTable)

	drop table IDBillInfoTable

	if (@isFirstTableEmty = 0)
		update TableFood set status = N'Trống' where id = @idTable2
	if (@isSecondTableEmty = 0)
		update TableFood set status = N'Trống' where id = @idTable1
end
go

alter table bill add totalPrice float
go

create proc USP_GetListBillByDate
@checkIn date, @checkOut date
as
begin
	select t.name as [Tên bàn], b.totalPrice as [Tổng tiền], DateCheckIn as [Thời gian vào], DateCheckOut as [Thời gian ra], discount as [Giảm giá]
	from Bill as b, TableFood as t
	where DateCheckIn >= @checkIn and DateCheckOut <= @checkOut and b.status = 1 and t.id = b.idTable
end
go

create proc USP_UpdateAccount
@userName nvarchar(100), @displayName nvarchar(100), @password nvarchar(100), @newPassword nvarchar(100)
as
begin
	declare @isRightPass int = 0
	select @isRightPass = count(*) from Account where UserName = @userName and PassWord = @password
	if (@isRightPass = 1)
	begin
		if (@newPassword = null or @newPassword = '')
			begin
				update Account set DisplayName = @displayName where UserName = @userName
			end
		else
			update Account set DisplayName = @displayName, PassWord = @newPassword where UserName = @userName
	end
end
go

create trigger UTG_DeleteBillInfo
on BillInfo for delete
as
begin
	declare @idBillInfo int
	declare @idBill int
	select @idBillInfo = id, @idBill = idBill from deleted

	declare @idTable int
	select @idTable = idTable from Bill where id = @idBill

	declare @count int = 0
	select @count = count(*) from BillInfo as bi, Bill as b where b.id = bi.idBill and b.id = @idBill and b.status = 0
	if (@count = 0)
		update TableFood set status = N'Trống'	where id = @idTable
end
go

create FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000) AS BEGIN IF @strInput IS NULL RETURN @strInput IF @strInput = '' RETURN @strInput DECLARE @RT NVARCHAR(4000) DECLARE @SIGN_CHARS NCHAR(136) DECLARE @UNSIGN_CHARS NCHAR (136) SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' DECLARE @COUNTER int DECLARE @COUNTER1 int SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput END
GO

create proc USP_GetListBillByDateAndPage
@checkIn date, @checkOut date, @page int
as
begin
	declare @pageRows int = 20
	declare @selectRows int = @pageRows
	declare @exceptRows int = (@page - 1) * @pageRows

	;with BillShow as ( select b.ID, t.name as [Tên bàn], b.totalPrice as [Tổng tiền], DateCheckIn as [Thời gian vào], DateCheckOut as [Thời gian ra], discount as [Giảm giá]
					   from Bill as b, TableFood as t
					   where DateCheckIn >= @checkIn and DateCheckOut <= @checkOut and b.status = 1 and t.id = b.idTable )
	select top (@selectRows) * from BillShow where id not in (select top (@exceptRows) id from BillShow)
end
go

create proc USP_GetNumBillByDate
@checkIn date, @checkOut date
as
begin
	select count(*)
	from Bill as b, TableFood as t
	where DateCheckIn >= @checkIn and DateCheckOut <= @checkOut and b.status = 1 and t.id = b.idTable
end
go
