Create database Test1
Go
use Test1
Go
CREATE TABLE dbo.Person
(
  Id int primary key identity(1,1),
    FName nvarchar(50) ,
	LName nvarchar(50),
	PhoneNumber  varchar(13),
	TelNumber1  varchar(11),
	TelNumber2  varchar(11),
	HomeAddress varchar(100)
	
	
	);