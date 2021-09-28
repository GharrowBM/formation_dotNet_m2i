/**
 * Les Opérateurs Logiques
 */

// Création d'une constante
// const result = document.querySelector('.result');
// var resultat;
// /**
//  * split()
//  */

// var chaine = "Bonjour, comment allez-vous?";
// console.log(typeof(chaine));
// console.log(chaine.split(''));
// console.log(chaine.split(' '));
// console.log(chaine.split(','));

// /**
//  * reverse()
//  */

// var arrayChaine= chaine.split(' ').reverse();
// console.log(arrayChaine);

// /**
//  * join()
//  */

// console.log(arrayChaine.join('-'));
// console.log(arrayChaine.join(''));
// console.log(arrayChaine.join(' '));

// console.log(resultat);

// // Patch des résultats dans le DOM
// result.innerHTML += resultat;


//Définition d'une fonction
//pour créer une fonction en javascript:
// 1- on peut utiliser le mot clé function
//- chaque fonction peut avoir un ou plusieurs paramètres
// function direBonjour(nom="titi", message="coucou") {
//     //Instruction de la fonction
//     if(message != undefined && nom != undefined)
//         console.log(`Bonjour ${nom}, message : ${message}`)
//     else 
//         console.log("Merci d'indiquer le nom et le massage")
// }
// 2- Créer la fonction et la stocker dans une variable
// const direBonjour = function(nom, message) {
//     console.log(`Bonjour ${nom}, message : ${message}`)
// }
// Ecrire une fonction anonyme sans le mot function
// const direBonjour = (nom, message) => {
//     console.log(`Bonjour ${nom}, message : ${message}`)
// }



// direBonjour("ihab", "Message 1")
// direBonjour("toto", "Message 2")
// const firstName = "t1"
// const mes = "tmessage"
// direBonjour(firstName, mes)

//Un autre exemple de fonction avec un retour

const addition =  (a, b)  => {
    return a + b
}

//une fonction avec CallBack

const calcule = function (a, b, fonctionCalcule) {
    console.log(fonctionCalcule(a,b))
}

// const result = addition(10,20)
// console.log(result)

calcule(10,20, addition)

calcule(20,30, (t,y) => t-y)







