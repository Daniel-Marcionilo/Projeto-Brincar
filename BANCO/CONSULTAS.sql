use projeto_brincar;
select nome from brincadeiras order by nome asc; 


delete from brincadeiras where nome = 'Pega-Pega';

alter table brincadeiras add column descricao varchar(500);

desc brincadeiras;

select * from brincadeiras;  
SELECT * FROM brincadeiras ORDER BY RAND() LIMIT 1;


