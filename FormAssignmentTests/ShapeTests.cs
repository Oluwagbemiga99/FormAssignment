using FormAssignment;
using System.Drawing;

namespace FormAssignmentTests
{
    [TestClass]
    public class ShapeTests
    {
        // This is used as a test implementation of the shape class
        protected class TestShape : Shape
        {
            public override void CheckParam()
            {
                throw new NotImplementedException();
            }

            public override void Draw()
            {
                throw new NotImplementedException();
            }
        }

        // This tests the Param setter and gettter in the shape class 
        [TestMethod]
        public void Test_the_ParamSetterAndGetter()
        {
            // Arrange
            var shape = new TestShape();
            var expectedParam = new List<string> { "test" };

            // Act
            shape.Param = expectedParam;
            var actualParam = shape.Param;

            // Assert
            CollectionAssert.AreEqual(expectedParam, actualParam);
        }

        // This tests the PaintCanvas setter and gettter in the shape class
        [TestMethod]
        public void Test_the_PaintCanvasSetterAndGetter()
        {
            // Arrange
            var shape = new TestShape();
            var expectedCanvas = new Canvas(new Bitmap(100, 100));

            // Act
            shape.PaintCanvas = expectedCanvas;
            var actualCanvas = shape.PaintCanvas;

            // Assert
            Assert.AreEqual(expectedCanvas, actualCanvas);
        }
    }
}