var Product = /** @class */ (function () {
    function Product() {
    }
    Product.prototype.productPrice = function () {
        var proPrice = (this.price * 1.2) + this.price;
        console.log(proPrice);
    };
    Product.prototype.display = function () {
        console.log(this.pid);
        console.log(this.pname);
        console.log(this.price);
    };
    return Product;
}());
var pro1 = new Product();
pro1.pid = 10;
pro1.pname = "Bat";
pro1.price = 12.99;
pro1.display();
pro1.productPrice();
