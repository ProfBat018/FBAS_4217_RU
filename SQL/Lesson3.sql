-- ctrl + enter

-- select * from Students;
--
--
-- select * from Students
-- where id % 2 = 0;



-- drop table Students;
--
-- create table Teachers(
--   Id int primary key identity(1, 1),
--   Name nvarchar(15) not null,
--   Surname nvarchar(15) not null,
--   Patronimic nvarchar(15),
--   Salary smallmoney not null,
--   Email nvarchar not null check(Email like '%_@__%.__%')
-- );
--
-- alter table Teachers alter column Email nvarchar(30)
--
-- insert into Teachers(Name, Surname, Patronimic, Salary, Email) values (N'Elvin', N'Azimov', N'Rasul', 666, N'azimov_e@itstep.org')
--
-- select * from Teachers




create table Faculty(
    Id int primary key identity(1, 1),
    Name nvarchar(15) NOT NULL
)

create table Groups(
    Id int primary key identity(1, 1),
    Name nvarchar(15) NOT NULL,
    FacultyId int foreign key references Faculty(Id)
)

--
-- insert into  Faculty(Name) values(N'Programming')
-- insert into  Faculty(Name) values(N'Networking')
-- insert into  Faculty(Name) values(N'Design')
--
-- insert into Groups(Name, FacultyId) values(N'FBAS_4217', 1);
-- insert into Groups(Name, FacultyId) values(N'FBMS_1211', 1);
-- insert into Groups(Name, FacultyId) values(N'FBAS_1221', 1);
--
-- insert into Groups(Name, FacultyId) values(N'FBAS_4212', 2);
-- insert into Groups(Name, FacultyId) values(N'FBBB_1661', 2);
--
-- insert into Groups(Name, FacultyId) values(N'FBBB_1345', 3);
-- insert into Groups(Name, FacultyId) values(N'FBBA_1527', 3);
-- insert into Groups(Name, FacultyId) values(N'FBBC_1689', 3);
-- insert into Groups(Name, FacultyId) values(N'FBCB_1061', 3);
-- insert into Groups(Name, FacultyId) values(N'FBGJ_1635', 3);


-- select Groups.Id, Groups.Name, GroupFaculty.Name
-- from Groups
-- inner join Faculty as GroupFaculty on GroupFaculty.Id = Groups.FacultyId
-- where GroupFaculty.Id = 1
--
--
-- select * from Groups


-- select Id as GroupId, Name as GroupName from Groups


-- select CONCAT('Id is: ', Id)
-- from Groups

use Shop;
go

select * from OrderProducts
inner join Orders O on O.Id = OrderProducts.OrderId
inner join OrderProducts OP on O.Id = OP.OrderId


select * from Products
inner join Categories C on C.Id = Products.CategoryId


-- insert into Categories(Title) Values(N'Phones');
-- insert into Categories(Title) Values(N'Laptops');

select * from Categories

insert into Products(Title, ImageUrl, Price, Description, CategoryId) Values(N'Iphone13', N'https://optimal.az/image/cache/catalog/products/telefon-ve-planshetler/telefonlar-ve-planshetler/iphone-13-midnight-select-2021-400x400.png?v=6', 1650.99, N'Iphone 13 128GB', 5);


