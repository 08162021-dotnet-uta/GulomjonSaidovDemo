

using System.Collections.Generic;

namespace Project0.StoreApplication.Domain.Interfaces
{
  public interface IRepository<T> where T : class
  {
    bool Delete();

    bool Insert(T entery);

    List<T> Select();

    T Update();
  }
}