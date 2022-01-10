var Greater_number = /** @class */ (function () {
    function Greater_number() {
        this.num1 = 12;
        this.num2 = 25;
        this.num3 = 89;
    }
    Greater_number.prototype.greater = function () {
        if ((this.num1 > this.num2) && (this.num1 > this.num3)) {
            console.log(this.num1);
        }
        else if ((this.num2 > this.num1) && (this.num2 > this.num3)) {
            console.log(this.num2);
        }
        else {
            console.log(this.num3);
        }
    };
    return Greater_number;
}());
var greater1 = new Greater_number();
greater1.greater();
