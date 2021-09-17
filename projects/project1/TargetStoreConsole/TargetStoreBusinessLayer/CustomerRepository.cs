using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TargetStore;
using TargetStoreBusinessLayer.Interfaces;
using TargetStoreDbContext.Models;

namespace TargetStoreBusinessLayer
{
    public class CustomerRepository : ICustomerRepository
    {
        // Step 1 of Dependency Injection - create a  private instance of the dependency
        private readonly StoreAppContext _context;
        // Step 2 of DI - call for an instance from the DI system in the constructor.
        public CustomerRepository(StoreAppContext context)
        {
            _context = context;
        }
    

        /// <summary>
    /// This method takes a ViewModelCustomer object and returns the ViewModelCustomer
    /// if found in the Db, null if not found
    /// </summary>
    /// <returns></returns>
        public async Task<ViewModelCustomer> LoginCustomerAsync(ViewModelCustomer vmc)
        {
            Customer c1 = ModelMapper.ViewModelCustomerToCustomer(vmc);

            Customer c2 = await _context.Customers.FromSqlRaw<Customer>("select * from Customers where FirstName = {0} AND LastName = {1}", c1.FirstName, c1.LastName).FirstOrDefaultAsync();
            
            if (c2 == null) return null;

            ViewModelCustomer c3 = ModelMapper.CustomerToViewModelCustomer(c2);
            return c3;
        }

        public async Task<ViewModelCustomer> RegisterCustomerAsync(ViewModelCustomer vmc)
        {
            Customer c1 = ModelMapper.ViewModelCustomerToCustomer(vmc);

            int c2 = await _context.Database.ExecuteSqlRawAsync("insert into Customers values({0}, {1})", c1.FirstName, c1.LastName);

            if (c2 != 1) return null;

            //Customer c3 = _context.Customers.FromSqlRaw<Customer>("select * from Customers where FirstName = {0} AND LastName = {1}", c1.FirstName, c1.LastName).FirstOrDefault();

            //if (c2 == null) return null;

            //ViewModelCustomer c4 = ModelMapper.CustomerToViewModelCustomer(c3);
            //return c4;
            return await LoginCustomerAsync(vmc);
        }

        /// <summary>
        /// This method returns a list of products or a single product given an input
        /// </summary>
        /// <returns></returns>
        //public async Task<List<ViewModelProduct>> ProductsAsync(int prodId = -1)
        //{
        //    List<ViewModelProduct> viewmodelproducts = new List<ViewModelProduct>();
        //    if (prodId ==-1)
        //    {
        //        List<Product> products = await _context.Products.FromSqlRaw<Product>("select * from Products").ToListAsync();
        //        // convert to ViewModelProduct
        //        foreach(Product p in products)
        //        {
        //            viewmodelproducts.Add(ModelMapper.ProductToViewModelProduct(p));
        //        }
        //        return viewmodelproducts;
        //    }
        //    else
        //    {
        //        List<Product> products = await _context.Products.FromSqlRaw<Product>("select TOP 1 from Products where ProductId={prodId}", prodId).ToListAsync();
        //        // convert to ViewModelProduct
        //        foreach(Product p in products)
        //        {
        //            viewmodelproducts.Add(ModelMapper.ProductToViewModelProduct(p));
        //        }
        //        return viewmodelproducts;
        //    }

            
        //}

        public async Task<List<ViewModelCustomer>> CustomerListAsync()
        {
            List<Customer> customers = await _context.Customers.FromSqlRaw<Customer>("select * from Customers").ToListAsync();

            List<ViewModelCustomer> vmc = new List<ViewModelCustomer>();
            foreach(Customer c in customers)
            {
                vmc.Add(ModelMapper.CustomerToViewModelCustomer(c));
            }
            return vmc;

        }

    }// end of class
}// end of namespace
