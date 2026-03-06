//Delegate - as per C# is a type-safe function pointer, which allows method to reference
//and invoke dynamically

/*
Delegates:
1. Must have same signature as the method it is pointing to
2. It can reference to static, not-static methods
3. Delegates are type-safe (bcoz it must have same sign. as the method it is pointing to)
4. Used along with events (not used isolated)
*/

public class DelegateDemo
{
    //Delegate declaration
    public delegate void SampleDelegate(string message);

    public static void DisplayMessage(string msg)
    {
        Console.WriteLine("The message is: "+msg);
    }
    public static void Main(String[] args)
    {
        //Instatiate a delegate
        SampleDelegate delegate1 = DisplayMessage;
        //Console.WriteLine("Name of the student after change: "+ student1.Name);
        delegate1("Hi Everyone, I am a delegate call");
    }
}