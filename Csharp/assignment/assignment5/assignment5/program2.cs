using System;


public class Box
{
    
    public double Length { get; set; }
    public double Breadth { get; set; }

    
    public Box(double length, double breadth)
    {
        Length = length;
        Breadth = breadth;
    }

   
    public static Box AddBoxes(Box box1, Box box2)
    {
        double newLength = box1.Length + box2.Length;
        double newBreadth = box1.Breadth + box2.Breadth;
        return new Box(newLength, newBreadth);
    }

   
    public void Display()
    {
        Console.WriteLine($"Length: {Length}, Breadth: {Breadth}");
    }
}


class Test
{
    static void Main()
    {
        
        Box box1 = new Box(5.0, 3.0);
        Box box2 = new Box(2.0, 4.0);

        
        Box box3 = Box.AddBoxes(box1, box2);

      
        Console.WriteLine("Box 1 dimensions:");
        box1.Display();

        Console.WriteLine("Box 2 dimensions:");
        box2.Display();

        Console.WriteLine("Box 3 dimensions (result of adding Box 1 and Box 2):");
        box3.Display();
        Console.Read();

    }
}
