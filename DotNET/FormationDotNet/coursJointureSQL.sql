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

CREATE TABLE produit(
	id int PRIMARY KEY IDENTITY(1,1),
	titre varchar(100) not null,
	prix decimal not null
);

INSERT INTO produit(titre, prix) values
('product 1', 100),
('product 2', 200),
('product 3', 300);


--Utilisation des fonctions
SELECT count(*) as nombre from produit where prix > 20;
SELECT SUM(prix) as totalPrix from produit;
SELECT AVG(prix) as moyenne from produit;

--utilisation des requêtes imbriquées.
SELECT AVG(prix) as moyenne from
(SELECT prix from produit where titre like '%produit%') as produitTmp;

SELECT SUM(prix) from produit where 
id IN (SELECT id from produit where titre like '%product%');