/*
function displayDetails(name, age){
    console.log("Name is: "+name)
    console.log("Age is: "+age)
}

displayDetails("Arun Kumar", 45);

function add(a, b){
    return a + b;
}

let sum = add(34, 45);
console.log("Sum of the two numbers: ", sum);

sum = add();
console.log("Sum of the two numbers: ", sum);

function multiply(a, b=10){ //DEFAULT VALUE
    return a * b;
}

console.log("Multiple of the two numbers: ", multiply(2));

function summation(...args){ //REST PARAMETERS
    let sum = 0;
    for(let arg of args){
        sum = sum + arg;        
    }
    return sum;
}

let summed = summation(12, 90, 45, 36, 18);
console.log(summed);
*/

//Anonymous function
const add = function(a, b){return a + b};
console.log(add(23, 34));

//Arrow Function
const add2 = (a, b) => {console.log(a + b); };
// console.log(add2(45, 55));
add2(45, 55);

//Without arrow
const hello = function(){return "Hello All";}
console.log(hello())

const hello1 = () => "Hello All";
console.log(hello1())

const hello2 = (name) => "Hello, " +name;
console.log(hello2("Rajesh"))

let res = (a, b) => {
    if (a<=10 && b <10){
        return a+b;
    }else if(a>10 && b>10){
        return a*b;
    }else{
        return 0;
    }
};

console.log(res(7, 6));
console.log(res(11, 12));