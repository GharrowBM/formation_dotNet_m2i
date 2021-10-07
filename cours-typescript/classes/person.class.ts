export class Person {
    //Attributs
    firstName:string
    lastName:string

    constructor(firstName:string, lastName:string) {
        this.firstName = firstName
        this.lastName = lastName
    }

    afficher():void {
        console.log(this.firstName + " "+ this.lastName)
    }
}