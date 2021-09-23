/**
 * EXERCICE04 - Les Variables et Opérateurs Arithmétiques - Les Palindromes
 */

// Création de la constante result permettant de recupérer l'élément HTML class="result"
const result = document.querySelector('.result');

// Declaration des variables
var mot,
    motLower,
    reverse;


// Insertion du titre dans la chaine affichage
affichage = "<h3>Ce mot est-il un palindrome?</h3><br>";

// Récupération mot utilisateur
mot = prompt("Veuillez saisir un mot");
motLower=mot.toLowerCase();

// affichage du mot de l'utilisateur
affichage += `Vous avez saisi : <b>${mot}</b> <br>`

// Invertion de la chaine de caractères
reverse = motLower.split('').reverse().join('');
affichage += `<br>le mot inversé : <b>${reverse}</b> <br>`

// Recherche de palindrome
if (reverse === motLower)
    affichage += `<br>Le mot <b>${mot}</b> est un palindrome<br>`
else
    affichage += `<br>Le mot <b>${mot}</b> n'est pas un palindrome<br>`

// Injection du résultat dans l'element HTML .result
result.innerHTML = `${affichage}`;