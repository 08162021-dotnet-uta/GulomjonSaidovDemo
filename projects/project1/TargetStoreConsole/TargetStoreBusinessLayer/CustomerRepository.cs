using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TargetStoreDbContext.Models;

namespace TargetStoreBusinessLayer
{
    public class CustomerRepository
    {
        //private readonly StoreAppContext context;

        public StoreAppContext context = new StoreAppContext();
    }
}
