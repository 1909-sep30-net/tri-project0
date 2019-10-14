--Where I'll store my tables and data for my watch store for project 0

CREATE TABLE Customer
(
  CID INT				NOT NULL,
  Names VARCHAR(30)		NOT NULL,
  Addresses VARCHAR(50)	NOT NULL,
  Phone INT				NOT NULL,
  PRIMARY KEY (CID)
);

CREATE TABLE Orders
(
  OID INT					NOT NULL,
  Order_Type VARCHAR(30)	NOT NULL,
  Order_Time DATE			NOT NULL,
  CID INT					NOT NULL,
  PRIMARY KEY (OID),
  FOREIGN KEY (CID) REFERENCES Customer(CID)
);

CREATE TABLE Product
(
  Names VARCHAR(30)			NOT NULL,
  PID INT					NOT NULL,
  Price INT					NOT NULL,
  Model VARCHAR(30)			NOT NULL,
  PRIMARY KEY (PID)
);

CREATE TABLE Customer_Order
(
  Amount INT			NOT NULL,
  OID INT				NOT NULL,
  PID INT				NOT NULL,
  FOREIGN KEY (OID) REFERENCES Orders(OID),
  FOREIGN KEY (PID) REFERENCES Product(PID)
);

CREATE TABLE Locations
(
  Located VARCHAR(30)	NOT NULL,
  LID INT				NOT NULL,
  Inventory INT			NOT NULL,
  PRIMARY KEY (Located),
  UNIQUE (LID)
);

CREATE TABLE Inventory
(
  Quantity INT			NOT NULL,
  Located VARCHAR(30)	NOT NULL,
  PID INT				NOT NULL,
  FOREIGN KEY (Located) REFERENCES Locations(Located),
  FOREIGN KEY (PID) REFERENCES Product(PID)
);

Drop Table Customer;  --6


Drop Table Orders; --3


Drop Table Product; --4

Drop Table dbo.Customer_Order; --1


Drop Table Locations; --5


Drop Table Inventory; --2



Insert Into Customer(CID, Names, Addresses, Phone) Values(1, 'Rotty Tops', 'Sequin Land', 8675309);
Delete From Customer Where Customer.CID = 1;

Select* From Customer;
Select* From Orders;
Select* From Product;
Select* From Customer_Order;
Select* From Locations;
Select* From Inventory; 
