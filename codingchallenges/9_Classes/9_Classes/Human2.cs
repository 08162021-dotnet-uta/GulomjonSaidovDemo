using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("9_ClassesChallenge.Tests")]
namespace _9_ClassesChallenge
{
  internal class Human2 : Human
  {
    private string eyeColor;
    private int age;

    public Human2(string firstName, string lastName, string eyeColor, int age) : base(firstName, lastName)
    {
      this.eyeColor = eyeColor;
      this.age = age;
    }
    public Human2(string firstName, string lastName, int age) : base(firstName, lastName)
    {
      this.age = age;
    }
    public Human2(string firstName, string lastName, string eyeColor) : base(firstName, lastName)
    {
      this.eyeColor = eyeColor;
    }

    public string AboutMe2()
    {
      if (this.eyeColor != null && this.age != 0)
      {
        return AboutMe() + $" My eye color {this.eyeColor} and my age is {this.age}.";
      }
      else if (this.age != 0)
      {
        return AboutMe() + $" My age is {this.age}.";
      }
      else if (this.eyeColor != null)
      {
        return AboutMe() + $" My eye color is {this.eyeColor}";
      }
      return AboutMe();
    }
  }
}