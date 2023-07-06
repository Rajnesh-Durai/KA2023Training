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
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE or alter FUNCTION staffMaster(
	-- Add the parameters for the function here

)
RETURNS @staffman TABLE 
(
	-- Add the column definitions for the TABLE variable here
	staffcod int, stafname nvarchar(50),mgcode int, staf_add nvarchar(50)
)
AS
BEGIN
WITH staffman_temp(v1,v2,v3,v4) 
AS(

	-- Fill the table variable with the rows for your result set
	select s.staff_code, s.staff_address , s.mgr_code, m.staff_name  from staff_Master s join staff_Master m
	on s.staff_code=m.staff_code
)	

INSERT @staffman select v1,v2,v3,v4 from staffman_temp
	RETURN 
END
GO