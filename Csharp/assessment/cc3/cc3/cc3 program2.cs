using System;

class Box
{
    public double Length { get; set; }
    public double Breadth { get; set; }

    public Box()
    {
        Length = 0;
        Breadth = 0;
    }
    public Box(double length, double breadth)
    {
        Length = length;
        Breadth = breadth;
    }
    public static Box operator +(Box b1, Box b2)
    {
        return new Box(b1.Length + b2.Length, b1.Breadth);
    }
    public void Display()
    {
        Console.WriteLine($"Length: {Length}, Breadth: {Breadth}");
        Console.Read();
    }
}
class Test
{
      static void Main(string[] args)
    {
        Box box1 = new Box(2.0, 5.0);
        Box box2 = new Box(1.0, 2.5);

        Box box3 = box1 + box2;

        Console.WriteLine("Box 1 details:");
        box1.Display();

        Console.WriteLine("Box 2 details:");
        box2.Display();

        Console.WriteLine("Box3 (sum of Box 1 and box 2) details:");
        box3.Display();

    }
}
