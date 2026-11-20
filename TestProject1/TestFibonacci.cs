using NUnit.Framework;
using ClassLibrary1;
using System;

namespace TestProject1
{
    public class TestFibonacci
    {
        // Тест 1: Обычное число
        [Test]
        public void Fibonacci_Position10_Returns55()
        {
            Assert.That(MathUtils.Fibonacci(10), Is.EqualTo(55));
        }

        // Тест 2: Нулевая позиция
        [Test]
        public void Fibonacci_Position0_Returns0()
        {
            Assert.That(MathUtils.Fibonacci(0), Is.EqualTo(0));
        }

        // Тест 3: Первая позиция
        [Test]
        public void Fibonacci_Position1_Returns1()
        {
            Assert.That(MathUtils.Fibonacci(1), Is.EqualTo(1));
        }

        // Тест 4: Отрицательная позиция
        [Test]
        public void Fibonacci_NegativePosition_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => MathUtils.Fibonacci(-1));
        }

        // Тест 5: Переполнение типа long
        [Test]
        public void Fibonacci_Overflow_ThrowsOverflowException()
        {
            // 93-е число Фибоначчи уже не влезает в тип long
            Assert.Throws<OverflowException>(() => MathUtils.Fibonacci(93));
        }
    }
}