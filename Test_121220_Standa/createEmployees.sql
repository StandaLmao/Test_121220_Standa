CREATE TABLE Employees (
	id int IDENTITY(0,1) PRIMARY KEY, 
	firstName varchar(20),
	lastName varchar(20),
	phoneNum varchar(9),
	email varchar(50),
	birthDate varchar(30)
)