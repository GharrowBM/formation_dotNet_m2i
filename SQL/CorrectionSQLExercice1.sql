--Création de la table
CREATE TABLE personne (
id int PRIMARY KEY IDENTITY(1,1),
titre varchar(5) NOT NULL,
prenom varchar(100) NOT NULL,
nom varchar(100) NOT NULL,
email varchar(300) not null,
telephone varchar(10) not null
);

--INSERT INTO

insert into personne (titre, prenom, nom, email, telephone)
values ('Mlle', 'tata', 'toto', 'tata@toto.fr', '0987654321'),
('Mme', 'tota', 'toto', 'tata@toto.com', '0977654321'),
('Mr', 'titi', 'minet', 'titi@minet.fr', '0978654321')
;

--1 ere request
SELECT * FROM personne order by nom asc;
SELECT * FROM personne order by titre asc;
SELECT * FROM personne where email = 'tata@toto.fr'