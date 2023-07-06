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
-- Author:		Rajnesh
-- Create date: 
-- Description:	
-- =============================================
CREATE or ALTER FUNCTION udf_busticket 
(
	-- Add the parameters for the function here
	
)
RETURNS 
 TABLE 

AS
	-- Fill the table variable with the rows for your result set
	
	RETURN 
	select sources
	from BUS
	where Routeno=6
GO