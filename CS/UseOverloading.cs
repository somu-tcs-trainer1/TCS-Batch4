public class UseOverloading
{
    static void Main(String[] args)
    {
        ArithmeticCalc calc = new ArithmeticCalc();
        calc.add();
        calc.add(20, 30);
        calc.add(10.50, 34);
        calc.add(34, 25.79);
    }
}

class ArithmeticCalc
{
    public void add()
    {
        int a= 10;
        int b = 20;
        int c = a+b;
        Console.WriteLine(c);
    }


    public void add(int a, int b)
    {
        int c = a+b;
        Console.WriteLine(c);
    }

    public void add(string a, string b)
    {
        string c = a+b;
        Console.WriteLine(c);
    }

    public void add(int a, double b)
    {
        double c = a+b;
        Console.WriteLine(c);
    }
    
    public void add(double a, int b)
    {
        double c = a+b;
        Console.WriteLine(c);
    }
}