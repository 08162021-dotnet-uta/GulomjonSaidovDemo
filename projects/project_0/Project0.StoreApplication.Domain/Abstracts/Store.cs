using System.Xml.Serialization;
using Project0.StoreApplication.Domain.Models;

namespace Project0.StoreApplication.Domain.Abstracts
{
  [XmlInclude(typeof(Central))]
  [XmlInclude(typeof(Colma))]
  [XmlInclude(typeof(Stonestown))]
  [XmlInclude(typeof(West))]
  public abstract class Store
  {
    public string Name { get; set; }

    public override string ToString()
    {
      return Name;
    }
  }
}