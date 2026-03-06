//new Error(message, filename, lineno)

class DivideByZeroError extends Error{
    constructor(message){
        super(message)
    }
}

try{
    let result = 10/0;
    console.log(result);
    if(!isFinite(result)){
        throw new DivideByZeroError("Cannot divide zero");
    }
}catch(err){
    console.error("Error Occured: ", err.message)
}finally{
    console.log("Script Run Completed")
}
