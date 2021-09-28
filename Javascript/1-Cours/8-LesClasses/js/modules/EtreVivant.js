
export default class EtreVivant {
    constructor(nom, type){
        this.nom=nom;
        this.type=type;
    }
    Naissance(){
        console.log("Tout les etres vivant maissent...");
    }
    Mort(){
        console.log("Tout les etres vivant meurent...");
    }
    Respiration(){
        console.log("Tout les etres vivant respirent... à leur manière");
    }
    Alimentation(){
        console.log("Tout les etres vivant mangent... à leur manière");
    }
}