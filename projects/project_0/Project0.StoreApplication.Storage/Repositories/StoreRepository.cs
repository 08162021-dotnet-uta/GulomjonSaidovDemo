using System.Collections.Generic;

namespace Project0.StoreApplication.Storage.Repositories
{
  public class StoreRepository
  {
    public List<Store> Stores { get; }

    public StoreRepository()
    {
      Stores = new List<Store>()
      {
        new Store(),
        new Store(),
        new Store()
      };
    }

    public Store GetStore(int index)
    {
      try
      {
        return Stores[index];
      }
      catch
      {
        return null;
      }
    }
  }
}