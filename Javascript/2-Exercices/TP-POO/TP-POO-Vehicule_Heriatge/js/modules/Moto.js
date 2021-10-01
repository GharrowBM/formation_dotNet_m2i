// import class Vehicule
import Vehicule from "./Vehicule.js";

// START Class Moto
export default class Moto extends Vehicule{
    // Override de la méthode display()
    display(){
        return`<b>Moto :</b> ${super.display()}`;
    }
}
// END Class Moto