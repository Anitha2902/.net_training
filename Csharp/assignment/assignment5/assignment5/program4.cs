using System;


public interface IStudent
{
    
    int StudentId { get; set; }
    string Name { get; set; }

    
    void ShowDetails();
}


public class Dayscholar : IStudent
{
    
    public int StudentId { get; set; }
    public string Name { get; set; }

    
    public void ShowDetails()
    {
        Console.WriteLine($"Student ID: {StudentId}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine("Type: Dayscholar");
        Console.WriteLine();
    }
}


public class Resident : IStudent
{
  
    public int StudentId { get; set; }
    public string Name { get; set; }

    
    public void ShowDetails()
    {
        Console.WriteLine($"Student ID: {StudentId}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine("Type: Resident");
        Console.WriteLine();
    }
}

class program
{
    static void Main()
    {
        
        IStudent student1 = new Dayscholar { StudentId = 1, Name = "John Doe" };
        IStudent student2 = new Resident { StudentId = 2, Name = "Jane Smith" };

        
        Console.WriteLine("Dayscholar Details:");
        student1.ShowDetails();

        Console.WriteLine("Resident Details:");
        student2.ShowDetails();
        Console.Read();
    }
}
