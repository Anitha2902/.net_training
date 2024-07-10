using System;
using System.IO;

class Append
{
    static void Main()
    {
        string filePath = "sample.txt";
        string textToAdd = "This text will be appended to the file.";

       
        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            writer.WriteLine(textToAdd);
        }

        Console.WriteLine("Text has been appended to the file.");
        Console.ReadLine();
    }
}
