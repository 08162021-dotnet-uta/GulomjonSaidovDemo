using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TargetStore;

namespace TargetStoreBusinessLayer.Interfaces
{
    public interface IProductRepository
    {
        List<ViewModelProduct> Products() { throw new NotImplementedException(); }
        List<ViewModelProduct> ProductsByStore(int id) { throw new NotImplementedException(); }
    }
}
