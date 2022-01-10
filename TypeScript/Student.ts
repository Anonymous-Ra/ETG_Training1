export class Student{
    studentID:number = 123;
    studentName:String = "ABC";
    studentMarks:number =  68;
    constructor(i:number,n:string,s:number){
        this.studentID = i;
        this.studentName = n;
        this.studentMarks = s;
    }
    display(){
        console.log(this.studentID);
        console.log(this.studentName);
        console.log(this.studentMarks);
    }
}
var e1 = new Student(123, "XYZ", 75);
e1.display();