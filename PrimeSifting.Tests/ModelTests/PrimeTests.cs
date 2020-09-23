using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prime.Models;
using System.Collections.Generic;

namespace PrimeSifting.Tests
{
  [TestClass]
  public class PrimeNumbersTests
  {
    [TestMethod]
    public void MakeList_CreatesAList_List()
    {
      //Arrange
      List<int> testList1 = new List<int> {};
      for (int i=2; i<=10; i++)
      {
        testList1.Add(i);
      }
      //Act      
      PrimeNumbers.MakeList(10);
      //Assert
      CollectionAssert.AreEqual(testList1, PrimeNumbers.numberList);
    }
  }
}