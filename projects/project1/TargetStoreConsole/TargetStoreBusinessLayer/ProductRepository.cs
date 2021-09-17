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
    public class ProductRepository : IProductRepository
    {
        // Step 1 of Dependency Injection - create a  private instance of the dependency
        private readonly StoreAppContext _context;
        // Step 2 of DI - call for an instance from the DI system in the constructor.
        public ProductRepository(StoreAppContext context)
        {
            _context = context;
        }


        public List<ViewModelProduct> Products()
        {
            List<Product> products = _context.Products.FromSqlRaw<Product>("select * from Products").ToList();

            List<ViewModelProduct> vmp = new List<ViewModelProduct>();
            foreach (Product p in products)
            {
                vmp.Add(ModelMapper.ProductToViewModelProduct(p));
            }

            return vmp;
        }

        public List<ViewModelProduct> ProductsByStore(int id)
        {
            List<Product> products = _context.Products.FromSqlRaw<Product>("select * from Products where productId = {0}", id).ToList();

            List<ViewModelProduct> vmp = new List<ViewModelProduct>();
            foreach (Product p in products)
            {
                vmp.Add(ModelMapper.ProductToViewModelProduct(p));
            }

            return vmp;
        }
    }
}
