const result = document.querySelector("#result")
const chapitre = document.querySelector("#chapitre")
const partie = document.querySelector("#partie")
const creation = document.querySelector("#creation")
//const taille = 4

//Récupérer les valeurs de chaque champs
//Ajouter un evenement click sur le bouton
//Générer le menu



//Fonction qui génère le menu et sous menu en fonction des paramètres chapitre et partie
const makeMenu = (chapitre, partie) => {
    let bloc = ""
    for (let i = 1; i <= chapitre; i++) {
        bloc += `<h3 class="row"><span class="col">Chapitre ${i}</span></h3>`
        bloc += "<ul class='row list-group'>"
        for (let j = 1; j <= partie; j++) {
            bloc += `<li class='col-12 list-group-item'>Partie ${i}.${j}</li>`
        }
        bloc += "</ul>"
    }
    return bloc
}

const executionClick = () => {
    const valChapitre = parseInt(chapitre.value)
    const valPartie = parseInt(partie.value)

    //Appelle la fonction makeMenu et on injecte le résultat dans l'html de la div result
    result.innerHTML = makeMenu(valChapitre, valPartie)
}

//Event click sur le bouton
creation.addEventListener('click', executionClick)