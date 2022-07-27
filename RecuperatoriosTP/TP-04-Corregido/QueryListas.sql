use master
CREATE DATABASE ListasdeServicios
go
use ListasdeServicios
go
create table clientes 
(id int identity (1,1) not null,
nombreApellido varchar(45) not null,
dni int not null,
fecha date not null,
constraint PK_Id Primary key (id))
go
create table servicios
(idServ int identity (1,1) not null,
precio int not null,
servicio varchar(45) not null,
dias varchar(10) not null,
equipo varchar(45) not null, 
constraint PK_IdServ Primary key (idServ),
constraint FK_Id_Clientes Foreign key (idServ) references clientes(id))
go
insert into clientes(nombreApellido, dni, fecha)
values('Suarez Brandon', 43396325, '2021/04/14 '),
('Franco Suarez', 47803308, '2021/04/15 '),
('Jose Gonzalez', 28456098, '2021/05/16 ')
go
insert into servicios(precio, servicio, dias, equipo)
values(4000, 'Mantenimiento', '7', 'PS4'),
(57000, 'Venta', '4','PC'),
(1500, 'Mantenimiento', '4', 'PS3')




