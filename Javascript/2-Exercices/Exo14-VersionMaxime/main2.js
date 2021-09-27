let cotes = {AB:0,BC:0,CA:0} // tableau associatif des coté du triangle

for (let cote in cotes) { // Pour chaque coté du triangle
    do{
        cotes[cote]= Number(prompt(`Entrer ${cote} : `)); // On demande ca valeur
        if (isNaN(cotes[cote])) {alert(`Veuillez rentrer un nombre`)} // On affiche une erreur si ce n'est pas un nombre
    }while (isNaN(cotes[cote])) // Tant que l'utilisateur n'as pas rentré un nombre
}

// turner fonctionnelle mais illisible
// document.querySelector(`.result`).innerHTML += (cotes["AB"]==cotes["BC"])?(cotes["AB"]==cotes["CA"])?`Le triangle est équilatérale`:`Le triangle est isocéle en B`:(cotes["BC"]==cotes["CA"])?`Le triangle est isocéle en C`:(cotes["AB"]==cotes["CA"])?`Le triangle est isocéle en A`:`Le triangle n'est isocéle ni en A ni en B, ni en C.`;

// turner fonctionnelle et un peu plus lisible
document.querySelector(`.result`).innerHTML += // ajouter dans l'html
(cotes["AB"]==cotes["BC"])? // if( AB==BC ){
    (cotes["AB"]==cotes["CA"])?`Le triangle est équilatérale`: `Le triangle est isocéle en B`// if( AB==CA ){}else
    :(cotes["BC"]==cotes["CA"])? `Le triangle est isocéle en C` // else{if(BC==CA)}
    :(cotes["AB"]==cotes["CA"])?`Le triangle est isocéle en A` // else{if(AB==CA)}
    :`Le triangle n'est isocéle ni en A ni en B, ni en C.`// else{}