class AccessModifiersDemo
{
    #privateVar;
    constructor(publicVar, protectedVar)    {        
        this._protectedVar = protectedVar
        this.publicVar = publicVar
    }
    publicMethod()
    {
        console.log("publicMethod");
    }

    _protectedMethod()
    {
        console.log(this._protectedVar);
        console.log("protectedMethod");
    }

    #privateMethod()
    {
        console.log("privateMethod");
    }

    accessPrivateVarMethod()
    {        
        this.#privateVar = 123;
        console.log(this.#privateVar);
        this.#privateMethod();
    }
}

const demo = new AccessModifiersDemo(25, 35);
demo.publicVar = 20;
console.log(demo.publicVar);
demo._protectedVar = 35;
console.log(demo._protectedVar)
demo._protectedMethod()
demo.accessPrivateVarMethod()

class ChildOfAccessModifiersDemo extends AccessModifiersDemo{
    constructor(publicVar, protectedVar){
        super(publicVar, protectedVar)
    }

    getVarValAssigned(){
        console.log(this.publicVar, this._protectedVar);
    }
}

const childdemo = new ChildOfAccessModifiersDemo(12, 13)
childdemo.getVarValAssigned();