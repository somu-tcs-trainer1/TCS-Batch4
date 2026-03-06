class Student
{
    public string Name { get; set; } = "Abhilash Kumar";
}

class UseProperty
{
    public static void Main(String[] args)
    {
        Student student1 = new Student();
        Console.WriteLine("The initial value of student name: "+student1.Name);

        student1.Name = "Ranjit Kumar";
        Console.WriteLine("Name of the student after change: "+ student1.Name);
    }
}