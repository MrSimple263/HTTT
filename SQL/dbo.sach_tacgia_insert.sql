CREATE PROC sach_tacgia_insert(@idsach INT,@idtacgia INT)
AS
BEGIN
INSERT INTO dbo.[SACH-TACGIA]
(
    sach,
    tacgia
)
VALUES
(   @idsach, -- sach - int
    @idtacgia  -- theloai - int
    )
END