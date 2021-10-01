/**
 * Exercice17 - IfElse - Calcul Impôts
 */
// Déclaration variables
var revenus = 0,
    nbAdulte = 0,
    nbEnfants = 0,
    nbParts = 0,
    revenuIMpossable = 0,
    montantImpot = 0;

// Création de la constante result permettant de recupérer l'élément HTML class="result"
const result = document.querySelector('.result');

// Récupération et stockage des saisie utilisateur
var revenus = Number(prompt("Veuillez saisir le montant total des revenus du foyer :"));
var nbAdulte = Number(prompt("Veuillez saisir le nombre d'alulte(s) :"));
var nbEnfants = Number(prompt("Veuillez saisir le nombre d'enfant(s):"));

// Calcul du nombre de parts du foyer            
if (nbEnfants <= 2)
    nbParts = nbAdulte + nbEnfants * 0.5;
else
    nbParts = nbAdulte + nbEnfants - 1;

// Sugar Syntaxe (ternaire) pour le Calcul du nombre de parts
//nbParts = nbEnfants <= 2 ? nbAdulte + nbEnfants * 0.5 : nbAdulte + nbEnfants - 1;



// Etablissement Structure If() pour calculer le montant de l'impôt
revenuImposable = revenus / nbParts;

switch (true) {
    case revenuImposable >= 10085 && revenuImposable <= 25659:
        montantImpot = Math.round((revenuImposable - 10084) * 0.11); break;
    case revenuImposable >= 25711 && revenuImposable <= 73369:
        montantImpot = Math.round((revenuImposable - 25710) * 0.3 + 1718.75); break;
    case revenuImposable >= 73517 && revenuImposable <= 157806:
        montantImpot = Math.round((revenuImposable - 73516) * 0.41 + 1718.75 + 14341.8); break;
    case revenuImposable >= 158123:
        montantImpot = Math.round((revenuImposable - 158122) * 0.45 + 1718.75 + 14341.8 + 34688.46); break;
}

montantImpot = montantImpot * nbParts;

// Injection du résultat dans l'element HTML .result
result.innerHTML = `Le montant de l'impôt sur le revenu pour un foyer composé de <b>${nbAdulte} adulte(s)</b> et
                    de <b>${nbEnfants} enfant(s)</b>, avec un revenu fiscal de <b>${revenus}€</b> 
                    s'élève à <b>${montantImpot}€</b>`;