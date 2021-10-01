/**
 * EXERCICE16 - IFELSE - Taille Vêtements
 */

// Création de la constante result permettant de recupérer l'élément HTML class="result"
const result = document.querySelector('.result');
const btnValider = document.querySelector('#btnValider');

// Déclaration de variables
let indemnite = 0;
let salaire = 0;
let anciennete = 0;
let age = 0;


function userData() {
    // Récupération et stockage des saisie utilisateur
    salaire = parseInt(document.querySelector("#salaire").value);
    anciennete = parseInt(document.querySelector("#anciennete").value);
    age = parseInt(document.querySelector("#age").value);
    console.log(salaire);
    console.log(anciennete);
    console.log(age);
}


function Valider() {
    userData();

    // Etablissement d'une structure conditionnelle afin de déterminer le montant de la prime
    if (anciennete >= 1 && anciennete <= 10) {
        indemnite += anciennete * salaire / 2;
    }
    if (anciennete > 10) {
        indemnite += 10 * salaire / 2;
        indemnite += (anciennete - 10) * salaire;
    }
    if (age > 45)
        indemnite += age < 50 ? 2 * salaire : 5 * salaire;

    Affichage();
}

function Affichage() {
    // Injection du résultat dans l'element HTML .result
    result.innerHTML = `<p>Le montant de l'indemnité pour un salaire de <b>${salaire}€</b> et un age de <b>${age} ans</b>
                        avec une ancienneté de <b>${anciennete}</b> s'éléve à <b>${indemnite}€</b>.</p>`;
}



