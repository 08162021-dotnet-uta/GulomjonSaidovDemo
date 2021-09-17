using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TargetStore;

namespace TargetStoreBusinessLayer.Interfaces
{
    public interface IModelMapper
    {
        ViewModelCustomer CustomerToViewModelCustomer(Customer c) { throw new NotImplementedException(); }
        Customer ViewModelCustomerToCustomer(ViewModelCustomer c) { throw new NotImplementedException(); }
        Product ViewModelProductToProduct(ViewModelProduct p) { throw new NotImplementedException(); }
        ViewModelProduct ProductToViewModelProduct(Product p) { throw new NotImplementedException(); }
        Store ViewModelStoretoStore(ViewModelStore s) { throw new NotImplementedException(); }
        ViewModelStore StoreToViewModelStore(Store s) { throw new NotImplementedException(); }
    }
}
