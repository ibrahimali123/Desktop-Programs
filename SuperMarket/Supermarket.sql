--create database Super_Market

create table Admin_info
(
 adminID   varchar(10) primary key,
 adminName varchar(40),
 adminPassword varchar(20)
)
create table Cashier_info
(
 CashierID   varchar(10) primary key,
 CashierName varchar(40),
 CashierPassword varchar(20)
)
create table Buy
(
 CompanyID   varchar(20) primary key,
 ProductName varchar(40),
 ProductSalary DOUBLE PRECISION,
 ProductDate varchar(20)
)
create table Bills
(
 Quantity   int,
 BillsName varchar(40),
 TotalSalary DOUBLE PRECISION,
 BillsDate varchar(20)
)
insert into Admin_info values( '20120004','ibrahim ali mohammed','123')

select * from  Bills
delete
from Admin_info
where adminID = '20120000'




SELECT SUM(ProductSalary) from Buy