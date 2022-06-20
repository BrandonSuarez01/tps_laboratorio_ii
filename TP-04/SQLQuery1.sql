use clientesGuardados;
 
create table clientes 
( dni int not null, nombreApellido varchar(45) not null, producto varchar(20) not null, importe int not null, fecha date not null); 

insert into clientes (dni, nombreApellido, producto, importe, fecha)
values (43396325, 'Brandon Suarez', 'TECLADO', 5500, '2021/06/23'),
(47803308, 'Franco Suarez', 'PANTALLA', 25000, '2022/07/3'),
(28410769, 'Roberto Suarez', 'AURICULARES', 3500, '2022/09/25'),
(27456782, 'Ariel Suarez', 'MOUSE', 2500, '2022/08/13'), 
(38221223, 'Pedro Rodriguez', 'TARJETA DE VIDEO', 250000, '2021/02/12'),
(45673234, 'Roque Fernandez', 'PANTALLA', 30000, '2021/03/12');

select * from clientes;