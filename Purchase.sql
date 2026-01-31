Create DataBase Purchase
Go

Use Purchase
GO 

 CREATE TABLE Client
 (
    ClientIDNumber INT NOT NULL,
    ClientName VARCHAR(40) NULL,
   ClientPassword VARCHAR(40) NULL,
   ClientAddress VARCHAR(100) Null,
   ClientEmail VARCHAR(15) Null,
   clientPhone VARCHAR(15) NULL,
   Questions VARCHAR(15) NULL,
   AccountBalance DECIMAL(5,2)Null,
   DateOpened DATETIME NULL,
   PRIMARY KEY (ClientIDNumber)
 )
 GO 

 Create TABLE Acccount
 (
  accountID INT not null Identity(1,1),
  accountDateOpened DATETIME not null,
  accountBalance Decimal(5,2) NOT NULL,
  ClientIDNumber INT not null
 CONSTRAINT ClientIDNumber_FK FOREIGN KEY(ClientIDNumber) REFERENCES Client (ClientIDNumber)
 PRIMARY KEY(accountID) 
 )
 GO 


 CREATE TABLE Transactions
 (
 transID INT not null IDENTITY(1,1),
 acccountID INT null REFERENCES Acccount(accountID),
 destinationAccount VARCHAR(15)NOT NULL,
 sourceAccount VARCHAR(15) NOT NULL,
 transAmount DECIMAL(5,2) NOT NULL,
 transDATE DATETIME NOT NULL,
 PRIMARY KEY(transID),
 )
 Go 

