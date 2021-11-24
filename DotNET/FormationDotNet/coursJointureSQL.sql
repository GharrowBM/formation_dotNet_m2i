CREATE TABLE adresse (
	id int PRIMARY KEY IDENTITY(1,1),
	rue varchar(1000) not null,
	ville varchar(200) not null,
	code_postal varchar(5) not null,
	personne_id int not null
);

INSERT INTO adresse (rue, ville, code_postal, personne_id)
values ('rue 1', 'lille', '59000', 1),
('rue 2', 'tourcoing', '59200', 2),
('rue 3', 'orchies', '59310', 3);

--inner join
SELECT * FROM personne as p inner join adresse as a 
on p.id = a.personne_id;

--left join
SELECT * FROM personne as p left join adresse as a 
on p.id = a.personne_id;

--right join
SELECT p.id as personne_id, a.id as adresse_id, a.ville FROM personne as p right join adresse as a 
on p.id = a.personne_id;