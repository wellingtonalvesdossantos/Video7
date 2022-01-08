using NUnit.Framework;
using SolutionDiagram.B;
using SolutionDiagram.B.Interfaces;

namespace SolutionDiagram.UnitTest
{
    public class B_CNPJ
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Format()
        {
            //Arrange
            IFormattable value = new CNPJ("24159139000140");
            string actual, expected = "24.159.139/0001-40";

            //Act
            actual = value.Format();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}