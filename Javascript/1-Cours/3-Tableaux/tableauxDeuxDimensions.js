/**
 *  Les tableaux à deux dimensions
 */

// declaration de deux tableaux
var legumes=["Carottes","Choux","Brocoli"];
var fruits=new Array("Raisin","Bananes","Abricots");

// Création d'un tableau à deux dimensions
var primeur= new Array(legumes, fruits);

// Affichage du tableau primeur
console.table(primeur);

// Affichage de Carottes
console.log(primeur[0][0]);

// Affichage de Abricots
console.log(primeur[1][2]);

// Déclaration d'un tableau mix

var zoo=[
    {
        pseudo:"Simba",
        espece:"Lion",
        continent:"Afrique"
    },
    {
        pseudo:"Tony",
        espece:"Kangourou",
        continent:"Océanie"
    }
];


// Afficher les pseudo de ces deux animaux
console.table(zoo);

console.log("Les pseudos sont "+zoo[0].pseudo+" et "+zoo[1].pseudo);