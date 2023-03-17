create database Veneza_Exchange
use Veneza_Exchange

create table contas(
id int IDENTITY(1,1),
usuario varchar(15),
senha	varchar(15)
);

select * from contas;

insert into contas values ('Viner', '123');

create table vendas(
id int identity(1,1),
tipo_ativo varchar(10),
nome_ativo varchar(7),
quantidade int,
valor decimal,
vendedor varchar(15)
);

create table compras(
id int identity(1,1),
tipo_ativo varchar(10),
nome_ativo varchar(7),
quantidade int,
valor decimal,
comprador varchar(15)
);


select * from compras;