export default class Contact {
    constructor(titre, nom, prenom, dateNaissance, telephone, email) {
        this.titre=titre;
        this.nom=nom;
        this.prenom=prenom;
        this.dateNaissance=dateNaissance;
        this.telephone=telephone;
        this.email=email;
    }

    getContact=()=>`${this.titre} ${this.nom}${this.prenom}${this.dateNaissance}${this.telephone}${this.email}`;
}