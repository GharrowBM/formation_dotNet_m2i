// Constructeur des liens
function Lien(link, text) {
    this.link = link;
    this.text = text;
}

// Creation des liens
var links = [];
links.push(
    new Lien("./accordion.html", "Accordion"),
    new Lien("./alert.html", "Alert"),
    new Lien("./badge.html", "Badge"),
    new Lien("./breadcrumb.html", "Breadcrumb"),
    new Lien("./buttons.html", "Buttons"),
    new Lien("./buttonsGroup.html", "ButtonsGroup"),
    new Lien("./cards.html", "Cards"),
    new Lien("./carroussel.html", "Carroussel"),
    new Lien("./closeBTN.html", "CloseButton"),
    new Lien("./collapse.html", "Collapse"),
    new Lien("./dropdown.html", "Dropdown"),
    new Lien("./listGroup.html", "Listgroup"),
    new Lien("./navAndTabs.html", "Nav and Tabs"),
    new Lien("./navBar.html", "NavBar"),
    new Lien("./offcanvas.html", "OffCanvas"),
    new Lien("./pagination.html", "Pagination"),
    new Lien("./popOvers.html", "PopOvers"),
    new Lien("./progress.html", "Progress"),
    new Lien("./spinners.html", "Spinners"),
    new Lien("./tooltips.html", "Tooltips")
);

// Génération du menu au chargement de la page
window.onload = function () {
    let listLinks = '<nav class="navbar fixed-bottom navbar-dark bg-dark">';
    links.forEach(lien => listLinks += `<span><a class="navbar-brand" href="${lien.link}">${lien.text}</a></span>`);    
        listLinks += "</nav>";
        document.getElementById("navMenu").innerHTML = listLinks;
}