using System;
using System.Collections.Generic;

namespace _7_GuessingGameChallenge
{
  public class Program
  {
    public static void Main(string[] args)
    {

    }

    /// <summary>
    /// This method returns a randomly chosen number between 1 and 100, inclusive.
    /// </summary>
    /// <returns></returns>
    public static int GetRandomNumber()
    {
      // throw new NotImplementedException();
      Random rand = new Random();
      return rand.Next(0, 101);
    }

    /// <summary>
    /// This method gets input from the user, 
    /// verifies that the input is valid and 
    /// returns an int.
    /// </summary>
    /// <returns></returns>
    public static int GetUsersGuess()
    {
      // throw new NotImplementedException();
      bool unsuccessful;
      int num;
      do
      {
        Console.WriteLine("Please type a number between 0 and 100 inlusive");
        string input = Console.ReadLine();
        unsuccessful = int.TryParse(input, out num);
      } while (!unsuccessful || num <= 100 || num >= 0);

      return num;
    }

    /// <summary>
    /// This method will has two int parameters.
    /// It will:
    /// 1) compare the first number to the second number
    /// 2) return -1 if the first number is less than the second number
    /// 3) return 0 if the numbers are equal
    /// 4) return 1 if the first number is greater than the second number
    /// </summary>
    /// <param name="randomNum"></param>
    /// <param name="guess"></param>
    /// <returns></returns>
    public static int CompareNums(int randomNum, int guess)
    {
      // throw new NotImplementedException();
      if (randomNum < guess)
      {
        return -1;
      }
      else if (randomNum > guess)
      {
        return 1;
      }
      return 0;
    }

    public static bool PlayGameAgain()
    {
      throw new NotImplementedException();
    }
  }
}
