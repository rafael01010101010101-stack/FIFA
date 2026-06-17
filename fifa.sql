create database fifa;

use fifa;

create table selecoes(
	codigo int primary key not null auto_increment,
    nome varchar(50) not null,
    localidade varchar(50) not null,
    totalCopas int not null,
    grupo varchar(10) not null
)engine = InnoDB;

select * from selecoes;
