export class Employee{
    empCode:number;
    empName:string;

    constructor(code:number , name:string){
        this.empCode = code;
        this.empName = name;
    }

    display = () => { return console.log(this.empCode + " " + this.empName);}
}

var e1 = new Employee(22,"Eeee");
e1.display();