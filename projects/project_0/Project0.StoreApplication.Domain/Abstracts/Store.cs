using System.Collections.Generic;
using System.Xml.Serialization;
using Project0.StoreApplication.Domain.Models;

namespace Project0.StoreApplication.Domain.Abstracts
{
  [XmlInclude(typeof(Central))]
  [XmlInclude(typeof(Colma))]
  [XmlInclude(typeof(Stonestown))]
  [XmlInclude(typeof(West))]
  public class Store
  {
    public string Name { get; set; }
    public int StoreId { get; set; }
    public List<Order> Orders { get; set; }
    public List<Product> Products { get; set; }

    public Store()
    {
      Orders = new List<Order>();
      Products = new List<Product>();
    }

    public override string ToString()
    {
      return Name;
    }
  }
}