/*
let animals = ["dog", "cat", "mouse", "pig", "cow"]

for(let i=0; i<animals.length; i++){
    console.log(animals[i]);
}

// animals.forEach()

for (const animal in animals) {   
    console.log(animal);
}

const person = {fname:"John", lname:"Doe", age:25};

for(const prop in person){
    console.log(person[prop])
}

let animals = ["dog", "cat", "mouse", "pig", "cow"]
for (let index in animals) {   
    console.log(animals[index]);
}


let animals = ["dog", "cat", "mouse", "pig", "cow"]
for (let animal of animals) {   
    console.log(animal);
}

//Object is not iterable with "For of" loops
// const person = {fname:"John", lname:"Doe", age:25};
// for(propVals of person){
//     console.log(propVals)
// }

let name1 = "Kantamala Venkatesh"
console.log(name1.charAt(3));
for(const char1 of name1){
    console.log(char1)
}

const user = {
 name: "Krishna",
 age: 20,
 city: "Hyderabad"
};
for (const key of Object.keys(user)) {
 console.log(key); 
}

for (const value of Object.values(user)) {
 console.log(value); 
}

// for ([key, value] of user) {
//  console.log(key, value); 
// }

// for (const value of Object.values(user)) {
//  console.log(value); 
// }

const map = new Map([
 ["name", "Radhika"],
 ["role", "QA Automation"]
]);

for (const [key, value] of map) {
    console.log(key, value); 
}

const user = {
 name: "Krishna",
 age: 20,
 city: "Hyderabad"
};

const map1 = new Map([user]);
for (const [key, value] of map1) {
    console.log(key, value); 
}
    */

const user = {
 name: "Krishna",
 age: 20,
 city: "Hyderabad"
};