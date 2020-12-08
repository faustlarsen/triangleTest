using Microsoft.VisualStudio.TestTools.UnitTesting;
using Objects;

namespace Objects.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void isItTriangle_Equilateral_True()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(true, testTriangle.isItTriangle(1, 0, 1));
    }
  }
}