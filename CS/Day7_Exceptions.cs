//EXCEPTIONS - try, catch, finally
public class ExceptionDemo
{
    static void Main(String[] args)
    {
        // try
        // {
        //     int[] nums = {12, 15, 89, 73, 41};
        //     Console.WriteLine(nums[14]);
        // }catch(DivideByZeroException ex)
        // {
        //     Console.WriteLine(ex.Message);
        //     Console.WriteLine("Divide by zero scenario");
        // } catch(IndexOutOfRangeException ex)
        // {
        //     Console.WriteLine(ex.Message);
        //     Console.WriteLine(ex.StackTrace);
        //     Console.WriteLine("Detected array index is not in range");
        // }
        // finally
        // {
        //     Console.WriteLine("This is finally block");
        // }

        int age = 17;
        if(age >= 18)
        {
            Console.WriteLine("Eligible to Vote");
        }
        else
        {
            throw new Exception("the person is not an adult to vote");
        }
        Console.WriteLine("After Exception Occured");
    }
}