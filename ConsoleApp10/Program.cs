using System;
using System.Collections.Generic;
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Height { get; set; }
    public double Weight { get; set; }
    public string EyeColor { get; set; }
}

public class Student : Person
{
    public string StudentId { get; set; }
}

public class Aspirant : Student
{
    public string DissertationTopic { get; set; }
}

public class Group
{
    private List<Student> students = new List<Student>();

    public Student this[int index]
    {
        get
        {
            if (index < 0 || index >= students.Count)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }
            return students[index];
        }
    }

    public void AddStudent(Student student)
    {
        students.Add(student);
    }
}

public class Program
{
    public static void Main()
    {
        Group g = new Group();
        Student s = new Student { Name = "Alex" };
        g.AddStudent(s);
        Console.WriteLine(g[0].Name);
    }
}