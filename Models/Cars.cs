using System.Collections.Generic;

namespace Dealership.Models
{

  public class Car
  {
    private string _makeModel;
    private int _miles;
    private int _price;
    private string _description;
    private static List<Car> _inventory = new List<Car> {};

    public Car(string makeModel, int miles, int price, string description)
    {
      _makeModel = makeModel;
      _miles = miles;
      _price = price;
      _description = description;
      _inventory.Add(this);

    }

    public string GetMakeModel()
    {
      return _makeModel;
    }

    public int GetMiles()
    {
      return _miles;
    }

    public int GetPrice()
    {
      return _price;
    }

    public string GetDescription()
    {
        return _description;
    }

    public static List<Car> GetAllCars()
    {
      return _inventory;
    }

    public void SetPrice(int newPrice)
    {
      _price = newPrice;
    }

    public bool WithinBudget(int maxPrice)
    {
      return (_price <= maxPrice);
    }

    public bool FewEnoughMiles(int maxMiles)
    {
        return (_miles <= maxMiles);
    }
  }

}
