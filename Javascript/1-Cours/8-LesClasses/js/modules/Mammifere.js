import EtreVivant from "./EtreVivant.js";

export default class Mammifere extends EtreVivant {
    constructor(nom, type){
        super(nom,type);
        this.heartRate=false;
        this.Naissance();
    }

    Naissance(){
        super.Naissance();
        console.log("Naisssance après la gestion");
        this.heartRate=true;
    }

    Mort(){
        console.log("Mon coeur s'arrête de battre!");
        this.heartRate=false;
    }    
}