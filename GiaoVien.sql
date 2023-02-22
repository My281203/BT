
CREATE TABLE GiaoVien
(
    Ma       VARCHAR (50) NULL,
    Ten      VARCHAR (50) NULL,
    Diachi   VARCHAR (50) NULL,
    Cmnd     VARCHAR (50) NULL,
    Ngaysinh DATETIME     NULL,
    Email    VARCHAR (50) NULL,
    SoDT     VARCHAR (50) NULL
);
select * from GiaoVien
delete from GiaoVien
INSERT INTO GiaoVien(Ma, Ten, Diachi, Cmnd, Ngaysinh, Email, SoDT)
VALUES('123', 'my', 'tra vinh', '334', 28-12-2003, 'my@', '429');
INSERT INTO GiaoVien(Ma, Ten, Diachi, Cmnd, Ngaysinh, Email, SoDT)
VALUES('456', 'diemmy', 'tra vinh', '774', 28-12-2003, 'my@', '429');
INSERT INTO GiaoVien(Ma, Ten, Diachi, Cmnd, Ngaysinh, Email, SoDT)
VALUES('789', 'mymy', 'tra vinh', '331', 28-12-2003, 'my@', '429');
