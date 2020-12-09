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