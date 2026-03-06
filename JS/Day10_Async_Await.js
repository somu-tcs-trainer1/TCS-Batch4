function display1(name){
    console.log("Name is: "+name)
}

function step1(){
    return Promise.resolve("A");
}

function step2(value){
    return Promise.resolve(value + "B");
}

function step3(value){
    return Promise.resolve(value+ "C");
}

//Run the 3 functions
step1()
    .then(function(value){
        return step2(value);
    })
    .then(function(value){
        return step3(value);
    })
    .then(function(value){
        return display1(value);
    })

//async keyword makes a function return a Promise
//await keyword - makes a function wait for a Promise
async function runSteps(){
    let s1 = await step1();
    let s2 = await step2(s1);
    let s3 = await step3(s2);
    display1(s3);
}

runSteps()