/**
 * EXERCICE16 - IFELSE - Taille Vêtements
 */

// Création de la constante result permettant de recupérer l'élément HTML class="result"
const result = document.querySelector('.result');

// Déclaration de variables
let indemnite = 0;

// Récupération et stockage des saisie utilisateur
let salaire = parseInt(prompt("Veuillez saisir le dernier :"));
let anciennete = parseInt(prompt("Veuillez saisir l'ancienneté :"));
let age = parseInt(prompt("Veuillez saisir l'age :"));

// Etablissement d'une structure conditionnelle afin de déterminer le montant de la prime
if (anciennete >= 1 && anciennete <= 10) {
    indemnite += anciennete * salaire / 2;
}
if (anciennete > 10) {
    indemnite += 10 * salaire / 2;
    indemnite += (anciennete - 10) * salaire;
}

if (age > 45) {

    if (age < 50) {
       indemnite+= 2 * salaire;
    } else {
       indemnite+= 5 * salaire;
    }

    //indemnite += age < 50 ? 2 * salaire : 5 * salaire;
}


// Injection du résultat dans l'element HTML .result
result.innerHTML = `<p>Le montant de l'indemnité pour un salaire de <b>${salaire}€</b> et un age de <b>${age} ans</b>
avec une ancienneté de <b>${anciennete}</b> s'éléve à <b>${indemnite}€</b>.</p>`;