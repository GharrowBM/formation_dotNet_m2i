// Commentaire sur une ligne

/*
    Commentaire
    Multi
    Lignes
*/

/**
 * Les variables
 */

// Déclarer une variable en js
var prenom;

// Affectaction de valeur à la variable
prenom = "Anthony";

// Affichage dans la console
console.log(prenom);

// Les type des variables
// On ne définit pas le type à la création de la variable
// Mais lors de l'affectation de sa valeur
// (Variable auto typé)
console.log(typeof(prenom));

// Déclaration de variable numérique
var age = 42;

// Affichage de la variable numérique dans la console
console.log(age);

// Affichage du type de la variable age
console.log(typeof(age));

// Concaténation de varibles
console.log("Bonjour, je m'appel "+prenom+" et j'ai "+age+" ans");
console.log(`Bonjour, je m'appel ${prenom} et j'ai ${age} ans`);