create database projeto_brincar;
use projeto_brincar;

create table brincadeiras (
codBrinc int primary key auto_increment not null,
nome varchar(150) not null,
image longblob not null,
descricao varchar(500) not null
); 



select * from brincadeiras;

select * from brincadeiras where nome ='teste1' and descricao='teste1';

update brincadeiras set nome = '2345', descricao = '980' where codBrinc = 1;

update brincadeiras set nome = 'teste' where codBrinc = 1;






