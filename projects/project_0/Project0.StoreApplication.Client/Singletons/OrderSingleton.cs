using System.Collections.Generic;
using Project0.StoreApplication.Domain.Abstracts;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Repositories;

namespace Project0.StoreApplication.Client.Singletons
{
  /// <summary>
  /// Defines ProductSingleton class
  /// </summary>
  public class OrderSingleton
  {
    private static OrderSingleton _orderSingleton;
    private static readonly OrderRepository _orderRepository = new OrderRepository();

    public List<Order> Orders { get; private set; }
    public static OrderSingleton Instance
    {
      get
      {
        if (_orderSingleton == null)
        {
          _orderSingleton = new OrderSingleton();
        }

        return _orderSingleton;
      }
    }

    /// <summary>
    /// Retrieves Orders collection
    /// </summary>
    private OrderSingleton()
    {
      Orders = _orderRepository.Select();
    }

    /// <summary>
    /// Adds to Orders collection
    /// </summary>
    /// <param name="order"></param>
    public void Add(Order order)
    {
      _orderRepository.Insert(order);
      Orders = _orderRepository.Select();
    }
    public void Append(Order order)
    {
      _orderRepository.Append(order);
      Orders = _orderRepository.Select();
    }
  }
}