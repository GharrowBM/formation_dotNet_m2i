// console.log("Bonjour tout le monde")

// let nom = "abadi"

// console.log(nom)

//Lecture à partir de la console.
//pour appeler un module dans un script nodejs
//Il faut avoir le nom du module, et la savoir si le module est bien disponible.
//Fonction node pour charger un module qui s'appelle require.
const readline = require('readline')
// const fonctions = require('./fonction')
const {direBonjour} = require('./fonction')
// import { direBonjour } from './fonction'
//Création d'une interface pour définir le flux d'entrée.

const readFromConsole = readline.createInterface({
    //Flux d'entrée
    input: process.stdin,
    //flux de sortie
    output: process.stdout
})

//on peut utliser des events de readFromConsole

readFromConsole.question("Votre nom : ", (response) => {
    // console.log("Votre nom est "+ response)
    // fonctions.direBonjour(response)
    direBonjour(response)
})

//console.log("test")