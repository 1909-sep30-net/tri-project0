--Where I'll store my tables and data for my watch store for project 0
--Last edit 10-15-19
CREATE TABLE Customer 
(
  CID INT				NOT NULL,
  Names VARCHAR(30)		NOT NULL,
  Addresses VARCHAR(50)	NOT NULL,
  Phone VARCHAR(15)		NOT NULL,
  PRIMARY KEY (CID)
);

CREATE TABLE Orders
(
  OID INT					NOT NULL,
  CID INT					NOT NULL,
  LID INT					NOT NULL,
  Order_Type VARCHAR(30)	NOT NULL,
  Order_Time DATE			NOT NULL,
  PRIMARY KEY (OID),
  FOREIGN KEY (CID) REFERENCES Customer(CID),
  FOREIGN KEY(LID) REFERENCES Locations(LID)
);

CREATE TABLE Product
(
  PID INT					NOT NULL,
  Names VARCHAR(30)			NOT NULL,
  Price INT					NOT NULL,
  Model VARCHAR(30)			NOT NULL,
  PRIMARY KEY (PID)
);

CREATE TABLE Customer_Order
(
  OID INT				NOT NULL,
  PID INT				NOT NULL,
  Amount INT			NOT NULL,
  FOREIGN KEY (OID) REFERENCES Orders(OID),
  FOREIGN KEY (PID) REFERENCES Product(PID),
  CONSTRAINT CompKey_OP PRIMARY KEY (OID, PID)
);

CREATE TABLE Locations
(
  LID INT				NOT NULL,
  Located VARCHAR(30)	NOT NULL,
  Inventory INT			NOT NULL,
  PRIMARY KEY (LID)
);

CREATE TABLE Inventory
(
  LID INT				NOT NULL,
  PID INT				NOT NULL,
  Quantity INT			NOT NULL,
  FOREIGN KEY (LID) REFERENCES Locations(LID),
  FOREIGN KEY (PID) REFERENCES Product(PID),
  CONSTRAINT CompKey_LP PRIMARY KEY(LID, PID)
);

--Drop Table Customer;  --6


--Drop Table Orders; --3


--Drop Table Product; --4

--Drop Table dbo.Customer_Order; --1


--Drop Table Locations; --5


--Drop Table Inventory; --2



--Insert Into Customer(CID, Names, Addresses, Phone) Values(1, 'Rotty Tops', 'Sequin Land', 8675309);
--Insert Into Customer(CID, Names, Addresses, Phone) Values(2, 'Cloud Strife', 'Midgar', 4548787);
--Delete From Customer Where Customer.CID = 1;
--Delete From Customer Where Customer.CID = 2;

--Insert Into Product(PID, Names, Price, Model) Values(1, 'Omega', 4500, 'Seamaster');

--Insert Into Locations(LID, Located, Inventory) Values(1, 'Morrowind', 100); 

--Insert Into Inventory(LID, PID, Quantity) Values(1, 1, 2);

--Insert Into Orders(OID, CID, LID, Order_Type, Order_Time) Values(1, 2, 1, 'Stainless steel', '2019-10-15');

--Select*
--From Orders
--Where CID = 2;

--Select*
--From Customer, Orders, Product
--Where Customer.CID = Orders.CID; 

--Select* From Customer; --2
--Select* From Orders; --1
--Select* From Product; --1
--Select* From Customer_Order;
--Select* From Locations; --1
--Select* From Inventory; --1
