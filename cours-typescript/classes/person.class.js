"use strict";
exports.__esModule = true;
exports.Person = void 0;
var Person = /** @class */ (function () {
    function Person(firstName, lastName) {
        this.firstName = firstName;
        this.lastName = lastName;
    }
    Person.prototype.afficher = function () {
        console.log(this.firstName + " " + this.lastName);
    };
    return Person;
}());
exports.Person = Person;
