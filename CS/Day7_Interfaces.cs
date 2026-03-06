interface Builder_Seller
{
    public void propertyDetails();
    public void termsOfPayment();
    public void otherTerms();
}

class Buyer1 : Builder_Seller
{
    public void propertyDetails()
    {
        Console.WriteLine("Block A, 101, East Facing, 1350 sft");
    }
    public void termsOfPayment()
    {
        Console.WriteLine("30% Cash, 70% Loan, 45 days payment");
    }
    public void otherTerms()
    {
        Console.WriteLine("Cannot modify the balcony");
    }
}

class Buyer2 : Builder_Seller
{
    public void propertyDetails()
    {
        Console.WriteLine("Block A, 102, West Facing, 1232 sft");
    }
    public void termsOfPayment()
    {
        Console.WriteLine("70% Cash, 30% Loan, 90 days payment");
    }
    public void otherTerms()
    {
        Console.WriteLine("Can modify the balcony");
    }
}

public class UseInterface
{
    public static void Main(String[] args)
    {
        //Buyer1 buyer1 = new Buyer1();
        Builder_Seller seller;
        seller = new Buyer1();
        seller.propertyDetails();
        seller.termsOfPayment();
        seller.otherTerms();

        seller = new Buyer2();
        seller.propertyDetails();
        seller.termsOfPayment();
        seller.otherTerms();
    }
    

}