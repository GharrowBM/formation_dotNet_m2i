//Selection des champs et la récupération des valeurs dans des variables.
//

const btn = document.querySelector(".btn-danger")

//En javascript chaque élement du DOM peut avoir un, ou plusieurs event.

//Pour écouter un event sur un élement, on peut utiliser la fonction générique addEventListner
//Fonction avec deux paramètres, le premier => l'évenement et le deuxième => la fonction de callback

const executionClick = (bouton) => {
    const netImposable = parseFloat(document.querySelector("#montant").value)
    const nbEnfant = parseInt(document.querySelector("#nbEnfant").value)
    const nbAdulte = parseInt(document.querySelector("#nbAdulte").value)
    const result = document.querySelector("#resultat")

    const nbPart = nbAdulte + (nbEnfant > 2 ? (nbEnfant - 1) : nbEnfant / 2)
    if(netImposable>= 158122){

        montant_impot = Math.round((netImposable*0.45) - (20405.78 * nbPart));
    
    }else if(netImposable>= 73516){
    
        montant_impot = Math.round((netImposable*0.41) - (14080.90 * nbPart));
    
    }else if(netImposable>= 25710){
    
        montant_impot = Math.round((netImposable*0.30) - (5994.14 * nbPart));
    
    }else if(netImposable>= 10084){
    
        montant_impot = Math.round((netImposable*0.11) - (1109.24 * nbPart));
    
    }else{
         montant_impot = 0;
    }
    montant_impot = (montant_impot < 0) ? 0 : montant_impot
    result.innerHTML ="<div class='col alert alert-success p-1'>Votre impôt est de "+montant_impot+"€</div>"
}
btn.addEventListener('click', executionClick)