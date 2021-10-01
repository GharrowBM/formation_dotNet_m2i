/**
 * TRAVAUX PRATIQUE POO - HERITAGE - Class Véhicule
 */

//import class
import Voiture from "./modules/Voiture.js";
import Moto from "./modules/Moto.js";

// Création de la constante result permettant de recupérer l'élément HTML class="result"
const result = document.querySelector('.result');

// Instance de Voiture
let voiture = new Voiture("Renault","Kangoo","240.000","2003","Climatisée");

// Instance de Moto
let moto = new Moto("BMW","R1150R Rockster","65.000","2005");

// Injection du résultat dans l'element HTML .result
result.innerHTML += `
                    <div>${voiture.display()}</div>
                    <div>${moto.display()}</div>
                     `;