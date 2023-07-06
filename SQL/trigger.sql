CREATE TABLE EmpLog (
	LogID int IDENTITY(1,1) NOT NULL,
	EmpID int NOT NULL,
	Operation nvarchar(10) NOT NULL,
	UpdatedDate Datetime NOT NULL	
)

/*INSERT  IN TRIGGER*/
create or alter trigger dbo.trg_EmployeeInsert
ON dbo.emp
FOR INSERT
AS
	INSERT INTO dbo.EmpLog(EmpID,Operation,UpdatedDate)
	SELECT empid,'INSERT',GETDATE() FROM INSERTED;

SELECT * FROM emp

select * from dbo.EmpLog

insert into emp(ename,ph,desig) values('jonas',9994153475,'CSE')

/*UPDATE*/

create or alter trigger dbo.trg_EmployeeUpdate
ON dbo.emp
AFTER UPDATE
AS
	INSERT INTO dbo.EmpLog(EmpID,Operation,UpdatedDate)
	SELECT empid,'UPDATE',GETDATE() FROM DELETED;

SELECT * FROM emp

select * from dbo.EmpLog

UPDATE emp set desig='mat' where empid=17;

/*DELETE*/

create or alter trigger dbo.trg_EmployeeDelete
ON dbo.emp
INSTEAD OF DELETE
AS
	INSERT INTO dbo.EmpLog(EmpID,Operation,UpdatedDate)
	SELECT empid,'DELETE',GETDATE() FROM DELETED;

SELECT * FROM emp

select * from dbo.EmpLog

DELETE FROM emp where empid=19

/*------------------------------------------------------------------*/

-- DDL Trigggers

create table dbo.TableLog
(
LogID int identity(1,1) Primary key,
EventVal xml not null,
EventDate datetime NOT null,
ChangedBy sysname not null
)

create or alter trigger trgTablechanges
ON DATABASE
FOR
	CREATE_TABLE, ALTER_TABLE, DROP_TABLE
AS
BEGIN
	INSERT INTO TableLog(EventVal, EventDate, ChangedBy)
	VALUES(EVENTDATA(), GETDATE(), USER);
END;
s

/*drop*/
create table dummy(testid int identity(1,1) PRIMARY KEY,
testname SYSNAME not null);
select * from Tablelog
drop table dummy

/*RESTRICTING TO 1 USER AT A TIME*/
create or alter trigger tryloginConnection
ON ALL SERVER
FOR logon
AS
BEGIN
	IF (ORIGINAL_LOGIN()=N'sa' AND (SELECT COUNT(*) FROM sys.dm_exec_sessions
	WHERE is_user_process=1 AND original_login_name=N'sa')>1)
		rollback;
END;
