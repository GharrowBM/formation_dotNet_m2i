export default class Vehicule {
    constructor(id, startDate = new Date()) {
        this.id = id;
        this.startDate = startDate;
        this.endDate;
    }
}