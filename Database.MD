
# Database Codes
````
create database OnionSchool
````

````
Create table Courses(
	Id int identity(1, 1) primary key,
	CourseName varchar(100)
)

insert into Courses values
('C#'), ('ASP.NET Core'), ('PHP')
````

````
create table Addresses(
	Id int identity(1, 1) primary key,
	City varchar(50),
	District varchar(50),
	FullAddress varchar(100)
)

insert into Addresses values
('Mersin', 'Tarsus', 'Mersin / Tarsus / Mah 1'),
('İstanbul', 'Kadıköy', 'İstanbul / Kadıköy / Mah 2'),
('Adana', 'Seyhan', 'Adana / Seyhan / Mah 3'),
('Balıkesir', 'Bandırma', 'Balıkesir / Bandırma / Mah 4')
````

````
create table Students(
	Id int identity(1, 1),
	FirstName varchar(30),
	LastName varchar(30),
	DateOfBirth Date,
	AddressId int,
	CourseId int,
	primary key(Id),
	foreign key (AddressId) references Addresses(Id),
	foreign key (CourseId) references Courses(Id)
)

insert into Students values
('Alex', 'Ivan', DATEADD(YEAR, -10, GETDATE()), 1, 1),
('Dale', 'West', DATEADD(YEAR, -20, GETDATE()), 2, 2),
('Beatrice ', 'Allen', DATEADD(DAY, -3000, GETDATE()), 3, 3),
('Raul', 'Dixon', DATEADD(YEAR, -40, GETDATE()), 4, 2),
('Mia', 'Reyes', DATEADD(MONTH, -500, GETDATE()), 1, 1)
````