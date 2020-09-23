using System.Collections.Generic;
using System;

namespace Prime.Models
{
  public class PrimeNumbers
  {
    public static List<int> numberList = new List<int> {};  

    public static void MakeList(int inputNum)
    {
      for (int i=2; i<=inputNum; i++)
      {
        numberList.Add(i);
      }
    }

    public static void MakePrime(List<int> numberList)
    {      
      for (int prime = 2; prime<numberList.Count; prime++)
      {         
        for (int i=1; i<numberList.Count; i++)  
        {          
          if (numberList[i] % prime == 0 && numberList[i] != prime)
          {
            numberList.Remove(numberList[i]);
          }
        }
      }
    }
  }
}