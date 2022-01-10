class Product{
    pid:number;
    pname:String;
    price:number;

    productPrice(){
        var proPrice = (this.price * 0.12)+this.price;
        console.log(proPrice);
    }
    display(){
        console.log(this.pid);
        console.log(this.pname);
        console.log(this.price);
    }
}

var pro1 =  new Product();
pro1.pid = 10;
pro1.pname= "Bat";
pro1.price= 12.99;
pro1.display();
pro1.productPrice();