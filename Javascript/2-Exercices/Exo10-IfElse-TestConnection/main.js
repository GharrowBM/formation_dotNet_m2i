/**
 * Exercice10 - Conditions - Test Connection
 */

// Création de la constante result permettant de recupérer l'élément HTML class="result"
const result = document.querySelector('.result');

// Declaration des constantes email et mdp
const email = "contact@teamjs.fr";
const mdp = "leLundiAuSoleil";

// Récupération et stockage des saisie utilisateur
var userEmail = prompt("Saisir votre email");
var userPassword = prompt("Saisir votre mot de passe");

// Affichage titre
resultat="<h2>Test de connection</h2>";


// Etablissement Structure If() pour vérifier les saisies utilisateurs
if (userEmail == email) {
    // Si la saisie correspond à la variable mdp
    if (userPassword == mdp) 
        resultat+="Bienvenue sur votre espace sécurisé";       
    else 
        resultat+="Mot de passe incorrect";    
} 
else {
    resultat+="Email non reconnu"
}

// Affichage du résultat en alert()
//alert(resultat);
// Injection du résultat dans l'element HTML .result
result.innerHTML = `${resultat}`;