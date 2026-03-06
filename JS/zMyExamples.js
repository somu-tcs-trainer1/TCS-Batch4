//MULTI LEVEL INHERITANCE
// class parent{
//     display(){
//         console.log("parent - level1")
//     }
// }

// class child1 extends parent{
//     display(){
//         super.display()
//         console.log("child1 - level2")
//     }
// }

// class grandchild1 extends child1{
//     display(){
//         super.display()
//         console.log("grandchild1 - level3")
//     }
// }

// const gc1 = new grandchild1()
// gc1.display()

//MULTIPLE INHERITANCE - NOT ALLOWED IN JS
// class parent1{
//     display(){
//         console.log("parent1 - level1")
//     }
// }

// class parent2{
//     display(){
//         console.log("parent2 - level1")
//     }
// }

// class child1 extends parent1, parent2{

// }

//HIERARCHICAL INHERITANCE
// class parent1{
//     display(){
//         console.log("parent1 - level1")
//     }
// }

// class child2 extends parent1{

// }

// class child3 extends parent1{

// }

// class grandchild2 extends child2{

// }

// const gc = new grandchild2()
// gc.display()


// ///********************************************************** */
// ///********************************************************** */

// function externalFunction(data) {
//   console.log("External function received:", data);
// }

// class MyClass {
//   myMethod(data) {
//     externalFunction(data); // Call the external function
//   }
// }

// const myInstance = new MyClass();
// myInstance.myMethod("Hello World");

// ///********************************************************** */
// ///********************************************************** */

function checkEligibility() {
  if (this.age >= 18) {
    console.log(`${this.name} is eligible.`);
  } else {
    console.log(`${this.name} is not eligible.`);
  }
}

class User {
  constructor(name, age) {
    this.name = name;
    this.age = age;
    this.check = checkEligibility; // Assign the external function
  }
}

const user1 = new User("Sara", 19);
user1.check(); // 'Sara is not eligible.'
