console.log("This is an example of class usage: ");

class Account{
    constructor(accNo, accName, address){
        this.accNo = accNo;
        this.accName = accName;
        this.address = address
    }

    printAccDetails(){
        console.log("The acc no. is: "+this.accNo);
        console.log("The acc name. is: "+this.accName);
        console.log("The acc address. is: "+this.address);        
    }
}

const acc1 = new Account(1234, "Nimmala Soorya", "294, Jubilee Hills")
acc1.printAccDetails()

class ClassDemo{
    // constructor(){
    //     console.log("Hi This is a constructor")
    // }

    // constructor(name){
    //     console.log("Hi This is a constructor" +name)
    // }

    printSomething(){
        console.log("Hi This is a print statement")
    }

    static printSomething(name){
        console.log("Hi This is a print statement, " +name)
    }
}

const obj1 = new ClassDemo()
obj1.printSomething()
obj1.printSomething("Rakesh")

const obj2 = new ClassDemo("Planter")

const obj3 = new Account(1234, "Nimmala Soorya", "294, Jubilee Hills");
obj3.accName = "Nimmala Narayana"
obj3.printAccDetails()

ClassDemo.printSomething("Suresh")