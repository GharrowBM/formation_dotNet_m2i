/**
 * Les Boucles et Itérations
 */

// Création d'une constante
const result = document.querySelector('.result');

// Déclaration de variables
var resultat="";


/**
 * La Boucle tant que : while
 */

// Exemple de boucle while : compter jusqu'a 10
var i = 1;
while(i<=10){
    console.log(`La boucle while s'est exécutée ${i} fois.`);
    i++; // Attention aux boucles infinies
}

/**
 * La Boucle tant que : Do...while
 */
//i=1; // Reset de i
// Exemple de boucle faire tant que while : compter jusqu'a 10
console.log("Avant la boucle do...while "+i);
do{
    console.log(`La boucle while s'est exécutée ${i} fois.`);
    i++; // Attention aux boucles infinies
}while(i<=10)

/**
 * La boucle Pour : FOR (var itération; condition de sortie ; incrémentation)
 */

//i=1;
for(i=1; i<=10; i++) {
    
}
for(i=10 ;  i>=1 ; i-=2){
    console.log(`La boucle while s'est exécutée ${i} fois.`);
}

/**
 * EXERCICE
 * A partir du tableau numérique suivant :
 * 
 * var names = ["Adam", "Etienne", "Sebastien", "Clement", "Virginie"];
 * 
 * 1/ Gràce à une boucle for, afficher la liste des prenoms du tableau
 * 2/ Gràce à une boucle while, afficher la liste des prenoms du tableau
 */
 var names = ["Adam", "Etienne", "Sebastien", "Clement", "Virginie"];

// 1 - boucle for

for (var j = 0; j < names.length; j++) {
    console.log(names[j]);
}

// 2 - boucle while

i = 0;
while(i < names.length) {
    console.log(names[i]);
    i++;
}

/**
 * Boucle Pour... dans : For...in
 */

// Parfaite pour les tableau associatif
var contact ={
    nom:"Richard",
    prenom:"Pierre",
    telephone:"0123456789",
    email:"prichard@gmail.com"
}

// Utilisation de la boucle for...in pour le parcourir
for(var key in contact){
    console.log(key); /// Affiche les clé
    console.log(contact[key]); // Affiche les valeur des clé
    console.log(key+" : "+contact[key]); // Affiche les valeur des clé
}

/**
 * La boucle for... of
 */

// utilisation du tableau names ci-dessus
for (var j = 0; j < names.length; j++) {
    console.log(names[j]);
}
// Avec une boucle for... of
for(const name of names){
    console.log(`La boucle for...of, names contient ${name}`);// var is deprecated, use "const" or "let"
}



// Affichage de resultat dans la console
//console.log(resultat);

// Patch des résultats dans le DOM
result.innerHTML += resultat;






