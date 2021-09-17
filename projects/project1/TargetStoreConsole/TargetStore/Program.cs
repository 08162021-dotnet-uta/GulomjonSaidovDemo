
//using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using TargetStoreBusinessLayer;
using TargetStoreDbContext.Models;
//using TargetStoreDbContext.Models;


namespace TargetStore
{
  class Program
  {
    static void Main(string[] args)
    {
            //ViewModelCustomer c1 = new ViewModelCustomer();
            //c1.Fname = "mike";
            //c1.Lname = "tyson";

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


            using (StoreAppContext _context = new StoreAppContext())
            {

                List<Customer> listofcustomers = _context.Customers.ToList();
                foreach(Customer c in listofcustomers)
                {
                    Console.WriteLine($"{c.FirstName} {c.LastName}");
                }

                Console.WriteLine("Welcome. Would you like to log in or are you a new customer?");
                Console.WriteLine("Select an option\n\t1 - Log in\n\t2 - Register");

                //1. register a new user with username and password, fname, lname
                string userinput = Console.ReadLine();
                if (userinput == "1")
                {
                    ViewModelCustomer c = new ViewModelCustomer();

                    // give a login option
                    Console.WriteLine($"Nice! Please enter your first name");
                    c.Fname = Console.ReadLine();

                    Console.WriteLine("Please enter your last name"); 
                    c.Lname = Console.ReadLine();


                    CustomerRepository customerRepo = new CustomerRepository();
                    ViewModelCustomer vmc = customerRepo.LoginCustomer(c);

                    //Console.WriteLine(vmc.Lname); // this returning null ? why

                    if (vmc == null)
                    {
                        userinput = "2";
                    }
                    else
                    {
                        Console.WriteLine($"The returned customer is {vmc.Fname} {vmc.Lname}");

                    }

                }
                if (userinput == "2")
                {
                    ViewModelCustomer c = new ViewModelCustomer();
                    // give a register option
                    Console.WriteLine($"To register, please enter your first name");
                    c.Fname = Console.ReadLine();

                    Console.WriteLine("Please enter your last name");
                    c.Lname = Console.ReadLine();

                    CustomerRepository customerRepo = new CustomerRepository();
                    ViewModelCustomer vmc = customerRepo.RegisterCustomer(c);

                    if (vmc == null)
                    {
                        Console.WriteLine("there was a problem with the register");
                    }
                    else
                    {
                        Console.WriteLine($"The registered customer is {vmc.Fname} {vmc.Lname}");
                    }
                }

                //2. get the list of products
                // query the DB to get the products and list them to the console.
                Console.WriteLine("Do you want to see the list of products?\nPress 1.\n Press anything to quit.");

                //if (Console.ReadLine() != -1)
                //{

                //}


                CustomerRepository custrepo = new CustomerRepository();
                List<ViewModelProduct> vmp = custrepo.Products();

                foreach(ViewModelProduct p in vmp)
                {
                    Console.WriteLine($"This is a {p.ProductName} described as {p.ProductDescription} at {p.ProductPrice}");
                }

                // take this action to the business layer

                //3. choose products

                //4. complete an order
            }// end of using statement
     }// end of main
  }//End of class
}// End of namespace
