// Import de la classe Vehicule
import Vehicule from './modules/Vehicule.js';

function getTicket() {

    let id = prompt("Saisir sa plaque d'immatriculation");

    // Création d'un nouveau Vehicule et ajout dans le tableau de vehicules
    vehicules.push(new Vehicule(id));

    alert("Veuillez prendre votre ticket");
    console.log(vehicules);
}

function getDiffDate(date1, date2) {
    let diff = (date2 - date1) / 60000; // pour obtenir des minutes à partir de la valeur en ms
    return diff;
}

function parkingPayment(id) {
    let duree, prix;

    /*for (const vehicule of vehicules) {
        if (id == vehicule.id) {
            // On stocke la date de sortie du véhicule
        }
    }*/

    const vehicule = vehicules.find(function(vehicule) {
        return vehicule.id == id;
    });

    // On stocke l'heure de sortie du véhicule
    vehicule.endDate = new Date();

    // Calculer et afficher le prix à payer
    duree = getDiffDate(vehicule.startDate, vehicule.endDate);

    if (duree <= 15) {
        prix = 0.8;
    } else if (duree <= 30) {
        prix = 1.3;
    } else if (duree <= 45) {
        prix = 1.7;
    } else {
        prix = 6;
    }

    alert(`Le prix à payer est de ${prix} €`);
}

const vehicules = new Array();
// Cas de tests pour valider les tarifs
vehicules.push(new Vehicule("AA-123-AA", new Date("2020-04-08T12:14:00")));
vehicules.push(new Vehicule("BB-123-BB", new Date("2020-04-08T11:54:00")));
vehicules.push(new Vehicule("CC-123-CC", new Date("2020-04-08T11:35:00")));

let choix, currentId;

do {

    choix = Number(prompt(`1 - Obtenir un ticket\n2 - Payer le parking\n0 - Commande secrète pour Regis`));

    if (choix == 1) {
        // Délivre un ticket
        getTicket();
    } else if (choix == 2) {

        // Décodage du ticket (on simule l'insertion du ticket dans la machine)
        currentId = prompt("Plaque du véhicule sortant");

        // Paiement du parking
        parkingPayment(currentId);
    }

} while (choix != 0);