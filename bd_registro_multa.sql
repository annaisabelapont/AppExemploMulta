create database bd_registro_multa;
use bd_registro_multa;

create table veiculo(
	id int primary key auto_increment,
    modelo varchar(25),
    marca varchar(20),
    placa varchar(10)
);

create table multa(
	id int primary key auto_increment,
    descricao varchar(30),
    valorMulta decimal,
    veiculoId int,
    
    foreign key (veiculoId) references veiculo(id)
);
