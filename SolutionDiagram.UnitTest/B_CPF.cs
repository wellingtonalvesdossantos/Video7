using NUnit.Framework;
using SolutionDiagram.B;
using SolutionDiagram.B.Interfaces;

namespace SolutionDiagram.UnitTest
{
    public class B_CPF
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Format()
        {
            //Arrange
            IFormattable value = new CPF("06708372029");
            string actual, expected = "067.083.720-29";

            //Act
            actual = value.Format();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}