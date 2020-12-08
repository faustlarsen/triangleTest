namespace Objects
{
  public class Triangle
  {
    public bool isItTriangle(int side1, int side2, int side3)
    {
      if (side1 == side2 && side2 == side3)
      {
        return true;
      } else
        {
          return false;
        }
    }
  }
}
