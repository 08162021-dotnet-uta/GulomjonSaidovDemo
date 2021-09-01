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
    private const string _logFilePath = @"/home/gulom/revature/gulomjon_repo/data/logs.txt";

    /// <summary>
    /// Defines the Main method of Program Class
    /// </summary>
    /// <param name="args"></param>
    private static void Main(string[] args)
    {

      Run();
    }

    /// <summary>
    /// Defines Run function
    /// </summary>
    private static void Run()
    {
      Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
      Log.Information("Logging Started!");

      if (_customerSingleton.Customers.Count == 0)
      {
        _customerSingleton.Add(new Customer());
      }

      var customer = _customerSingleton.Customers[Capture<Customer>(_customerSingleton.Customers)];
      var store = _storeSingleton.Stores[Capture<Store>(_storeSingleton.Stores)];
      var order = _orderSingleton.Orders[Capture<Order>(_orderSingleton.Orders)];

      // Output<Store>(_storeSingleton.Stores);
      // customers
      // Output<Customer>(_customerSingleton.Customers);
      // // products
      // Output<Product>(_productSingleton.Products);

      Console.WriteLine(customer);
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

    private static void HelloSQL()
    {
      var def = new DemoEF();

      foreach (var item in def.GetCustomers())
      {
        Console.WriteLine(item);
      }

    }
  }
}
