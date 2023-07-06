-- ================================================
-- Template generated from Template Explorer using:
-- Create Multi-Statement Function (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the function.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Raja
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE or ALTER FUNCTION udf_emp
(
	-- Add the parameters for the function here

)
RETURNS @x TABLE
(
	-- Add the column definitions for the TABLE variable here
	eno int, ename nvarchar(20)
)
AS
BEGIN
WITH EMP_TEMP(num,na)
	-- Fill the table variable with the rows for your result set
	AS(SELECT empid,ename from emp 
	)
	INSERT @x
	SELECT num,na FROM emp_temp
	RETURN 
END
GO