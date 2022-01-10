function getArray(items) {
    return new Array().concat(items);
}
var myNumArr = getArray([100, 200, 300]);
var myStrArr = getArray(["Hello", "World"]);
myNumArr.push(400);
myStrArr.push("Hi");
myNumArr.push("String");
myStrArr.push(30);
console.log(myStrArr);
console.log(myNumArr);
