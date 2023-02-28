using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using CarDealership.Models;

namespace CarDealership.Tests
{
  [TestClass]
  // public class CarTests : IDisposable
  public class CarTests
  {

    // public void Dispose()
    // {
    //   CarLot.ClearAll();
    // }

    [TestMethod]
    public void CarConstructor_CreatesInstanceOfCar_Car()
    {
      //arrange
      Car newCar = new Car("test");
      //act //assert
      Assert.AreEqual(typeof(Car), newCar.GetType());
    }
  }
}
