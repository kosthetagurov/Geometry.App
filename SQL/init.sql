CREATE DATABASE ProductCategoryDB;
GO

USE ProductCategoryDB;
GO

CREATE TABLE Products (
    ProductId INT PRIMARY KEY IDENTITY(1,1),
    ProductName NVARCHAR(100) NOT NULL
);
GO

CREATE TABLE Categories (
    CategoryId INT PRIMARY KEY IDENTITY(1,1),
    CategoryName NVARCHAR(100) NOT NULL
);
GO

CREATE TABLE ProductCategories (
    ProductId INT,
    CategoryId INT,
    PRIMARY KEY (ProductId, CategoryId),
    FOREIGN KEY (ProductId) REFERENCES Products(ProductId),
    FOREIGN KEY (CategoryId) REFERENCES Categories(CategoryId)
);
GO

INSERT INTO Products (ProductName) VALUES 
('Product A'), 
('Product B'), 
('Product C'),
('Product D');
GO

INSERT INTO Categories (CategoryName) VALUES 
('Category 1'), 
('Category 2'), 
('Category 3');
GO

INSERT INTO ProductCategories (ProductId, CategoryId) VALUES 
(1, 1), 
(1, 2), 
(2, 1), 
(3, 3);
GO

SELECT 
    p.ProductName,
    c.CategoryName
FROM 
    Products p
LEFT JOIN 
    ProductCategories pc ON p.ProductId = pc.ProductId
LEFT JOIN 
    Categories c ON pc.CategoryId = c.CategoryId
ORDER BY 
    p.ProductName, c.CategoryName;