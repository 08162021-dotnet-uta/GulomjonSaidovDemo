using System.Collections.Generic;

namespace Project0.StoreApplication.Domain.Models
{
  /// <summary>
  /// Defines Customer
  /// </summary>
  public class Customer
  {
    public string Name { get; set; }
    public byte CustomerId { get; set; }
    public List<Order> Orders { get; set; }

    public Customer()
    {
      // Name = "Gulomjon";
    }

    public override string ToString()
    {
      return $"{Name} has {Orders.Count} orders.";
    }
  }
}