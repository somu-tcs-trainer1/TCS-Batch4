//ABSTRACTION - abstract classes, interfaces
//abstract classes - 0 to 100% abstraction
//interfaces - 100% abstraction

abstract class AbstractDemo
{
    //public abstract int name;
    public abstract void abstractMethod1();
    public abstract void abstractMethod2();
    public abstract void abstractMethod3();
    public void concreteMethod1()
    {
        Console.WriteLine("concreteMethod1 - AbstractDemo Class");
    }

    public void concreteMethod2()
    {
        Console.WriteLine("concreteMethod2 - AbstractDemo Class");
    }
}

class ChildAbsDemo : AbstractDemo
{
    public override void abstractMethod1()
    {
        Console.WriteLine("implemented abstractMethod1 - ChildAbsDemo Class");
    }

    public override void abstractMethod2()
    {
        Console.WriteLine("implemented abstractMethod2 - ChildAbsDemo Class");
    }

    public override void abstractMethod3()
    {
        Console.WriteLine("implemented abstractMethod3 - ChildAbsDemo Class");
    }
}

class UseAbstractDemo
{
    static void Main(String[] args)
    {
        // AbstractDemo demo = new AbstractDemo();
        // demo.concreteMethod1();
        // demo.concreteMethod2();

        // ChildAbsDemo child1 = new ChildAbsDemo();
        // child1.concreteMethod1();
        // child1.concreteMethod2();
        // child1.abstractMethod1();
        // child1.abstractMethod2();
        // child1.abstractMethod3();

        AbstractDemo absdemoref = new ChildAbsDemo();
        absdemoref.abstractMethod1();
        absdemoref.concreteMethod1();
    }
}