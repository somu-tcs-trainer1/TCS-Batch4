public class UseBank
{
    static void Main(String[] args)
    {
        Bank bank = new Bank("HDFC", "KUKATPALLY", 78102, 500072);
        bank.printBankDetails();

        ICICI icici = new ICICI("icici", "sanath nagar", 89076, 500038, "New Var");
        icici.printBankDetails();
    }
}

class Bank
{
    public string name;
    public string branch;
    public int brcode;
    public int pincode;
    public Bank(string name, string branch, int brcode, int pincode)
    {
        this.name = name;
        this.branch = branch;
        this.brcode = brcode;
        this.pincode = pincode;
    }
    public void printBankDetails()
    {
        Console.WriteLine("Bank Name: "+name);
        Console.WriteLine("Bank Branch: "+branch);
        Console.WriteLine("Bank Br code is: "+brcode);
        Console.WriteLine("Bank Br Pincode is: "+pincode);
    }
}

//Bank - Parent or Base class
//ICICI - Child or Derived class
class ICICI : Bank
{
    string newVar;
    public ICICI(string name, string branch, int brcode, int pincode, string newVar) : base(name, branch, brcode, pincode)
    {
        this.newVar = newVar;
        Console.WriteLine("New Var of ICICI is: "+this.newVar);
    }
}