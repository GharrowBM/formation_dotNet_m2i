const readline = require('readline')
const { notrePropreQuestion } = require('./tools')
const readLineInterface = readline.createInterface({
    input:process.stdin,
    output: process.stdout
})

// const {notrePropreQuestion} = require('./tools')
class Playing {
    //Attribut premier joueur
    isFirstPlayer = true

    //Attribut pour fin de jeu
    endGame = false
    
    //cette méthode permet de demander à un jour de saisir les cords d'une case
    async getCasePosition(player) {
        console.log("Joueur : "+player)
        let casePosition = {x:0, y:0}
        console.log("Merci de saisir la X : ")
        //Une fonction qui permet de récupérer le resultat saisi dans la console
        casePosition.x =  await (await readLineInterface[Symbol.asyncIterator]().next()).value
        console.log("Merci de saisir la Y : ")
        casePosition.y =  await (await readLineInterface[Symbol.asyncIterator]().next()).value
        return casePosition
    }
    async gamerPlay() {
        //Tant que le jeu n'est pas términé
        while(!this.endGame) {
            //Récupère la position la case
            let position = await this.getCasePosition(this.isFirstPlayer ? 'X' : 'O')
            console.log(position)
            //On inverse le joueur
            this.isFirstPlayer = !this.isFirstPlayer
        }
    }
}

exports.Playing = Playing