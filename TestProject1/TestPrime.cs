using NUnit.Framework;
using ClassLibrary1;

namespace TestProject1
{
    public class TestPrime
    {
        // Обычное число
        [Test]
        public void IsPrime_PrimeNumber17_ReturnsTrue()
        {
            Assert.That(MathUtils.IsPrime(17), Is.True);
        }

        // Составное число
        [Test]
        public void IsPrime_CompositeNumber15_ReturnsFalse()
        {
            Assert.That(MathUtils.IsPrime(15), Is.False);
        }

        // Граница (числа <= 1)
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(-5)]
        public void IsPrime_LessThanTwo_ReturnsFalse(int number)
        {
            Assert.That(MathUtils.IsPrime(number), Is.False);
        }

        // Двойка (Граничный случай)
        [Test]
        public void IsPrime_Two_ReturnsTrue()
        {
            Assert.That(MathUtils.IsPrime(2), Is.True);
        }

        // Четное число
        [Test]
        public void IsPrime_EvenNumberGreaterThanTwo_ReturnsFalse()
        {
            Assert.That(MathUtils.IsPrime(4), Is.False);
        }

        // Квадрат простого числа (проверка границы цикла Math.Sqrt)
        [Test]
        public void IsPrime_SquareOfPrime_ReturnsFalse()
        {
            // 9 = 3 * 3. Квадратный корень из 9 равен 3. 
            // Цикл должен включить 3 и вернуть false.
            Assert.That(MathUtils.IsPrime(9), Is.False);
        }
    }
}