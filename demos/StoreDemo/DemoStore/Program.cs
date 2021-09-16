using DemoStoreDbContext.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using cust = DemoStoreDbContext.Models.Customer;

namespace DemoStore
{
  class Program
  {
    static void Main(string[] args)
    {
      ViewModelCustomer c1 = new ViewModelCustomer("Gulomjon", "Saidov");

      ViewModelCustomer c2 = new ViewModelCustomer();
      c2.Fname = "Ibrohim";
      c2.Lname = "Saidov";
      Console.WriteLine($"The names are {c1.Fname} {c1.Lname} and {c2.Fname} {c2.Lname}");

      using (DemoContext context = new DemoContext())
      {
                #region
                //context.Database.ExecuteSqlRaw("exec AddaCustomer @fname='agile', @lname='some';");
                //context.Database.ExecuteSqlRaw("exec DeleteaCustomer @fname='Ben', @lname='Frank';");
                //context.Customers.FromSqlRaw<cust>("delet from Customers where FirstName='agile'");// didnt' work
                var customers = context.Customers.FromSqlRaw<cust>("select * from Customers").ToList();
                ////var customers = context.Customers.ToList();

                foreach (var x in customers)
                {
                    Console.WriteLine($"The customer is {x.FirstName} {x.LastName}");
                }

                // cust c3 = new cust();
                // c3.FirstName = "Thaee";
                // c3.LastName = "Thworf";

                // context.Add(c3);
                // context.SaveChanges();

                // var custs = context.Customers.FromSqlRaw<cust>("select * from Customers").ToList();
                // //var customers = context.Customers.ToList();

                // foreach (var x in custs)
                // {
                //   Console.WriteLine($"The customer is {x.FirstName} {x.LastName}");
                // }
                #endregion


            }

     }
  }
}
