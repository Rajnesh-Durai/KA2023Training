USE [sampledemo]
GO

DECLARE	@return_value int,
		@cout int

EXEC	@return_value = [dbo].[empData]
		@ename = N'Martha',
		@ph = 94981653,
		@desig = N'.NET',
		@cout = @cout OUTPUT

SELECT	@cout as N'@cout'

SELECT	'Return Value' = @return_value

GO
