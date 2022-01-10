"use strict";
exports.__esModule = true;
exports.Employee = void 0;
var Employee = /** @class */ (function () {
    function Employee(code, name) {
        var _this = this;
        this.display = function () { return console.log(_this.empCode + _this.empName); };
        this.empCode = code;
        this.empName = name;
    }
    return Employee;
}());
exports.Employee = Employee;
var e1 = new Employee(22, "Eeee");
e1.display();
