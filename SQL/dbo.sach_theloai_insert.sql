CREATE PROC sach_theloai_insert(@idsach INT,@idtheloai INT)
AS
BEGIN
INSERT INTO dbo.[SACH-THELOAI]
(
    sach,
    theloai
)
VALUES
(   @idsach, -- sach - int
    @idtheloai  -- theloai - int
    )
END