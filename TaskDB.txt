create database TaskDB
use TaskDB
create table Users
(
	UserID int primary key identity(1,1),
	UserName nvarchar(50),
	UserPass nvarchar(50),
	Role nvarchar(50) check (Role in('admin' , 'user'))
)

insert into Users
values ('mario' , '123' , 'admin'),
('kiro' , '456' , 'user'),
('ayman' , '789' , 'user')

select * from Users

create table Tasks
(
	TaskID int primary key,
	TaskTitle nvarchar(50),
	Description nvarchar(50),
	Status nvarchar(50) check (Status in('pending' , 'in progress' , 'completed')),
	DueDate datetime
)

insert into Tasks
values(1 ,'Front-End' , 'finish header' , 'pending' , '2024-11-27'),
(2,'Back-End' , 'finish sql' , 'pending' ,'2024-11-27'),
(3 ,'game dev' , 'finish unity' , 'in progress' ,'2024-11-27')

select * from Tasks

