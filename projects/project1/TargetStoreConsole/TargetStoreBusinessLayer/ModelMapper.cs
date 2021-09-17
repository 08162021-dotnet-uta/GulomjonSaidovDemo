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
    public class ModelMapper : IModelMapper
    {

        /// <summary>
        /// This method takes a Customer and returns the mapping to a ViewModelCustomer
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static ViewModelCustomer CustomerToViewModelCustomer(Customer c)
        {
            ViewModelCustomer c1 = new ViewModelCustomer();
            c1.Fname = c.FirstName;
            c1.Lname = c.LastName;

            return c1;
        }

        /// <summary>
        /// This method takes a ViewModelCustomer and returns the mapping to a Customer
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static Customer ViewModelCustomerToCustomer(ViewModelCustomer c)
        {
            Customer c1 = new Customer();
            c1.FirstName = c.Fname;
            c1.LastName = c.Lname;

            return c1;
        }

        /// <summary>
        /// This method takes a ViewModelProduct and returns the mapping to a Product
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static Product ViewModelProductToProduct(ViewModelProduct p)
        {
            Product p1 = new Product();
            p1.ProductId = p.ProductId;
            p1.ProductName = p.ProductName;
            p1.ProductDescription = p.ProductDescription;
            p1.ProductPrice = p.ProductPrice;

            return p1;
        }

        /// <summary>
        /// This method takes a Product and returns the mapping to a ViewModelProduct
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static ViewModelProduct ProductToViewModelProduct(Product p)
        {
            ViewModelProduct p1 = new ViewModelProduct();
            p1.ProductId = p.ProductId;
            p1.ProductName = p.ProductName;
            p1.ProductDescription = p.ProductDescription;
            p1.ProductPrice = p.ProductPrice;

            return p1;
        }

        public static Store ViewModelStoretoStore(ViewModelStore s)
        {
            Store s1 = new Store();
            s1.StoreId = s.StoreId;
            s1.StoreName = s.StoreName;

            return s1;
        }

        /// <summary>
        /// This method takes a Store returns the mapping to a ViewModelStore
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static ViewModelStore StoreToViewModelStore(Store s)
        {
            ViewModelStore s1 = new ViewModelStore();
            s1.StoreId = s.StoreId;
            s1.StoreName = s.StoreName;

            return s1;
        }
    }
}
