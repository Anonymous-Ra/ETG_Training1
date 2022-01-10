export class Employee{
    empID:number = 123;
    empName:String = "ABC";
    empSal:number = 500;
    constructor(i:number,n:string,s:number){
        this.empID = i;
        this.empName = n;
        this.empSal = s;
    }
    display(){
        console.log(this.empID);
        console.log(this.empName);
        console.log(this.empSal);
    }
}
var e1 = new Employee(123, "XYZ", 999);
e1.display();