//npm est un outil de gestion de dépendance.

const readline = require('readline-sync')

const nom = readline.question("Merci de saisir votre nom : ")

console.log(nom)

const password = readline.question("Merci de saisir un mot de passe : ", {hideEchoBack:true})
console.log(password)
