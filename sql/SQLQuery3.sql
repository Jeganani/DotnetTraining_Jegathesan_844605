create database empdb;
use empdb;
create table Product
(
productID int not null,
productname varchar(50) not null);

insert into Product values(102,'garnier');
insert into Product values(103,'nivea');
insert into Product values(104,'clean&clear');
insert into Product values(105,'ponds');
create table orders
(
orderID int not null,
productID varchar(50) not null);

insert into orders values(1021,102);
insert into orders values(1032,102);
insert into orders values(1041,103);
insert into orders values(1052,104);
insert into orders values(1045,103);
insert into orders values(1062,104);
Select Product.*,orders.* From Product INNER JOIN orders ON Product.ProductID=orders.ProductID; 
