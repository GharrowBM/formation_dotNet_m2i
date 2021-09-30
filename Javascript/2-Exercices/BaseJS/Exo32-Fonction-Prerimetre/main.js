/**
 * Exercice32 - LES FONCTIONS() - Perimètre
 */

// Création de la constante result permettant de recupérer l'élément HTML class="result"
const result = document.querySelector('.result');

// Création de la Fonction() permettant de calculer les périmetre à partir de deux parametres
function perimetre(longueur, largeur) {
    // resultat est une variable locale, elle n'existe que dans la fonction perimetre
    var resultat = (longueur + largeur) * 2;
    // La fonction retourne la variable resultat
    return resultat;
}

// Récupération et stockage des saisie utilisateur
var long = Number(prompt("Saisir une longueur"));
var larg = Number(prompt("Saisir une largeur"));

console.log(typeof(long)); // Attention le prompt retourne une chaine même pour les nombres
// Solution : transformer une chaine en nombre -> Number() (Casting)


// Déclaration d'une variable résultat prenant la valeur de retour de la fonction perimetre()
var resultat = perimetre(long, larg);

// Affichage de la valeur de la variable result dans la console
console.log(`Le périmètre de votre quadrilatère est ${resultat}cm`);

// Injection du résultat dans l'element HTML .result
result.innerHTML = `${resultat} cm`;