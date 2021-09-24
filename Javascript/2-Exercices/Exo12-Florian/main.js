const result = document.querySelector('.result');

var nbUser = "";
var divi = "";
var affichage = "";


nbUser = prompt("Saisissez un entier relatif je vous dirais s'il est divisible et par combien");

var divi = 2;
var diviseurs = '1';
while (divi <= nbUser) {
    if (nbUser % divi == 0) {
        diviseurs = diviseurs + ', ' + divi;
    }
    divi++;
}
affichage = `Le nombre <mark><b>${nbUser}</b></mark> est divisible par <mark><b>${diviseurs}</b></mark>`
result.innerHTML += affichage;