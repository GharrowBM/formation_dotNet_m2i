/**
 * Les Tableaux Associatifs
 */

var personne ={
    nom:"Dupont",
    prenom:"Jean",
    age:25
}

// Affichage du tableau
console.table(personne);

// Affichage de la valeur de la clé nom
console.log(personne.nom);

// Affichage de la valeur de la clé prenom
console.log(personne["prenom"]);
