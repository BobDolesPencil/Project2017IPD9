create schema Media;
select * from [Libraries].[MediaFiles];
alter table [Libraries].[MediaFiles] add userId varchar(30) not null;
alter table [Libraries].[MediaFiles] add constraint MediaFiles_userId_fk foreign key(userID) references 