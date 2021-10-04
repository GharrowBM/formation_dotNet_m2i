const express = require("express")
const path = require("path")

const webApp = express()

//route pour accéder à l'accueil
webApp.get('/', (req,res) => {
    res.sendFile(path.join(`${__dirname}/html/accueil.html`))
})

webApp.get('/contact', (req,res) => {
    res.sendFile(path.join(`${__dirname}/html/contact.html`))
})

webApp.get('/description', (req,res) => {
    res.sendFile(path.join(`${__dirname}/html/description.html`))
})

webApp.get('/qui-sommes-nous', (req,res) => {
    res.sendFile(path.join(`${__dirname}/html/qui-sommes-nous.html`))
})


webApp.listen(80)