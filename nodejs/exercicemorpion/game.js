class Game {

    //L'attribut qui contient le contenu de notre plateau du jeu, un tableau avec 3 tableaux, chaque tableau est une ligne
    board = []
   
    constructor() {
        //On  rempli notre plateau par 3 lignes, chaque ligne contient 3 éléments vide
        for(let i=1; i<=3; i++) {
            this.board = [...this.board, [' ',' ',' ']]
        }
    }

    // Une méthode qui récupère le joueur(X,O), le numéro de la ligne et le numéro de la col
    play(gamer, x, y) {
        //On vérfie si la case est vide
        if(this.board[x-1][y-1] == ' ') {
            //Si c'est vrai, on ajoute le caractère du joueur dans la case
            this.board[x-1][y-1] = gamer
            return true
        }
        return false
    }

    //Une méthode pour dessiner notre plateau
    draw() {
        //Pour chaque ligne,
        for(let i=0; i < this.board.length; i++) {
            //On crée la ligne
            let ligne = ' '
            //On rempli la ligne par les valeurs des cases
            for(let j=0; j < this.board.length; j++) {
                ligne += '|'+ this.board[i][j] + '|'
            }
            //On affiche la ligne
            console.log(ligne)
            console.log('----------')
        }
    }

    testWin(gamer) {
        return false
    }   
}
exports.Game = Game