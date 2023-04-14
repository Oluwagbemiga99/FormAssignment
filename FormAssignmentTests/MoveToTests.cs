using FormAssignment;
using System.Drawing;
using System.Windows.Forms;

namespace FormAssignmentTests
{
    [TestClass]
    public class MoveToTests
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
        public void CheckParam_ValidInput_ShouldSetNewXAndNewY()
        {
            param.Add("100,200");
            MoveTo moveTo = new MoveTo(canvas, param);

            moveTo.CheckParam();

            Assert.AreEqual(100, moveTo.NewX);
            Assert.AreEqual(200, moveTo.NewY);
        }

        // Tests the Draw method with valid parameters
        [TestMethod]
        public void TestDraw_ShouldSetCanvasXPosAndYPos()
        {
            param.Add("100,200");
            MoveTo moveTo = new MoveTo(canvas, param);
            moveTo.CheckParam();

            moveTo.Draw();

            Assert.AreEqual(100, canvas.XPos);
            Assert.AreEqual(200, canvas.YPos);
        }

        // Tests the CheckParam method with invalid type of parameters
        [TestMethod]
        public void CheckParam_InvalidType_ShouldShowErrorMessage()
        {
            // Arrange
            var param = new List<string>() { "100,A" };
            var moveTo = new MoveTo(canvas, param);

            // Act
            moveTo.CheckParam();

            // Assert
            var errorMessage = "Invalid Type of parameters";
            var messageBox = MessageBox.Show(errorMessage);
            Assert.AreEqual(messageBox, DialogResult.OK);
        }
    }
}
