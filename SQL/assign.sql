CREATE TABLE customer(
	CustomerId int, 
Cust_Name varchar(20), 
Address1 Varchar(30),  
Address2 Varchar(30)
      );
SELECT *from customer;

alter table customer
alter column Cust_Name varchar(30) not null;
exec sp_rename 'dbo.customer.Cust_Name', 'CustomerName', 'COLUMN';

INSERT INTO customer value(1000, 'Allen', '#115 Chicago', '#115 Chicago', 'M', 25,  7878776)
INSERT INTO customer value(1000, 'Allen', '#115 Chicago',' #115 Chicago', 'M', 25, 7878776);
INSERT INTO customer value(1001, 'George', '#116 France', '#116 France', 'M', 25, 434524);
INSERT INTO customer value(1002, 'Becker', '#114 New York', '#114 New York', 'M', 45, 431525);

ALTER TABLE customer add constraint CustId_Prim PRIMARY KEY(Customerld);

alter table customer
add  Gender Varchar(1),
Age int,
PhoneNo int;
exec sp_help customer;

create table Employee(EMPNO int not null,
ENAME varchar(10),
JOB varchar(50), 
MGR int, 
HIREDATE date, 
SAL int, 
COMM int, 
DEPTNO int);
select * from Employee;

INSERT INTO Employee(EMPNO,ENAME,SAL,DEPTNO)  value(7369,'SMITH',800,20);
INSERT INTO Employee(EMPNO,ENAME,SAL,DEPTNO)  value(7499,'ALLEN',1600,30)
INSERT INTO Employee(EMPNO,ENAME,SAL,DEPTNO)  value(7521,'WARD',1250,30)
INSERT INTO Employee(EMPNO,ENAME,SAL,DEPTNO)  value(7566,'JONES',2975,20)
INSERT INTO Employee(EMPNO,ENAME,SAL,DEPTNO)  value(7654,'MARTIN',1250,30)
INSERT INTO Employee(EMPNO,ENAME,SAL,DEPTNO)  value(7698,'BLAKE',2850,30)
INSERT INTO Employee(EMPNO,ENAME,SAL,DEPTNO)  value(7782,'CLARK',2450,10)
INSERT INTO Employee(EMPNO,ENAME,SAL,DEPTNO)  value(7788,'SCOTT',3000,20)
INSERT INTO Employee(EMPNO,ENAME,SAL,DEPTNO)  value(7839,'KING',5000,10)
INSERT INTO Employee(EMPNO,ENAME,SAL,DEPTNO)  value(7844,'TURNER',1500,30)
INSERT INTO Employee(EMPNO,ENAME,SAL,DEPTNO)  value(7876,'ADAMS',1100,20)
INSERT INTO Employee(EMPNO,ENAME,SAL,DEPTNO)  value(7900,'JAMES',950,30)
INSERT INTO Employee(EMPNO,ENAME,SAL,DEPTNO)  value(7902,'FORD',3000,20)
INSERT INTO Employee(EMPNO,ENAME,SAL,DEPTNO)  value(7934,'MILLER',1300,10)



CREATE TABLE Project(
PROJID VARCHAR(10) not null,
PROJ_NAME VARCHAR(25),
START_DATE DATE,
END_DATE DATE);
select * from Project;

INSERT INTO Project value("PID1","SMITH",2001/03/16,2001/06/28)
       INSERT INTO Project value(‘PID2’,’PETER’,2001/04/19,2001/09/14)
       INSERT INTO Project value(‘PID3’,’PARKER’,2001/06/06,2001/12/22 )
