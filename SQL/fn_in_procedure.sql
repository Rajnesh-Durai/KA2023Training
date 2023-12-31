USE [sampledemo]
GO
/****** Object:  StoredProcedure [dbo].[EmpNameDisplay]    Script Date: 16-03-2023 17:07:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ===========================================s==
-- Author:		Raja
-- Create date: 
-- Description:	
-- =============================================
ALTER PROCEDURE [dbo].[EmpNameDisplay] 
	-- Add the parameters for the stored procedure here
	@p1 int = 0, 
	@p2 int = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT ENO,ENAME from [dbo].[udf_emp]()

    -- Insert statements for procedure here
	SELECT empid, ename from emp;
END
