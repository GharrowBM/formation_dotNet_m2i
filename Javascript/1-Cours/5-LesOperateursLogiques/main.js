/**
 * Les Opérateurs Logiques
 */

// Création d'une constante
const result = document.querySelector('.result');

// Provoque une erreur
// const a;
// a = 5;
// console.log(a);

// Affichage de result
console.log(result);

/**
 * L'opérateur logique ET => &&
 */

// Exemple de vérification si un nombre se situe dans un range de valeurs
var resultat = "<h1> L'opérateur ET => && </h1>";
var nb = Number(prompt("Veuillez saisir une valeur entre 1 et 3 :"));
if (nb >= 1 && nb <= 3)
    resultat += `<p>Le nombre ${nb} est bien supérieur ou egal à 1 ET inférieur ou égal à 3.</p> `;
else
    resultat += `<p>Le nombre ${nb} n'est pas supérieur ou egal à 1 ET inférieur ou égal à 3.</p> `;

/**
 * L'opérateur logique OU => ||
 */

// Exemple de vérification si un nombre se situe hors d'un range de valeurs
resultat += "<br><hr><br><h1> L'opérateur OU => || </h1>";
if (nb < 1 || nb > 3)
    resultat += `<p>Le nombre ${nb} est bien inférieur à 1 OU supérieur à 3.</p> `;
else
    resultat += `<p>Le nombre ${nb} n'est pas inférieur à 1 OU supérieur à 3.</p> `;

/**
 * L'opérateur logique NON => ! (Contraire de...)
 */

// Exemple de vérification si un nombre se situe dans un range de valeurs
resultat += "<br><hr><br><h1> L'opérateur NON => ! (Contraire de) </h1>";

var pause = true;
if (!pause)
    resultat += `<p>Ce n'est pas l'heure de la pause</p> `;
else
    resultat += `<p>C'est l'heure de la pause!</p> `;




// Affichage de resultat dans la console
console.log(resultat);

// Patch des résultats dans le DOM
result.innerHTML += resultat;






