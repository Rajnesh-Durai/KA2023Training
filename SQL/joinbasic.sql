use northwind;
select *from Products;
/*ORDER BY ==> SORT*/
select ProductName, UnitsInStock
from Products
order by ProductName;

select ProductName, UnitsInStock
from Products
order by ProductName desc,UnitsInStock;

/*GROUP BY*/
select CategoryID,sum( UnitsInStock)
from Products
group by CategoryID;

select CategoryID,sum( UnitsInStock)
from Products
group by CategoryID
having sum(UnitsInStock)>=30;

select * from Shippers;
ALTER TABLE Shippers ADD Country nvarchar(15)not null;
ALTER TABLE Shippers ADD CountryID int not null;
ALTER TABLE Shippers ADD ShipPort nvarchar(15) not null;

UPDATE Shippers
set Country='India',CountryID=2,ShipPort='Chennai'
where ShipperID=1;
UPDATE Shippers
set Country='Australia',CountryID=3,ShipPort='Canberra'
where ShipperID=2;
UPDATE Shippers
set Country='England',CountryID=4,ShipPort='Buckingham'
where ShipperID=3;

/*JOIN*/

use sampledemo;

select * from dept;
insert into dept values(116,'UI');
insert into dept values(114,'.NET');
insert into dept values(117,'SQL');
insert into dept values(112,'UI');
insert into dept values(115,'UI');

UPDATE DEPT
set dname='UI'
where deptno=112;
UPDATE DEPT
set dname='UI'
where deptno=115;


INSERT INTO emp values('Kirmaada',9150112752,'CSE',116);
INSERT INTO emp values('Kamsan',9150112752,'MECH',114);
INSERT INTO emp values('Raju',9150112752,'EEE',117);
INSERT INTO emp values('Chotta Bheem',9150112752,'ECE',112);
INSERT INTO emp values('Kaalia',9150112752,'CIVIL',115);

/*INNER JOIN*/
select ename,desig 
from emp 
INNER JOIN dept
on emp.deptno=dept.deptno and dname='UI';

select e.ename ,e.deptno,dname
from emp e
FULL OUTER JOIN dept
on e.deptno=dept.deptno;

select d.deptno, d.dname
from emp e
right outer JOIN dept d
on e.deptno=d.deptno;