import Mammifere from './Mammifere.js'

export default class Chien extends Mammifere {
        
    Respiration(){
        console.log("Inspiration, expiration, j'ai des poumons...");
    }
    Alimentation(){
        console.log("Je mange des os et des croquettes");
    }
    Aboyer(){
        if(this.heartRate){
            console.log("Wouaf!");
        }
        else
            console.log("Je ne suis plus...");
    }
}