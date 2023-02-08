-- DROP DATABASE Academy

-- create database Academy
use Academy

CREATE TABLE Subjects
(
    Id   INT PRIMARY KEY IDENTITY (1, 1),
    Name NVARCHAR(30) NOT NULL CHECK (Name NOT LIKE '')
)

CREATE TABLE Teachers
(
    Id      INT PRIMARY KEY IDENTITY (1, 1),
    Name    NVARCHAR(30) NOT NULL CHECK (Name NOT LIKE ''),
    Surname NVARCHAR(30) NOT NULL CHECK (Surname NOT LIKE ''),
    Salary  SMALLMONEY   NOT NULL CHECK (Salary > 0 AND Salary < 5000 )
)

CREATE TABLE Curators
(
    Id      INT PRIMARY KEY IDENTITY (1, 1),
    Name    NVARCHAR(30) NOT NULL CHECK (Name NOT LIKE ''),
    Surname NVARCHAR(30) NOT NULL CHECK (Surname NOT LIKE '')
)

CREATE TABLE Faculties
(
    Id        INT PRIMARY KEY IDENTITY (1, 1),
    Financing MONEY        NOT NULL CHECK (Financing <= 100000 AND Financing >= 10000 ),
    Name      NVARCHAR(30) NOT NULL CHECK (Name NOT LIKE '')
)


CREATE TABLE Departments
(
    Id        INT PRIMARY KEY IDENTITY (1, 1),
    Financing MONEY        NOT NULL CHECK (Financing <= 10000 AND Financing >= 1000),
    Name      NVARCHAR(30) NOT NULL CHECK (Name NOT LIKE ''),
    FacultyId INT FOREIGN KEY REFERENCES Faculties (Id)
)


CREATE TABLE Groups
(
    Id           INT PRIMARY KEY IDENTITY (1, 1),
    Name         NVARCHAR(30) NOT NULL CHECK (Name NOT LIKE ''),
    Year         INT          NOT NULL CHECK (Year <= 5 AND Year >= 1),
    DepartmentId INT FOREIGN KEY REFERENCES Departments (Id)
)

CREATE TABLE GroupsCurators
(
    Id        INT PRIMARY KEY IDENTITY (1, 1),
    CuratorId INT FOREIGN KEY REFERENCES Curators (Id),
    GroupId   INT FOREIGN KEY REFERENCES Groups (Id)
)

CREATE TABLE Lectures
(
    Id          INT PRIMARY KEY IDENTITY (1, 1),
    LectureRoom NVARCHAR(15) NOT NULL CHECK (LectureRoom NOT LIKE '') UNIQUE,
    SubjectId   INT FOREIGN KEY REFERENCES Subjects (Id),
    TeacherId   INT FOREIGN KEY REFERENCES Teachers (Id)
)


CREATE TABLE GroupsLectures
(
    Id        INT PRIMARY KEY IDENTITY (1, 1),
    GroupId   INT FOREIGN KEY REFERENCES Groups (Id),
    LectureId INT FOREIGN KEY REFERENCES Lectures (Id)
)


INSERT INTO Faculties(Financing, Name)
VALUES (100000, N'Computer Graphics and Design')
INSERT INTO Faculties(Financing, Name)
VALUES (75000, N'Network and Cybersecurity')
INSERT INTO Faculties(Financing, Name)
VALUES (45000, N'Software Development')

INSERT INTO Departments(Financing, Name, FacultyId)
VALUES (5000, N'2D Art', 1)
INSERT INTO Departments(Financing, Name, FacultyId)
VALUES (10000, N'3D Graphics', 1)
INSERT INTO Departments(Financing, Name, FacultyId)
VALUES (3000, N'Web Design', 1)

INSERT INTO Subjects(Name)
VALUES (N'Photoshop')
INSERT INTO Subjects(Name)
VALUES (N'Illustrator')
INSERT INTO Subjects(Name)
VALUES (N'InDesign')
INSERT INTO Subjects(Name)
VALUES (N'History of art')
INSERT INTO Subjects(Name)
VALUES (N'Advertisement design')

INSERT INTO Subjects(Name)
VALUES (N'3dsMax')
INSERT INTO Subjects(Name)
VALUES (N'Autocad')
INSERT INTO Subjects(Name)
VALUES (N'Maya')
INSERT INTO Subjects(Name)
VALUES (N'Adobe Premiere Pro')
INSERT INTO Subjects(Name)
VALUES (N'Adobe After Effects')

INSERT INTO Subjects(Name)
VALUES (N'UI/UX design')
INSERT INTO Subjects(Name)
VALUES (N'HTML')
INSERT INTO Subjects(Name)
VALUES (N'CSS')


INSERT INTO Departments(Financing, Name, FacultyId)
VALUES (7000, N'System administration', 2)
INSERT INTO Departments(Financing, Name, FacultyId)
VALUES (9000, N'Network administration', 2)
INSERT INTO Departments(Financing, Name, FacultyId)
VALUES (10000, N'Cyber Security', 2)

INSERT INTO Subjects(Name)
VALUES (N'IT Essentials')
INSERT INTO Subjects(Name)
VALUES (N'Cable Management')
INSERT INTO Subjects(Name)
VALUES (N'Linux')
INSERT INTO Subjects(Name)
VALUES (N'Windows Administration')

INSERT INTO Subjects(Name)
VALUES (N'Network Fundamentals')
INSERT INTO Subjects(Name)
VALUES (N'Network Access')
INSERT INTO Subjects(Name)
VALUES (N'IP Connectivity')
INSERT INTO Subjects(Name)
VALUES (N'IP Services')
INSERT INTO Subjects(Name)
VALUES (N'Routers and Switches')

INSERT INTO Subjects(Name)
VALUES (N'Security Fundamentals')
INSERT INTO Subjects(Name)
VALUES (N'System Security')
INSERT INTO Subjects(Name)
VALUES (N'Network Security')
INSERT INTO Subjects(Name)
VALUES (N'Security Protocols')


INSERT INTO Departments(Financing, Name, FacultyId)
VALUES (9000, N'Back-end', 3)
INSERT INTO Departments(Financing, Name, FacultyId)
VALUES (4000, N'Front-end', 3)

INSERT INTO Subjects(Name)
VALUES (N'Python')
INSERT INTO Subjects(Name)
VALUES (N'C++ fundamentals')
INSERT INTO Subjects(Name)
VALUES (N'OOP using C++')
INSERT INTO Subjects(Name)
VALUES (N'.NET and C#')
INSERT INTO Subjects(Name)
VALUES (N'Windows Forms and WPF')
INSERT INTO Subjects(Name)
VALUES (N'PHP')
INSERT INTO Subjects(Name)
VALUES (N'SQL')
INSERT INTO Subjects(Name)
VALUES (N'System Programming')
INSERT INTO Subjects(Name)
VALUES (N'Network Programming')
INSERT INTO Subjects(Name)
VALUES (N'ADO.NET & EF CORE 6')
INSERT INTO Subjects(Name)
VALUES (N'ASP.NET')

INSERT INTO Subjects(Name)
VALUES (N'HTML')
INSERT INTO Subjects(Name)
VALUES (N'CSS')
INSERT INTO Subjects(Name)
VALUES (N'Javascript')
INSERT INTO Subjects(Name)
VALUES (N'JQuery')
INSERT INTO Subjects(Name)
VALUES (N'Node.js')
INSERT INTO Subjects(Name)
VALUES (N'Typescript')
INSERT INTO Subjects(Name)
VALUES (N'Angular')


INSERT INTO Curators (Name, Surname)
VALUES ('Tillie', 'Coupar');
INSERT INTO Curators (Name, Surname)
VALUES ('Stacee', 'Le Grand');
INSERT INTO Curators (Name, Surname)
VALUES ('Arron', 'Tschirasche');
INSERT INTO Curators (Name, Surname)
VALUES ('Corrina', 'Marmon');
INSERT INTO Curators (Name, Surname)
VALUES ('Libby', 'Stride');
INSERT INTO Curators (Name, Surname)
VALUES ('Ferdinande', 'Purdie');
INSERT INTO Curators (Name, Surname)
VALUES ('Hayes', 'Artharg');
INSERT INTO Curators (Name, Surname)
VALUES ('Kris', 'Speedy');


INSERT INTO Teachers(Name, Surname, Salary)
VALUES (N'Elvin', N'Azimov', 4000)
INSERT INTO Teachers (Name, Surname, Salary)
VALUES ('Carol-jean', 'Sigert', 2281);
INSERT INTO Teachers (Name, Surname, Salary)
VALUES ('Karrie', 'Rimbault', 3828);
INSERT INTO Teachers (Name, Surname, Salary)
VALUES ('Richard', 'Pimlett', 1466);
INSERT INTO Teachers (Name, Surname, Salary)
VALUES ('Erv', 'Harold', 1112);
INSERT INTO Teachers (Name, Surname, Salary)
VALUES ('Xylina', 'Krochmann', 1764);
INSERT INTO Teachers (Name, Surname, Salary)
VALUES ('Bartie', 'Oldman', 3774);
INSERT INTO Teachers (Name, Surname, Salary)
VALUES ('Margi', 'Gertz', 1451);
INSERT INTO Teachers (Name, Surname, Salary)
VALUES ('Dunc', 'Bang', 1826);
INSERT INTO Teachers (Name, Surname, Salary)
VALUES ('Beatriz', 'Huggan', 2141);
INSERT INTO Teachers (Name, Surname, Salary)
VALUES ('Maren', 'Ludvigsen', 2189);
INSERT INTO Teachers (Name, Surname, Salary)
VALUES ('Lovell', 'Ferrand', 4223);
INSERT INTO Teachers (Name, Surname, Salary)
VALUES ('Lani', 'Ubsdell', 3276);
INSERT INTO Teachers (Name, Surname, Salary)
VALUES ('Jereme', 'Yokley', 4170);
INSERT INTO Teachers (Name, Surname, Salary)
VALUES ('Nyssa', 'Phillip', 888);
INSERT INTO Teachers (Name, Surname, Salary)
VALUES ('Malena', 'Hedditch', 3335);
INSERT INTO Teachers (Name, Surname, Salary)
VALUES ('Harriot', 'Richly', 4120);
INSERT INTO Teachers (Name, Surname, Salary)
VALUES ('Wilhelmine', 'Fahey', 4292);
INSERT INTO Teachers (Name, Surname, Salary)
VALUES ('Tedi', 'Northeast', 4894);
INSERT INTO Teachers (Name, Surname, Salary)
VALUES ('Kylie', 'MacAloren', 1424);
INSERT INTO Teachers (Name, Surname, Salary)
VALUES ('Giffer', 'de Aguirre', 1437);
INSERT INTO Teachers (Name, Surname, Salary)
VALUES ('Rory', 'Ludwig', 3001);
INSERT INTO Teachers (Name, Surname, Salary)
VALUES ('Kaitlin', 'Dunbabin', 4453);
INSERT INTO Teachers (Name, Surname, Salary)
VALUES ('Ralina', 'Leipelt', 1860);
INSERT INTO Teachers (Name, Surname, Salary)
VALUES ('Bette-ann', 'Birrane', 4504);
INSERT INTO Teachers (Name, Surname, Salary)
VALUES ('Perry', 'Brothwood', 4512);
INSERT INTO Teachers (Name, Surname, Salary)
VALUES ('Binky', 'Joron', 3130);
INSERT INTO Teachers (Name, Surname, Salary)
VALUES ('Dyanne', 'Kightly', 3653);
INSERT INTO Teachers (Name, Surname, Salary)
VALUES ('Merry', 'Schultes', 1974);
INSERT INTO Teachers (Name, Surname, Salary)
VALUES ('Consolata', 'Boyet', 4204);
INSERT INTO Teachers (Name, Surname, Salary)
VALUES ('Gwendolyn', 'Shrive', 4683);
INSERT INTO Teachers (Name, Surname, Salary)
VALUES ('Avis', 'Diament', 3524);
INSERT INTO Teachers (Name, Surname, Salary)
VALUES ('Winni', 'Peniman', 4692);
INSERT INTO Teachers (Name, Surname, Salary)
VALUES ('Ric', 'Cancutt', 2979);
INSERT INTO Teachers (Name, Surname, Salary)
VALUES ('Trixie', 'Dorrance', 2024);
INSERT INTO Teachers (Name, Surname, Salary)
VALUES ('Bobby', 'Jee', 4264);
INSERT INTO Teachers (Name, Surname, Salary)
VALUES ('Lloyd', 'Kroll', 3611);
INSERT INTO Teachers (Name, Surname, Salary)
VALUES ('Leighton', 'Hyland', 1469);
INSERT INTO Teachers (Name, Surname, Salary)
VALUES ('Sonya', 'Hullyer', 1881);
INSERT INTO Teachers (Name, Surname, Salary)
VALUES ('Corbin', 'McRobbie', 4298);
INSERT INTO Teachers (Name, Surname, Salary)
VALUES ('Pembroke', 'Davidovici', 2811);



INSERT INTO Lectures(LectureRoom, SubjectId, TeacherId)
VALUES ('18', 27, 1)
INSERT INTO Lectures(LectureRoom, SubjectId, TeacherId)
VALUES ('16', 27, 1)
INSERT INTO Lectures(LectureRoom, SubjectId, TeacherId)
VALUES ('15', 28, 1)
INSERT INTO Lectures(LectureRoom, SubjectId, TeacherId)
VALUES ('1A', 29, 2)
INSERT INTO Lectures(LectureRoom, SubjectId, TeacherId)
VALUES ('13', 6, 3)
INSERT INTO Lectures(LectureRoom, SubjectId, TeacherId)
VALUES ('2A', 5, 4)
INSERT INTO Lectures(LectureRoom, SubjectId, TeacherId)
VALUES ('2B', 14, 4)
INSERT INTO Lectures(LectureRoom, SubjectId, TeacherId)
VALUES ('2C', 2, 5)
INSERT INTO Lectures(LectureRoom, SubjectId, TeacherId)
VALUES ('2D', 1, 6)
INSERT INTO Lectures(LectureRoom, SubjectId, TeacherId)
VALUES ('2E', 30, 6)
INSERT INTO Lectures(LectureRoom, SubjectId, TeacherId)
VALUES ('21', 15, 10)
INSERT INTO Lectures(LectureRoom, SubjectId, TeacherId)
VALUES ('22', 18, 11)
INSERT INTO Lectures(LectureRoom, SubjectId, TeacherId)
VALUES ('23', 40, 12)
INSERT INTO Lectures(LectureRoom, SubjectId, TeacherId)
VALUES ('24', 20, 13)
INSERT INTO Lectures(LectureRoom, SubjectId, TeacherId)
VALUES ('25', 19, 14)
INSERT INTO Lectures(LectureRoom, SubjectId, TeacherId)
VALUES ('26', 26, 9)
INSERT INTO Lectures(LectureRoom, SubjectId, TeacherId)
VALUES ('27', 15, 4)
INSERT INTO Lectures(LectureRoom, SubjectId, TeacherId)
VALUES ('28', 7, 7)
INSERT INTO Lectures(LectureRoom, SubjectId, TeacherId)
VALUES ('29', 10, 12)


INSERT INTO Groups(Name, Year, DepartmentId)
VALUES (N'2D_Art1', 1, 1)
INSERT INTO Groups(Name, Year, DepartmentId)
VALUES (N'2D_Art2', 1, 1)
INSERT INTO Groups(Name, Year, DepartmentId)
VALUES (N'2D_Art3', 2, 1)
INSERT INTO Groups(Name, Year, DepartmentId)
VALUES (N'2D_Art4', 2, 1)
INSERT INTO Groups(Name, Year, DepartmentId)
VALUES (N'2D_Art5', 3, 1)
INSERT INTO Groups(Name, Year, DepartmentId)
VALUES (N'2D_Art6', 3, 1)
INSERT INTO Groups(Name, Year, DepartmentId)
VALUES (N'2D_Art7', 3, 1)

INSERT INTO Groups(Name, Year, DepartmentId)
VALUES (N'3D_Art1', 2, 2)
INSERT INTO Groups(Name, Year, DepartmentId)
VALUES (N'3D_Art2', 2, 2)
INSERT INTO Groups(Name, Year, DepartmentId)
VALUES (N'3D_Art3', 2, 2)
INSERT INTO Groups(Name, Year, DepartmentId)
VALUES (N'3D_Art4', 3, 2)
INSERT INTO Groups(Name, Year, DepartmentId)
VALUES (N'3D_Art5', 3, 2)
INSERT INTO Groups(Name, Year, DepartmentId)
VALUES (N'3D_Art5', 3, 2)
INSERT INTO Groups(Name, Year, DepartmentId)
VALUES (N'3D_Art6', 4, 2)
INSERT INTO Groups(Name, Year, DepartmentId)
VALUES (N'3D_Art7', 5, 2)

INSERT INTO Groups(Name, Year, DepartmentId)
VALUES (N'Sys1', 1, 4)
INSERT INTO Groups(Name, Year, DepartmentId)
VALUES (N'Sys2', 1, 4)
INSERT INTO Groups(Name, Year, DepartmentId)
VALUES (N'Sys3', 1, 4)
INSERT INTO Groups(Name, Year, DepartmentId)
VALUES (N'Sys4', 4, 4)
INSERT INTO Groups(Name, Year, DepartmentId)
VALUES (N'Sys5', 2, 4)
INSERT INTO Groups(Name, Year, DepartmentId)
VALUES (N'Sys6', 2, 4)
INSERT INTO Groups(Name, Year, DepartmentId)
VALUES (N'Sys7', 2, 4)
INSERT INTO Groups(Name, Year, DepartmentId)
VALUES (N'Sys8', 5, 4)

INSERT INTO Groups(Name, Year, DepartmentId)
VALUES (N'Network1', 2, 5)
INSERT INTO Groups(Name, Year, DepartmentId)
VALUES (N'Network2', 2, 5)
INSERT INTO Groups(Name, Year, DepartmentId)
VALUES (N'Network3', 2, 5)
INSERT INTO Groups(Name, Year, DepartmentId)
VALUES (N'Network4', 3, 5)
INSERT INTO Groups(Name, Year, DepartmentId)
VALUES (N'Network5', 3, 5)
INSERT INTO Groups(Name, Year, DepartmentId)
VALUES (N'Network6', 3, 5)
INSERT INTO Groups(Name, Year, DepartmentId)
VALUES (N'Network7', 4, 5)
INSERT INTO Groups(Name, Year, DepartmentId)
VALUES (N'Network8', 5, 5)

INSERT INTO Groups(Name, Year, DepartmentId)
VALUES (N'Cyber1', 3, 6)
INSERT INTO Groups(Name, Year, DepartmentId)
VALUES (N'Cyber2', 3, 6)
INSERT INTO Groups(Name, Year, DepartmentId)
VALUES (N'Cyber3', 3, 6)
INSERT INTO Groups(Name, Year, DepartmentId)
VALUES (N'Cyber4', 3, 6)
INSERT INTO Groups(Name, Year, DepartmentId)
VALUES (N'Cyber5', 3, 6)
INSERT INTO Groups(Name, Year, DepartmentId)
VALUES (N'Cyber6', 4, 6)
INSERT INTO Groups(Name, Year, DepartmentId)
VALUES (N'Cyber7', 4, 6)
INSERT INTO Groups(Name, Year, DepartmentId)
VALUES (N'Cyber8', 5, 6)

INSERT INTO Groups(Name, Year, DepartmentId)
VALUES (N'Back-End1', 1, 7)
INSERT INTO Groups(Name, Year, DepartmentId)
VALUES (N'Back-End2', 2, 7)
INSERT INTO Groups(Name, Year, DepartmentId)
VALUES (N'Back-End3', 3, 7)
INSERT INTO Groups(Name, Year, DepartmentId)
VALUES (N'Back-End4', 4, 7)

INSERT INTO Groups(Name, Year, DepartmentId)
VALUES (N'Front-End1', 1, 8)
INSERT INTO Groups(Name, Year, DepartmentId)
VALUES (N'Front-End2', 2, 8)
INSERT INTO Groups(Name, Year, DepartmentId)
VALUES (N'Front-End3', 3, 8)
INSERT INTO Groups(Name, Year, DepartmentId)
VALUES (N'Front-End4', 4, 8)
INSERT INTO Groups(Name, Year, DepartmentId)
VALUES (N'Front-End5', 5, 8)

INSERT INTO GroupsCurators (CuratorId, GroupId)
VALUES (1, 27);
INSERT INTO GroupsCurators (CuratorId, GroupId)
VALUES (1, 41);
INSERT INTO GroupsCurators (CuratorId, GroupId)
VALUES (4, 23);
INSERT INTO GroupsCurators (CuratorId, GroupId)
VALUES (8, 5);
INSERT INTO GroupsCurators (CuratorId, GroupId)
VALUES (6, 10);
INSERT INTO GroupsCurators (CuratorId, GroupId)
VALUES (5, 3);
INSERT INTO GroupsCurators (CuratorId, GroupId)
VALUES (4, 47);
INSERT INTO GroupsCurators (CuratorId, GroupId)
VALUES (1, 43);
INSERT INTO GroupsCurators (CuratorId, GroupId)
VALUES (2, 30);
INSERT INTO GroupsCurators (CuratorId, GroupId)
VALUES (2, 33);
INSERT INTO GroupsCurators (CuratorId, GroupId)
VALUES (3, 15);
INSERT INTO GroupsCurators (CuratorId, GroupId)
VALUES (7, 7);
INSERT INTO GroupsCurators (CuratorId, GroupId)
VALUES (8, 7);
INSERT INTO GroupsCurators (CuratorId, GroupId)
VALUES (6, 44);
INSERT INTO GroupsCurators (CuratorId, GroupId)
VALUES (2, 39);
INSERT INTO GroupsCurators (CuratorId, GroupId)
VALUES (3, 39);
INSERT INTO GroupsCurators (CuratorId, GroupId)
VALUES (7, 38);
INSERT INTO GroupsCurators (CuratorId, GroupId)
VALUES (1, 28);
INSERT INTO GroupsCurators (CuratorId, GroupId)
VALUES (4, 13);
INSERT INTO GroupsCurators (CuratorId, GroupId)
VALUES (8, 12);
INSERT INTO GroupsCurators (CuratorId, GroupId)
VALUES (6, 5);
INSERT INTO GroupsCurators (CuratorId, GroupId)
VALUES (2, 23);
INSERT INTO GroupsCurators (CuratorId, GroupId)
VALUES (7, 19);
INSERT INTO GroupsCurators (CuratorId, GroupId)
VALUES (8, 16);
INSERT INTO GroupsCurators (CuratorId, GroupId)
VALUES (8, 21);
INSERT INTO GroupsCurators (CuratorId, GroupId)
VALUES (7, 1);
INSERT INTO GroupsCurators (CuratorId, GroupId)
VALUES (4, 39);
INSERT INTO GroupsCurators (CuratorId, GroupId)
VALUES (7, 5);
INSERT INTO GroupsCurators (CuratorId, GroupId)
VALUES (1, 31);
INSERT INTO GroupsCurators (CuratorId, GroupId)
VALUES (8, 37);
INSERT INTO GroupsCurators (CuratorId, GroupId)
VALUES (4, 47);
INSERT INTO GroupsCurators (CuratorId, GroupId)
VALUES (3, 6);
INSERT INTO GroupsCurators (CuratorId, GroupId)
VALUES (7, 17);
INSERT INTO GroupsCurators (CuratorId, GroupId)
VALUES (7, 7);
INSERT INTO GroupsCurators (CuratorId, GroupId)
VALUES (2, 13);
INSERT INTO GroupsCurators (CuratorId, GroupId)
VALUES (4, 5);
INSERT INTO GroupsCurators (CuratorId, GroupId)
VALUES (5, 37);
INSERT INTO GroupsCurators (CuratorId, GroupId)
VALUES (5, 45);
INSERT INTO GroupsCurators (CuratorId, GroupId)
VALUES (3, 43);
INSERT INTO GroupsCurators (CuratorId, GroupId)
VALUES (2, 15);


select *
from GroupsLectures


insert into GroupsLectures (GroupId, LectureId)
values (37, 15);
insert into GroupsLectures (GroupId, LectureId)
values (29, 9);
insert into GroupsLectures (GroupId, LectureId)
values (26, 8);
insert into GroupsLectures (GroupId, LectureId)
values (37, 7);
insert into GroupsLectures (GroupId, LectureId)
values (40, 14);
insert into GroupsLectures (GroupId, LectureId)
values (45, 1);
insert into GroupsLectures (GroupId, LectureId)
values (3, 9);
insert into GroupsLectures (GroupId, LectureId)
values (23, 7);
insert into GroupsLectures (GroupId, LectureId)
values (31, 11);
insert into GroupsLectures (GroupId, LectureId)
values (31, 1);
insert into GroupsLectures (GroupId, LectureId)
values (30, 12);
insert into GroupsLectures (GroupId, LectureId)
values (15, 18);
insert into GroupsLectures (GroupId, LectureId)
values (15, 1);
insert into GroupsLectures (GroupId, LectureId)
values (31, 2);
insert into GroupsLectures (GroupId, LectureId)
values (38, 11);
insert into GroupsLectures (GroupId, LectureId)
values (12, 13);
insert into GroupsLectures (GroupId, LectureId)
values (27, 8);
insert into GroupsLectures (GroupId, LectureId)
values (33, 5);
insert into GroupsLectures (GroupId, LectureId)
values (13, 7);
insert into GroupsLectures (GroupId, LectureId)
values (22, 14);
insert into GroupsLectures (GroupId, LectureId)
values (36, 11);
insert into GroupsLectures (GroupId, LectureId)
values (37, 2);
insert into GroupsLectures (GroupId, LectureId)
values (23, 12);
insert into GroupsLectures (GroupId, LectureId)
values (22, 15);
insert into GroupsLectures (GroupId, LectureId)
values (17, 8);
insert into GroupsLectures (GroupId, LectureId)
values (19, 4);
insert into GroupsLectures (GroupId, LectureId)
values (1, 5);
insert into GroupsLectures (GroupId, LectureId)
values (42, 19);
insert into GroupsLectures (GroupId, LectureId)
values (27, 12);
insert into GroupsLectures (GroupId, LectureId)
values (36, 3);
insert into GroupsLectures (GroupId, LectureId)
values (41, 18);
insert into GroupsLectures (GroupId, LectureId)
values (2, 2);
insert into GroupsLectures (GroupId, LectureId)
values (21, 17);
insert into GroupsLectures (GroupId, LectureId)
values (45, 3);
insert into GroupsLectures (GroupId, LectureId)
values (16, 17);
insert into GroupsLectures (GroupId, LectureId)
values (45, 16);
insert into GroupsLectures (GroupId, LectureId)
values (26, 7);
insert into GroupsLectures (GroupId, LectureId)
values (15, 11);
insert into GroupsLectures (GroupId, LectureId)
values (11, 17);
insert into GroupsLectures (GroupId, LectureId)
values (24, 14);



select *
from Curators
select *
from Departments
select *
from Faculties
select *
from Groups
select *
from GroupsCurators


select Groups.Name           as GroupName,
       Groups.Year           as Year,
       Departments.Name      as DepartmenName,
       Departments.Financing as DepartmentFinancing,
       Faculties.Name        as FacultyName,
       Faculties.Financing   as facultyFinancing
from Groups
         inner join Departments on Departments.Id = Groups.DepartmentId
         inner join Faculties on Faculties.Id = Departments.FacultyId


select *
from Curators
         inner join GroupsCurators GC on Curators.Id = GC.CuratorId
         inner join Groups G on G.Id = GC.GroupId


select *
from GroupsCurators
         right join Groups G on G.Id = GroupsCurators.GroupId
where GroupsCurators.Id is null


use Showroom

BEGIN transaction First

insert into Cars(Make, Model, Year, ImageUrl)
values (N'Mercedes', N'CLS63AMG', 2021, N'https://www.allcarz.ru/wp-content/uploads/2021/04/foto-cls-2022_09.jpg');

select *
from Cars

rollback tran

commit tran


use Academy;


select *
from Curators;
select *
from Teachers;


insert into Curators(Name, Surname)
values ((select TOP 1 Name from Teachers where Name LIKE 'Elvin'),
        (select TOP 1 Surname from Teachers where Name LIKE 'Elvin'))


select *
from Curators



