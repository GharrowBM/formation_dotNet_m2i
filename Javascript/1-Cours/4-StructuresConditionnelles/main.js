/**
 * Les structures Conditionnelles
 */

/*
    L'instruction Si... Alors ... Sinon...

    if(condition){

    }
    else{

    }

*/
var age;
//var age = Number(prompt("Veuillez saisir votre age :"));

console.log(age);
console.log(typeof (age));

if (age >= 18) {
    console.log(`A ${age} ans, vous êtes majeur`);
}
else {
    console.log(`A ${age} ans, vous êtes mineur`);
}

var compte = 00;
if (compte > 0) {
    console.log(`Vous avez ${compte}€, vous êtes créditeur`);
}
else if (compte == 0) {
    console.log(`Vous avez ${compte}€, solde est nul`);
}
else {
    console.log(`Vous avez ${compte}€, vous êtes débiteur`);
}

/**
 * Le Switch case
 */
choix=5;

switch (choix) {
    case 0:
        console.log(`Vous avez fait le choix 0`);
        break;
    case 1:
        console.log(`Vous avez fait le choix 1`);
        break;
    default:
        console.log(`C'est le cas par defaut`);
        break;
}



switch (true) {
    case compte>0:
        console.log(`Vous avez ${compte}€, vous êtes créditeur(switch)`);
        break;
    case compte==0:
        console.log(`Vous avez ${compte}€, votre solde est null(switch)`);
        break;
    default:
        console.log(`Vous avez ${compte}€, vous êtes débiteur(switch)`);
        break;
}

/**
 * Les Operateurs de comparaison
 * 
 *  == signifie est égal à => Permet de vérifier que deux variables sont égale en valeur
 * 
 *  === signifie strictement égal à => Permet de vérifier que deux variables sont égale en valeur et en type
 * 
 *  != signifie est différent de => Permet de vérifier que deux variables sont différente
 * 
 *  !== signifie est strictement différent de => Permet de vérifier si le type OU la valeur sont différent
 */

console.log(1==1); // vrai
console.log("1"==1); // vrai
console.log(1===1); // vrai
console.log("1"===1); // faux
console.log("1"!=1); // faux
console.log("3"!==3); // vrai
console.log(3!==3); // faux
console.log(4!==3); // true






