select * from ProductsUpdated

create table ProductsUpdated(
	ProductID INT PRIMARY KEY IDENTITY(1,1),
	Product_Section nvarchar(20),
	Product nvarchar(20),
	Price decimal,
	Available_Quantity decimal
	);

	delete from ProductsUpdated where ProductID=39
insert into ProductsUpdated (Product_Section,Product,Price,Available_Quantity) Values ('Vegetables','Tomato',18,45);
insert into ProductsUpdated (Product_Section,Product,Price,Available_Quantity) Values ('Vegetables','Potato',32,18);
insert into ProductsUpdated (Product_Section,Product,Price,Available_Quantity) Values ('Vegetables','Cabbage',35,13);
insert into ProductsUpdated (Product_Section,Product,Price,Available_Quantity) Values ('Vegetables','CauliFlower',45,8);
insert into ProductsUpdated (Product_Section,Product,Price,Available_Quantity) Values ('Vegetables','Brinjal',62,26);
insert into ProductsUpdated (Product_Section,Product,Price,Available_Quantity) Values ('Vegetables','Pumpkin',54,20);
insert into ProductsUpdated (Product_Section,Product,Price,Available_Quantity) Values ('Vegetables','Cucumber',26,15);
insert into ProductsUpdated (Product_Section,Product,Price,Available_Quantity) Values ('Vegetables','Onion',70,50);
insert into ProductsUpdated (Product_Section,Product,Price,Available_Quantity) Values ('Vegetables','Carrot',46,25);

insert into ProductsUpdated (Product_Section,Product,Price,Available_Quantity) Values ('Fruits','Apple',250,25);
insert into ProductsUpdated (Product_Section,Product,Price,Available_Quantity) Values ('Fruits','Orange',120,25);
insert into ProductsUpdated (Product_Section,Product,Price,Available_Quantity) Values ('Fruits','Banana',12,45);
insert into ProductsUpdated (Product_Section,Product,Price,Available_Quantity) Values ('Fruits','Pomegranate',180,35);
insert into ProductsUpdated (Product_Section,Product,Price,Available_Quantity) Values ('Fruits','Mango',200,15);
insert into ProductsUpdated (Product_Section,Product,Price,Available_Quantity) Values ('Fruits','Cherry',80,15);
insert into ProductsUpdated (Product_Section,Product,Price,Available_Quantity) Values ('Fruits','Guava',50,18);
insert into ProductsUpdated (Product_Section,Product,Price,Available_Quantity) Values ('Fruits','Watermelon',56,14);
insert into ProductsUpdated (Product_Section,Product,Price,Available_Quantity) Values ('Fruits','Kiwi',110,25);

insert into ProductsUpdated (Product_Section,Product,Price,Available_Quantity) Values ('Grocery','Milk',28,10);
insert into ProductsUpdated (Product_Section,Product,Price,Available_Quantity) Values ('Grocery','Butter',50,8);
insert into ProductsUpdated (Product_Section,Product,Price,Available_Quantity) Values ('Grocery','Bread',28,12);
insert into ProductsUpdated (Product_Section,Product,Price,Available_Quantity) Values ('Grocery','Jam',58,6);
insert into ProductsUpdated (Product_Section,Product,Price,Available_Quantity) Values ('Grocery','Ice Cream',35,15);
insert into ProductsUpdated (Product_Section,Product,Price,Available_Quantity) Values ('Grocery','Snacks',25,45);
insert into ProductsUpdated (Product_Section,Product,Price,Available_Quantity) Values ('Grocery','Cookies',40,25);
insert into ProductsUpdated (Product_Section,Product,Price,Available_Quantity) Values ('Grocery','Juice',50,15);
insert into ProductsUpdated (Product_Section,Product,Price,Available_Quantity) Values ('Grocery','Toothpaste',60,15);
insert into ProductsUpdated (Product_Section,Product,Price,Available_Quantity) Values ('Grocery','Soap',35,45);

insert into ProductsUpdated (Product_Section,Product,Price,Available_Quantity) Values ('Stationary','Note',38,45);
insert into ProductsUpdated (Product_Section,Product,Price,Available_Quantity) Values ('Stationary','Pencil',10,90);
insert into ProductsUpdated (Product_Section,Product,Price,Available_Quantity) Values ('Stationary','Rubber',5,80);
insert into ProductsUpdated (Product_Section,Product,Price,Available_Quantity) Values ('Stationary','Paper',18,45);
insert into ProductsUpdated (Product_Section,Product,Price,Available_Quantity) Values ('Stationary','Pen',10,45);
insert into ProductsUpdated (Product_Section,Product,Price,Available_Quantity) Values ('Stationary','Pelican',28,45);
insert into ProductsUpdated (Product_Section,Product,Price,Available_Quantity) Values ('Stationary','Ink Bottle',48,15);
insert into ProductsUpdated (Product_Section,Product,Price,Available_Quantity) Values ('Stationary','File',18,25);