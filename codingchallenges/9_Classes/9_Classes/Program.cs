using System;

namespace _9_ClassesChallenge
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Human gulom = new Human("gulom", "saidov");
      Console.WriteLine(gulom.AboutMe());



      Human2 mike = new Human2("Mike", "Tyson", "brown");
      Console.WriteLine(mike.AboutMe2());

      Human2 mike1 = new Human2("Mike", "Tyson", "brown", 50);
      Console.WriteLine(mike1.AboutMe2());

      Human2 mike2 = new Human2("Mike", "Tyson", 50);
      Console.WriteLine(mike2.AboutMe2());

    }
  }
}
