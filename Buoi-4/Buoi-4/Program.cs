using Buoi_4;

public class Student
{
    public int id;
    public string name;
    public int age;
    private string password;
    public string Password
    {
        get { return password; }
        set { password = value; }
    }
    public string country { get; set; }
    public string major { get; private set; }
    private double result;
    public double Result
    {
        get { return result; }
        set
        {
            if (result < 0)
            {
                Console.WriteLine("Diem phai tren 0!");
                result = value;
            }
        }
    }
    //Constructor

    public Student(string Name, int Age)
    {
        this.name = Name;
        this.age = Age;
    }
    public Student() 
    {
    }
    public Student ( Student studentcopy)
    {
        this.name = studentcopy.name;
        this.age = studentcopy.age;
    }

    public void study()
    {
        Console.WriteLine("Student study C#");
    }
}

public class StudentFPTUniv: Student
{

}

public class StudentFPTHighschool: StudentFPTUniv
{

}

public class Person2: IPerson, IFpt
{
    public void sleep()
    {
        Console.WriteLine("Sleep");
    }
    public void eat()
    {
        Console.WriteLine("Eat");
    }
    public void study()
    {
        Console.WriteLine("Study");
    }
}

class Program
{
    static void Main()
    {
        Student student1 = new Student();
        student1.id = 1;
        student1.name = "test";
        student1.study();
        Student student2 = new Student("Quang", 20);
        Student student3 = new Student(student2);
        StudentFPTUniv student4 = new StudentFPTUniv();
        student4.id = 2;
        student4.name = "Dam";
        StudentFPTHighschool student5 = new StudentFPTHighschool();
        student5.id = 3;
        student5.name = "Nam";
    }
}
