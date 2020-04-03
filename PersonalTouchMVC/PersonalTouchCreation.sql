DROP DATABASE IF Exists [Personal Touch Database]
CREATE DATABASE	[Personal Touch Database]

DROP TABLE IF EXISTS dbo.Customers
GO

CREATE TABLE dbo.Customers
(
CustomerID INT PRIMARY KEY,
email NVARCHAR(max),
[User Name] NVARCHAR(max),
[First Name] NVARCHAR(max),
[Last Name] NVARCHAR(max),
[Middle Name] NVARCHAR(max),
Password NVARCHAR(max),
[Date Account Created] DateTime,
Adress NVARCHAR(max),
[Phone Number] NVARCHAR(max)
)

DROP TABLE IF EXISTS Contacts
GO
CREATE TABLE Contacts
(
ContactID INT NOT NULL PRIMARY KEY,
CustomerID INT,
[First Name] NVARCHAR(max),
[Last Name] NVARCHAR(max),
[Middle Name] NVARCHAR(max),
Adress NVARCHAR(max)
)

ALTER TABLE Contacts
ADD FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID);

select*
FROM Contacts

DROP TABLE IF EXISTS Payments
GO
CREATE TABLE Payments
(
PaymentID INT PRIMARY KEY,
CustomerID INT,
[Credit Card Name] NVARCHAR(max),
[Credit Card Number] int,
[Card Experation Date] DateTime,
[CVC Code] int,
[Name on Card] NVARCHAR(max),
[Billing Address] NVARCHAR(max),
)
ALTER TABLE Payments
ADD FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID);

DROP TABLE IF EXISTS EventDates
GO
CREATE TABLE EventDates
(
EventID INT PRIMARY KEY,
[Event Name] NVARCHAR(max),
[Event Date] DATETIME,
ContactID INT
)

ALTER TABLE EventDates
ADD FOREIGN KEY (ContactID) REFERENCES Contacts(ContactID);

DROP TABLE IF EXISTS CardBank
GO
CREATE TABLE CardBank
(
CardID INT PRIMARY KEY,
EventID INT,
[Card Front Image Path] NVARCHAR(max),
[Card Back Image Path] NVARCHAR (max),
)
ALTER TABLE CardBank
ADD FOREIGN KEY (EventID) REFERENCES EventDates(EventID);

DROP TABLE IF EXISTS CardTemplate
GO
CREATE TABLE CardTemplate
(
CardID INT PRIMARY KEY,
[Card Name] NVARCHAR(max),
URL NVARCHAR(max),
[Times Template Selected] int,
[Card Category] NVARCHAR(max)
)
DROP TABLE IF EXISTS Pictures
GO
CREATE TABLE Pictures
(
PictureID INT PRIMARY KEY,
URL NVARCHAR(max),
[Picture Name] NVARCHAR(max),
[Times Photo Selected] int,

)
