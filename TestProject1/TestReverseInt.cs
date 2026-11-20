using NUnit.Framework;
using ClassLibrary1;

namespace TestProject1
{
    public class TestReverseInt
    {
        // Обычное число
        [Test]
        public void ReverseInt_PositiveNumber_ReturnsReversed()
        {
            Assert.That(MathUtils.ReverseInt(123), Is.EqualTo(321));
        }

        // Отрицательное число с нулем на конце
        [Test]
        public void ReverseInt_NegativeWithZero_ReturnsReversed()
        {
            Assert.That(MathUtils.ReverseInt(-120), Is.EqualTo(-21));
        }

        // Ноль
        [Test]
        public void ReverseInt_Zero_ReturnsZero()
        {
            Assert.That(MathUtils.ReverseInt(0), Is.EqualTo(0));
        }

        // Переполнение положительного числа
        [Test]
        public void ReverseInt_PositiveOverflow_ReturnsZero()
        {
            Assert.That(MathUtils.ReverseInt(1534236469), Is.EqualTo(0));
        }

        // Тест 5: Переполнение отрицательного числа
        [Test]
        public void ReverseInt_NegativeOverflow_ReturnsZero()
        {
            Assert.That(MathUtils.ReverseInt(-1534236469), Is.EqualTo(0));
        }


        // Тест 7: Однозначное число
        [Test]
        public void ReverseInt_SingleDigit_ReturnsSameNumber()
        {
            Assert.That(MathUtils.ReverseInt(7), Is.EqualTo(7));
        }
    }
}