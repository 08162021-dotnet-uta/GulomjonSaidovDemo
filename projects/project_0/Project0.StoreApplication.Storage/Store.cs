using System;

namespace Project0.StoreApplication.Storage
{
  public class Store
  {
    public string Name { get; }

    public Store()
    {
      Name = DateTime.Now.ToLongDateString();
    }

    public override string ToString()
    {
      return Name;
    }
  }
}