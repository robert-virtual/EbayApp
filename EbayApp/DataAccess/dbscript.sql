-- dapper - mini orm - realiza las consultas


create DATABASE ebaydb

use ebaydb

create table Categories(
    CategoryId int PRIMARY KEY IDENTITY,
    Name NVARCHAR(25)
)

create table Products(
    ProductId int PRIMARY KEY IDENTITY,
    Name NVARCHAR(25),
    Price money,
    CategoryFk int FOREIGN KEY REFERENCES Categories(CategoryId),
    Activo bit DEFAULT 1,
    CreatedAt DATETIME DEFAULT GETDATE()
)

select * from Products
select * from Categories

insert into Categories(Name) VALUES('Beverages')
insert into Products(Name,Price,CategoryFk) VALUES('cocacola',60,1)


create table Customers(
    DNI NVARCHAR(13) PRIMARY KEY,
    Name NVARCHAR(50),
    Phone NVARCHAR(8),
    Address NVARCHAR(100),
    CreatedAt DATETIME DEFAULT GETDATE()
)

create table Roles(
    RolId int PRIMARY KEY IDENTITY,
    Name nvarchar(50)
)

create table Employees(
    DNI NVARCHAR(13) PRIMARY KEY,
    Name NVARCHAR(50),
    Password NVARCHAR(450),
    Phone NVARCHAR(8),
    Address NVARCHAR(100),
    RolFk int FOREIGN KEY REFERENCES Roles(RolId),
    Birthday DATE,
    HiredAt DATE DEFAULT GETDATE(),
    FiredAt DATE,
    Activo bit DEFAULT 1,
)

insert into Roles VALUES('admin'),('sells')




--
create table Sells(
    SellId int PRIMARY KEY,
    EmployeeFk NVARCHAR(13) FOREIGN KEY REFERENCES Employees(DNI),
    CustomerFk NVARCHAR(13) FOREIGN KEY REFERENCES Customers(DNI),
    CreatedAt DATETIME DEFAULT GETDATE()

)
create table SellDetails(
    SellFk int FOREIGN KEY REFERENCES Sells(SellId),
    ProductFk int FOREIGN KEY REFERENCES Products(ProductId),
    Amout int, 
    Price money,
    Descount money
)


create table Suppliers(
    SupplierId int PRIMARY KEY IDENTITY,
    Name NVARCHAR(50)
)

--

create table Purchases(
    PurchaseId int PRIMARY KEY IDENTITY,
    EmployeeFk NVARCHAR(13) FOREIGN KEY REFERENCES Employees(DNI),
    SupplierFk int FOREIGN KEY REFERENCES Suppliers(SupplierId),
    CreatedAt DATETIME DEFAULT GETDATE()

)
create table PurchaseDetails(

    PurchaseFk int FOREIGN KEY REFERENCES Purchases(PurchaseId),
    ProductFk int FOREIGN KEY REFERENCES Products(ProductId),
    Amout int, 
    Price money,
)