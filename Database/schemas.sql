-- ================================================
-- Create Schema Template for Windows Azure SQL Database
-- ================================================

create schema Users;
GO;

create table Users.UserLogin
(
userId varchar(30) not null unique,
pass varchar(20) not null
);
GO;

select * from Users.UserLogin;




