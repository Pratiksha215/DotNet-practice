USE [SunbeamDB]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[spInsert]
		@Id = 15,
		@Name = N'jayesh',
		@Address = N'Jalgaon'

SELECT	@return_value as 'Return Value'

GO
