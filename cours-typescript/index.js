"use strict";
// console.log("bonjour tout le monde")
exports.__esModule = true;
//Déclarer des variables
// let firstName:string = "ihab"
// // let, ou  const <nom_variable>:type , type=> string, number, boolean, tableau
// //Une fonction doit typé les paramètres, et peut avoir un type de retour => number, boolean, tableau, string, void
// const direBonjour = (nom:string) : void => {
//     console.log(nom)
// }
// //Déclarer des tableaux en typescript
// // const noms = ["toto", "tata", "titi"]
// const noms:Array<string> = ["toto", "tata", "titi"]
// const calcule = (a:number, b:number):number => {
//     return a+b
// }
// console.log(firstName+10)
var express = require("express");
var app = express();
app.get('/', function (req, res) {
    res.send("Bonjour tout le monde");
});
app.listen(80);
