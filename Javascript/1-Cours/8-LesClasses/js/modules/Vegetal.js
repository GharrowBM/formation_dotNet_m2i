import EtreVivant from "./EtreVivant.js";

export default class Vegetal extends EtreVivant {
    constructor(nom, type){
        super(nom,type);
        this.photosynthese=false;
    }

    Respiration(){
        console.log("Je rejette de l'O2 le jour, la nuit je rejette du CO2");
    }
    Alimentation(){
        console.log("Je me nourris par les racines et le soleil");
    }
}