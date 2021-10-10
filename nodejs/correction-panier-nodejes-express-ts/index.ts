import * as express from "express"
import {Request, Response} from "express"
import { Product } from "./interfaces/product.interface"
 

const app = express()
// const bodyParser = require("body-parser")
//stock nos produits dans un tableau js
let products:Array<Product> = [
    {name: 'produit 1', description: 'description produit 1', price: 10, category: 'cat 1',},
    {name: 'produit 2', description: 'description produit 2', price: 20, category: 'cat 1',},
    {name: 'produit 3', description: 'description produit 3', price: 30, category: 'cat 2'},
    {name: 'produit 4', description: 'description produit 4', price: 40, category: 'cat 2'},
    {name: 'produit 5', description: 'description produit 5', price: 50, category: 'cat 1'},
    {name: 'produit 6', description: 'description produit 6', price: 60, category: 'cat 3'},
    {name: 'produit 7', description: 'description produit 7', price: 70, category: 'cat 3'},
]

//Dossier pour les ressources statiques (css, javascript)
app.use(express.static(__dirname+"/assets"))

app.use(express.urlencoded())
//Indiquer que le moteur de rendu est ejs
app.set("view engine","ejs")


//Route accueil
app.get('/', (req:Request,res:Response) => {
    //Renvoie le rendu généré par ejs à partir de la page  products.ejs
    let productsToDispaly = products
    //Dans le cadre de la recherche dans les params de la req, on aura un paramètre search non udenfined
    const search:string = <string>req.query.search
    console.log(req)
    if(search != undefined) {
        productsToDispaly = products.filter(e => e.name.includes(search))
    }    
    res.render("pages/products", {
        products: productsToDispaly
    })
})

//Route afficher un produit
app.get('/product/:id', (req:Request,res:Response) => {
    const id:number = parseInt(req.params.id)
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
app.get('/deleteproduct/:id', (req:Request,res:Response) => {
    const id:number = parseInt(req.params.id)
    if(products.length > id) {
        products.splice(id,1)
        res.redirect("/")
    }
})

//route pour le formulaire ajout du produit
app.get('/formProduct', (req:Request,res:Response) => {
    res.render('pages/form-product', {product:undefined, id: undefined})
})

//Route qui renvoie le formulaire, en récupérant le produit à modifier
app.get('/formProduct/:id', (req:Request,res:Response) => {
    //Récupération de l'id  du produit
    const id:number = parseInt(req.params.id)
    if(products.length > id) {
        //Récupération du produit
        const product:Product = products[id]
        res.render('pages/form-product', {product:product, id: id})
    }else {
        res.render('pages/error')
    }
})

//Action pour valider le formulaire
app.post('/submitProduct', (req:Request,res:Response) => {
    //Soit on fait de l'ajout, soit c'est la modification

    const id = parseInt(req.body.id)
    //Un nouveau produit
    if(id== -1) {
        products = [...products, {name:req.body.name, price: req.body.price, category: req.body.category, description: req.body.description}]
    }
    else {
        //modification
        //On vérifie que le produit existe bien
        if(products.length > id) {
            products[id] = {name:req.body.name, price: req.body.price, category: req.body.category, description: req.body.description}
        }
    }
    res.redirect('/')
})

app.listen(80)



