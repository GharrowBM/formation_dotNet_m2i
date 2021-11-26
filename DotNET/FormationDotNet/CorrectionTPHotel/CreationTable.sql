CREATE TABLE client (
id int PRIMARY KEY IDENTITY(1,1) NOT NULL,
nom varchar(100) NOT NULL,
prenom varchar(100) NOT NULL,
telephone varchar(10) NOT NULL
);



CREATE TABLE chambre (
id int PRIMARY KEY IDENTITY(1,1) NOT NULL,
statut varchar(30) NOT NULL,
prix int NOT NULL,
nb_max int NOT NULL
);



CREATE TABLE reservation (
id int PRIMARY KEY IDENTITY(1,1) NOT NULL,
client_id int NOT NULL,
statut int NOT NULL,
);



CREATE TABLE reservation_chambre (
id int PRIMARY KEY IDENTITY(1,1) NOT NULL,
chambre_id int NOT NULL,
reservation_id int NOT NULL
);