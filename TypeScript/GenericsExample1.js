function getArray12(items) {
    return new Array().concat(items);
}
var myNumArr12 = getArray12([100, 200, 300]);
var myStrArr12 = getArray12(["Hello", "World"]);
myNumArr12.push(400); //ok
myStrArr12.push("Hi"); //ok
/*
myNumArr12.push("String");//Compiler Error
myStrArr12.push(30);//Compiler Error
*/
console.log(myStrArr12); //[ 'Hello', 'World', 'Hi' ]
console.log(myNumArr12); //[ 100, 200, 300, 400 ]
