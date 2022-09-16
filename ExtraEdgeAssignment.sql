

create table Customer(
Id int primary key,
Name varchar(50),
Email varchar(50),
Gender varchar(20),
Address varchar(50)
)
select * from Customer
drop table Customer

create table MobileBrand(
Id int ,
BrandName varchar(50),
ModelNo int,
Price int,
Discount int,
From_to_Date date
)
select * from MobileBrand
drop table MobileBrand

insert into MobileBrand values(1,'Vivo 13 Pro',143542542,20000,1000,'2022-08-15');

insert into Customer values(101,'Rajashri','rajashri@gmail.com','Female','Pune')

select * from Customer

create table OrderPlace(
OrderId int primary key,
Name varchar(50),
BrandName varchar(50),
Email varchar(50),
Address varchar(50),
Price int,
From_to_Date date
)
select * from OrderPlace
drop table OrderPlace

insert into OrderPlace values(1,'Ram','Oppo','ram@gmail.com','Pune',23000,'2022-09-15')
