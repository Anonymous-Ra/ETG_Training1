"use strict";
exports.__esModule = true;
exports.Student = void 0;
var Student = /** @class */ (function () {
    function Student(i, n, s) {
        this.studentID = 123;
        this.studentName = "ABC";
        this.studentMarks = 68;
        this.studentID = i;
        this.studentName = n;
        this.studentMarks = s;
    }
    Student.prototype.display = function () {
        console.log(this.studentID);
        console.log(this.studentName);
        console.log(this.studentMarks);
    };
    return Student;
}());
exports.Student = Student;
var e1 = new Student(123, "XYZ", 75);
e1.display();
