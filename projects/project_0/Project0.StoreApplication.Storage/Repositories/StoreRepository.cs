using System.Collections.Generic;
using Project0.StoreApplication.Domain.Abstracts;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Adapters;

namespace Project0.StoreApplication.Storage.Repositories
{
  public class StoreRepository
  {
    public List<Store> Stores { get; }

    public StoreRepository()
    {
      // Stores = new List<Store>()
      // {
      //   new Central(),
      //   new Stonestown(),
      //   new West(),
      // };
      var fileAdapter = new FileAdapter();

      // if (fileAdapter.ReadFromFile() == null)
      // {
      //   fileAdapter.WriteToFile(new List<Store>()
      //   {
      //     new Central(),
      //     new West(),
      //     new West()
      //     // new Colma()
      //   });
      // }
      fileAdapter.WriteToFile(new List<Store>()
        {
          new Central(),
          new West(),
          new West(),
          new Colma(),
        });


      Stores = fileAdapter.ReadFromFile();
    }

    // public Store GetStore(int index)
    // {
    //   try
    //   {
    //     return Stores[index];
    //   }
    //   catch
    //   {
    //     return null;  
    //   }
    // }
  }
}