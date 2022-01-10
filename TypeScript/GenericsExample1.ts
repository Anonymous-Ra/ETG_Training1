function getArray12<T>(items:T[]):T[] {
    return new Array<T>().concat(items);
}

let myNumArr12 = getArray12<number>([100,200,300]);
let myStrArr12 = getArray12<string>(["Hello", "World"]);

myNumArr12.push(400);//ok
myStrArr12.push("Hi");//ok
/*
myNumArr12.push("String");//Compiler Error
myStrArr12.push(30);//Compiler Error
*/
console.log(myStrArr12);//[ 'Hello', 'World', 'Hi' ]
console.log(myNumArr12);//[ 100, 200, 300, 400 ]