// Déclaration de variables
let rayon, perimetre, aire;

// Récupération, calcul des valeurs et stockage
rayon = Number(prompt("Veuilliez donner le rayon (en cm) du cercle"));
perimetre = Math.PI * (rayon*2);
aire = Math.PI * Math.pow(rayon, 2);

// Affichage dans l'HTML
document.querySelector("#insertHere").innerHTML = `
<h2> Utilisation de la constante π (pi)</h2>
La valeur de π est : <b>${Math.PI}</b>

<h2>Calcul du périmètre <i>(d x π)</i> et de l'aire <i>(π * r²)</i> d'un cercle</h2>
Diamètre = <b>${rayon*2}cm</b><br>
Périmètre = <b>${perimetre}cm</b><br>
Aire = <b>${aire}cm</b><br>
Périmètre (arrondi) = <b>${Math.round(perimetre)}cm</b><br>
Aire (arrondie) = <b>${Math.round(aire)}cm²</b>
`;