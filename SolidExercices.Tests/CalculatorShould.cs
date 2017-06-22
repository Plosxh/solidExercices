using NFluent;
using NUnit.Framework;

namespace SolidExercices.Tests
{
    public class CalculatorShould
    {
        [Test]
        public void CalculateASum()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("1+2,3");
            Check.That(result).IsEqualTo(3.3);
        }
        [Test]
        public void CalculateASub()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("2-1");
            Check.That(result).IsEqualTo(1.0);
        }
        [Test]
        public void CalculateADiv()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("1/2");
            Check.That(result).IsEqualTo(0.5);
        }
        [Test]
        public void CalculateAMult()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("1*2");
            Check.That(result).IsEqualTo(2.0);
        }
    }
}
