var proArr = [
    {price:"100", product : "Mobile"},
    {price:"200", product : "Laptop"},
    {price:"300", product : "Mic"},
    {price:"400", product : "PC"}
]
//map example
 var newPro = proArr.map(function(value){
     return value.price;
 })
 console.log(newPro);
  
 //with arrow function
 var newPro1 = proArr.map(value=>value.price);
 console.log(newPro1);

 //filter example
 var filterEx = proArr.filter(function(value){
     if(value.price > 300){
         console.log(true);
     }
 })
 console.log(filterEx);

 //with arrow function
 const arrowValue = proArr.filter(value=>value.price>300);
 console.log(arrowValue);

 //sort example
 const sortProduct = proArr.sort((a,b)=>(a.product > b.product ? 1:-1));
 console.log(sortProduct);