// Retrouve les elements de class result (Depuis le DOM) puis y insere un sous-titre
const result = document.querySelector(`.result`);
const voyelles = ["a","e","i","o","u","y"];
const lettre = prompt(`Entrer une lettre : `)
result.innerHTML += (voyelles.indexOf(lettre.toLowerCase()) >= 0)?`la lettre ${lettre} est une voyelle`:`la lettre ${lettre} est une consonne`;