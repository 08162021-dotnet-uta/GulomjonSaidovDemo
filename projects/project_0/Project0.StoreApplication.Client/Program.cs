using System;
using System.Collections.Generic;
using Project0.StoreApplication.Client.Singletons;
using Project0.StoreApplication.Domain.Abstracts;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage;
using Serilog;

namespace Project0.StoreApplication.Client
{
  /// <summary>
  /// Defines the Program Class
  /// </summary>
  internal class Program
  {
    private static readonly CustomerSingleton _customerSingleton = CustomerSingleton.Instance;
    private static readonly StoreSingleton _storeSingleton = StoreSingleton.Instance;
    private static readonly ProductSingleton _productSingleton = ProductSingleton.Instance;
    private static readonly OrderSingleton _orderSingleton = OrderSingleton.Instance;
    private const string _logFilePath = @"C:\Users\gulom\source\repos\08162021-dotnet-uta\GulomjonSaidovRepo1\data\logs.txt";

    /// <summary>
    /// Defines the Main method of Program Class
    /// </summary>
    /// <param name="args"></param>
    private static void Main(string[] args)
    {

            //Run();
            HelloSql();
    }

    /// <summary>
    /// Defines Run function
    /// </summary>
    private static void Run()
    {
      Log.Logger = new LoggerConfiguration().WriteTo.File(_logFilePath).CreateLogger();
      Log.Information("Logging Started!");
      // var customer = _customerSingleton.Customers[Capture<Customer>(_customerSingleton.Customers)];

      bool unsuccessful;
      int num1;
      do
      {
        Console.WriteLine("Welcome to Target! Are you store manageror a customer?");
        Console.WriteLine("Press 1 for customer, 2 for Store Manager.");
        string input = Console.ReadLine();
        unsuccessful = int.TryParse(input, out num1);
      } while (!unsuccessful || num1 < 1 || num1 > 2);

      if (num1 == 1)
      {
        var store = _storeSingleton.Stores[Capture<Store>(_storeSingleton.Stores)];

        Console.WriteLine("You selected {0}", store);

        var product = _productSingleton.Products[Capture<Product>(_productSingleton.Products)];
        Console.WriteLine("You have selected {0}.\n1 - Confirm to purchase\n2 - Decline to purchase", product);
        var input = int.Parse(Console.ReadLine());
        if (input == 1)
        {
          Console.WriteLine("Please enter your name:");
          var name = Console.ReadLine();
          var customer = new Customer() { Name = name };
          _orderSingleton.Append(new Order()
          {
            OrderDate = DateTime.Now.ToLocalTime(),
            Product = product,
            Customer = customer,
            Store = store
          });

          OutputPastPurchase(name);
        }
        else
        {
          Run();
        }

      }
      else
      {
        Console.WriteLine("Option:\nPress 1 - view past purchases\nPress 2 - add a Product");
        var input = Console.ReadLine();
        if (input == "1")
        {
          Output<Order>(_orderSingleton.Orders);
        }
        else if (input == "2")
        {
          Console.WriteLine("Enter product name:");
          var name = Console.ReadLine();
          Console.WriteLine("Enter product price:");
          var price = Decimal.Parse(Console.ReadLine());

          _productSingleton.Append(new Product() { Name = name, Price = price });
          Console.WriteLine("Successfully added");
        }
        else
        {
          Console.WriteLine("Option:\nPress 1 - view past purchases\nPress 2 - add a Product");
        }
      }


    }

    /// <summary>
    /// Prints all the stores
    /// </summary>
    private static void Output<T>(List<T> data) where T : class
    {
      Log.Information($"Method: Output<{typeof(T)}>");
      var index = 0;

      foreach (var item in data)
      {

        Console.WriteLine($"[{++index}] - {item}");
      }
    }

    private static void OutputPastPurchase(string name)
    {
      // var orders = new List<Order>();
      foreach (var order in _orderSingleton.Orders)
      {
        if (order.Customer.Name == name)
        {
          Console.WriteLine(order);
        }
      }
    }

    /// <summary>
    /// Captures user input
    /// </summary>
    /// <returns></returns>
    private static int Capture<T>(List<T> data) where T : class
    {
      Log.Information("method: Capture()");

      Output<T>(data);

      Console.WriteLine("Please choose your option: ");

      int selected = int.Parse(Console.ReadLine());

      Log.Information("Input captured \"CaptureInput()\": {selected}", selected);

      return selected - 1;
    }

        private static void HelloSql()
        {
            Log.Logger = new LoggerConfiguration().WriteTo.File(_logFilePath).CreateLogger();
            Log.Information("Logging Started!");
            var def = new DemoEF();

            //def.setcustomer(new Customer());

            foreach (var item in def.GetCustomers())
            {
                Console.WriteLine(item);
            }

        }
    }
}
