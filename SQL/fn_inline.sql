-- ================================================
-- Template generated from Template Explorer using:
-- Create Inline Function (New Menu).SQL
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
CREATE or ALTER FUNCTION udf_empName
(	
	-- Add the parameters for the function here
	@empnum int
)
RETURNS nvarchar(20) 
AS

BEGIN

RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT ename from dbo.emp where empid=@empnum
)

END
GO
