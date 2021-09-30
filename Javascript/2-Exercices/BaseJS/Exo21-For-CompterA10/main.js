/**
 * Exercice21 - For - Compter à 10
 */


// Déclaration variables
var affichage = "<h2>Compter jusqu'à 10.</h2><br><ul>";

// Création de la constante result permettant de recupérer l'élément HTML class="result"
const result = document.querySelector('.result');

for (let i = 1; i <= 10; i++) {
    affichage += `<li>${i}</li>`;
}
affichage += "</ul><br><p><b>Super, je sais compter jusqu'à 10!</b></p>";

// Injection du résultat dans l'element HTML .result
result.innerHTML = affichage;