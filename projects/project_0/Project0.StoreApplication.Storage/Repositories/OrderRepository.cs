using System;
using System.Collections.Generic;
using Project0.StoreApplication.Domain.Interfaces;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Adapters;

namespace Project0.StoreApplication.Storage.Repositories
{
  /// <summary>
  /// 
  /// </summary>
  public class OrderRepository : IRepository<Order>
  {
    private const string _path = @"/home/gulom/revature/gulomjon_repo/data/orders.xml";
    private static readonly FileAdapter _fileAdapter = new FileAdapter();

    public OrderRepository()
    {
      if (_fileAdapter.ReadFromFile<Order>(_path) == null)
      {
        _fileAdapter.WriteToFile<Order>(_path, new List<Order>());
      }
    }

    /// <summary>
    /// Deletes Order collection
    /// </summary>
    /// <returns></returns>
    public bool Delete()
    {
      throw new System.NotImplementedException();
    }

    /// <summary>
    /// Inserts into Order collection
    /// </summary>
    /// <returns></returns>
    public bool Insert(Order entry)
    {
      _fileAdapter.WriteToFile<Order>(_path, new List<Order> { entry });

      return true;
    }

    /// <summary>
    /// Gets Order collection
    /// </summary>
    /// <returns></returns>
    public List<Order> Select()
    {
      return _fileAdapter.ReadFromFile<Order>(_path);
    }

    /// <summary>
    /// Updates Order collection
    /// </summary>
    /// <returns></returns>
    public Order Update()
    {
      throw new System.NotImplementedException();
    }
    /// <summary>
    /// Appends single order object to the Order collection in objects.xml file
    /// </summary>
    /// <param name="entry"></param>
    /// <returns></returns>
    public bool Append(Order entry)
    {
      var orders = _fileAdapter.ReadFromFile<Order>(_path);
      orders.Add(entry);
      _fileAdapter.WriteToFile<Order>(_path, orders);

      return true;
    }
  }
}