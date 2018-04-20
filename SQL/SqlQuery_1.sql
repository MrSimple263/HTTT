--thủ tục thêm vào chi tiết hóa đơn
CREATE PROC cthd_insert(@sach INT,@dongia INT,@hoadon INT,@soluong int)
AS
BEGIN
INSERT INTO CTHD(sach,dongia,hoadon,soluong) VALUES(@sach,@dongia,@hoadon,@soluong)
END
