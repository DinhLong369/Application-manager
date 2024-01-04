CREATE DATABASE QLQuanLauNuong
GO

USE QLQuanLauNuong
GO

-- Table
-- FoodCategory
-- Account
-- Bill
-- BillInfor

CREATE TABLE TableFood
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) DEFAULT N'Chưa đặt tên',
	status NVARCHAR(100) DEFAULT N'Trống' -- trống || có người
)
GO

CREATE TABLE Account
(
	UserName NVARCHAR(100) PRIMARY KEY,
	ShowName NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	PassWord NVARCHAR(100) NOT NULL DEFAULT 0,
	Type INT NOT NULL DEFAULT 0
)
GO

CREATE TABLE FoodCategory
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
)
GO

CREATE TABLE Food
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	idCategory INT NOT NULL,
	price FLOAT NOT NULL
	FOREIGN KEY (idCategory) REFERENCES dbo.FoodCategory(id)
)
GO

CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATE,
	idTable INT NOT NULL,
	status INT NOT NULL DEFAULT 0--1: đã thanh toán || 0: chưa thanh toán
	FOREIGN KEY (idTable) REFERENCES dbo.TableFood(id)
)
GO

CREATE TABLE BillInfor
(
	id INT IDENTITY PRIMARY KEY,
	idBill INT NOT NULL,
	idFood INT NOT NULL,
	count INT NOT NULL DEFAULT 0 
	FOREIGN KEY (idBill) REFERENCES dbo.Bill(id),
	FOREIGN KEY (idFood) REFERENCES dbo.Food(id)
)
GO

-- INSERT
INSERT INTO dbo.Account ( UserName,ShowName,PassWord,Type) VALUES (N'dh',N'duy hung', N'1',0)
INSERT INTO dbo.Account ( UserName,ShowName,PassWord,Type) VALUES (N'staff',N'staff', N'1',1)
INSERT INTO dbo.Account ( UserName,ShowName,PassWord,Type) VALUES (N'dhung',N'Duy Hùng', N'1',1)
INSERT INTO dbo.Account ( UserName,ShowName,PassWord,Type) VALUES (N'ad',N'Admin', N'1',1)
INSERT INTO dbo.Account ( UserName,ShowName,PassWord,Type) VALUES (N'staff1',N'staff1', N'1',1)
INSERT INTO dbo.Account ( UserName,ShowName,PassWord,Type) VALUES (N'staff2',N'staff2', N'1',1)

DECLARE @i INT = 1
WHILE @i <= 16
BEGIN
	INSERT INTO dbo.TableFood(name) VALUES (N'Bàn ' + CAST(@i AS NVARCHAR(100)))
	SET @i = @i + 1
END

INSERT INTO dbo.FoodCategory ( name ) VALUES (N'Hải sản')
INSERT INTO dbo.FoodCategory ( name ) VALUES (N'Nông sản')
INSERT INTO dbo.FoodCategory ( name ) VALUES (N'Lâm sản')
INSERT INTO dbo.FoodCategory ( name ) VALUES (N'Nước ngoài')
INSERT INTO dbo.FoodCategory ( name ) VALUES (N'Nước uống')

INSERT INTO dbo.Food ( name, idCategory, price ) VALUES(N'Tôm hùm Alaska', 1 , 5000000.0) 
INSERT INTO dbo.Food ( name, idCategory, price ) VALUES(N'Cua hoàng đế', 1 , 6000000.0) 
INSERT INTO dbo.Food ( name, idCategory, price ) VALUES(N'Thịt trâu gác bếp', 2 , 100000.0)
INSERT INTO dbo.Food ( name, idCategory, price ) VALUES(N'Thịt dê nướng', 3 , 200000.0) 
INSERT INTO dbo.Food ( name, idCategory, price ) VALUES(N'Kim chi', 4 , 5000000.0)
INSERT INTO dbo.Food ( name, idCategory, price ) VALUES(N'Noodle soup', 4 , 30000.0)

INSERT INTO dbo.Bill ( DateCheckIn, DateCheckOut, idTable, status) VALUES ( GETDATE(), NULL , 2 ,0)
INSERT INTO dbo.Bill ( DateCheckIn, DateCheckOut, idTable, status) VALUES ( GETDATE(), NULL , 3 ,0)
INSERT INTO dbo.Bill ( DateCheckIn, DateCheckOut, idTable, status) VALUES ( GETDATE(), NULL , 4 ,1)

INSERT INTO dbo.BillInfor ( idBill, idFood, count ) VALUES(1, 1, 2)
INSERT INTO dbo.BillInfor ( idBill, idFood, count ) VALUES(1, 3, 6)
INSERT INTO dbo.BillInfor ( idBill, idFood, count ) VALUES(2, 1, 1)
INSERT INTO dbo.BillInfor ( idBill, idFood, count ) VALUES(2, 6, 8)
INSERT INTO dbo.BillInfor ( idBill, idFood, count ) VALUES(3, 6, 8)


------------------------------------------------------------------------------------------------------------
CREATE PROC USP_GetAccountByUserName
@userName nvarchar(100)
AS 
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName
END
GO

CREATE PROC USP_GetTableList
AS SELECT * FROM dbo.TableFood
GO
EXEC dbo.USP_GetTableList


CREATE PROC USP_Login
@userName nvarchar(100), @passWord nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName AND PassWord = @passWord
END
GO

Alter table Bill ADD discount int
CREATE PROC USP_InsertBill
@idTable INT
AS
BEGIN 
	INSERT INTO dbo.Bill
	(
	    DateCheckIn,
	    DateCheckOut,
	    idTable,
	    status,
		discount
	)
	VALUES
	(   GETDATE(), -- DateCheckIn - date
	    null, -- DateCheckOut - date
	    @idTable,         -- idTable - int
	    0,          -- status - int
		0
	    )
END
GO

CREATE PROC USP_InsertBillInfo 
@idBill INT, @idFood INT, @count INT
AS
BEGIN
	DECLARE @isExistsBillInfor INT
	DECLARE @foodCount INT = 1
	SELECT @isExistsBillInfor = id, @foodCount = count FROM dbo.BillInfor WHERE idBill = @idBill AND idFood = @idFood
	IF(@isExistsBillInfor > 0)
	BEGIN
		DECLARE @newCount INT = @foodCount + @count
		IF(@newCount > 0)
			UPDATE dbo.BillInfor SET count = @foodCount + @count WHERE idFood = @idFood
		ELSE 
			DELETE dbo.BillInfor WHERE idBill = @idBill AND idFood = @idFood
	END


	ELSE
		INSERT INTO dbo.BillInfor
	(
	    idBill,
	    idFood,
	    count
	)
	VALUES
	(   @idBill, -- idBill - int
	    @idFood, -- idFood - int
	    @count  -- count - int
	    )
END
GO

DELETE dbo.BillInfor

DELETE dbo.Bill

CREATE TRIGGER UTG_UpdateBillInfo
ON dbo.BillInfor FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @idBill INT
	
	SELECT @idBill = idBill FROM Inserted
	
	DECLARE @idTable INT
	
	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill AND status = 0
	
	UPDATE dbo.TableFood SET status = N'Có người' WHERE id = @idTable
END
GO

CREATE TRIGGER UTG_UpdateBill
ON dbo.Bill FOR UPDATE
AS
BEGIN
	DECLARE @idBill INT
	
	SELECT @idBill = id FROM Inserted	
	
	DECLARE @idTable INT
	
	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill
	
	DECLARE @count int = 0
	
	SELECT @count = COUNT(*) FROM dbo.Bill WHERE idTable = @idTable AND status = 0
	
	IF (@count = 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable
END
GO

ALTER TABLE dbo.Bill
ADD discount INT
UPDATE dbo.Bill SET discount = 0

ALTER TABLE Bill ADD totalPrice FLOAT 

DELETE dbo.BillInfor
DELETE dbo.Bill
GO

CREATE PROC USP_GetListBillByDate
@checkin DATE, @checkout DATE
AS
BEGIN
    SELECT t.name AS [Tên món], b.DateCheckIn AS [Ngày vào], b.DateCheckOut AS [Ngày ra], b.discount AS [Giảm giá], b.totalPrice AS [Tổng tiền]
	FROM dbo.Bill AS b , dbo.TableFood AS t
	WHERE b.DateCheckIn >= @checkin AND b.DateCheckOut <= @checkout AND b.status = 1 AND t.id = b.idTable
END

SELECT * FROM Account
