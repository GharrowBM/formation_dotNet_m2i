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


 


// Affichage de resultat dans la console
//console.log(resultat);

// Patch des résultats dans le DOM
result.innerHTML += resultat;






