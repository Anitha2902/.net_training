﻿using System;


namespace Assignment4

{

    class Program2

    {

        static void Main()

        {

            Console.Write("Enter a string: ");

            string inputString = Console.ReadLine();

            Console.Write("Enter the letter to be counted: ");

            char letter = char.Parse(Console.ReadLine());

            int occurrences = CountLetterOccurrences(inputString, letter);

            Console.WriteLine($"The letter '{letter}' appears {occurrences} times in the string '{inputString}'");

            Console.ReadLine();

        }

        static int CountLetterOccurrences(string str, char letter)

        {

          

            str = str.ToLower();

            letter = char.ToLower(letter);

            int count = 0;

            foreach (char c in str)

            {

                if (c == letter)

                    count++;

            }

            return count;
            

        }

    }

}

