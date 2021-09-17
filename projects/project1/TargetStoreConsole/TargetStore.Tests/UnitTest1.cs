using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TargetStoreBusinessLayer;
using TargetStoreDbContext.Models;
using Xunit;

namespace TargetStore.Tests
{
    public class UnitTest1
    {
        public DbContextOptions<StoreAppContext> options { get; set; } = new
        DbContextOptionsBuilder<StoreAppContext>()
            .UseInMemoryDatabase(databaseName: "TestDb")
            .Options;
        [Fact]
        public async Task Test1()
        {
            //DbContextOptions<StoreAppContext> options = new DbContextOptionsBuilder<StoreAppContext>()
            //.UseInMemoryDatabase(databaseName: "TestDb")
            //.Options;

            using (StoreAppContext _context = new StoreAppContext(options))
            {
                // arrange - create the test foundation
                _context.Database.EnsureDeleted();
                _context.Database.EnsureCreated();

                Customer c = new Customer() { FirstName="Belly", LastName="Jelly"};
                Customer c1 = new Customer() { FirstName = "Kelly", LastName = "Jelly" };
                Customer c2 = new Customer() { FirstName = "Molly", LastName = "Jelly" };

                _context.Customers.Add(c);
                _context.Customers.Add(c1);
                _context.Customers.Add(c2);
                //_context.Database.ExecuteSqlRaw("insert into Customers values ({0}, {1})", c.FirstName, c.LastName);
                _context.SaveChanges();

                CustomerRepository cr = new CustomerRepository(_context);

                // act - on the foundation
                //Customer c1 = _context.Customers.Where(cust => cust.FirstName == "Belly" && cust.LastName == "Jelly").FirstOrDefault();


                // use the customer repository with the mocked db and the fake data
                List<ViewModelCustomer> result = await cr.CustomerListAsync();
                // assert
                Assert.Equal(result.Count, 3);
                Assert.True(result[2].Fname == "Molly");
                Assert.True(result.Count == 3); 
            }
        }
    }
}
