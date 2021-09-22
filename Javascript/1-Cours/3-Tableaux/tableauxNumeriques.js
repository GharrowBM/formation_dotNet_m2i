
/**
 * Les Tableaux Numériques
 */

// Déclaration des tableaux (2 façons)
var monTableau = [];
var monTableau = new Array();

// Affichage du type
console.log(typeof(monTableau));

// Affectation de valeur à un tableau numérique
monTableau[0]="Pomme"; // j'affecte à la premiere position de mon tableau la valeur pomme
monTableau[1]="Poire"; // j'affecte à la deuxieme position de mon tableau la valeur Poire

// Affichage de mon tableau
console.log(monTableau);
console.table(monTableau);

// Affichage d'une valeur à un index
console.log("En premiere position : "+monTableau[0]);
console.log("En deuxieme position : "+monTableau[1]);

// Déclaration et assignation en une instruction
var legumes = ["Carottes","Choux","Haricots"];
// equivaut à var legumes = new Array("Carottes","Choux","Haricots");

// Réafectation de valeur
console.table(legumes)
console.log(legumes[2]);
legumes[2]="Epinard"; // change la valeur en Haricot en Epinard
console.table(legumes);
console.log(legumes[2]);

// Recupérer la taille de notre tableau
console.log("Taille du tableau légumes : "+legumes.length);

// Ajouter un ou plusieur elements au tableau
legumes.push("Courgette");
console.table(legumes);
legumes.push("Potiron","Aubergines");
console.table(legumes);

// Retirer la dernier entree d'un tableau [pop()]
legumes.pop();
console.table(legumes);

// Retirer la dernier entree d'un tableau [shift()]
legumes.shift();
console.table(legumes);

// On rajoute des élément pour créer des doublons
legumes.push("Courgette");
console.table(legumes);
legumes.push("Potiron","Aubergines");
console.table(legumes);

// Retirer un ou plusieurs éléments du tableau
legumes.splice(2,2);
console.table(legumes);

// Ajouter des éléments à un index donné
legumes.splice(2,0,"Concombre");
console.table(legumes);

// Remplacer un élément à un index donné
legumes.splice(2,2,"Brocoli");
console.table(legumes);






