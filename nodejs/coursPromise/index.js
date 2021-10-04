//Une promise est un objet qui permet d'executer du code en javascript d'une façon asynchrone.

//Pour créer une promise, on crée un objet de type Promise
//Une promise récupère comme paramètre une callback avec deux paramètres (Premier pour résoudre la promise, le deuxième pour la rejeter)
// const maPromise = new Promise((resolve, reject) => {            
//     setTimeout(() => {
//         //Une tâche lourde qui peut prendre 3 secondes pour l'executer
//         resolve("message de la promise")
//         //Si notre génère une  erreur, pour la renvoyer dans la promise,
//         //On utilse reject
//         //reject("echec de la promise")
//     }, 3000);
// })


//Une fonction qui fonctionne comme une promise mai en utilisant le mot clé async 
async function maPromise() {
    await setTimeout(() => {
        return "message de la promise async"
    }, 3000);
}


//A l'execution de la promise la réponse envoyer pa le resolver est récupèrer dans la méthode then
// maPromise.then(response => {
//     console.log("Tache finie, voici le resultat")
//     console.log(response)
// }).catch(err => {
//     console.log("désolé erreur d'execution, "+ err)
// })

//Pour attendre une promise, async et await

const result = maPromise()
console.log(result)