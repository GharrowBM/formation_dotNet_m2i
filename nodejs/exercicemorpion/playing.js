const readline = require('readline')
const { Game } = require('./game')
const { notrePropreQuestion } = require('./tools')

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
        casePosition.x = await notrePropreQuestion("cord i : ")
        casePosition.y = await notrePropreQuestion("cord j: ")
        return casePosition
    }

    async gamerPlay() {
        //Tant que le jeu n'est pas términé
        while(!this.endGame) {
            //Récupère la position la case
            let joueur = this.isFirstPlayer ? 'X' : 'O'
            let position =  await this.getCasePosition(joueur)
            
            if(!this.game.play(joueur, parseInt(position.x), parseInt(position.y))) {
                console.log("Impossible de jouer cette case")
            }else {
                this.game.draw()
                this.endGame = this.game.testWin(joueur)
                //On inverse le joueur
                this.isFirstPlayer = !this.isFirstPlayer
            }
        }
    }
}

exports.Playing = Playing