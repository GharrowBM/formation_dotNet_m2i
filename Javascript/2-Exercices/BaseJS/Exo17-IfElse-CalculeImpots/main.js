/**
 * EXERCICE17 - IFELSE - Calcul impots
 */

// Création de la constante result permettant de recupérer l'élément HTML class="result"
const result = document.querySelector('.result');

// Déclaration de variables
let revenus = 0,
    nbAdulte = 0,
    nbEnfant = 0,
    nbParts = 0,
    revenuImposable = 0,
    montantImpot = 0;


// Récupération et stockage des saisie utilisateur
revenus = parseInt(prompt("Veuillez saisir Le revenu fical de référence :"));
nbAdulte = parseInt(prompt("Veuillez saisir le nombre d'adultes :"));
nbEnfant = parseInt(prompt("Veuillez saisir le nombre d'enfants :"));

// Calcul du nombre de part
if (nbEnfant <= 2)
    nbParts = nbAdulte + nbEnfant * 0.5;
else
    nbParts = nbAdulte + nbEnfant - 1;

// // Calcul du nombre part en sugar syntaxe
// nbParts = nbEnfant <= 2 ? nbAdulte + nbEnfant * 0.5 : nbAdulte + nbEnfant - 1;

// Calcul du montant des l'impôt
revenuImposable = revenus / nbParts;

if (revenuImposable >= 10085 && revenuImposable <= 25710)
    montantImpot = Math.round((revenuImposable - 10084) * 0.11);
else if (revenuImposable >= 25711 && revenuImposable <= 73516)
    montantImpot = Math.round((revenuImposable - 25711) * 0.30 + (25711 - 10085) * 0.11);
else if (revenuImposable >= 73517 && revenuImposable <= 158122)
    montantImpot = Math.round((revenuImposable - 73516) * 0.41 + (73516 - 25710) * 0.30 + (25711 - 10085) * 0.11);
else if (revenuImposable >= 158123)
    montantImpot = Math.round((revenuImposable - 158122) * 0.45 + (158122 - 73516) * 0.41 + (73516 - 25710) * 0.30 + (25711 - 10085) * 0.11);

montantImpot *= nbParts;

console.log(montantImpot);

// Injection du résultat dans l'element HTML .result
result.innerHTML = `<p>Le montant de l'impôt pour un revenu fiscal de <b>${revenus}€</b> avec  <b>${nbAdulte} alulte(s)</b>
et <b>${nbEnfant} enfant(s)</b> s'éléve à <b>${montantImpot}€</b>. </p>`;