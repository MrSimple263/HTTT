CREATE PROCEDURE sach_theloai_dell
	(@idsach int)
AS
begin
	delete from SACH_THELOAI
	where sach=@idsach
end
