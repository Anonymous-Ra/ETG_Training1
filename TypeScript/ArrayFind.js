var Arrayex = /** @class */ (function () {
    function Arrayex() {
        this.numarr = [1, 2, 3, 4];
        this.count = 0;
    }
    Arrayex.prototype.ReverseArray = function () {
        this.numarr.reverse();
        console.log(this.numarr);
    };
    Arrayex.prototype.find = function () {
        for (this.i = 0; this.i < this.numarr.length; this.i = this.i + 1) {
            if (5 == this.numarr[this.i]) {
                this.count = 1;
            }
        }
        if (this.count == 1) {
            console.log("number found");
        }
        else {
            console.log("number not found");
        }
    };
    return Arrayex;
}());
var arr = new Arrayex();
arr.find();
arr.ReverseArray();
