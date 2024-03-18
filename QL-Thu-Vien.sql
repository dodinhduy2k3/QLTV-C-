create table tacgia(
tacgiaID int primary key,
tenTacGia varchar2(100));

create table theloai(
theLoaiID int primary key ,
tenTheLoai nvarchar2(100));

create table sach(
sachID int primary Key,
tenSach nvarchar2(100), 
noiDung varchar2(100) ,
tacgiaID int ,
theLoaiID int ,
FOREIGN KEY (tacgiaID) REFERENCES tacgia(tacgiaID),
FOREIGN KEY (theLoaiID) REFERENCES theloai(theLoaiID)

)
create table nguoiDung(
nguoiDungID int primary key,
tenNguoiDung nvarchar2(25) ,
pass nvarchar2(25)

)
--thêm d? li?u cho b?ng tác gi? 
INSERT INTO tacgia (tacgiaID, tenTacGia) VALUES (9001, '?? ?ình Duy');
INSERT INTO tacgia (tacgiaID, tenTacGia) VALUES (9002, 'Ngô V?n Hâu');
INSERT INTO tacgia (tacgiaID, tenTacGia) VALUES (9003, 'Hoàng Trung Hi?u');
INSERT INTO tacgia (tacgiaID, tenTacGia) VALUES (9004, 'Lù Xuân H?i');
INSERT INTO tacgia (tacgiaID, tenTacGia) VALUES (9005, '?ình V?n Duy');

select * from tacgia;
-- thêm d? li?u cho b?ng th? lo?i
INSERT INTO theloai (theLoaiID,tenTheLoai) VALUES (8001, 'Kinh D?');
INSERT INTO theloai (theLoaiID,tenTheLoai) VALUES (8002, N'sách Thi?u Nhi');
INSERT INTO theloai (theLoaiID,tenTheLoai) VALUES (8003, N'sách Tâm Lý');
INSERT INTO theloai (theLoaiID,tenTheLoai) VALUES (8004, N'sách Tôn Giáo');

select * from theloai;
-- thêm d? li?u cho b?ng sách 
INSERT INTO sach (sachID, tenSach,noiDung,tacgiaID,theLoaiID) VALUES (7001, N'Ch? ?? Th? 2 ',N'“Ch? ?? th? II” có th? ban phát cho ng??i dùng nh?ng siêu n?ng l?c',9001,8001);
INSERT INTO sach (sachID, tenSach,noiDung,tacgiaID,theLoaiID) VALUES (7002, N'Ác M?ng Kinh Hoàng ',N'“gi?m ??p lên nhau và vô tình ph?m vào quy t?c ?? tr?n áp sát khí n?i ?ây',9001,8001);
INSERT INTO sach (sachID, tenSach,noiDung,tacgiaID,theLoaiID) VALUES (7003, N'T?m V?i ?? ',N'“Ch? ?? th? II” có th? ban phát cho ng??i dùng nh?ng siêu n?ng l?c',9001,8001);
INSERT INTO sach (sachID, tenSach,noiDung,tacgiaID,theLoaiID) VALUES (7004, N'T?m V?i Xanh ',N'“Ch? ?? th? II” có th? ban phát cho ng??i dùng nh?ng siêu n?ng l?c',9001,8001);

SELECT * FROM sach;
INSERT INTO nguoiDung (nguoiDungID, tennguoidung, pass) VALUES (1, 'admin', '1');
INSERT INTO nguoiDung (nguoiDungID, tennguoidung, pass) VALUES (2, 'doduy', '1');


select * from nguoidung

