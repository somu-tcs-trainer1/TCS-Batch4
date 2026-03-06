public class UseOverloading
{
    static void Main(String[] args)
    {
        // Maruthi m1 = new Maruthi();
        // m1.start();
        // m1.changeGears();
        // m1.accelerate();
        // m1.stop();

        Ferrari f1 = new Ferrari();
        f1.start();
        f1.changeGears();
        f1.accelerate();
        f1.stop();
        f1.specialFeature();

    }
}

class Car1
{
    public int price;
    public virtual void start()
    {
        Console.WriteLine("Start method - car with Turnkey");
    }

    public void changeGears()
    {
        Console.WriteLine("changeGears method - car");
    }

    public void accelerate()
    {
        Console.WriteLine("accelerate method - car");
    }

    public virtual void stop()
    {
        Console.WriteLine("Stop method - car turnkey stop");
    }
}

class Maruthi : Car1
{
    
}

class Ferrari : Car1
{
    public void specialFeature()
    {
        Console.WriteLine(price);
    }
    // base.start();
    public override void start()
    {
        base.start();
        Console.WriteLine("Start method - with voice command");
    }

   public override void stop()
    {
        base.price = 20;
        base.stop();
        // base.
        Console.WriteLine("Stop method - with voice command");
    }
}