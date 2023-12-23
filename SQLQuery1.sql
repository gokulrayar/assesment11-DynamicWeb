create database ContentDB
on primary (name='Day12_Db', Filename='D:\mphasis Simplilearn\Phase2\Day12\Day12_Db.mdf')
log on (name='Day12_Db_log',filename='D:\mphasis Simplilearn\Phase2\Day4\Day12_Db_log.ldf')
COLLATE SQL_Latin1_General_CP1_CI_AS


use ContentDB

create table Article
(Id int Primary key,
Title nvarchar(50) null,
Content nvarchar(50) null,
Publishdate date )

Insert into Article values (1,'One piece','Adventure',04-01-2024)
insert into Article values (2,'spy x family','sci-fi',03-03-2024)

select * from Article