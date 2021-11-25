-- Table produits

CREATE TABLE produit (
	id int PRIMARY KEY IDENTITY(1,1),
	titre varchar(200) not null,
	prix decimal not null,
	stock int not null
);

--Table vente
CREATE TABLE vente (
	id int PRIMARY KEY IDENTITY(1,1),
	total decimal not null,
	etat varchar(100),
	type_paiement int not null
);

--TABLE vente_produit
CREATE table vente_produit (
	id int PRIMARY KEY IDENTITY(1,1),
	produit_id int not null,
	vente_id int not null
);
