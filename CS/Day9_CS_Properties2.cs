using System.Security.Cryptography;

class Person
{
    private int age;
    public int Age //Property
    {
        get{ return age; } //get accessor
        set{
            if(value >= 18) 
            age = value;
            else
            {
                Console.WriteLine("Age cannot be less than 18");
            }
            } //set accessor
    }
}

class UseProperty
{
    public static void Main(String[] args)
    {
        Person person1 = new Person();
        person1.Age = 21;
        Console.WriteLine("Age of the person: "+ person1.Age);
    }
}