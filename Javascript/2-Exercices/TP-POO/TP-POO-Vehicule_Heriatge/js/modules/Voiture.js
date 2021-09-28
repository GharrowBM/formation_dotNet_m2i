// import class Vehicule
import Vehicule from "./Vehicule.js";

// START Class Voiture
export default class Voiture extends Vehicule{
    constructor(marque, modele,kilometrage,annee,clim="non-climatisée"){
        super(marque, modele,kilometrage,annee);
        this.clim = clim;
    }
    // Override de la méthode display()
    display(){
        return `<b>Voiture :</b> ${super.display()} - ${this.clim}`;
    }
}
// END Class Voiture