/**
 * EXERCICE17Bis - IFELSE - Calcul des Impôts - HTML
 */

// Création de la constante result permettant de recupérer l'élément HTML class="result"
const result = document.querySelector('.result');
const btnValider = document.querySelector('#btnValider');

// Déclaration de variables
let revenus = 0,
    nbAdulte = 0,
    nbEnfant = 0,
    nbParts = 0,
    revenuImposable = 0,
    montantImpot = 0;

function Valider() {

    // Récupération et stockage des saisie utilisateur
    revenus = parseInt(document.querySelector('#revenu').value);
    nbAdulte = parseInt(document.querySelector('#nbAdultes').value);
    nbEnfant = parseInt(document.querySelector('#nbEnfants').value);

    // Calcul du nombre de parts
    if (revenus > 0 && nbAdulte > 0)
        nbParts = nbPart();
    console.log("Nbparts" + nbParts)

    // Calcul du montant des l'impôt
    revenuImposable = revenus / nbParts;
    console.log(revenuImposable);
    if (revenuImposable >= 10085 && revenuImposable <= 25710)
        montantImpot = Math.round((revenuImposable - 10084) * 0.11);
    else if (revenuImposable >= 25711 && revenuImposable <= 73516)
        montantImpot = Math.round((revenuImposable - 25711) * 0.30 + (25711 - 10085) * 0.11);
    else if (revenuImposable >= 73517 && revenuImposable <= 158122)
        montantImpot = Math.round((revenuImposable - 73516) * 0.41 + (73516 - 25710) * 0.30 + (25711 - 10085) * 0.11);
    else if (revenuImposable >= 158123)
        montantImpot = Math.round((revenuImposable - 158122) * 0.45 + (158122 - 73516) * 0.41 + (73516 - 25710) * 0.30 + (25711 - 10085) * 0.11);
    console.log(montantImpot);

    // Calcul de l'impot par le nbpart
    montantImpot *= nbParts;

    // Affiche le résulta dans la console
    //console.log(montantImpot);

    // Execute la méthode afficher()
    Afficher();
    // Nettoyage des champs
    clear();
}

function nbPart() {
    // Calcul du nombre de part
    if (nbEnfant <= 2)
        nbParts = nbAdulte + nbEnfant * 0.5;
    else
        nbParts = nbAdulte + nbEnfant - 1;
    return nbParts;
}
function clear() {
    document.querySelector('#revenu').value = "";
    document.querySelector('#nbAdultes').value = "";
    document.querySelector('#nbEnfants').value = "";
}

function Afficher() {
    // Injection du résultat dans l'element HTML .result
    result.innerHTML = `<p>Le montant de l'impôt pour un revenu fiscal de <b>${revenus}€</b> avec  <b>${nbAdulte} alulte(s)</b>
                        et <b>${nbEnfant} enfant(s)</b> s'éléve à <b>${montantImpot}€</b>. </p>`;
}






