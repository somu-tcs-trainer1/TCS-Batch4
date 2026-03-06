/*
ACCESS MODIFIERS - 
1. public - accessible for all classes
2. private - only accessible within the same class
3. protected - accessible within the same class , also for the inherited class (child class)
4. internal - only accessible within the assembly
*/

// using System.Security.Cryptography.X509Certificates;

public class AccessModifiers
{
    static void Main(String[] args)
    {
        Console.WriteLine(x);
        AccessModifiersDemo demo = new AccessModifiersDemo();
        demo.publicVar = 10;
        demo.internalVar = 20;

        demo.publicMethod();
        demo.internalMethod();
        demo.accessPrivateVarMethod();

        ChildOfAccessModifersDemo demo2 = new ChildOfAccessModifersDemo();
        demo2.accessProtectedVarMethod();
    }
}

class ChildOfAccessModifersDemo : AccessModifiersDemo
{
    public void accessProtectedVarMethod()
    {
        protectedVar = 35;
        Console.WriteLine(protectedVar);
        protectedMethod();
    }
}

class AccessModifiersDemo
{
    public int publicVar;
    protected int protectedVar;
    private int privateVar;
    internal int internalVar;

    // private int x
    // {
    //     get
    //     {
    //         return x;
    //     }
    //     set
    //     {
    //         x = value;
    //     }
    // }

    public void publicMethod()
    {
        Console.WriteLine("publicMethod");
    }

    protected void protectedMethod()
    {
        Console.WriteLine("protectedMethod");
    }

    private void privateMethod()
    {
        Console.WriteLine("privateMethod");
    }

    internal void internalMethod()
    {
        Console.WriteLine("internalMethod");
    }

    public void accessPrivateVarMethod()
    {
        privateVar = 25;
        Console.WriteLine(privateVar);
        privateMethod();
    }
}