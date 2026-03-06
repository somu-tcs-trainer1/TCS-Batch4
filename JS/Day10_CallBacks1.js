function display1(name){
    console.log("Name is: "+name)
}

//Callbacks with condition
function getData(callback){
    let ok = false;

    if(ok){
        callback(null, "Data");
    }else{
        callback("Something failed", null)
    }
}

getData(function(error, data){
    if(error){
        display1(error);
        return;
    }
    display1(data);
}
);
