-- Creating the Category table
CREATE TABLE Category (
    CategoryId INT PRIMARY KEY IDENTITY,
    CategoryName NVARCHAR(100) NOT NULL
);

-- Creating the Product table
CREATE TABLE Product (
    ProductId INT PRIMARY KEY IDENTITY,
    CategoryId INT FOREIGN KEY REFERENCES Category(CategoryId),
    ProductName NVARCHAR(100) NOT NULL,
    Weight DECIMAL(10, 2),
    UnitPrice DECIMAL(10, 2),
    UnitsInStock INT
);

-- Creating the Member table
CREATE TABLE Member (
    MemberId INT PRIMARY KEY IDENTITY,
    Email NVARCHAR(100) NOT NULL,
    CompanyName NVARCHAR(100),
    City NVARCHAR(100),
    Country NVARCHAR(100),
    Password NVARCHAR(100) NOT NULL
);

-- Creating the Order table
CREATE TABLE [Order] (
    OrderId INT PRIMARY KEY IDENTITY,
    MemberId INT FOREIGN KEY REFERENCES Member(MemberId),
    OrderDate DATETIME NOT NULL,
    RequiredDate DATETIME,
    ShippedDate DATETIME,
    Freight DECIMAL(10, 2)
);

-- Creating the OrderDetail table
CREATE TABLE OrderDetail (
    OrderId INT FOREIGN KEY REFERENCES [Order](OrderId),
    ProductId INT FOREIGN KEY REFERENCES Product(ProductId),
    UnitPrice DECIMAL(10, 2) NOT NULL,
    Quantity INT NOT NULL,
    Discount DECIMAL(5, 2),
    PRIMARY KEY (OrderId, ProductId)
);
