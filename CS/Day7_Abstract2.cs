class Parent
{
    public void method1()
    {
        
    }
    public void method2()
    {
        
    }
}

class Child : Parent
{
    public void method3()
    {
        
    }
    public void method3()
    {
        
    }
}

public class UseParentChild
{
    //static Parent parentref;
    static void Main(String[] args)
    {
        Parent parentref;
        parentref = new Child();
        parentref.method1();
        parentref.method2();
    }
}