// let name = "Raju";

// //let name = "Ganesh";

// let x = 5
// let y = '5'

// if(x === y)
//     console.log("correct")
// else
//     console.log("incorrect")

// let text1 = "A"; 
// let text2 = "B"; 
// let result = text1 < text2;

// console.log(result)

// let result1 = x > y
// console.log(result1)

// console.log('a' > 'A')

// let a = 10;
// let b = 20;
// let c = 30;

// if(a>b && a>c){
//     console.log("a is greatest");
// }else if(b>c){
//     console.log("b is greatest");
// }else{
//     console.log("c is greatest");
// }

// let name1 = "Rajesh"
// console.log(typeof(c))

// console.log(typeof(name1))

//CONDITIONAL STATMENTS - IF

// //Simple If
// let hour = 13;
// if(hour < 12){
//     console.log("Good Morning");
//     // console.log("Good Morning");
// }

// //If else
// if(hour < 12){
//     console.log("Good Morning");
// } else{
//     console.log("Good Day");
// }

// //If else if, else
// let a = 10;
// let b = 20;
// let c = 30;

// if(a>b && a>c){
//     console.log("a is greatest");
// }else if(b>c){
//     console.log("b is greatest");
// }else{
//     console.log("c is greatest");
// }

// //SWITCH CASE
// let day = 1;

// switch(day){
//     case 1:
//         console.log("Monday");
//         break;
//     case 2:
//         console.log("Tuesday");
//         break;
//     case 3:
//         console.log("Wednesday");
//         break;
//     case 4:
//         console.log("Thursday");
//         break;
//     case 5:
//         console.log("Friday");
//         break;
//     case 6:
//         console.log("Saturday");
//         break;
//     case 7:
//         console.log("Sunday");
//         break;
//     default:
//         console.log("Plese give day value between 1 and 7");        
// }

// //Nested If condition
// let name1 = "Ramesh";

// if(name1 == "Ramesh"){
//     console.log("The name value is correct")
//     if(typeof(name1)=="string"){
//         console.log("the value type is string")
//     }
// }

//ITERATIVE STATEMENTS / LOOPS
//1. initialization - initial value set
//2. condition 
//3. limit is set

// //WHILE LOOP
// let greet = "Good Morning";
// let count = 1;
// while(count <= 10){
//     console.log(greet);
//     //break;
//     //count = count + 1;
//     count++;
//     //count+=2;
// }

// console.log("Count value after while loop execution: "+count)

// while(count >=1){
//     console.log(count);
//     count--;
// }
// console.log("Count value after while loop execution (decrement): "+count)

//FOR LOOP
// for(let count=1, greeting1 = "Hello"; count <=10 ; count++){
//     console.log(greeting1);    
// }

// let count = 1
// let greeting = "Hello"
// for( ; count <=10 ; count++){
//     console.log(greeting);    
// }
// console.log("Count value after for loop execution: "+count)

// // count = "my name";
// // console.log(typeof(count))

// for( ; count >=1 ; count--){
//     console.log(greeting);    
// }
// console.log("Count value after for loop execution: "+count)

//ARRAYS
const cars = ["Saab", 
    "Volvo", 
    "BMW"];
console.log(cars[1])

cars[1] = "Zen"
console.log(cars[1])

// cars = ["Maruthi", "Hyundai", "MG"];
// console.log(cars[1]);

//cars = "hello"
cars.push("Comet");
console.log(cars);

cars.pop()
console.log(cars);
cars.toString()
console.log(cars.toString());
console.log(typeof(cars));