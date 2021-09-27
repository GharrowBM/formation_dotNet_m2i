const result = document.querySelector('.result');

let affichage = "";
const nomCat = ["Baby","Poussin","Pupille","Minime","Cadet"]
const Age = prompt('Entrez l\'âge de votre enfant').replace(",",".");
const regex = /^[0-9]+$/i; // Détecte seulement les chiffres

if (Age.match(regex)) {
    if (Age >= 18 || Age < 3) {
        affichage += `Votre enfant n'a pas l'âge requis pour avoir une licence.`
    } else {
        let i = "";
        if (Age >= 3 && Age <= 6) {
            i = 0;
        }
        if (Age >= 7 && Age <= 8) {
            i = 1;
        }
        if (Age >= 9 && Age <= 10) {
            i = 2;
        }
        if (Age >= 11 && Age <= 12) {
            i = 3;
        }
        if (Age >= 13) {
            i = 4;
        }
        affichage += `Vous pouvez inscrire votre enfant en catégorie ${nomCat[i]}.`
    }
} else {
    affichage += `Veuillez entrer seulement des chiffres.`
}

result.innerHTML += affichage;





