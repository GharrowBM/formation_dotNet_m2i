// Retrouve les elements de class result (Depuis le DOM) puis y insere un sous-titre
const result = document.querySelector(`.result`);
let dividande = Number(prompt(`Entrer le dividande : `))
let diviseur = Number(prompt(`Entrer le diviseur : `))
result.innerHTML += (dividande % diviseur == 0)?`le nombre ${dividande} est divisible par ${diviseur}`:`le nombre ${dividande} n'est pas divisible par ${diviseur}`;