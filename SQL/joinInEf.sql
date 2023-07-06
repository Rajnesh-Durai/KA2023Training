create table Dept(Deptno int primary key,
Dname nvarchar(30));

create table Emp(
empno int primary key,
ename nvarchar(20),
Deptno int foreign key references Dept(Deptno));