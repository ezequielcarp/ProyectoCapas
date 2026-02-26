CREATE DATABASE BDpersona;
GO


USE BDpersona;
GO


CREATE TABLE PERSONA(
    id INT PRIMARY KEY IDENTITY(1,1),
    nombre varchar(50),
    edad int,
    celular varchar(10)
);
GO

INSERT INTO PERSONA (nombre, edad, celular) 
VALUES 
    ('MARTIN', 28, '1145678922'),
    ('LUCIA', 22, '1134567833'),
    ('DIEGO', 35, '1123456744'),
    ('SOFIA', 19, '1156789055'),
    ('CARLOS', 45, '1167890166'),
    ('VALERIA', 31, '1143210987'),
    ('FACUNDO', 26, '1154321098'),
    ('CAMILA', 24, '1165432109'),
    ('NICOLAS', 29, '1132109876'),
    ('JULIETA', 27, '1121098765');