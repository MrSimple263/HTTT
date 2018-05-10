USE [CUAHANGSACH]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[nhanvien_update]
		@username = N'hoa',
		@pass = N'123',
		@hoten = N'HOa',
		@ngaysinh = '01-01-1999',
		@sdt = N'016123',
		@role = 1,
		@id = 4

SELECT	@return_value as 'Return Value'

GO
