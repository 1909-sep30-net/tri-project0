--Where I'll store my tables and data for my watch store for project 0
--Last edit 10-15-19
CREATE TABLE Customer 
(
  CID INT IDENTITY(1,1)			,
  Names VARCHAR(30)		NOT NULL,
  Addresses VARCHAR(50)	NOT NULL,
  Phone VARCHAR(15)		NOT NULL,
  PRIMARY KEY (CID)
);

CREATE TABLE Orders
(
  OID INT IDENTITY(1,1)		NOT NULL,
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
  PID INT IDENTITY(1,1)		NOT NULL,
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
  LID INT IDENTITY(1,1)			,
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

--Insert Into Product(Names, Price, Model) Values('Omega', 4500, 'Seamaster');
--Insert Into Product(Names, Price, Model) Values('Rolex', 5700, 'Datejust');
--Insert Into Product(Names, Price, Model) Values('Grand Seiko', 5500, 'Snowflake');
--Insert Into Product(Names, Price, Model) Values('IWC', 1200, 'Flieger');
--Insert Into Product(Names, Price, Model) Values('Timex', 200, 'Marlin');

--Insert Into Locations(Located, Inventory) Values('Geneva', 100); 
--Insert Into Locations(Located, Inventory) Values('Brooklyn', 50); 
--Insert Into Locations(Located, Inventory) Values('Anaheim', 150); 

--Insert Into Inventory(LID, PID, Quantity) Values(1, 1, 2);

--Insert Into Orders(OID, CID, LID, Order_Type, Order_Time) Values(1, 2, 1, 'Stainless steel', '2019-10-15');

--Insert Into Customer_Order(OID, PID, Amount) Values(1, 1, 2);

--Update Customer
--Set Names = 'Rotty Tops', Addresses = 'Sequin Land', Phone = 8675309
--Where CID = 3;

--Update Customer
--Set Names = 'Cloud Strife', Addresses = 'Midgar', Phone = 7776655
--Where CID = 4;

--Update Locations
--Set Inventory = 300
--Where Located = 'Geneva';

--Select*
--From Orders
--Where CID = 2;

--Select*
--From Customer, Orders, Product
--Where Customer.CID = Orders.CID; 

--Select* From Customer; --3
--Select* From Orders; 
--Select* From Product; --5
--Select* From Customer_Order;
--Select* From Locations; --2
--Select* From Inventory; 