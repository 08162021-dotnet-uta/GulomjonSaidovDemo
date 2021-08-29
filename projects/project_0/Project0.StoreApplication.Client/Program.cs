using System;
using Project0.StoreApplication.Storage.Repositories;
using Serilog;

namespace Project0.StoreApplication.Client
{
  public class Program
  {
    private const string _logFilePath = @"/home/gulom/revature/gulomjon_repo/data/logs.txt";

    static void Main(string[] args)
    {
      Log.Logger = new LoggerConfiguration().WriteTo.File(_logFilePath).CreateLogger();

      Log.Information("Logging Started!");

      var program = new Program();

      program.CaptureOutput();


    }

    private void OutputStores()
    {
      var storeRepository = new StoreRepository();

      foreach (var store in storeRepository.Stores)
      {

        Console.WriteLine(store.Name);
      }
    }

    private int CaptureInput()
    {
      OutputStores();

      Console.WriteLine("Please pick a store:");

      // capture customer input
      int selected = int.Parse(Console.ReadLine());

      Log.Information("Input captured \"CaptureInput()\": {selected}", selected);

      return selected;
    }

    private void CaptureOutput()
    {
      Log.Information("Method CaptureOutput()");

      var storeRepository = new StoreRepository();
      Console.WriteLine($"You have selected {storeRepository.Stores[CaptureInput()]}");
    }
  }
}
