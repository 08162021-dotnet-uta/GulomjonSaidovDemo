// Topics Discussed
// type inference (var give a type in runtime)
// parsing
// casting
// Scope (namespace, class, method, block)
// Single Responsibiity (part of SOLID)
// DRY (don't repeat yourself)
// Method (signature, parameter)
// Primitive Types(int, boo, string, float, double)
// Type Families(value, reference)
// Method Signature - access modifiers, optionally non-access mofidiers, return type, identifier, optionally parameters
// Exception handling

using System;

namespace Calculator
{
  class Program
  {
    static void Main(string[] args)
    {
      int input1, input2;
      Input(out input1, out input2);
      // compute stuff
      var result1 = Add(inputs[0], inputs[1]);
      var result2 = Subtract(inputs[0], inputs[1]);
      var result3 = Multiply(inputs[0], inputs[1]);
      var result4 = Divide(inputs[0], inputs[1]);

      // output stuff
      Print(result1, result2, result3, result4);

    }

    static int Add(int input1, int input2)
    {
      // compute stuff
      var compute = input1 + input2; // type inference, casting
      return compute;
    }

    static int Subtract(int input1, int input2)
    {
      // compute stuff
      var compute = input1 - input2; // type inference, casting
      return compute;
    }

    static int Multiply(int input1, int input2)
    {
      // compute stuff
      var compute = input1 * input2; // type inference, casting
      return compute;
    }

    static int Divide(int input1, int input2)
    {
      // compute stuff
      var compute = input1 / input2; // type inference, casting
      return compute;
    }

    static void Print(params int[] results)
    {
      // output stff
      for (int i = 0; i < results.Length; i++)
      {
        Console.WriteLine(results[i]);
      }
      // Console.WriteLine(results);
    }

    // custom try-parse
    static bool CustomTryParse(string s, out int result)
    {
      try
      {
        result = int.Parse(s);

        return true;
      }
      catch
      {
        result = 0;
        return false;
      }
    }

    static bool Input(out int i1, out int i2)
    {
      // try
      // {
      //   var input1 = int.Parse(Console.ReadLine()); // type inference, parsing
      //   var input2 = int.Parse(Console.ReadLine());

      //   return new int[] { input1, input2 };
      // }
      // catch (Exception ex)
      // {
      //   throw ex; // point to the original error - not recommended 
      //   //throw new Exception("we are sorry for it", ex); // creates a new error
      // }
      // finally
      // {
      //   // always run
      // }
      int input1, input2;
      if (int.TryParse(Console.ReadLine(), out input1) & int.TryParse(Console.ReadLine(), out input2))
      {
        i1 = input1;
        i2 = input2;

        return true;
      }
      else
      {
        i1 = i2 = 0;

        return false;
      }
    }
  }
}
