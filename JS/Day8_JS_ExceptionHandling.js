//EXCEPTION HANDLING IN JS - Errors


//SYNTAX ERROR
//console.log("Hello How Are You"

//REFERENCE ERROR - when not defined variable is used
//console.log(x);

//TYPE ERROR - when value of unexpected type is found
// let age = 25;
// age.toUpperCase();

//RANGE ERROR - occurs when value is out of range, eg. invalid no. to a function
//let agesArr = Array(-1);

// let age = 17;
// if(age < 18){
//     throw new Error("Minor, cannot vote");
// }

//EXCEPTION HANDLING IN JS - try, catch and finally
try{
    let result = 10/0;
    console.log(result);
    if(!isFinite(result)){
        throw new Error("Cannot divide zero");
    }
}catch(err){
    console.error("Error Occured: ", err.message)
}finally{
    console.log("Script Run Completed")
}

// let ages = [23,31,45, 17];
// try{
//     if(ages.in)
//     console.log(ages[-5])
// }


// console.log(ages.length);