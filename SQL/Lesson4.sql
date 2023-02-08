-- create database Showroom
--

create table Cars
(
    [Id]    int primary key identity (1, 1),
    [Make]  nvarchar(30) NOT NULL,
    [Model] nvarchar(30) NOT NULL,
    [Year]  date check ( [Year] > '01/01/2008' and [Year] < FORMAT(getdate(), 'dd.MM.yy'))
);

create table Salesman
(
    [Id]         int primary key identity (1, 1),
    [PersonId]   int foreign key references Person (Id),
    [SalesCount] int
);


create table Customers
(
    [Id]       int primary key identity (1, 1),
    [PersonId] int foreign key references Person (Id)
);

create table Sales
(
    [Id]         int primary key identity (1, 1),
    [SalesmanId] int NOT NULL foreign key references Salesman (Id),
    [CarId]      int NOT NULL foreign key references Cars (Id),
    [PersonId]   int NOT NULL foreign key references Person (Id)
);

create table Person
(
    [Id]      int primary key identity (1, 1),
    [Name]    nvarchar(30) NOT NULL,
    [Surname] nvarchar(30) NOT NULL,
    [Age]     int check ([Age] > 18 and [Age] < 75)
);


create table Manager
(
    [Id] int primary key identity (1, 1),

)

insert into Cars (Make, Model, Year)
values ('Chevrolet', 'Lumina', 1994);
insert into Cars (Make, Model, Year)
values ('Pontiac', 'Fiero', 1988);
insert into Cars (Make, Model, Year)
values ('Ford', 'Econoline E250', 2002);
insert into Cars (Make, Model, Year)
values ('Chevrolet', 'Camaro', 2002);
insert into Cars (Make, Model, Year)
values ('Mazda', 'Tribute', 2008);
insert into Cars (Make, Model, Year)
values ('Jeep', 'Patriot', 2008);
insert into Cars (Make, Model, Year)
values ('Nissan', 'Sentra', 1993);
insert into Cars (Make, Model, Year)
values ('Acura', 'NSX', 2005);
insert into Cars (Make, Model, Year)
values ('Lexus', 'CT', 2011);
insert into Cars (Make, Model, Year)
values ('Nissan', 'Murano', 2012);
insert into Cars (Make, Model, Year)
values ('Jeep', 'Cherokee', 1996);
insert into Cars (Make, Model, Year)
values ('Lincoln', 'Continental', 1990);
insert into Cars (Make, Model, Year)
values ('GMC', 'Sierra 3500', 2002);
insert into Cars (Make, Model, Year)
values ('Oldsmobile', '88', 1999);
insert into Cars (Make, Model, Year)
values ('Ford', 'Focus', 2003);


alter table Cars
    alter column [Year] int

alter table Cars
    add constraint CK_Year check ([Year] >= 1988 and [Year] < 2022)

select *
from Cars

alter table Salesman
    add constraint CK_Count check ([SalesCount] < 100)


insert into Person (Name, Surname, Age)
values ('Gian', 'Jaskowicz', 41);
insert into Person (Name, Surname, Age)
values ('Yelena', 'Telezhkin', 47);
insert into Person (Name, Surname, Age)
values ('Gayla', 'Card', 27);
insert into Person (Name, Surname, Age)
values ('Efrem', 'Garfield', 45);
insert into Person (Name, Surname, Age)
values ('Dal', 'Le Page', 19);
insert into Person (Name, Surname, Age)
values ('Milty', 'Drivers', 25);
insert into Person (Name, Surname, Age)
values ('Truda', 'Wasson', 55);
insert into Person (Name, Surname, Age)
values ('Elora', 'Chart', 51);
insert into Person (Name, Surname, Age)
values ('Corina', 'Howen', 47);
insert into Person (Name, Surname, Age)
values ('Tiertza', 'Castle', 20);
insert into Person (Name, Surname, Age)
values ('Hort', 'Quenby', 54);
insert into Person (Name, Surname, Age)
values ('Margarette', 'Puleston', 44);
insert into Person (Name, Surname, Age)
values ('Janessa', 'Ruddock', 45);
insert into Person (Name, Surname, Age)
values ('Andrus', 'Briskey', 54);
insert into Person (Name, Surname, Age)
values ('Bidget', 'Carruth', 35);
insert into Person (Name, Surname, Age)
values ('Vicki', 'Mennear', 23);
insert into Person (Name, Surname, Age)
values ('Colline', 'Hunter', 51);
insert into Person (Name, Surname, Age)
values ('Donella', 'Gold', 47);
insert into Person (Name, Surname, Age)
values ('Gaspard', 'Northall', 35);
insert into Person (Name, Surname, Age)
values ('Gertrudis', 'Soutar', 24);
insert into Person (Name, Surname, Age)
values ('Ruthy', 'Bawcock', 26);
insert into Person (Name, Surname, Age)
values ('Cherey', 'Dawney', 37);
insert into Person (Name, Surname, Age)
values ('Dallis', 'Troppmann', 50);
insert into Person (Name, Surname, Age)
values ('Virginia', 'Metzig', 27);
insert into Person (Name, Surname, Age)
values ('Leodora', 'Motto', 23);
insert into Person (Name, Surname, Age)
values ('Saundra', 'Everall', 20);
insert into Person (Name, Surname, Age)
values ('Bernadine', 'Mayston', 45);
insert into Person (Name, Surname, Age)
values ('Cari', 'Pitchford', 31);
insert into Person (Name, Surname, Age)
values ('Mame', 'Philipet', 22);
insert into Person (Name, Surname, Age)
values ('Timotheus', 'Kuhlmey', 21);



DECLARE @i int = 1

while @i <= 15
    begin
        insert into Customers (PersonId) values (@i);
        set @i = (@i + 1)
    end


select *
from Customers
         inner join Person P on P.Id = Customers.PersonId


DECLARE @i int = 16

while @i <= 30
    begin
        insert into Salesman (PersonId, SalesCount) values (@i, rand(40));
        set @i = (@i + 1)
    end


select Salesman.Id as SalesmanId,
       Salesman.SalesCount,
       Person.Name as Name,
       Person.Surname as Surname,
       Person.Age as Age
from Salesman
         inner join Person on Person.Id = Salesman.PersonId


select  Salesman.Id as SalesmanId,
       Salesman.SalesCount,
       Person.Name as Name,
       Person.Surname as Surname,
       Person.Age as Age
from Salesman
    left join Person on Person.Id = Salesman.PersonId


select  Salesman.Id as SalesmanId,
       Salesman.SalesCount,
       Person.Name as Name,
       Person.Surname as Surname,
       Person.Age as Age
from Salesman
    full outer join Person on Person.Id = Salesman.PersonId
    where  Salesman.Id is NULL
