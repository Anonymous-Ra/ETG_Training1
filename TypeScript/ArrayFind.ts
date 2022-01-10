class Arrayex{

    numarr:number[]=[1,2,3,4];

    i:number;

    count:number = 0;
    ReverseArray(){
        this.numarr.reverse();
        console.log(this.numarr);
    }
    find(){
        
        for(this.i=0;this.i<this.numarr.length;this.i=this.i+1){

            if (5==this.numarr[this.i]){

                this.count =1;

            }
            

        }
        if (this.count == 1){

            console.log("number found");

        }
        else {
            console.log("number not found");
        }
    }




}

var arr=new Arrayex();

arr.find();
arr.ReverseArray();