/**
 * Les Classes
 */

import Chien from "./modules/Chien.js";
import Fleur from "./modules/Fleur.js";

let medor = new Chien("Médor", "Berger Allemmand");
let cosmos = new Fleur("Cosmos", "Cosmos Sulphureus");

medor.Aboyer();

console.log(`Les battements de coeur de médor ${medor.heartRate}`);
console.log(`La phtosyntese de cosmos ${cosmos.photosynthese}`);

let etresVivants = [medor, cosmos];

for(let etre of etresVivants){
    console.log(`----- ${etre.nom} -----`);
    etre.Respiration();
    etre.Alimentation();
    etre.Mort();
    console.log(`-------------------`);
}

console.log(`Les battements de coeur de médor ${medor.heartRate}`);
console.log(`La phtosyntese de cosmos ${cosmos.photosynthese}`);

medor.Aboyer();
