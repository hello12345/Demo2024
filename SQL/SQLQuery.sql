
-- Create the Products table
CREATE TABLE Products (
    Id INT PRIMARY KEY IDENTITY(1,1),  -- Primary key with auto-increment
    Name NVARCHAR(100) NOT NULL,        -- Product name
    Price DECIMAL(18, 2) NOT NULL,      -- Product price
    AttributesJson NVARCHAR(MAX)         -- JSON column for additional attributes
);

-- Create the Orders table
CREATE TABLE Orders (
    Id INT PRIMARY KEY IDENTITY(1,1),    -- Primary key with auto-increment
    ProductId INT NOT NULL,              -- Foreign key to Products
    OrderDate DATETIME NOT NULL,         -- Date of the order
    FOREIGN KEY (ProductId) REFERENCES Products(Id)  -- Foreign key constraint
);