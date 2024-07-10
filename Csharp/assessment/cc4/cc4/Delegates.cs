using System;

public delegate int CalculatorDelegate(int num1, int num2);

class Delegate
{
    static void Main()
    {
       
        CalculatorDelegate addition = (a, b) => a + b;
        CalculatorDelegate subtraction = (a, b) => a - b;
        CalculatorDelegate multiplication = (a, b) => a * b;

        
        Console.Write("Enter the first number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

       
        int resultAddition = addition(number1, number2);
        int resultSubtraction = subtraction(number1, number2);
        int resultMultiplication = multiplication(number1, number2);

        
        Console.WriteLine($"Result of Addition: {resultAddition}");
        Console.WriteLine($"Result of Subtraction: {resultSubtraction}");
        Console.WriteLine($"Result of Multiplication: {resultMultiplication}");

        Console.ReadLine();
    }
}
