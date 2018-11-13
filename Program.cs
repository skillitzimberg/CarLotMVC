using System;
using System.Collections.Generic;

namespace Dealership {

  public class Program
  {
    public static void Main()
    {
      Car porsche = new Car("2004 Porsche 911", 12000, 114991, "This car is a thing with wheels." );
      Car ford = new Car("2011 Ford F450", 14241, 55995, "Red");
      Car lexus = new Car("2013 Lexus RX 350", 20000, 44700, "Too cherry to drive");
      Car mercedes = new Car("Mercedes Benz CLS550", 37979, 39900, "German . . .");

      List<Car> Cars = new List<Car>() { porsche, ford, lexus, mercedes };

      lexus.SetPrice(30000);

      Console.WriteLine("Enter your maximum price: ");
      string stringMaxPrice = Console.ReadLine();
      int maxPrice = int.Parse(stringMaxPrice);

      Console.WriteLine("What's the maximum mileage you're considering: ");
      string stringMaxMiles = Console.ReadLine();
      int maxMiles = int.Parse(stringMaxMiles);

      List<Car> CarsMatchingSearch = new List<Car>(0);

      foreach (Car automobile in Cars)
      {
        if (automobile.WithinBudget(maxPrice) && automobile.FewEnoughMiles(maxMiles))
        {
          CarsMatchingSearch.Add(automobile);
        }
      }

      if (CarsMatchingSearch.Count > 0)
      {
          foreach(Car automobile in CarsMatchingSearch)
          {
            Console.WriteLine("------------------------");
            Console.WriteLine(automobile.GetMakeModel());
            Console.WriteLine(automobile.GetMiles() + " miles");
            Console.WriteLine("$" + automobile.GetPrice());
            Console.WriteLine(automobile.GetDescription());
          }
        }
        else
        {
            Console.WriteLine("Nothing matches criteria.");
        }
    }
  }
}
