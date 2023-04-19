drop database BdiExamen;
create database BdiExamen;
create table tblExamen(
idExamen int not null primary Key identity(1,1),
nombre varchar(255) not null,
descripcion varchar(255) not null
);

