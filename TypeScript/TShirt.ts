class Tshirt{
    color:string;
    material:string;
    design:string;
    size:string;

    constructor(siz:string,col:string,  matr:string,des:string){
        this.color = col;
        this.design = des;
        this.material = matr;
        this.size = siz;
    }
    display(){
        console.log("Size - " + this.size 
                + "\n Material - " + this.material + 
                    "\n Design - "  + this.design  
                    +"\n Color - " + this.color);
    }
}

var t1 = new Tshirt("small","red","cotton","round-neck");
var t2 = new Tshirt("large","yellow","lenin","V-neck");
var t3 = new Tshirt("xtra-large","blue","cotton","round-neck");

t1.display();
t2.display();
t3.display();