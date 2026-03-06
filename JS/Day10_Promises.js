//Promise - futuristic state where an action can give some result 
// 3 states of promises
// pending - still in progress
// fulfulled/completed - operation / task completed
// rejected - operation is failed

//SYNTAX:
/*
let promise1 = new Promise(function(resolve, reject){
        resolve(value);//when successful
        reject(value); // when error
    });

    promise1.then(
        function(value){ code if success}
        function(value){ code if error}
    )
*/

function display1(name){
    console.log("Name is: "+name)
}

let myPromise = new Promise(function (resolve, reject){
    let ok = false;
    if(ok){        
        resolve("OK");      
        console.log("we are in if block of Promise")  
    }else{
        reject("Error");
        console.log("we are in else block of Promise")
    }
});

myPromise.then(
    function(value){ display1(value); },
    function(value){ display1(value); }
);

//=====================================================

let promise2 = Promise.resolve("OK");

promise2
    .then(function(value){
        console.log(value);
    })
    .catch(function(value){
        display1(value);
    });

let promise3 = Promise.reject("Error");

promise3
    .then(function(value){
        console.log(value);
    })
    .catch(function(value){
        display1(value);
    });    