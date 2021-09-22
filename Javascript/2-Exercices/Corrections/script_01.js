let x1 = '1';
x1 += 1;
x1 -= 1;
console.log(x1);

var compte = 4, compte2 = 3;

switch (compte, compte2) {
    case 4,3 : 
    console.log("Hello");
}
// Création des deux variables prénom et nom de famille
let personFirstName, personLastName;

//Récupération du prénom et mise en forme
personFirstName = prompt("Quel est votre prénom ?");
personFirstName = personFirstName[0].toUpperCase() + personFirstName.substring(1).toLowerCase();

// Récupération du nom de famille et mise en forme
personLastName = prompt("Quel est votre nom de famille ?");
personLastName = personLastName.toUpperCase();

// Modification de l'HTML pour affichage des valeurs
document.querySelector("#insertHere").innerHTML = `
Vous avez saisi : <b>${personFirstName}</b><br>
Vous avez saisi : <b>${personLastName}</b><br>
Bonjour <b>${personFirstName} ${personLastName}</b>
`;