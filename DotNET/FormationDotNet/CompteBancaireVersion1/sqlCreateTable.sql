--Table Client
CREATE TABLE client (
	id int primary key identity(1,1),
	nom varchar(100) not null,
	prenom varchar(100) not null,
	telephone varchar(100) not null
);

--Table compte

CREATE table compte(
	id int primary key identity(1,1),
	solde decimal not null,
	client_id int not null
);

--Table operation

CREATE table operation(
	id int primary key identity(1,1),
	montant decimal not null,
	compte_id int not null,
	date_operation datetime not null
);