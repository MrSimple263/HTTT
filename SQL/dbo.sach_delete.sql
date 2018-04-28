ALTER proc sach_delete(@id int)
as
BEGIN
DELETE FROM dbo.CTHD
WHERE sach=id;
DELETE FROM dbo.[SACH-TACGIA]
WHERE sach=@id;
DELETE FROM dbo.[SACH-THELOAI]
WHERE sach=@id;
delete from SACH
where id=@id
end