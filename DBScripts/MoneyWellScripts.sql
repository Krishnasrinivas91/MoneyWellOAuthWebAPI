Create Table Customer
(
	Id int Identity(1,1) PRIMARY KEY,
	CustomerName nvarchar(50),

)

Create Table BankAccount
(
	Id int Identity(1,1),
	CustomerId int FOREIGN KEY references Customer(Id),
	AccountBalance money null
)


INSERT INTO Customer values ('Julien')
INSERT INTO Customer values ('Thibault')
INSERT INTO Customer values ('Merci')
INSERT INTO Customer values ('Abhi')
INSERT INTO Customer values ('Shiv')


Insert INTO BankAccount values(1, 25000)
Insert INTO BankAccount values(2, 50000)
Insert INTO BankAccount values(3, 2500)
Insert INTO BankAccount values(4, 15000)
Insert INTO BankAccount values(5, 205000)