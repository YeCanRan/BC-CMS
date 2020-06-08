--创建数据库
use master
go

if exists(select name from sys.databases where name='BC_CMSDB')
drop database BC_CMSDB
go

create database BC_CMSDB
on primary
(name=BC_CMS_data,filename='C:\Data\BC_CMS_data.mdf',size=5,filegrowth=20%)
log on
(name=BC_CMS_log,filename='C:\Data\BC_CMS_log.mdf',size=3,filegrowth=20%)
go

--创建数据表
use BC_CMSDB
go

if OBJECT_ID('Privilege','U') is not null
drop table Privilege
go
create table Privilege
(
	Level int primary key not null,
	CreateChild int not null default 0,
	Remark text,
)

if OBJECT_ID('Employee','U') is not null
drop table Employee
go
create table Employee
(
	No char(6) primary key not null default '000000',
	Password char(32) not null,
	Name varchar(8) not null,
	Sex char(2) not null,
	Nation varchar(8) not null,
	NativePlace varchar(16) not null,
	Political varchar(8) not null,
	Class varchar(8) not null,
	Shift int not null,
	Salary int not null,
	Tel char(11) not null default '00000000000',
	Address varchar(32) not null default '--',
	PrivilegeLevel int not null foreign key references Privilege(Level),
	IDCardNo char(18) not null default '000000000000000000',
	BankCardNo varchar(19) not null,
	BirthDay date not null,
	MaritalStatus int not null,
	DateOfEmployment date not null,
	Remark text,
)

if OBJECT_ID('Member','U') is not null
drop table Member
go
create table Member
(
	CardNo char(6) primary key not null default '000000',
	Password char(32) not null,
	Name varchar(8) not null,
	Sex char(2) not null,
	IDCardNo char(18) not null default '000000000000000000',
	Tel char(11) not null default '00000000000',
	Address varchar(32) not null default '--',
	HandleDate date not null,
	HandlePerson char(6) not null foreign key references Employee(No),
	Balance int not null default 0,
	Remark text,
)

if OBJECT_ID('Consumer','U') is not null
drop table Consumer
go
create table Consumer
(
	No varchar(3) primary key not null,
	Sex char(2) not null,
	CardNo char(6) not null default '000000',-- foreign key references Member(CardNo)
	Remark text,
)

if OBJECT_ID('Price','U') is not null
drop table Price
go
create table Price
(
	No char(2) primary key not null default '00',
	Name varchar(16) not null,
	Class varchar(8) not null,
	Price int not null,
	VIPPrice int not null,
	Remark text,
)

if OBJECT_ID('Revenue','U') is not null
drop table Revenue
go
create table Revenue
(
	No int primary key not null identity,
	Class varchar(8) not null,
	Date date not null,
	RevenuesOrExpenditure int not null,
	Price int not null,
	Remark text,
)

if OBJECT_ID('Item','U') is not null
drop table Item
go
create table Item
(
	No char(2) primary key not null,
	Name varchar(8) not null,
	Class varchar(8) not null,
	Numbers int not null default 0,
	TotalReserves int not null default 0,
	Remark text,
)

if OBJECT_ID('Consumption','U') is not null
drop table Consumption
go
create table Consumption
(
	CustomerNo varchar(3) not null foreign key references Consumer(No),
	PriceNo char(2) not null default '00' foreign key references Price(No),
	--ConPrice int not null,
	constraint pk primary key (CustomerNo,PriceNo)
)

if OBJECT_ID('Coupon','U') is not null
drop table Coupon
go
create table Coupon
(
	No int primary key not null identity,
	Class varchar(8) not null,
	Discount int not null default 0,
	Equivalent int not null default 0,
	HandlePerson char(6) not null foreign key references Employee(No),
	Numbers int not null default 0,
	Remark text,
)

--创建视图
--这个不对，先留着
if exists (select * from sys.objects where name = 'ViewSettleAccounts')
drop view ViewSettleAccounts
go
create view ViewSettleAccounts as
	select No,Sex,SUM(Price) as Price,CardNo from (select Consumer.No,Consumer.Sex,Price.Price,Consumer.CardNo from Consumer,Consumption,Price where Consumption.CustomerNo=Consumer.No and Consumption.PriceNo=Price.No)as a group by No,Sex,CardNo
go

if exists (select * from sys.objects where name = 'ViewMemberInformation')
drop view ViewMemberInformation
go
create view ViewMemberInformation as
	select CardNo,Name,Sex,Tel,Address,HandleDate,Balance from Member
go


if exists (select * from sys.objects where name = 'ViewMemberInformationEdit')
drop view ViewMemberInformationEdit
go
create view ViewMemberInformationEdit as
	select * from Member
go

if exists (select * from sys.objects where name = 'ViewEmployeeInformation')
drop view ViewEmployeeInformation
go
create view ViewEmployeeInformation as
	select No,Name,Sex,Tel,Address,DateOfEmployment,BankCardNo from Employee
go

if exists (select * from sys.objects where name = 'ViewEmployeeInformationEdit')
drop view ViewEmployeeInformationEdit
go
create view ViewEmployeeInformationEdit as
	select * from Employee
go

if exists (select * from sys.objects where name = 'ViewEmployeeClass')
drop view ViewEmployeeClass
go
create view ViewEmployeeClass as
	select distinct Class from Employee 
go

if exists (select * from sys.objects where name = 'ViewPrice')
drop view ViewPrice
go
create view ViewPrice as
	select Name,Price from Price
go

if exists (select * from sys.objects where name = 'ViewItem')
drop view ViewItem
go
create view ViewItem as
	select Class,Numbers,TotalReserves from Item
go

if exists (select * from sys.objects where name = 'ViewCoupon')
drop view ViewCoupon
go
create view ViewCoupon as
	select Class,Discount,Equivalent,Numbers,HandlePerson from Coupon
go

if exists (select * from sys.objects where name = 'ViewConsumerNumbers')
drop view ViewConsumerNumbers
go
create view ViewConsumerNumbers as
	select COUNT(No) as ConsumerNumbers from Coupon
go

if exists (select * from sys.objects where name = 'ViewItemNumbers')
drop view ViewItemNumbers
go
create view ViewItemNumbers as
	select Name,Numbers from Item
go

if exists (select * from sys.objects where name = 'ViewRevenues')
drop view ViewRevenues
go
create view ViewRevenues as
	select Price,Date from Revenue where RevenuesOrExpenditure=0
go

if exists (select * from sys.objects where name = 'ViewExpenditure')
drop view ViewExpenditure
go
create view ViewExpenditure as
	select Price,Date from Revenue where RevenuesOrExpenditure=1
go

--创建存储过程
--返回值为0，管理员登录
--返回值为1，店长登录
--返回值为2，经理登录
--返回值为3，前台登录
--返回值为4，后勤登录
--返回值为5，权限不足
--返回值为6，密码错误
--返回值为7，用户名错误
if OBJECT_ID('UserLogin','P') is not null
drop procedure UserLogin
go

create procedure [dbo].[UserLogin] @No char(6),@Password char(32) as
	if exists(select * from Employee where No=@No and Password=@Password and PrivilegeLevel=0)
		return 0
	if exists(select * from Employee where No=@No and Password=@Password and PrivilegeLevel=1)
		return 1
	if exists(select * from Employee where No=@No and Password=@Password and PrivilegeLevel=2)
		return 2
	if exists(select * from Employee where No=@No and Password=@Password and PrivilegeLevel=3)
		return 3
	if exists(select * from Employee where No=@No and Password=@Password and PrivilegeLevel=4)
		return 4
	if exists(select * from Employee where No=@No and Password=@Password and PrivilegeLevel=5)
		return 5
	if exists(select * from Employee where No=@No and Password<>@Password)
		return 6
	if not exists(select * from Employee where No=@No)
		return 7

--删除会员
if OBJECT_ID('MemberDelete','P') is not null
drop procedure MemberDelete
go

create procedure [dbo].[MemberDelete] @CardNo char(6) as
	delete from Member where CardNo=@CardNo
go

--提交会员修改信息
if OBJECT_ID('SubmitMemberEdit','P') is not null
drop procedure SubmitMemberEdit
go

create procedure [dbo].[SubmitMemberEdit] @CardNo char(6),@Password char(32),@Name varchar(8),@Sex char(2),@IDCardNo char(18),@Tel char(11), @Address varchar(32),@Balance int,@Remark text as
	update Member set Password=@Password,Name=@Name,Sex=@Sex,IDCardNo=@IDCardNo,Tel=@Tel,Address=@Address,Balance=@Balance,Remark=@Remark where CardNo=@CardNo
go

--提交会员办理信息
if OBJECT_ID('SubmitMemberHandle','P') is not null
drop procedure SubmitMemberHandle
go

create procedure [dbo].[SubmitMemberHandle] @CardNo char(6),@Password char(32),@Name varchar(8),@Sex char(2),@IDCardNo char(18),@Tel char(11), @Address varchar(32),@HandleDate Date,@HandlePerson char(6),@Balance int,@Remark text as
	insert into Member values(@CardNo,@Password,@Name,@Sex,@IDCardNo,@Tel,@Address,@HandleDate,@HandlePerson,@Balance,@Remark)
go

--充值
if OBJECT_ID('Recharge','P') is not null
drop procedure Recharge
go

create procedure [dbo].[Recharge] @CardNo char(6),@Password char(32),@Balance int as
	update Member set Balance+=@Balance where CardNo=@CardNo and Password=@Password
go
