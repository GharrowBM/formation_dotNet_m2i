"use strict";
// console.log("bonjour tout le monde")
exports.__esModule = true;
var person_class_1 = require("./classes/person.class");
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
// import * as express from "express"
// import { Request, Response } from "express"
// const app = express()
// app.get('/', (req:Request,res:Response) => {
//     res.send("Bonjour tout le monde")
// })
// app.listen(80)
//Utilisation d'objet en typescript
var p = new person_class_1.Person('toto', 'tata');
//Utilisation de la méthode afficher
p.afficher();
var a = { address: "Mon adresse", city: "Tourcoing", postCode: "59200" };
