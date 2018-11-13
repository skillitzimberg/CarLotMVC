using System;

namespace Dealership {

  class Car
  {
    private string MakeModel;
    private int Miles;
    private int Price;
    private string Description;

    public Car(string makeModel, int miles, int price, string description )
    {
      MakeModel = makeModel;
      Miles = miles;
      Price = price;
      Description = description;

    }

    public string GetMakeModel()
    {
      return MakeModel;
    }

    public int GetMiles()
    {
      return Miles;
    }

    public int GetPrice()
    {
      return Price;
    }

    public string GetDescription()
    {
        return Description;
    }

    public void SetPrice(int newPrice)
    {
      Price = newPrice;
    }

    public bool WithinBudget(int maxPrice)
    {
      return (Price <= maxPrice);
    }

    public bool FewEnoughMiles(int maxMiles)
    {
        return (Miles <= maxMiles);
    }
  }

}
