--Création de la table
CREATE TABLE livre (
id int PRIMARY KEY IDENTITY(1,1),
titre varchar(200) not null,
auteur varchar(100) not null,
editeur varchar(100) not null,
date_publication date,
isbn_10 varchar(10) not null,
isbn_13 varchar(14) not null);

DROP TABLE livre;

--QUESTION 1
SELECT * FROM livre order by titre asc;
--QUESTION 2
SELECT * FROM livre order by date_publication asc;

--QUESTION 3

SELECT TOP 10 date_publication from livre order by date_publication asc;

--QUESTION 4
SELECT TOP 10 * from livre order by date_publication asc;

--QUESTION 5
SELECT TOP 10 date_publication, auteur, titre from livre order by date_publication asc;

--QUESTION 6
SELECT * FROM livre where auteur = 'Agatha Christie';

--QUESTION 7
UPDATE livre set auteur = 'Agatha Christie' where auteur = 'Agatha Christies';

--QUESTION 8

INSERT INTO livre (titre, auteur, editeur, date_publication, isbn_10, isbn_13) values (
'Ainsi parla zarathoustra', 'Nietzsche', 'amazon', '01-01-2021', 'XXXXXXXXXX', 'XXX-XXXXXXXXXX');

--QUESTION 9
DELETE FROM livre where auteur = 'Nietzsche';

