use northwind;
select * from Suppliers
SELECT * FROM Products

select p.ProductName, s.Country
from Products p inner join Suppliers s
on s.Country='UK' and p.SupplierID=s.SupplierID

/*SUBQUERY*/

select sum(p.UnitsInStock)
from Products p
where p.SupplierID IN(
select s.SupplierID
from Suppliers s
group by s.Country,s.SupplierID
)

USE sampledemo
CREATE TABLE dupl(dname int, ddept nvarchar(25) )
SELECT * FROM dupl;
select * from dept;
insert into dupl select * from dept;
drop table dupl;
