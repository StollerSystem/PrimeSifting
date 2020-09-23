using System.Collections.Generic;

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

    // for (int prime=2; prime<=inputNum; prime++)
    //   {
    //     for (int i=prime+1; i<numberList.Count; i++)
    //     {
    //       if (numberList[i] % prime == 0)
    //     }
    //   }
    // properties, methods, etc. will go here.

  }
}