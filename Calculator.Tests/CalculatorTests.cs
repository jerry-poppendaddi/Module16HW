using NUnit.Framework;
using Calculator;

namespace Calculator.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AdditionCorrect()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Addition(200, 10) == 210);
        }

        [Test]
        public void SubtractionCorrect()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Subtraction(200, 10) == 200);
        }

        [Test]
        public void MultiplicationCorrect()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Multiplication(200, 10) == 2000);
        }

        [Test]
        public void DivisionCorrect()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Division(200, 10) == 20);
            Assert.Throws<DivideByZeroException>(() => calculator.Division(30, 0));
        }
    }
}
