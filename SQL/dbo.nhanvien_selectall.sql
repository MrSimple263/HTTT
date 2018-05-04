alter proc nhanvien_selectall
as 
begin
select NHANVIEN.id,username,password,hoten,ngaysinh,sdt,ROLE.name
from NHANVIEN inner join ROLE on role=ROLE.id
end