public class UseConstructorDemo
{
    static void Main(String[] args)
    {
        Car car1 = new Car(800000, 2025, "Silver", "Maruthi Swift");
        car1.printCarDetails();
    }
}

class Car
{
    public int price;
    public int modelYear;
    public string color;
    public string brand;

    public Car(int price, int modelYear, string color, string brand)
    {
        this.price  = price;
        this.modelYear = modelYear;
        this.brand = brand;
        this.color = color;
    }

    public void printCarDetails()
    {
        Console.WriteLine("The brand of car is: "+brand);
        Console.WriteLine("The color of car is: "+color);
        Console.WriteLine("The price of car is: "+price);
        Console.WriteLine("The model year of car is: "+modelYear);
    }
    public void start()
    {
        Console.WriteLine("Start method - car");
    }

    public void changeGears()
    {
        Console.WriteLine("changeGears method - car");
    }

    public void accelerate()
    {
        Console.WriteLine("accelerate method - car");
    }

    public void stop()
    {
        Console.WriteLine("Stop method - car");
    }
}