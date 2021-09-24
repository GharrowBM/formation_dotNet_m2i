const affichage = document.querySelector('.result');

var affich="";
var AB, BC, CA;


AB=prompt("Saisir le côté AB");
BC=prompt("Saisir le côté BC");
CA=prompt("Saisir le côté CA");

//Ternaire

affich += (AB==BC && BC==CA)?`<p>Le triangle est équilatéral</p>`
        :(AB==CA && AB!=BC)?`<p>Le triangle est isocèle en A.</p>`
        :(AB==BC && BC!=CA)?`<p>Le triangle est isocèle en B.</p>`
        :(CA==BC && CA!=AB)?`<p>Le triangle est isocèle en C.</p>`
        :`<p>Le triangle n'est isocèle ni en A, ni en B, ni en C</p>`;


affichage.innerHTML += affich;