using FormAssignment;
using System.Drawing;

namespace FormAssignmentTests
{
    [TestClass]
    public class CircleTests
    {
        // Tests the CheckParam method with valid parameters
        [TestMethod]
        public void Test_the_CheckParamWithValidParams()
        {
            // Arrange
            Bitmap bitmap = new Bitmap(100, 100);
            Canvas canvas = new Canvas(bitmap);
            List<string> param = new List<string> { "40" };
            Circle circle = new Circle(canvas, param);

            // Act
            circle.CheckParam();

            // Assert
            Assert.AreEqual(40, circle.Radius);
        }

        // Tests the CheckParam method with invalid type of parameters
        [TestMethod]
        public void Test_the_CheckParamWithInvalidTypeOfParams()
        {
            // Arrange
            Bitmap bitmap = new Bitmap(100, 100);
            Canvas canvas = new Canvas(bitmap);
            List<string> param = new List<string> { "wrong" };
            Circle circle = new Circle(canvas, param);

            // Act
            circle.CheckParam();

            // Assert
            Assert.AreEqual(0, circle.Radius);
        }
    }
}
