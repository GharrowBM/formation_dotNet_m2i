-- LDD Langage de  définition de données
--Exemple de commande CREATE, ALTER, DROP
--Création de table
--CREATE TABLE  personne (
--	id int NOT NULL IDENTITY(1,1),
--	nom varchar(150),
--	prenom varchar(150)
--);
--CREATE TABLE voiture (
--	id int NOT NULL PRIMARY KEY IDENTITY(1,1),
--	model varchar(100)
--);
----Supprimer une table
--DROP TABLE personne;

----Modification
--ALTER TABLE personne ADD  telephone varchar(100);
--ALTER TABLE personne DROP COLUMN telephone;
--LMD langage manipulation des données
--Insertion
INSERT INTO voiture (model) values ('kia');

--Mettre à jour
UPDATE voiture set model = 'kia' WHERE id = 1;

--suppression
DELETE from voiture where id =1;

--Selection des données
SELECT model as toto, id from voiture where id < 3 
OR model like '%o%';