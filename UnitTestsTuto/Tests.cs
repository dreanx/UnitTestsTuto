using NUnit.Framework;

namespace UnitTestsTuto.Add
{
    [TestFixture]
    public class Add
    {
        [Test]
        public void Add_TwoNumbers_ReturnsSum()
        {
            // Arrange
            Calculator addition = new Calculator();
            int a = 2;
            int b = 3;
            int expected = 5;

            // Act
            int result = addition.Add(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}

namespace UnitTestsTuto.Sub
{
    [TestFixture]
    public class Sub
    {
        [Test]
        public void Sub_TwoNumbers_ReturnsSum()
        {
            // Arrange
            Calculator addition = new Calculator();
            int a = 5;
            int b = 5;
            int expected = 0;

            // Act
            int result = addition.Sub(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}