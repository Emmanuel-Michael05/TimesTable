
using System;
using System.Globalization;

namespace Examples
{
    class Program
    {
        static void Main(string[] args) 
        {
                Console.WriteLine("Enter a number   ");
                int userInput = int.Parse(Console.ReadLine());
  
            for (int i = 1; i <= 10; i++)
            {
                int result = i * userInput;
                Console.WriteLine( $"{i} * {userInput} = {result}");
                Console.ReadLine();
            }
        }
    }

  
}