//Import de la dependance express
const express = require("express")

//Import path
const path = require("path")


//On crée une application express pour générer une application web
const app = express()

//On intercepte la request sur la racine de l'application en verb GET
//Méthode get accepte deux paramètres, le premier => l'url, le deuxième est la fonction de callback qui prend comme paramètre un objet avec la request
// et un autre pour créer une reponse.
app.get('/', (req,res) => {
    //On renvoie une réponse avec une chaine de caractère à la request
    res.end("Bonjour sur notre serveur web")
})

app.get('/fichierHtml', (req, res) => {
    res.sendFile(path.join(__dirname+'/html/page.html'))
})


//L'application express ecoute le port 4000
app.listen(4000)