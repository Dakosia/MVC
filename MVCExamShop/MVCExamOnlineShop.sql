CREATE DATABASE MVCExamOnlineShop
GO

USE MVCExamOnlineShop
GO

CREATE TABLE Category
(
	CategoryId INT IDENTITY(1, 1) NOT NULL,
	CategoryName VARCHAR(255) NOT NULL,
	ParentCategoryId INT NOT NULL,
	CONSTRAINT PK_CategoryId PRIMARY KEY (CategoryId)
)
GO

INSERT INTO Category VALUES
('Men', 0),
('Women', 0),
('Baby & Kids', 0),
('Watches', 1),
('Footwear', 1),
('Men''s Grooming', 1),
('Casio', 4),
('Fastrack', 4),
('Fossil', 4),
('Sonata', 4),
('Titan', 4),
('Casual Shoes', 5),
('Flip- Flops', 5),
('Formal Shoes', 5),
('Sandals & Floaters', 5),
('Sports Shoes', 5),
('Beard Care & Grooming', 6),
('Deodorants', 6),
('Perfumes', 6),
('Shaving & Aftershave', 6),
('Accessories', 2),
('Beauty & Grooming', 2),
('Clothing', 2),
('Ethnic Wear', 2),
('Footwear', 2),
('Handbags', 21),
('Shoulder Bags', 21),
('Sling bags', 21),
('Smart Bands', 21),
('Sunglasses', 21),
('Baby Care', 3),
('Kids Clothing', 3),
('Kids Footwear', 3),
('Toys', 3)
GO


CREATE TABLE Brand
(
	BrandId INT IDENTITY(1, 1) NOT NULL,
	BrandName VARCHAR(255) NOT NULL,
	BrandFirstChar VARCHAR(1) NOT NULL
	CONSTRAINT PK_BrandId PRIMARY KEY (BrandId)
)
GO

INSERT INTO Brand VALUES
('Apple', 'A'),
('Canon', 'C'),
('Hewlett-Packard', 'H'),
('Palm', 'P'),
('Sony', 'S'),
('HTC', 'H')
GO


CREATE TABLE Product
(
	ProductId INT IDENTITY(1, 1) NOT NULL,
	ProductName VARCHAR(255) NOT NULL,
	ProductCode VARCHAR(255) NOT NULL,
	ProductDescriptionInText VARCHAR(MAX) NOT NULL,
	ProductDescriptionInHTML VARCHAR(MAX) NOT NULL,
	ProductOldPrice FLOAT NULL,
	ProductNewPrice FLOAT NOT NULL,
	ProductExTaxPrice FLOAT NOT NULL,
	ProductAvailability VARCHAR(20) NOT NULL,
	ProductQtyInStock INT NOT NULL,
	ProductImagePath VARCHAR(500) NOT NULL,
	CategoryId INT NOT NULL,
	BrandId INT NOT NULL
	CONSTRAINT PK_ProductId PRIMARY KEY (ProductId),
	CONSTRAINT FK_CategoryId FOREIGN KEY (CategoryId) REFERENCES Category (CategoryId) ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT FK_BrandId FOREIGN KEY (BrandId) REFERENCES Brand (BrandId) ON DELETE CASCADE ON UPDATE CASCADE
)
GO

INSERT INTO Product VALUES
('Fabseasons Printed Cotton Men''S Scarf', 'SAM1', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.', NULL, 241.99, 199.99, 'Pre-Order', 20, '/Content/image/cache/catalog/17-416x520.jpg', 1, 7),
('THE CRAZY ME CYCLE RIDE SCARF', ' product 20', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.', NULL, 122.00, 100.00, 'In Stock', 5, '/Content/image/cache/catalog/7-800x1000.jpg', 1, 1),
('THE CRAZY ME ELEPHANT SCARF', 'Product 1', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.', NULL, 122.00, 100.00, 'In Stock', 13, '/Content/image/cache/catalog/4-800x1000.jpg', 2, 3),
('BEAUTIFUL EMBROIDERED BLACK ABAYA', 'Product 3', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.', 122.00, 98.00, 80.00, 'In Stock', 9, '/Content/image/cache/catalog/2-800x1000.jpg', 2, 5),
('CONIFER SYMMETRY BRIEFCASE BAG', 'Product 16', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.', 602.00, 62.00, 50.00, 'Pre-Order', 50, '/Content/image/cache/catalog/11-800x1000.jpg', 2, 4),
('CORUM GOLDEN BRIDGE WATCH', 'Product 9', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.', 122.00, 8.00, 5.00, 'In Stock', 20, '/Content/image/cache/catalog/8-800x1000.jpg', 3, 4),
('ICW GIRLS'' SCARF', 'Product 8', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.', NULL, 122.00, 100.00, 'In Stock', 10, '/Content/image/cache/catalog/16-800x1000.jpg', 3, 2)
GO



CREATE TABLE Blog
(
	BlogId INT IDENTITY(1, 1) NOT NULL,
	BlogName VARCHAR(255) NOT NULL,
	BlogShortDescription VARCHAR(1000) NOT NULL,
	BlogCreationDate DATE NOT NULL,
	BlogContent VARCHAR(MAX) NOT NULL,
	BlogImagePath VARCHAR(500) NOT NULL,
	CONSTRAINT PK_BlogId PRIMARY KEY (BlogId)
)
GO

INSERT INTO Blog VALUES
('Quisque egestas ullamco laboris', 'Mrs. Darling first heard of Peter when she was tidying up her children’s minds. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim adminim veniam, quis nostrud ercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.  ', '04.09.2018', 'Mrs. Darling first heard of Peter when she was tidying up her children’s minds. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim adminim veniam, quis nostrud ercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.  ', '/Content/image/cache/catalog/blog6-910x700.jpg'),
('Nostrum Iesum Christum ', 'Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo onsequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id st laborum.  ', '04.09.2018', 'Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo onsequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id st laborum.  ', '/Content/image/cache/catalog/blog5-910x700.jpg'),
('Libero lorem vehicula ', 'Link: St. Louis Blues Audio shortcode: “Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.  ', '04.09.2018', 'Link: St. Louis Blues Audio shortcode: “Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.  ', '/Content/image/cache/catalog/blog4-910x700.jpg'),
('Excepteur sint occaecat cupidatat', 'Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamcao laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur..  ', '04.09.2018', 'Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamcao laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur..  ', '/Content/image/cache/catalog/blog3-910x700.jpg'),
('Ipsum blandit donec vitae', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.  ', '04.09.2018', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.  ', '/Content/image/cache/catalog/blog2-910x700.jpg'),
('Contrary to all popular belief Lorem Ipsum is simply', 'Passage of Lorem Ipsum, you need to be sure there isn''t anything embarrassing hidden in Middle of text. All the.Passage of Lorem Ipsum, you need to be sure there isn''t anything embarrassing hidden in Middle of text. All the.Passage of Lorem Ipsum, you need to be sure there isn''t anything embarrassing hidden in Middle of text.  ', '04.09.2018', 'Passage of Lorem Ipsum, you need to be sure there isn''t anything embarrassing hidden in Middle of text. All the.Passage of Lorem Ipsum, you need to be sure there isn''t anything embarrassing hidden in Middle of text. All the.Passage of Lorem Ipsum, you need to be sure there isn''t anything embarrassing hidden in Middle of text.  ', '/Content/image/cache/catalog/blog1-910x700.jpg')
GO

CREATE TABLE Comment
(
	CommentId INT IDENTITY(1, 1) NOT NULL,
	Author VARCHAR(255) NOT NULL,
	UserEmail VARCHAR(255) NOT NULL,
	UserComment VARCHAR(255) NOT NULL,
	CommentCreationDate DATE NOT NULL DEFAULT GETDATE(),
	BlogId INT NOT NULL
	CONSTRAINT PK_CommentId PRIMARY KEY (CommentId),
	CONSTRAINT FK_BlogId FOREIGN KEY (BlogId) REFERENCES Blog (BlogId) ON DELETE CASCADE ON UPDATE CASCADE
)
GO

INSERT INTO Comment VALUES
('Janak', 'janak@gmail.com', 'Mrs. Darling first heard of Peter when she was tidying up her children’s minds. Lorem ipsum dolor sit amet, consectetur adipiscing elit', '04.09.2018', 1)
GO

CREATE TABLE Contact
(
	ContactId INT IDENTITY(1, 1) NOT NULL,
	UserName VARCHAR(255) NOT NULL,
	UserEmail VARCHAR(255) NOT NULL,
	UserMessage VARCHAR(255) NOT NULL
	CONSTRAINT PK_ContactId PRIMARY KEY (ContactId)
)
GO

SELECT * FROM Blog
SELECT * FROM Brand
SELECT * FROM Category
SELECT * FROM Contact
SELECT * FROM Comment
SELECT * FROM Product
GO