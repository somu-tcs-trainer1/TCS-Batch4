class OverridingDemoParent{
    constructor(var1, var2){
        this.var1 = var1
        this.var2 = var2
    }
    method1(){
        console.log("this is method1 - OverridingDemoParent")
    }

    method2(){
        console.log("this is method2 - OverridingDemoParent")
    }

    method3(){
        console.log("this is method3 - OverridingDemoParent")
    }

    display(){
        console.log("var1: "+ this.var1);
        console.log("var2: "+ this.var2);
    }
}

class OverridingDemoChild extends OverridingDemoParent{
    constructor(var1, var2, var3){
        super(var1, var2);
        this.var3 = var3;
    }
    method2(){
        console.log("this is method2 - OverridingDemoChild")
    }
}

const child = new OverridingDemoChild("first var", "second var", "third var")
child.method1()
child.method2()
child.method3()
child.display()