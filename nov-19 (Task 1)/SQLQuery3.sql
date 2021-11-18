
Drop table if exists Products;
Drop table if exists Brands;


CREATE TABLE Products
(
Id INT IDENTITY PRIMARY KEY,
Name NVARCHAR(50),
Price Int, 
)

CREATE TABLE Brands(
Id INT IDENTITY PRIMARY KEY ,
Name VARCHAR(50)
)

ALTER TABLE Products ADD BrandId INT

ALTER TABLE Products
ADD CONSTRAINT fk_pox FOREIGN KEY(BrandId)
REFERENCES Brands(Id)


INSERT INTO Brands
Values('Apple')
INSERT INTO Brands
Values('Samsung')
INSERT INTO Brands
Values('Sony')
INSERT INTO Brands
Values('Google')
INSERT INTO Brands
Values('Poco')
INSERT INTO Brands
Values('General Mobile')
INSERT INTO Products
Values('Iphone 6',399,1)
INSERT INTO Products
Values('Iphone 7',649,1)
INSERT INTO Products
Values('Iphone 8',707,1)
INSERT INTO Products
Values('Iphone x',499,1)
INSERT INTO Products
Values('Galaxy Z flip 3',999,2)
INSERT INTO Products
Values('Xperia PRO-I',1799,3)
INSERT INTO Products
Values('Pixel 5',699,4)
INSERT INTO Products
Values('M4 Pro 5G',308,5)
INSERT INTO Products
Values('GM 21 PRO',235,6)
INSERT INTO Products
Values('Galaxy fold 3',1800,2)
INSERT INTO Products
Values('Galaxy Tab s7 FE',650,2)
SELECT*FROM Brands
SELECT*FROM Products

SELECT*FROM Products WHERE Price>1000
SELECT * FROM Products
WHERE Price < (SELECT AVG(Price) FROM Products);

SELECT*FROM Brands
WHERE LEN(Name)>5
