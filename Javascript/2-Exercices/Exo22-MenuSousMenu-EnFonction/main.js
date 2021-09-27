const result = document.querySelector("#result")
const taille = 6
for(let i=1; i <= taille; i++) {
    let bloc = `<h3 class="row"><span class="col">Chapitre ${i}</span></h3>`
    bloc += "<ul class='row list-group'>"
    for(let j=1; j <= taille; j++) {
        bloc += `<li class='col-12 list-group-item'>Partie ${i}.${j}</li>`
    }
    bloc += "</ul>"
    result.innerHTML+= bloc
}