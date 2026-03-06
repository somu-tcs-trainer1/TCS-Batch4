//3 in-built delegates:
/*
Action - void type
Function - Returns a value
Predicate - Returns a bool
*/

using System.Collections.Specialized;
using System.Diagnostics;
using System.Text;

public class UseInbuiltDelegates
{
    static void Main(String[] args)
    {
        Func<int, int, int> subtract = (a, b) => a-b;
        Console.WriteLine("The differce of 2 no.s: "+ subtract(7, 4));

        Func<string, string, string> conctStrs = (a,b) => a+b;
        Console.WriteLine(conctStrs("My name is: ", "Soma Shekhar"));

        Predicate<string> isShort = (s) => s.Length < 10;
        Console.WriteLine("Is the entered string less than 10 chars?: "+isShort("Hello All, Good Morning"));

        ////Predicate  takes only ONE param
        // Predicate<int, int> isGreater = (a,b) => a > b;
        // Console.WriteLine("Is a val greater than b? "+isGreater(20, 35));

        Action<string> greeting = (greet) => Console.WriteLine(greet);
        greeting("Hi to the Action Delegate, inbuilt in C#");
    }
}
