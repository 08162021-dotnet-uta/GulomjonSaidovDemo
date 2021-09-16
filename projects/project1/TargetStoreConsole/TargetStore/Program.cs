
//using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
//using TargetStoreDbContext.Models;


namespace TargetStore
{
  class Program
  {
    static void Main(string[] args)
    {
            //ViewModelCustomer c1 = new ViewModelCustomer("mike", "tyson");

            //Console.WriteLine($"{c1.Fname} {c1.Lname}");

            // setup code
            #region
            //List<cust> customer = context.Customers.FromSqlRaw<cust>("select * from Customers").ToList();


            //foreach (var x in customer)
            //{
            //    Console.WriteLine($"The customer name is {x.FirstName} {x.LastName}");
            //}

            //cust c2 = new cust();
            //c2.FirstName = "agile";
            //c2.LastName = "scrum";

            //context.Add(c2);
            //context.SaveChanges();

            //List<cust> customer1 = context.Customers.FromSqlRaw<cust>("select * from Customers").ToList();

            //foreach (var x in customer1)
            //{
            //    Console.WriteLine($"The customer name is {x.FirstName} {x.LastName}");
            //}
            #endregion
            Console.WriteLine("Welcome. Would you like to log in or are you a new customer?");
            Console.WriteLine("Select an option\n\t1 - Log in\n\t2 - Register");
     }
  }
}
