using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Enter first number:");

    // Create a string variable and get user input from the keyboard and store it in the variable
    int number_1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter first number:");
    int number_2 = int.Parse(Console.ReadLine());
   
    Console.WriteLine(number_1 + number_2);
  }
}
