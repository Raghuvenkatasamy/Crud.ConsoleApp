use Batch7

CREATE TABLE MobileDetails
(
    MobileId bigint NOT NULL primary key identity(1,1),
	Name varchar(50) NOT NULL,
	ManufactureName nvarchar(50) NOT NULL,
	DateofMaufacture date NOT NULL,
	YearofMaufacture bigint NOT NULL,
	Quantity int not null
) 

drop table MobileDetails
truncate table MobileDetails
select*from  MobileDetails

select * from MobileDetails

--Insert
create procedure InsertMobileDetails
@Name varchar(50),@ManufactureName nvarchar(50),@DateofMaufacture date,@YearofMaufacture bigint,@Quantity int
as
begin
insert into MobileDetails values(@Name,@ManufactureName,@DateofMaufacture,@YearofMaufacture,@Quantity)
end

drop procedure InsertMobileDetails

exec InsertMobileDetails 'sss','qwer','11/11/1111',2003,2

--Update

create procedure UpdateMobileDetails
@MobileId bigint,@Name varchar(50),@ManufactureName nvarchar(50),@DateofMaufacture date,@YearofMaufacture bigint,@Quantity int
as
begin
update MobileDetails set Name=@Name,ManufactureName=@ManufactureName,DateofMaufacture=@DateofMaufacture,YearofMaufacture=@YearofMaufacture,Quantity=@Quantity  where MobileId=@MobileId
end

drop procedure UpdateMobileDetails
exec UpdateMobileDetails 1,'www','qwer','11/11/1111',2003,2
select * from MobileDetails

--Delete
create procedure DeleteMobileDetails
@MobileId bigint 
as
begin
delete from MobileDetails where MobileId=@MobileId
end

exec DeleteMobileDetails 1

-- select

create procedure ReadMobileDetails
as
begin
select * from MobileDetails
end

exec InsertMobileDetails
exec UpdateMobileDetails
exec DeleteMobileDetails
exec ReadMobileDetails

select * from MobileDetails
