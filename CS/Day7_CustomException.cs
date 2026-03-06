//CUSTOM EXCEPTION
class InsufficientFundsException : Exception
{
    public double accBalance;
    public InsufficientFundsException(string msg, double bal) : base(msg)
    {
        accBalance = bal;
    }
}

public class AccountDemo
{
    static void Main(String[] args)
    {
        double balance = 500;
        try
        {
            double withdrawAmt = 700;
            if(withdrawAmt > balance)
            {
                throw new InsufficientFundsException("Balance less than withdraw amount", balance);
            }
            else
            {
                balance = balance - withdrawAmt;
                Console.WriteLine("Withdraw successful, remaining bal is: "+balance);
            }
        }
        catch (InsufficientFundsException ex)
        {
            Console.WriteLine("Issue with withdrawal is: "+ex.Message);
        }
    }
}