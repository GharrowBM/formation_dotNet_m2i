import Contact from "./js/Contact.js";

// Création de la constante result permettant de recupérer l'élément HTML class="result"
const tableau = document.querySelector('#tableau');
const btnValider = document.querySelector('#valider');

console.log(Date.now());

// Déclaration des variables
let contacts = [];

function updateList() {
    tableau.innerHTML = `
                <thead>
                    <th class="title">Titre</th>
                    <th class="title">Nom</th>
                    <th class="title">Prénom</th>
                    <th class="title">Date Naissance</th>
                    <th class="title">Telephone</th>
                    <th class="title">Email</th>
                </thead>
    `;
    for (let contact of contacts) {
        tableau.innerHTML += `<tr>
                                <td>${contact.titre}</td>    
                                <td>${contact.nom}</td> 
                                <td>${contact.prenom}</td>   
                                <td>${contact.dateNaissance}</td>   
                                <td>${contact.telephone}</td>    
                                <td>${contact.email}</td>    
                            </tr>`;
    }
}


function createFake() {

    // Création d'un tableau de personne à deux dimensions
    let annuaire = [
        {
            titre: "Mr",
            nom: "Dupont",
            prenom: "Jean",
            dateNaissance: "1973,10,08",
            telephone: "+(33)6 12 36 54 78",
            email: "jdupont@gmail.com"
        },
        {
            titre: "Mme",
            nom: "Doe",
            prenom: "Jeanne",
            dateNaissance: "1985,02,24",
            telephone: "+(33)6 45 23 87 14",
            email: "jdoe@yahoo.fr"
        },
        {
            titre: "Mr",
            nom: "Martin",
            prenom: "Jacques",
            dateNaissance: "1933,06,22",
            telephone: "+(33)6 78 45 24 95",
            email: "jmartin@petitrapporteur.fr"
        }
    ];

    // Ajout des contact à contacts
    for (let contact of annuaire) {
        let cTmp = new Contact(contact.titre, contact.nom, contact.prenom, new Date(contact.dateNaissance).toLocaleDateString(), contact.telephone, contact.email);
        contacts.push(cTmp);
    }
}

btnValider.onclick = () => {
    // Recupération des valeur utilisateur
    const nom = document.querySelector("#nom").value;
    const prenom = document.querySelector("#prenom").value;
    const dateNaissance = document.querySelector("#dateNaissance").value;
    const telephone = document.querySelector("#telephone").value;
    const email = document.querySelector("#email").value;

    //S'il est coché, on récupère la valeur du bouton radio.
    let titre;
    if (document.getElementById('Mr').checked) {
        titre = "Mr";
    }
    else {
        titre = "Mme";
    }
    let cTmp = new Contact(titre, nom, prenom, new Date(dateNaissance).toLocaleDateString(), telephone, email);
    console.log(cTmp);
    contacts.push(cTmp);
    updateList();
    resetForm();
};

function resetForm() {
    document.querySelector("#nom").value = "";
    document.querySelector("#prenom").value = "";
    document.querySelector("#dateNaissance").value = "";
    document.querySelector("#telephone").value = "";
    document.querySelector("#email").value = "";
}

// Methode Init
function init() {
    createFake();
    updateList();
    // Affichage du résultat dans la console
    console.table(contacts);
    console.log(contacts[1].prenom + " " + contacts[1]["nom"]);
}

window.onload = init();