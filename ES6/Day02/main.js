////////////////////// (1) ///////////////////////////
function myfun(myObj){
    let obj={
        courseName:"ES6" , 
        courseDuration:"3days", 
        courseOwner:"JavaScript"
    };
    var newObj = Object.assign({},obj,myObj)
    if(Object.keys(newObj).length > 3 ){
        throw new Error ("Enter Valid Number of properties");
    }
    else{
        return `courseName:${newObj.courseName} courseDuration:${newObj.courseDuration} courseOwner:${newObj.courseOwner}`
    }
}
console.log(myfun({ }))
console.log(myfun({ courseName:"C#" , courseDuration:"7days", courseOwner:".Net"}))
console.log(myfun({ courseName:"C#" ,courseDuration:"7days"}))
// console.log(myfun({ courseName:"C#" , courseDuration:"7days", courseOwner:".Net", content:"collections"}))

////////////////////// (2) ///////////////////////////

console.log("a.the parameter passed determines the number of elements displayed from the series.");
function* fibonacci(nums) {
    let [prev, curr] = [0, 1];
    for (let i = 0; i < nums; i++) {
        yield curr;
        [prev, curr] = [curr, prev + curr];
    }
}

var fibo = fibonacci(10);

for (let num of fibo) {
    console.log(num);
}

console.log("b.the parameter passed determines the max number of the displayed series should not exceed its value");

function* newFibonacci(maxNum) {
    let [prev, curr] = [0, 1];
    while (curr <= maxNum) {
        yield curr;
        [prev, curr] = [curr, prev + curr];
    }
}

const fibIter = newFibonacci(21);

for (let num of fibIter) {
    console.log(num);
}

///////////////////// (3) ///////////////////////////

var regexp = /HELLO WORLD/;  
regexp[Symbol.match] = false;  
console.log('/HELLO WORLD/'.startsWith(regexp));  
console.log('/TEST/'.endsWith(regexp));  
