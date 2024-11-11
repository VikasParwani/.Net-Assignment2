using System;
using System.Linq;

public class Student
{
    public string Name { get; set; }
    public int RollNo { get; set; }
    public int[] Marks = new int[5];
    public int TotalMarks { get; set; }
    public double Percentage { get; set; }

    public static string UniversityName = "Central University";

    // Default Constructor
    public Student()
    {
        Name = "Unknown";
        RollNo = 0;
        Marks = new int[5];
        TotalMarks = 0;
        Percentage = 0.0;
    }

    // Parameterized Constructor
    public Student(string name, int rollNo, int[] marks)
    {
        Name = name;
        RollNo = rollNo;
        Marks = marks;
        CalculateResult();
    }

    // Static Constructor
    static Student()
    {
        Console.WriteLine("University Name: " + UniversityName);
    }

    // Read data from the user
    public void ReadData()
    {
        Console.Write("Enter Name: ");
        Name = Console.ReadLine();

        Console.Write("Enter Roll No: ");
        RollNo = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Marks in 5 Subjects:");
        for (int i = 0; i < 5; i++)
        {
            Marks[i] = int.Parse(Console.ReadLine());
        }

        CalculateResult();
    }

    public void CalculateResult()
    {
        TotalMarks = Marks.Sum();
        Percentage = (double)TotalMarks / 500 * 100;
    }

    // Display student information
    public void Display()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Roll No: " + RollNo);
        Console.WriteLine("Marks: " + string.Join(", ", Marks));
        Console.WriteLine("Total Marks: " + TotalMarks);
        Console.WriteLine("Percentage: " + Percentage + "%");
    }
}