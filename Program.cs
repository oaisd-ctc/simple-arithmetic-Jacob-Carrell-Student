using System;

public class Program
{
    public static void Main(string[] args)
    {
        // This is where we get two numbers from the user's input
        Console.WriteLine("Provide one number to perform the addition operation");
        string numb = Console.ReadLine();
    
        Console.WriteLine(numb + "… got it. Provide an additional number to add to " + numb);
        string numb1 =Console.ReadLine();

       // converting the strings into doubles
       double number = Double.Parse(numb);
       double number1 = Double.Parse(numb1);

       Console.WriteLine();  // This is just a blank line to separate the input from the output in the terminal

       // Output of number + number, number - number, etc...
       Console.WriteLine(number + number1);
       Console.WriteLine(number - number1);
       Console.WriteLine(number * number1);
       Console.WriteLine(number / number1);
       Console.WriteLine(number % number1);
    }
}