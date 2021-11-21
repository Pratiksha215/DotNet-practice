USE [SunbeamDB]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[SpUpdate]
		@Id = 14,
		@Name = N'Vyankatesh',
		@Address = N'Latur'

SELECT	@return_value as 'Return Value'

GO
