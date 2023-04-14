using FormAssignment;
using System.Drawing;
using System.Windows.Forms;

namespace FormAssignmentTests
{
    [TestClass]
    public class VariableTests
    {
        // Tests that the parameters are set correctly
        [TestMethod]
        public void Variable_Parameters_SetCorrectly()
        {
            // Arrange
            List<string> param = new List<string> { "x", "=", "5" };

            // Act
            Variable variable = new Variable(param);

            // Assert
            Assert.AreEqual("x", variable.VarName);
            Assert.AreEqual(5, variable.VarValue);
        }

        // Tests that the variable has the right format 
        [TestMethod]
        public void CheckVarDeclaration_ForValidVariableDeclaration()
        {
            //Arrange
            List<string> param = new List<string> { "x", "=", "10" };

            // Act
            Variable var1 = new Variable(param);

            // Assert
            Assert.AreEqual(var1.VarName, "x");
            Assert.AreEqual(var1.VarValue, 10);
        }

        // Tests that the variable has the wrong format
        [TestMethod]
        public void CheckVarDeclaration_ForIncorrectFormat()
        {
            // Arrange
            List<string> param = new List<string> { "x", "+=", "2" };

            // Act
            Variable var2 = new Variable(param);

            // Assert
            Assert.AreEqual(var2.VarName, null);
            Assert.AreEqual(var2.VarValue, 0);
        }
    }
}
