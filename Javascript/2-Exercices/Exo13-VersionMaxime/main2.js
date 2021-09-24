// Retrouve les elements de class result (Depuis le DOM) puis y insere un sous-titre
let age = Number(prompt(`Entrer l'age de votre enfant : `))

if(age<3){
    document.querySelector(`#Jeune`).classList.add("table-danger")
}else if(age>=3 && age<=6){
    document.querySelector(`#Baby`).classList.add("table-success")
}else if(age>=7 && age<=8){
    document.querySelector(`#Poussin`).classList.add("table-success")
}else if(age>=9 && age<=10){
    document.querySelector(`#Pupille`).classList.add("table-success")
}else if(age>=11 && age<=12){
    document.querySelector(`#Minime`).classList.add("table-success")
}else if(age>=13 && age<=18){
    document.querySelector(`#Cadet`).classList.add("table-success")
}else if(age>18){
    document.querySelector(`#Vieux`).classList.add("table-danger")
}else{
    alert(`on dirait que vous n'avez pas rentrer un age. Veuillez recharger la page`)
}