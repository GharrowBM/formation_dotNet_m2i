/**
 * Les nouveautés apportées par l'ES6
 * 
 * (Le JS est une implémentation de la spécification ECMA 6)
 */

/**
 * let
 * 
 * Jusqu'a présent , on déclaré var comme mot clé pour toutes les variables
 * Maintenant utilisons let, voyons pourquoi:
 */

console.log(prenomVar); // Hoisting (remonté de la déclaration des variables)
//console.log(nomlet); // Uncaught ReferenceError: nomlet is not defined

var prenomVar = "Anthony";// undefine

let nomLet = "Di Persio";// provoque une erreur

/**
 * const
 * 
 * déclaration de constante
 */
console.log("---------- Const ----------")
const nbMax = 128;
console.log("NbMax / 2 : " + nbMax / 2);
//nbMax = 130; // Uncaught TypeError: Assignment to constant variable.

const fruits = ["pomme"];
console.table(fruits);
//fruits= ["Abricot","Poire"];//Uncaught TypeError: Assignment to constant variable.
fruits.push("Abricot", "Poire");
console.table(fruits);

/**
 * Les nouvelles méthodes apportées par l'ES6
 * 
 * .foreach()
 * .map()
 * .find()
 * .filter()
 * 
 */
console.log("---------- Nouvelles méthodes ES6 ----------")

// Déclaration d'un tableau de légumes (2 dimensions)

const vegetables = [
    {
        code: 1,
        nom: "Carotte",
        price: 1.99
    },
    {
        code: 2,
        nom: "Poivron Vert",
        price: 4.99
    },
    {
        code: 3,
        nom: "Poivron Rouge",
        price: 4.99
    },
    {
        code: 4,
        nom: "Haricot Vert",
        price: 3.89
    },
    {
        code: 5,
        nom: "Courgette",
        price: 2.5
    }
];

console.table(vegetables);
console.log("---------- Parcours du tazbleau avec .foreach(vegetable) ----------")

// .foreach(vegetable)
vegetables.forEach(function (vegetable) {
    console.log(vegetable.nom);
})

console.log("---------- Parcours du tableau avec .foreach(vegetable,index) ----------")

// .foreach(vegetable,index)
vegetables.forEach(function (vegetable, index) {
    console.log((index + 1) + " - " + vegetable.nom);
})

// .map()
console.log("---------- Parcours du tableau avec .map() ----------")

const listVegetables = vegetables.map(function (vegetable) {
    return vegetable.nom;
});

console.table(listVegetables);

//.find()
console.log("---------- Parcours du tableau avec .find() ----------")

const poivron = vegetables.find(function (vegetable) {
    return vegetable.nom.includes("Poivron");
});
console.log(poivron);

//.filter()
console.log("---------- Parcours du tableau avec .filter() ----------")

const poivrons = vegetables.filter(function (vegetable) {
    return vegetable.nom.includes("Poivron");
});
console.table(poivrons);

/**
 * Les litéraux de gabarit
 * 
 * Nouvelle possibilité de concaténer les variables dans les
 * chaines de caracteres à l'aide d'un nouveau caractère
 * de templating " ` " = backtic
 */

console.log("---------- Les litéraux de gabarit ----------");

let prenom = "jean";
let nom = "Valjean";

console.log("Bonjour " + nom + " " + prenom);
console.log(`Bonjour ${prenom} ${nom}, tu vas bien?`);

/**
 * Destructuring
 * 
 * Accès simplifié à un élément d'un tableau, d'un objet...
 */

console.log("---------- Le Destructuring ----------");
console.log("---------- Avec Tableau numérique ----------");

// AVEC TABLEAU
const tabNum = [1, 2, 3];
//  // En ES5
//  const a = tabNum[0];
//  const b = tabNum[1];

// En ES6 avec le destructuring
const [a, b] = tabNum;

// AFfichage
console.log(a);
console.log(b);

console.log("---------- Avec tableau associatif ----------");

// AVEC TABLEAU ASSOCIATIF
const user = {
    firstname: "Jean",
    lastname: "Dupond",
    age: 35,
    active: true
};

//  // En ES5
//  const firstname=user.firstname;
//  const lastname=user.lastname;

// En ES6 avec le destructuring
const { firstname, lastname } = user

console.log(`Avec destructirun d'objet ${firstname} ${lastname}`)

// AVEC DES FONCTION
console.log("---------- Avec des Fonction() ----------");

// Fonction sans destructuring
// function getFullName( user){
//     return `${user.firstname} ${user.lastname}`;
// }
// console.log("Sans destructuring de méthode : "+getFullName(user));


// Fonction avec Destructuring
function getFullName({ firstname, lastname }) {
    return `${firstname} ${lastname}`;
}
console.log("Avec destructuring de méthode : " + getFullName(user));

/**
 * LES FONCTIONS FLECHEES --> Arrow Function
 * 
 * Pour ecrire une fonction fléchée, nous allons utiliser un opérateur
 * que l'on appelle FAT ARROW =>
 */

console.log("---------- Arrow Function ----------");

// Cas 1
// Sans parametre
let test = function () {
    return "Toto";
}
// Equivalent à
test = () => {
    return "Toto";
}
// Simplification seulement si la fonction ne fait qu'un return
test = () => "Toto";

// Cas 2 
// Avec 1 parametre
let test2 = function (vegetable) {
    return vegetable.nom;
}
// Equivalent à
test2 = (vegetable) => {
    return vegetable.nom;
}
// Simplification seulement si la fonction ne fait qu'un return
test2 = (vegetable) => vegetable.nom;

// Cas 3 
//Au moins deux paramètres
let test3 = function (firstname, lastname) {
    return `${firstname} ${lastname}`;
}
// Equivalent à
test3 = (firstname, lastname) => {
    return `${firstname} ${lastname}`;
}
// Simplification seulement si la fonction ne fait qu'un return
test3 = (firstname, lastname) => `${firstname} ${lastname}`;

console.log(test3("Anthony", "Di persio"));


/**
 * rest opérator
 * 
 * ...
 */
console.log("---------- Rest operator ----------");
console.table(vegetables);

//let haricot = vegetables[3]; // Crée une réference vers l'objet vegetable[3], la copie n'en est pas vraiment une
let haricot = { ...vegetables[3] };

console.log(haricot);
console.log(vegetables[3]);

haricot.price = 2.99;

console.log(haricot);
console.log(vegetables[3]);
console.table(vegetables);

// Autre exemple avec destructuring

const tabNum2 = [1, 2, 3, 4];
console.table(tabNum2);
//  // En ES5
//  const a = tabNum[0];
//  const b = tabNum[1];

// En ES6 avec le destructuring
const [c, ...d] = tabNum2;

// AFfichage
console.log(c);
console.log(d);

/**
 * Valeur par défaut des parametres d'une fonction
 */
console.log("---------- Valeur par défaut des fonctions ----------");

function carre(nb = 10) {
    return nb * nb;
}

console.log("Avec parametre de méthodes" + carre(5));//25
console.log("sans parametre de méthodes" + carre());//100


/**
 * CLASSES
 * 
 * Introduit par l'ES6
 */
console.log("---------- les classes ----------");

class Personne {

    constructor(prenom, nom){
        this.firstname = prenom;
        this.lastname = nom;
        this.heart = true;
    }

    getFullName(){
        return `${this.firstname} ${this.lastname}`;
    }
}
// let var1 = prompt("Veuillez saisir un nom");
// let var2 = prompt("Veuillez saisir un prenom");

// let personne1 = new Personne(var2, var1);

// console.log(personne1);
// console.log(personne1.firstname);
// console.log(personne1.getFullName());

/**
 * L'héritage en Javascript
 * 
 * Comment preceder ? Avec l'utilisaion du mot clé "extends"
 */

class Cadre extends Personne{
    constructor(prenom, nom, metier="Cadre"){
        super(prenom, nom);
        this.job=metier;
    }

    getJob(){
        return `${this.job}`;
    }
    getFullName(){
        return true;
    }
    display(){
        return `${super.getFullName()} - ${this.job}`;
    }
}
let personne2 = new Cadre("Toto","Titi","CEO");
console.log(personne2.getFullName());
console.log(personne2.getJob());
console.log(personne2.display());

























