using NUnit.Framework;
using ClassLibrary1;
using System;

namespace TestProject1
{
    public class TestFactorial
    {
        // Тест 1: Обычное число
        [Test]
        public void Factorial_Positive()
        {
            Assert.That(MathUtils.Factorial(5), Is.EqualTo(120));
        }

        // Тест 2: Ноль (0! = 1)
        [Test]
        public void Factorial_Zero()
        {
            Assert.That(MathUtils.Factorial(0), Is.EqualTo(1));
        }

        // Тест 3: Единица (1! = 1)
        [Test]
        public void Factorial_One()
        {
            Assert.That(MathUtils.Factorial(1), Is.EqualTo(1));
        }

        // Тест 4: Отрицательное число 
        [Test]
        public void Factorial_NegativeNumber()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => MathUtils.Factorial(-5));
        }

        // Тест 5: Переполнение (проверка, что checked работает)
        [Test]
        public void Factorial_Overflow()
        {
            // 21! не влезает в тип long (максимум long ~9.22 * 10^18)
            Assert.Throws<OverflowException>(() => MathUtils.Factorial(21));
        }
    }
}