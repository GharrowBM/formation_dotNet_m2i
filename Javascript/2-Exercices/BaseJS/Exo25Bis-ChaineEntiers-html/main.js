/**
 * EXERCICE25 - FOR - Entiers Chainés
 */

// Déclaration variables
let nombre = 0,
    debut,
    fin,
    duree,
    affichage = `<h2>Listes d'entiers chaînés</h2><br><hr>`;

// Création de la constante result permettant de recupérer l'élément HTML class="result"
const result = document.querySelector('.result');
const input = document.querySelector('#nbUser');


function valider() {
    // Récupération saisie utilisateur
    nombre = input.value;

    // Affichage de la saisie
    affichage += nombre >= 0 && nombre < 10 ? `<p>Vous avez saisi le chiffre <b>${nombre}</b></p>` : `<p>Vous avez saisi le nombre <b>${nombre}</b></p>`;

    //console.log(isNaN(nombre));
    // Mettre en place les boucles pour générer les chaines d'entiers
    if (!isNaN(nombre)) {

        affichage = `<p>Voici la liste d'entiers dont la sommes correspond a ${nombre}</p><ul>`;

        // mise en place de la structure imbriqué pour recherche les liste d'entier = nombre
        debut = new Date();
        //console.log(debut);
        for (let i = 1; i < nombre / 2; i++) {
            let chaine = `${nombre} = ${i}`;
            let somme = i;
            for (let j = i + 1; j < nombre / 2 + 1; j++) {
                somme = somme + j;
                chaine += ` + ${j}`;
                if (somme == nombre) {
                    affichage += `<li>${chaine}</li>`;
                    break;
                }
                if (somme > nombre)
                    break;
            }
        }
        fin = new Date();
        duree = fin - debut;
        console.log(duree + " ms");
        affichage += "</ul>";
        result.innerHTML = affichage;
        input.value="";
    }
};

input.addEventListener("keyup", function (event) {
    if(event.key ==="Enter"){
        valider();
    }
});
