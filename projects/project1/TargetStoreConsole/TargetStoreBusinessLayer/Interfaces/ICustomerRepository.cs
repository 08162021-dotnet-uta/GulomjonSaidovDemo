using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TargetStore;
using TargetStoreDbContext.Models;

namespace TargetStoreBusinessLayer.Interfaces
{
    public interface ICustomerRepository
    {
        Task<ViewModelCustomer> LoginCustomerAsync(ViewModelCustomer vmc);

        Task<ViewModelCustomer> RegisterCustomerAsync(ViewModelCustomer vmc);

        //Task<List<ViewModelProduct>> ProductsAsync(int prodId = -1);
        Task<List<ViewModelCustomer>> CustomerListAsync();

    }
}
