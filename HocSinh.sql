CREATE TABLE HocSinh
(
    Ma       VARCHAR (100) NOT NULL,
    Ten      VARCHAR (255) NOT NULL,
    Diachi   VARCHAR (100) NOT NULL,
    Cmnd     VARCHAR (50)  NOT NULL,
    Ngaysinh DATETIME      NOT NULL,
    Email    VARCHAR (50)  NOT NULL,
    SoDT     VARCHAR (50)  NOT NULL
);
select * from HocSinh
delete from HocSinh
INSERT INTO HocSinh(Ma, Ten, Diachi, Cmnd, Ngaysinh, Email, SoDT)
VALUES('123', 'my', 'tra vinh', '334', 28-12-2003, 'my@', '429');
INSERT INTO HocSinh(Ma, Ten, Diachi, Cmnd, Ngaysinh, Email, SoDT)
VALUES('456', 'diemmy', 'tra vinh', '221', 28-12-2003, 'my@', '429');
INSERT INTO HocSinh(Ma, Ten, Diachi, Cmnd, Ngaysinh, Email, SoDT)
VALUES('789', 'mymy', 'tra vinh', '445', 28-12-2003, 'my@', '429');

