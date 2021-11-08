//pour exporter un élément en utisant les normes es6+ => il suffit d'ajouter le mot clé export avant l'élément qu'on shouaite exporter
//
export const direBonjour = (nom) => {
    console.log("Bonjour "+ nom)
}


//ES5 (Supprimer export devant la déclaration const)
//exports.direBonjour = direBonjour