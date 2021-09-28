var 
choix = "",
longueurCarre = "",
perimCarre = "",
airCarre = "",
longueurRectangle = "",
largeurRectangle = "",
perimRectangle = "",
airRectangle = "";
      
choix = prompt(`
1 - Carré
2 - Rectangle `);  

if (choix == 1){
      longueurCarre = prompt('Entrez la longueur du carré : ');   
}
else if(choix == 2){
      longueurRectangle = prompt('Entrez la longueur du rectangle : '); 
      largeurRectangle = prompt('Entrez la largeur du rectangle : '); 
}
else{
      alert('Je n\'ai pas compris votre choix')
}

const result = document.querySelector('.result');
                  


//Carré
perimCarre = longueurCarre * 4;
airCarre = longueurCarre * longueurCarre;

//Rectangle
perimRectangle = (Number(longueurRectangle) + Number(largeurRectangle))*2; 
airRectangle = longueurRectangle * largeurRectangle;
console.log(airRectangle);
     
                            

var affichage1 = "<h3>Calcul de l'aire et du périmètre d'un carré</h3>";
affichage1 += `Les longueurs des cotés du carré étant de <b>${longueurCarre}cm,</b> <br>`;
affichage1 += `<ul>`;
affichage1 += `<li>Le périmètre de ce carré est de <b>${perimCarre}cm</b></li> <br>`;
affichage1 += `<li>L'air de ce carré est de <b>${airCarre}cm</b></li> <br>`;
affichage1 += `</ul><br><hr>`;

var affichage2 = "<h3>Calcul de l'aire et du périmètre d'un rectangle</h3>";
affichage2 += `Les longueurs des cotés du rectangle étant de <b>${longueurRectangle}cm</b> pour la longueur, et de <b>${largeurRectangle}cm</b> <br>`;
affichage2 += `<ul>`;
affichage2 += `<li>Le périmètre de ce rectangle est de <b>${perimRectangle}cm</b></li> <br>`;
affichage2 += `<li>L'air de ce rectangle est de <b>${airRectangle}cm</b></li> <br>`;
affichage2 += `</ul><br><hr>`;


if (choix == 1){
      result.innerHTML += affichage1;
}
else{
      result.innerHTML += affichage2;
}






