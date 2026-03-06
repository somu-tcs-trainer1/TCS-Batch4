class Employee
{
    private string empName =  string.Empty;//null //field
    // private string empName =  "Abhilash Kumar";
    public string EmpName //Property
    {
        get{ return empName; } //get accessor
        set{ empName = value; } //set accessor
    }
}

class UseProperty
{
    public static void Main(String[] args)
    {
        Employee emp = new Employee();
        emp.EmpName = "Ranjit Kumar";
        Console.WriteLine("Name of the employee: "+ emp.EmpName);
    }
}