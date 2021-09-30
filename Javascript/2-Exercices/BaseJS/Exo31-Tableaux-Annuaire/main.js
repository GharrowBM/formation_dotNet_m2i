// Création de la constante result permettant de recupérer l'élément HTML class="result"
const result = document.querySelector('.result');
const tableau = document.querySelector('#tableau');

// Création d'un tableau de personne à deux dimensions
var annuaire = [
    {
        nom: "Dupont",
        prenom: "Jean",
        age: 15
    },
    {
        nom: "Durant",
        prenom: "Pierre",
        age: 16
    },
    {
        nom: "Martin",
        prenom: "Jean",
        age: 17
    }
];

for(let contact of annuaire){
    tableau.innerHTML+=`<tr>
                            <td>${contact.prenom}</td>    
                            <td>${contact.nom}</td>    
                            <td>${contact.age}</td>    
                        </tr>`;
}

// Affichage du résultat dans la console
console.table(annuaire);
console.log(annuaire[1].prenom + " " + annuaire[1]["nom"]);

// Injection du résultat dans l'element HTML .result
result.innerHTML ="<b>"+ annuaire[1].prenom + " " + annuaire[1].nom +"</b>";