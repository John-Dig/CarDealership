using System.Collections.Generic;

namespace CarDealership.Models
{
  public class Car
  {
    public string Color { get; set; }
    public float Price { get; set; }

    public Car(string color)
    {
      Color = color;
    }
  }
}
