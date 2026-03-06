public class UsePerson
{
    static void Main(String[] args)
    {
        //classname objName = new className
        Person person1 = new Person();
        person1.age = 25;
        person1.name = "Raghav Reddy";

        Console.WriteLine(person1.name);
        Console.WriteLine(person1.age);
        
        person1.talk();
        person1.read();
    }
}

class Person
{
    public string name = null;
    public int age;

    public void read()
    {
        Console.WriteLine("reading");
    }

    public void talk()
    {
        Console.WriteLine("talking");
    }
}
