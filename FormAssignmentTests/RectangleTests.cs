using FormAssignment;
using System.Drawing;
using System.Windows.Forms;

namespace FormAssignmentTests
{
    [TestClass]
    public class RectangleTests
    {
        private Canvas canvas;
        private List<string> param;

        [TestInitialize]
        public void Setup()
        {
            Bitmap bitmap = new Bitmap(100, 100);
            canvas = new Canvas(bitmap);
            param = new List<string>();
        }

        // This tests the constructor of the rectangle class
        [TestMethod]
        public void Constructor_ValidParameters_ShouldSetProperties()
        {
            // Arrange
            List<string> param = new List<string>() { "50,100" };

            // Act
            FormAssignment.Rectangle rectangle = new FormAssignment.Rectangle(canvas, param);

            // Assert
            Assert.AreEqual(canvas, rectangle.PaintCanvas);
            Assert.AreEqual(param, rectangle.Param);
            Assert.AreEqual(50, rectangle.Width);
            Assert.AreEqual(100, rectangle.Height);
        }

        // Tests the CheckParam method with valid parameters
        [TestMethod]
        public void CheckParam_ValidParameters_ShouldSetWidthAndHeight()
        {
            // Arrange
            param.Add("100,120");
            FormAssignment.Rectangle rectangle = new FormAssignment.Rectangle(canvas, param);

            // Act
            rectangle.CheckParam();

            // Assert
            Assert.AreEqual(100, rectangle.Width);
            Assert.AreEqual(120, rectangle.Height);
        }

        // Tests the CheckParam method with invalid type of parameters
        [TestMethod]
        public void Test_the_CheckParamWithInvalidTypeOfParams()
        {
            // Arrange
            List<string> param = new List<string> { "wrong" };
            FormAssignment.Rectangle rectangle = new FormAssignment.Rectangle(canvas, param);

            // Act
            rectangle.CheckParam();

            // Assert
            Assert.AreEqual(0, rectangle.Width);
            Assert.AreEqual(0, rectangle.Height);
        }
    }
}
