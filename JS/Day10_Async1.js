/*
function displayDetails(name, age){
    console.log("Name is: "+name)
    console.log("Age is: "+age)
}

console.log("First statement to print");
setTimeout(displayDetails, 3000);
console.log("First statement to print");

function getTime(){
    let day = new Date();
    console.log(day.getHours() + ":"  + day.getMinutes() + ":" + day.getSeconds());
}

setInterval(getTime, 1000);
*/
//=====================================

//CALLBACK HELL - multiple nested functions inside one another
//COMPLEX TO UNDERSTAND and CALL
function task1(callback){
    setTimeout(() => {
        console.log("Task One Completed");
        callback();
    }, 3000);
}

function task2(callback){
    setTimeout(() => {
        console.log("Task Two Completed");
        callback();
    }, 3000);
}

task1(function(){
    task2(function(){
        console.log("Both tasks are now completed");
    })
})