using System;

namespace Triangle.Models

{
  public class Program
  {

    static void Main()
    {
      Console.WriteLine("Please eneter three numbers, one for each side of a triangle;");
      Console.WriteLine("The length you want for a first triangle side:");
      string sideOne = Console.ReadLine();
      Console.WriteLine("The length you want for a second triangle side:");
      string sideTwo = Console.ReadLine();
      Console.WriteLine("The length you want for a third triangle side:");
      string sideThree = Console.ReadLine();
      Console.WriteLine("side one: " + sideOne + " side two: " + sideTwo + " side three: " + sideThree);
      int side1 = int.Parse(sideOne);
      int side2 = int.Parse(sideTwo);
      int side3 = int.Parse(sideThree);



      Console.WriteLine(side1+side2+side3);
    }
  }
}