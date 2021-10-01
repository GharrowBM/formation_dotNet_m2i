/**
 * Live Typing
 */

// recupération des element du DOM
const result = document.querySelector('.result');
const result2 = document.querySelector('#result2');
const input = document.querySelector('#liveTyping');
const btnValider = document.querySelector('#btnValider');


// ecouteur evenement sur input
input.addEventListener('keyup', () => {
    result.innerHTML = input.value;
})

function Valider() {
    result2.innerHTML = input.value;
}

// btnValider.onclick = () => {
//     result2.innerHTML = input.value;
// }

