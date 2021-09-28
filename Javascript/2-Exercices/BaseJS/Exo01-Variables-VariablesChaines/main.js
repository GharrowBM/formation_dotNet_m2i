/**
 * Exercice 01 - VARIABLES - Les variables type chaines
 */

// Création d'une constante
const result = document.querySelector('.result');

// Déclaration des variables
var prenom="",
    nom="",
    resultat="",
    affichage="";

affichage="<h3> Addition de deux variables de type chaine </h3>";

// recupération des saisies utilisateur
prenom=prompt("Veuillez saisir votre prénom");
affichage+=`<p>Vous avez saisi : <b>${prenom}</b></p>`;
nom=prompt("Veuillez saisir votre nom");
affichage+=`Vous avez saisi : <b>${nom}</b><br>`;


// Addition des deux variables string
resultat=prenom+" "+nom;

// Redaction du résultat à retourner à l'utilisateur
affichage+=`<br>Bonjour <b>${prenom}</b> <b>${nom}</b> = <b>${resultat}</b> `;



// Affichage du résultat en alert
alert(resultat);

// Patch des résultats dans le DOM
result.innerHTML += affichage;






