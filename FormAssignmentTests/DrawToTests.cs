using FormAssignment;
using System.Drawing;
using System.Windows.Forms;

namespace FormAssignmentTests
{
    [TestClass]
    public class DrawToTests
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

        // Tests the CheckParam method with valid parameters
        [TestMethod]
        public void TestCheckParam_ValidParams_ShouldSetNewXAndNewY()
        {
            // Arrange
            param.Add("100,200");
            DrawTo drawTo = new DrawTo(canvas, param);
            int expectedNewX = 100;
            int expectedNewY = 200;

            // Act
            drawTo.CheckParam();

            // Assert
            Assert.AreEqual(expectedNewX, drawTo.NewX);
            Assert.AreEqual(expectedNewY, drawTo.NewY);
        }

        // Tests the CheckParam method with invalid number of parameters
        [TestMethod]
        public void CheckParam_WithInvalidNumberOfParams_ShouldNotSetParams()
        {
            // Arrange
            param.Add("100");
            DrawTo drawTo = new DrawTo(canvas, param);

            // Act
            drawTo.CheckParam();

            // Assert
            int expectedNewX = 0;
            int expectedNewY = 0;
            Assert.AreEqual(expectedNewX, drawTo.NewX);
            Assert.AreEqual(expectedNewY, drawTo.NewY);
        }
    }
}
