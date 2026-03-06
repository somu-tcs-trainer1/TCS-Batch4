public class UseOverrideDemo
{
    static void Main(String[] args)
    {
        // Child child = new Child();
        // string name = child.sendString("Rajesh", "Khanna");
        // Console.WriteLine("The name: "+name);

        Parent parentRef;
        parentRef = new Child();
        string name = parentRef.sendString("Rajesh", "Khanna");
        Console.WriteLine("The name: "+name);
    }
}

class Parent
{
    public virtual string sendString(string firstName, string lastName)
    {
        return firstName+" "+lastName;
    }
}

class Child : Parent
{
    public override string sendString(string firstName, string lastName)
    {
        return firstName+"-"+lastName;
    }
}