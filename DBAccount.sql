Use DBCustomer
Create Table Amdin_Table_1(UserId varchar(100),passwordd varchar(100))
insert into Amdin_Table_1 values('seema','seema@123')
Create Table Account_Table1(AccountId int primary key,AccountType varchar(100),Branchcode varchar(100),CName varchar(100),CAge int,CNumber numeric(10,0),CEmail varchar(100),CAddress varchar(100),CDateofBirth DateTime)
insert into Account_Table1 values(11,'SBI','SBIN00044001','seema',26,
'7890654321','seema123@gmail.com','Hyderabad',28/10/2020)

create table Account_logs(logID int primary key , operation nvarchar(20), updateDate Datetime);

create trigger Account_Insert_Trigger
on Account_Table1
for insert
as
insert into Account_logs(logID, operation, updateDate)
select AccountId, 'Data Inserted', GETDATE() from inserted

create trigger Account_Delete_Trigger
on Account_Table1
for insert
as
insert into Account_logs(logID, operation, updateDate)
select AccountId, 'Data Inserted', GETDATE() from inserted

