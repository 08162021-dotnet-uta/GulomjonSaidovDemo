using System.Collections.Generic;
using Project0.StoreApplication.Domain.Interfaces;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Adapters;

namespace Project0.StoreApplication.Storage.Repositories
{
  /// <summary>
  /// 
  /// </summary>
  public class ProductRepository : IRepository<Product>
  {
    private const string _path = @"/home/gulom/revature/gulomjon_repo/data/products.xml";
    private static readonly FileAdapter _fileAdapter = new FileAdapter();

    public ProductRepository()
    {
      if (_fileAdapter.ReadFromFile<Product>(_path) == null)
      {
        _fileAdapter.WriteToFile<Product>(_path, new List<Product>()
        {
          new Product(){ProductId = 1, Name = "Dell XPS 15.4", Price = 1500},
          new Product(){ProductId = 2, Name = "Monitor", Price = 1000},
          new Product(){ProductId = 3, Name = "Galaxy Note", Price = 150},
          new Product(){ProductId = 4, Name = "HP 17", Price = 500},
          new Product(){ProductId = 5, Name = "Samsung Tablet", Price = 800},
          new Product(){ProductId = 6, Name = "Bose II Head Phone", Price = 300},
          new Product(){ProductId = 7, Name = "Logitech Wireless Keyboard", Price = 50}
        });
      }
    }

    /// <summary>
    /// Deletes Product collection
    /// </summary>
    /// <returns></returns>
    public bool Delete()
    {
      throw new System.NotImplementedException();
    }

    /// <summary>
    /// Inserts into Product collection
    /// </summary>
    /// <returns></returns>
    public bool Insert(Product entry)
    {
      _fileAdapter.WriteToFile<Product>(_path, new List<Product> { entry });

      return true;
    }

    /// <summary>
    /// Gets Product collection
    /// </summary>
    /// <returns></returns>
    public List<Product> Select()
    {
      return _fileAdapter.ReadFromFile<Product>(_path);
    }

    /// <summary>
    /// Updates Product collection
    /// </summary>
    /// <returns></returns>
    public Product Update()
    {
      throw new System.NotImplementedException();
    }
    /// <summary>
    /// Appends sigle Product object to Product collection in products.xml file
    /// </summary>
    /// <param name="entry"></param>
    /// <returns></returns>
    public bool Append(Product entry)
    {
      var collections = _fileAdapter.ReadFromFile<Product>(_path);
      collections.Add(entry);
      _fileAdapter.WriteToFile<Product>(_path, collections);

      return true;
    }
  }
}