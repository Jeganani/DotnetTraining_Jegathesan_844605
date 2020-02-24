create database empdb;
use empdb;
create table employe
(
 empID int primary key not null,
 salary int not null,
 name varchar(50) not null,
 depID smallint not null);
 insert into employe values(1,10000,'jegan',5);
 insert into employe values(2,15000,'mohan',3);
 insert into employe values(3,17000,'vijay',7);
 insert into employe values(4,19000,'karthick',8);
 drop table employe;
create table department
(
depID int not null,
deoname varchar(50) not null);
insert into department values(1,'technichal');
insert into department values(2,'admin');
insert into department values(3,'stores');
insert into department values(3,null);
select reverse(deoname) from department;
select da(getdate());
