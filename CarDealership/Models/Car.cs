using System.Collections.Generic;

namespace CarDealership.Models
{
  public class Car
  {
    public string Color { get; set; }
    public float Price { get; set; }

    private static List<Car> _instances = new List<Car> { };

    public Car(string color)
    {
      Color = color;
      _instances.Add(this);
    }
  }
}
