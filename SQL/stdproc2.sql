-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
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

 

CREATE OR ALTER PROCEDURE empData 
	-- Add the parameters for the stored procedure here

	@ename nvarchar(20)='Oogway',@ph int,@desig nvarchar(20),@cout int=0 OUT
AS
	DECLARE @oldcount int=0;
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	BEGIN TRANSACTION
	set @oldcount=(select count(*) from emp);
	INSERT INTO emp(ename,ph,desig) values(@ename,@ph,@desig)
	COMMIT;
	set @cout=(@oldcount+1)
	SET @cout=(@cout)
	select * from emp
END
GO