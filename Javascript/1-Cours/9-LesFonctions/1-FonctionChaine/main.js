/**
 * Les Opérateurs Logiques
 */

// Création d'une constante
const result = document.querySelector('.result');
var resultat;
/**
 * split()
 */

var chaine = "Bonjour, comment allez-vous?";
console.log(typeof(chaine));
console.log(chaine.split(''));
console.log(chaine.split(' '));
console.log(chaine.split(','));

/**
 * reverse()
 */

var arrayChaine= chaine.split(' ').reverse();
console.log(arrayChaine);

/**
 * join()
 */

console.log(arrayChaine.join('-'));
console.log(arrayChaine.join(''));
console.log(arrayChaine.join(' '));

console.log(resultat);

// Patch des résultats dans le DOM
result.innerHTML += resultat;






