using NUnit.Framework;
using SolutionDiagram.A.Extensions;

namespace SolutionDiagram.UnitTest
{
    public class A_Doc
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FormatCpf()
        {
            //Arrange
            string actual, value = "06708372029", expected = "067.083.720-29";

            //Act
            actual = value.FormatCpfCnpj();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FormatCnpj()
        {
            //Arrange
            string actual, value = "24159139000140", expected = "24.159.139/0001-40";

            //Act
            actual = value.FormatCpfCnpj();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}