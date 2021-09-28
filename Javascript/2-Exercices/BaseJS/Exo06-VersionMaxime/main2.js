// Retrouve les elements de class result (Depuis le DOM) puis y insere un sous-titre
const result = document.querySelector(`.result`);

// Pour chaque element de mon tableau topics
const topics = [`carré`, `rectangle`].forEach(figure => {

	let figperi, figaire, figtaille, figlong, figlarg;
	result.innerHTML += `<hr><h3>Calcule de l'aire et du périmétre d'un ${figure}</h3>`;

	switch (figure) {
	case `carré` :
		figtaille = prompt(`Veuillez saisir la taille d'un côté votre carré`);
		figperi = figtaille * 4;
		figaire = Math.pow(figtaille, 2);
		result.innerHTML += `<div>La longueure des coté du carré est donc ${figtaille}cm</div>`;
		break;
	case `rectangle` :
		figlong = prompt(`Veuillez saisir la longeure de votre rectangle`);
		figlarg = prompt(`Veuillez saisir la largeure de votre rectangle`);
		figperi = figlong * 2 + figlarg * 2;
		figaire = figlong * figlarg;
		result.innerHTML += `<div>La largeur du côté du rectangle est de ${figlarg}cm et sa longeure est de ${figlong}cm</div>`;
		break;
	default:
	}

	result.innerHTML += `<div>Le périmétre du ${figure} est de ${figperi}cm</div><div>L'aire du ${figure} est de ${figaire}cm</div>`;
});