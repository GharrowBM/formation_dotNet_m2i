const express = require("express")
const path = require("path")
const app = express()

const users = [
    {firstName: 'ihab', lastName: 'abadi'},
    {firstName: 'tata', lastName: 'toto'},
]

//Le moteur de rendu utilisé est ejs
app.set('view engine', 'ejs')
app.get('/', (req, res) => {
    //res.sendFile(path.join(__dirname+"/html/home.html"))
    res.render("html/home")
})

app.get('/contact', (req, res) => {
   // res.sendFile(path.join(__dirname+"/html/contact.html"))
   res.render("html/contact")

})

app.get('/description', (req,res) => {
    let description = "Ma description dynamique"
    res.render("html/description", {
       description: description 
    })
})

app.get('/users', (req, res) => {
    res.render("html/users", {
        utilisateurs: users
    })
})

//définition d'une route en GET avec un paramètre id
app.get('/users/:id', (req, res) => {
    //Le paramètre req de la fonction callback contient un objet params avec les différents paramètres dynamique dans l'url
    let id = req.params.id
    res.render("html/user", {
        id: id
    })
})
app.listen(80)