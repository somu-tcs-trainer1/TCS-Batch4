class Getter{
    #name;// = "Sreelatha"
    // constructor(name){
    //     this.#name = name;
    // }
    #age;

    set age(newAge){
        if(newAge <18){
            console.log("Minor, cannot be considered")
        }else{
            this.#age = newAge
        }        
    }

    get age(){
        return this.#age;
    }

    set name(newName){
        this.#name = newName;
    }

    get name(){
        return this.#name;
    }
}

const obj1 = new Getter();
obj1.name = "Ragini";
console.log(obj1.name);
obj1.age = 17;
console.log(obj1.age);
