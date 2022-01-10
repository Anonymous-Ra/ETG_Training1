import { PersonInterface } from "./PersonInterface";

class PersonDetails implements PersonInterface{
    first: string;
    last: string;

    getFullName(): string {
        return this.first + " " +  this.last;
    }
}

var p1 = new PersonDetails();
p1.first = "Ravi";
p1.last ="tej";
console.log(p1.getFullName());