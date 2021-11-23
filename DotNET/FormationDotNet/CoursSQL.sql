-- LDD Langage de  définition de données
--Exemple de commande CREATE, ALTER, DROP
--Création de table
CREATE TABLE  personne (
	id int NOT NULL IDENTITY(1,1),
	nom varchar(150),
	prenom varchar(150)
);

--Supprimer une table
DROP TABLE personne;