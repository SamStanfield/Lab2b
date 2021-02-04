using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("What is the first number?");
    double num1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine ("What is the second number?");
    double num2 = Convert.ToDouble(Console.ReadLine());
    double sum = num1 + num2;
    double diff = num1 - num2;
    double product = num1 * num2;
    double quotient = num1 / num2;
    double remainder = num1 % num2;
    Console.WriteLine("Sum = " + sum);
    Console.WriteLine("Difference = " + diff);
    Console.WriteLine("Product = " + product);
    Console.WriteLine("Quotient = " + quotient);
    Console.WriteLine("Remainder = " + remainder);

  }
}