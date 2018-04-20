--thủ tục thêm vào chi tiết hóa đơn
CREATE PROC cthd_insert(@sach INT,@dongia INT,@hoadon INT)
AS
BEGIN
INSERT INTO CTHD(sach,dongia,hoadon) VALUES(@sach,@dongia,@hoadon)
END
