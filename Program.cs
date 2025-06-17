using System;
class Program
{
   static void Main()
   {
       while (true)
       {
           Console.WriteLine("Simple Calculator");
           Console.Write("Enter first number: ");
           if (!double.TryParse(Console.ReadLine(), out double num1)) continue;
           Console.Write("Enter operation (+ - * /): ");
           string op = Console.ReadLine();
           Console.Write("Enter second number: ");
           if (!double.TryParse(Console.ReadLine(), out double num2)) continue;
           double result = op switch
           {
               "+" => num1 + num2,
               "-" => num1 - num2,
               "*" => num1 * num2,
               "/" => num2 != 0 ? num1 / num2 : double.NaN,
               _ => double.NaN
           };
           Console.WriteLine($"Result: {result}");
           Console.Write("Continue? (y/n): ");
           if (Console.ReadLine()?.ToLower() != "y") break;
       }
   }
}