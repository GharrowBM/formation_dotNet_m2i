import Vegetal from "./Vegetal.js";

export default class Fleur extends Vegetal {
    constructor(nom, type){
        super(nom,type);
        this.Naissance();
    }
    Naissance(){
        console.log("Je viens d'une graine...");
        this.photosynthese=true;
    }
    Mort(){
        console.log("Je fane...");
        this.photosynthese=false;
    }
}