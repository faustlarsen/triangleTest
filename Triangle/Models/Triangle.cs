using System;

namespace Triangle.Models
{
  public class Triangle
  {
    public void EvaluateTriangle(int side1, int side2, int side3)
    {
      if (side1 == side2 && side2 == side3)
      {
        Console.WriteLine("Equalateral");
      }
    }
  }
}

EvaluateTriangle is an instance method, which means you need to call it on an instance of the Triangle class.

You need 