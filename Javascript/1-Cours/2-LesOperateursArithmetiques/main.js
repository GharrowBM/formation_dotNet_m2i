
/**
 * Les Opérateurs Arithmétiques
 */

// Déclaration de plusieur variables à la volée
var nb = 10, nb1 = 5, nb2 = 5, resultat;

// L'addition
resultat = nb + nb2;
console.log(nb + " + " + nb2 + " = " + resultat);

// La soustraction
resultat = nb - nb2;
console.log(nb + " - " + nb2 + " = " + resultat);

// La multiplication
resultat = nb * nb2;
console.log(nb + " x " + nb2 + " = " + resultat);

// La division
resultat = nb / nb2;
console.log(nb + " / " + nb2 + " = " + resultat);

// Le modulo
resultat = nb % nb2;
console.log(nb + " % " + nb2 + " = " + resultat);

/**
 * Les notations simplifiées
 */

// l'addition
nb1 = nb1 + nb2;
console.log("Nb1 vaut : " + nb1);
// Peut s'ecrire
nb1 += 5;
console.log("Nb1 vaut : " + nb1);

// la soustraction
nb1 = nb1 - 5;
console.log("Nb1 vaut : " + nb1);
// Peut s'ecrire
nb1 -= 5;
console.log("Nb1 vaut : " + nb1);

// la multiplication
nb1 = nb1 * 5;
console.log("Nb1 vaut : " + nb1);
// Peut s'ecrire
nb1 *= 5;
console.log("Nb1 vaut : " + nb1);

// la division
nb1 = nb1 / 5;
console.log("Nb1 vaut : " + nb1);
// Peut s'ecrire
nb1 /= nb2;
console.log("Nb1 vaut : " + nb1);

// Le modulo
nb1 %= 2;
console.log(nb1);

/**
 * Les opérateurs d'incrémentation
 */

console.log("Nb vaut "+nb+" avant incrémentation");
// Incrémentation
nb = nb + 1;
// Simplifié en
nb += 1;
// Avec l'opérateur d'incrémentation
nb++;
console.log("Nb vaut "+nb+" aprés incrémentation");


console.log("Nb vaut "+nb+" avant décrémentation");
// Décrémentation
nb = nb - 1;
// Simplifié en
nb -= 1;
// Avec l'opérateur d'incrémentation
nb--;
console.log("Nb vaut "+nb+" après décrémentation");

/*
    Positionnement de l'opérateur incrémentation/décrementation
*/

// Affiche la valeur avant son incrémentation
nb1 =1;
console.log("nb1 vaut : "+nb1);
console.log(nb1++);
console.log("nb1 vaut : "+nb1);

// Affiche la valeur après son incrémentation
nb1 =1;
console.log("nb1 vaut : "+nb1);
console.log(++nb1);
console.log("nb1 vaut : "+nb1);
