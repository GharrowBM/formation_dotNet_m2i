/**
 * EXERCICE32 - FOR - Meilleurs Note
 */

// Création de la constante result permettant de recupérer l'élément HTML class="result"
const result = document.querySelector('.result');
const menu = document.querySelector('#menu');
const notes = document.querySelector('#notes');

// Déclaration variables
let nbNotes = 0,
    maxNote = 0,
    minNote = 20,
    moyNote = 0,
    ok = false;

// Permet de réinitialiser les calculs    
function ResetAll(){
    nbNotes = 0,
    maxNote = 0,
    minNote = 20,
    moyNote = 0,
    result.innerHTML="";
    notes.innerHTML ="";
    ok=false; 
}

function Menu() {
    return `<h3>Gestion des notes avec menu</h3>
            <nav>
                <button onClick="SetNotes()" class="btn btn-primary">Saisir les notes</button>
                <button onClick="ShowBetter()" class="btn btn-success">Voir la meilleur note</button>
                <button onClick="ShowWorst()" class="btn btn-danger">Voir la moins bonne notes</button>
                <button onClick="ShowAvg()" class="btn btn-secondary">Voir la moyenne des notes</button>
                
            </nav>`
};

function userSet() {
    return parseInt(prompt(`Veuillez saisir une note sur 20 (777 pour quitter)`));
}


function SetNotes() {
    ResetAll();

    while(!ok){
        let noteTmp = userSet();
        if (!isNaN(noteTmp)) {
            if (noteTmp >= 0 && noteTmp <= 20) {
                console.log(noteTmp);
                result.innerHTML += `<li>En note <b>${nbNotes + 1}</b>, vous avez saisi <b>${noteTmp}/20</b>.</li>`;
                // Ajoute la note saisie au total
                moyNote += noteTmp;
                // Verifie si la note saisie est supérieure à la note max, Si oui Note max prend la valeur de noteTmp
                if (noteTmp > maxNote)
                    maxNote = noteTmp;
                // Verifie si la note saisie est inférieure à la note min, Si oui note min prend la valeur de noteTmp
                if (noteTmp < minNote)
                    minNote = noteTmp;
                nbNotes++;
            }
            else if (noteTmp === 777) {
                ok = true;
            }
            else
                alert("Merci de saisir une note entre 0 et 20");
    
        } else
            alert("Merci de saisir un nombre...");
    }
}

function ShowBetter() {
    notes.innerHTML = `<h3 class="green">La meilleur note est de <b>${maxNote}/20</b></h3>`;
}

function ShowWorst() {
    notes.innerHTML = `<h3 class="red">La moins bonne note est de <b>${minNote}/20</b></h3>`;
}

function ShowAvg() {
    // Calcul de la moyenne des notes
    let moyenne = Math.round(((moyNote / nbNotes) + Number.EPSILON) * 10) / 10;
    notes.innerHTML = `<h3 class="gray">La moyenne des notes est de <b>${moyenne}/20</b></h3>`;
}

function Init(){
    menu.innerHTML = Menu();
}

window.onload=Init();
//window.onload=menu.innerHTML = Menu();;

