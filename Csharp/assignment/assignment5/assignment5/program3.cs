using System;

public class Employee
{
    
    public int Empid { get; private set; }
    public string Empname { get; private set; }
    public float Salary { get; protected set; } 

 
    public Employee(int empid, string empname, float salary)
    {
        Empid = empid;
        Empname = empname;
        Salary = salary;
    }

    
    public virtual void Display()
    {
        Console.WriteLine($"Employee ID: {Empid}");
        Console.WriteLine($"Employee Name: {Empname}");
        Console.WriteLine($"Salary: {Salary:C}");
    }
}


public class ParttimeEmployee : Employee
{
   
    public float Wages { get; private set; }

    
    public ParttimeEmployee(int empid, string empname, float salary, float wages)
        : base(empid, empname, salary)
    {
        Wages = wages;
    }

    
    public override void Display()
    {
        base.Display(); 
        Console.WriteLine($"Wages: {Wages:C}"); 
    }
}

class program
{
    static void Main()
    {
        
        ParttimeEmployee parttimeEmp = new ParttimeEmployee(1, "Charishma Mamidi", 2500.75f, 15.5f);

       
        Console.WriteLine("Part-time Employee Details:");
        parttimeEmp.Display();
        Console.Read();
    }

}
