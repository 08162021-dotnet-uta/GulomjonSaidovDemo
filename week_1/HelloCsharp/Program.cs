using System;

namespace HelloCsharp
{
  class Program

  {

    static int Add(int x, int y)
    {
      return x + y;
    }

    static int Subtract(int x, int y)
    {
      return x - y;
    }

    static int Multiply(int x, int y)
    {
      return x * y;
    }

    static int Divide(int x, int y)
    {
      return x / y;
    }
    static void Main(string[] args)
    {
      Console.WriteLine("Enter a number:");

      string num1 = Console.ReadLine();
      int int1 = Convert.ToInt32(num1);

      Console.WriteLine("Type 'add' or 'subtract' or 'multiply' or 'divide'");

      string operation = Console.ReadLine();

      Console.WriteLine("Enter you next number");

      string num2 = Console.ReadLine();
      int int2 = Convert.ToInt32(num2);

      if (operation == "add")
      {
        Console.WriteLine(Program.Add(int1, int2));
      }
      else if (operation == "subtract")
      {
        Console.WriteLine(Program.Subtract(int1, int2));
      }
      else if (operation == "multiply")
      {
        Console.WriteLine(Program.Multiply(int1, int2));
      }
      else if (operation == "divide")
      {
        Console.WriteLine(Program.Divide(int1, int2));
      }
    }


  }
}

