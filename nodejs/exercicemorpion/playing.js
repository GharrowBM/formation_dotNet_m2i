const readline = require('readline')
const { Game } = require('./game')
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
    
    //Attribut game
    game = new Game()
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
            let joueur = this.isFirstPlayer ? 'X' : 'O'
            let position =  await this.getCasePosition(joueur)
            
            this.game.play(joueur, parseInt(position.x), parseInt(position.y))
          
            this.game.draw()
            //On inverse le joueur
            this.isFirstPlayer = !this.isFirstPlayer
        }
    }
}

exports.Playing = Playing