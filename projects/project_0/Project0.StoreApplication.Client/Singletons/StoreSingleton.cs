using System.Collections.Generic;
using Project0.StoreApplication.Domain.Abstracts;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Repositories;

namespace Project0.StoreApplication.Client.Singletons
{
  /// <summary>
  /// Defines StoreSingleton class
  /// </summary>
  public class StoreSingleton
  {
    private static StoreSingleton _storeSingleton;
    private static readonly StoreRepository _storeRepository = new StoreRepository();

    public List<Store> Stores { get; private set; }
    public static StoreSingleton Instance
    {
      get
      {
        if (_storeSingleton == null)
        {
          _storeSingleton = new StoreSingleton();
        }

        return _storeSingleton;
      }
    }

    /// <summary>
    /// Retrieves Store collection
    /// </summary>
    private StoreSingleton()
    {
      Stores = _storeRepository.Select();
    }

    /// <summary>
    /// Adds to Store collection
    /// </summary>
    /// <param name="Store"></param>
    public void Add(Store Store)
    {
      _storeRepository.Insert(Store);
      Stores = _storeRepository.Select();
    }
  }
}