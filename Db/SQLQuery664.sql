Create Database Sistema

Use Sistema

Create table Persona
(Usuario Varchar (25),
Contraseña Varchar (25),
);

Create table Cliente
(Id_cliente int not null primary key,
Nombre Varchar (25),
Apellido Varchar (25),
Direccion varchar (25),
Telefono int
);

select  *from Cliente 

Create table Provedores
(Id_Prov int not null primary key,
Tipo Varchar (25),
Direccion varchar (25),
Telefono int
);


insert into Provedores values (1,'Agricola', 'Zona 4', 23568343 )
insert into Provedores values (2,'Agricola', 'Zona 6', 98561243 )
select *from Provedores 
