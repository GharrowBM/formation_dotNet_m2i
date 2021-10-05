const express = require("express")

const app = express()

//stock nos produits dans un tableau js
let products = [
    {name: 'produit 1', description: 'description produit 1', price: 10, category: 'cat 1'},
    {name: 'produit 2', description: 'description produit 2', price: 20, category: 'cat 1'},
    {name: 'produit 3', description: 'description produit 3', price: 30, category: 'cat 2'},
    {name: 'produit 4', description: 'description produit 4', price: 40, category: 'cat 2'},
    {name: 'produit 5', description: 'description produit 5', price: 50, category: 'cat 1'},
    {name: 'produit 6', description: 'description produit 6', price: 60, category: 'cat 3'},
    {name: 'produit 7', description: 'description produit 7', price: 70, category: 'cat 3'},
]

//Dossier pour les ressources statiques (css, javascript)
app.use(express.static(__dirname+"/assets"))


//Indiquer que le moteur de rendu est ejs
app.set("view engine","ejs")


//Route accueil
app.get('/', (req,res) => {
    //Renvoie le rendu généré par ejs à partir de la page  products.ejs
    res.render("pages/products", {
        products: products
    })
})

//Route afficher un produit
app.get('/product/:id', (req,res) => {
    const id = req.params.id
    if(products.length > id) {
        res.render('pages/product', {
            product : products[id],
            id: id
        })
    }
    else {
        res.render('pages/error')
    }
})

//Route pour supprimer un produit
app.get('/deleteproduct/:id', (req, res) => {
    const id = req.params.id
    if(products.length > id) {
        products.splice(id,1)
        res.redirect("/")
    }
})

app.listen(80)



