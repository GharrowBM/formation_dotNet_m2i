const express = require("express")
const path = require("path")
const app = express()

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
app.listen(80)