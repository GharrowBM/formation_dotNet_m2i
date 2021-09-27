//Selectionner la div ou on souhaite afficher les tables de multiplication.
const result = document.querySelector("#result")

const tableMultiplication = (nombre) => {
    let html = "<div class='col-2 p-1 border m-1'>"
    html += `<h3>Table de ${nombre}</h3>`
    html += "<ul>"
    //Construit le html
    for(let i=1; i <= 10; i++) {
        html += `<li>${nombre} X ${i} = ${nombre * i}</li>`
    }
    html += "</ul></div>"
    return html
}

for(let i=1; i <= 10; i++) {
    result.innerHTML += tableMultiplication(i)
}