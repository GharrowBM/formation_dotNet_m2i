class Game {
    board = []
   
    constructor() {
        for(let i=1; i<=3; i++) {
            this.board = [...this.board, [' ',' ',' ']]
        }
    }

    play(gamer, x, y) {
        if(this.board[x-1][y-1] != '') {
            this.board[x-1][y-1] = gamer
            return true
        }
        return false
    }

    draw() {
        for(let i=0; i < this.board.length; i++) {
            let ligne = ' '
            for(let j=0; j < this.board.length; j++) {
                ligne += '|'+ this.board[i][j] + '|'
            }
            console.log(ligne)
            console.log('----------')
        }
    }
}
exports.Game = Game