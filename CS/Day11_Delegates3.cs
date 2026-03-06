using System;
public class Calculator : Delegate2
{
    static int num = 10;

    public static int AddNum(int number)
    {
        num = num + number;
        return num;
    }

    public static int SubNum(int number)
    {
        num = num - number;
        return num;
    }

    public static int MulNum(int number)
    {
        num = num * number;
        return num;
    }

    public static int getNum()
    {
        return num;
    }

    public static void Main(String[] args)
    {
    //NumberCalc calculator;
    NumberCalc calc1 = new NumberCalc(AddNum);
    NumberCalc calc2 = new NumberCalc(SubNum);
    NumberCalc calc3 = new NumberCalc(MulNum);
    NumberCalc calc4 = new NumberCalc(Delegate2.DivNum);

    // calculator = calc1;
    // calc1(25);
    // Console.WriteLine("The value of number is: "+getNum());
    //calc1(65);
    Console.WriteLine("The value of added number :"+calc1(65));
    Console.WriteLine("The value of subtracted number :"+calc2(65));
    Console.WriteLine("The value of multiplied number :"+calc3(65));
    Console.WriteLine("The value of divided number :"+calc4(5));
    }
}

public class Delegate2
{
    public delegate int NumberCalc(int n);
    public static int num = 10;
    public static int DivNum(int number)
    {
        num = num / number;
        return num;
    }
}