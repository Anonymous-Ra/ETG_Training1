function getArray(items:any[]):any[] {
    return new Array().concat(items);
}

let myNumArr = getArray([100,200,300]);
let myStrArr = getArray(["Hello", "World"]);

myNumArr.push(400);//ok
myStrArr.push("Hi");//ok

myNumArr.push("String");//ok
myStrArr.push(30);//ok

console.log(myStrArr);//[ 'Hello', 'World', 'Hi', 30 ]
console.log(myNumArr);//[ 100, 200, 300, 400, 'String' ]