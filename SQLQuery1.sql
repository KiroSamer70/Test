Create Database SchoolDB
on primary (Name='SchoolDB',Filename='D:\kirollos SAmer j0323108\Database\SchoolDB.mdf')
Log on (Name='SchoolDB_LOG',Filename='D:\kirollos SAmer j0323108\Database\SchoolDB_LOG.ldf')
use SchoolDB

Create Table Class
(
Cid int primary key identity(5,5),
CName Nvarchar(10),
CSeats int
)
Alter table Class
Add [Password] int

Create Table Students
(
St_ID int primary key identity(5,5),
St_Name Nvarchar(25),
Cid int,Foreign key (Cid)references Class (Cid)
)

