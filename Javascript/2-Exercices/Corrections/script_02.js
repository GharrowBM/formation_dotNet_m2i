// Déclaration des variables
let nbA, nbB;

// Récupération des valeurs et casting en Number
nbA = Number(prompt("Veuilliez entrer un premier nombre SVP"));
nbB = Number(prompt("Veuilliez entrer un second nombre SVP"));

// Modification de l'HTML
document.querySelector("#insertHere").innerHTML = `
Vous avez saisi <b>${nbA}</b><br>
Vous avez saisi <b>${nbB}</b><br>
La somme de <b>${nbA}</b> + <b>${nbB}</b> = <b>${nbA + nbB}</b>
`;