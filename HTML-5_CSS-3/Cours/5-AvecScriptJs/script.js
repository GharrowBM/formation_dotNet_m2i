// Constructeur Objet produit
function Product(pic, name, price) {
    this.pic = pic;
    this.name = name;
    this.price = price;
}
// Création liste de produits
var products = [];

// Création de 4 produits
const x270 = new Product("img/lenovo-x270.jpg", 'Thinkpad X270', 299);
const t420 = new Product('img/lenovo-thinkpad-t420.jpg', 'Thinkpad T420', 299);
const t560 = new Product('img/lenovo_T560.jpg', 'Thinkpad T560', 499);
const x1 = new Product('img/ThinkPad_x1_Carbon_2020.png', 'Thinkpad X1 Carbon', 899);

// Ajout des 4 produits à la liste
products.push(x270, t420, t560, x1);

// Fonction composant la liste de produits en HTML
window.onload = function (){
    let listOfProducts= '';    
    products.forEach(prod =>
        listOfProducts += `
          <tr class="text-center">
            <td><img src=${prod.pic} class="img-fluid img-thumbnail w-50"></td>
            <td class="w-25 align-middle">${prod.name}</td>
            <td class="w-25 align-middle">${prod.price}€</td>
            <td class="w-25 align-middle"><button class="btn btn-info" onclick='details("${prod.name}","${prod.price}")'>Push Me!</button></td>
          </tr>
          `
          
    )
    // Insertion de la liste de produit dans la <div id="productList"> dans le DOM Virtuel
    document.getElementById('productList').innerHTML = listOfProducts;
}

// Fonction pour création d'un message type alert avec le nom et le prix du produit
function details(name,price){
  alert(`Le produit ${name} est au prix de ${price}€`);
}

