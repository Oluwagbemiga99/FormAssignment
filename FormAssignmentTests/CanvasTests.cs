using FormAssignment;
using System.Drawing;

namespace FormAssignmentTests
{
    [TestClass]
    public class CanvasTests
    {
        // This tests the setter and gettter methods in the canvas class
        [TestMethod]
        public void Testing_the_SettersAndGetters()
        {
            // Creates an instance of the canvas class
            Bitmap bitmap = new Bitmap(100, 100);
            Canvas canvas = new Canvas(bitmap);

            canvas.Filled = true;
            canvas.XPos = 50;
            canvas.YPos = 60;
            canvas.MyColour = Color.Red;

            // Assert
            Assert.AreEqual(true, canvas.Filled);
            Assert.AreEqual(50, canvas.XPos);
            Assert.AreEqual(60, canvas.YPos);
            Assert.AreEqual(Color.Red, canvas.MyColour);
        }
    }
}
