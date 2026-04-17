create database Company
use Company 

create table Countries(
Id int primary key identity,
[Name] nvarchar(50) not null,
)

create table Cities(
Id int primary key identity,
[Name] nvarchar(50) not null,
CountriesId int foreign key references Countries(Id)
)

create table Employees(
Id int primary key identity,
[Name] nvarchar(50) not null,
Surname nvarchar(50) not null,
Age int,
Salary decimal(6,2),
Position nvarchar(50),
IsDeleted bit default 0,
CityId int foreign key references Cities(Id)
)

insert into Countries (Name) 
values
('Azerbaycan'), 
('Turkiye'), 
('Almaniya'), 
('Fransa'), 
('Yaponiya'), 
('Italiya')

insert into Cities (Name, CountriesId) 
values 
('Ganja', 1),
('Hamburg', 3),
('Izmir', 2),
('Rome', 6),
('Marseille', 4),
('Osaka', 5),
('Munich', 3),
('Florence', 6),
('Shaki', 1)

insert into Employees (Name, Surname, Age, Salary, Position, IsDeleted, CityId) 
values 
('Ilkay', 'Gundogan', 33, 7777.77, 'Developer', 0, 1),     
('Hakan', 'Sukur', 42, 3500.99, 'Reception', 0, 4),        
('Ciro', 'Immobile', 34, 2100.67, 'Manager', 0, 2),        
('Antoine', 'Griezmann', 32, 4500.54, 'Developer', 0, 9),  
('Takumi', 'Minamino', 29, 6800.73, 'Reception', 0, 3),    
('Burak', 'Yilmaz', 38, 6000.98, 'Manager', 0, 10),      
('Ritsu', 'Doan', 25, 5000.35, 'Developer', 1, 5),         
('Olivier', 'Giroud', 37, 3200.78, 'Reception', 0, 7)      



select e.Name as EmployeesName, e.Surname as Surname, ci.Name as City, co.Name as Country from Employees as e
left join Cities as ci 
on e.CityId = ci.Id
left join Countries as co 
on ci.CountriesId = co.Id


select e.Name, co.Name as Country from Employees as e
inner join Cities as ci
on e.CityId = ci.Id
inner join Countries as co
on ci.CountriesId = co.Id
where e.Salary > 2000




select ci.Name as City, co.Name as Country from Cities as ci
left join Countries as co 
on ci.CountriesId = co.Id


select e.Name, e.Surname, e.Age, e.Salary, e.Position, e.IsDeleted,ci.Name as CityName, co.Name as CountryName 
from Employees as e
left join Cities as ci on e.CityId = ci.Id
left join Countries as co on ci.CountriesId = co.Id
where e.Position = 'Reception'


select  e.Name, e.Surname, ci.Name as City, co.Name as Country from Employees as e
inner join Cities as ci on e.CityId = ci.Id
inner join Countries as co on ci.CountriesId = co.Id
where e.IsDeleted = 1