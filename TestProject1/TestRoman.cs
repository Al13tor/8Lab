using NUnit.Framework;
using ClassLibrary1;
using System;

namespace TestProject1
{
    public class TestRoman
    {
        // Простое число
        [Test]
        public void ToRoman_SimpleNumber_ReturnsCorrectSymbol()
        {
            Assert.That(MathUtils.ToRoman(8), Is.EqualTo("VIII")); // 5 + 1 + 1 + 1
        }

        // Сложное число с вычитанием (Позитивный)
        [Test]
        public void ToRoman_SubtractiveNotation_ReturnsCorrectSymbol()
        {
            Assert.That(MathUtils.ToRoman(1994), Is.EqualTo("MCMXCIV"));
        }

        // Максимальное возможное число
        [Test]
        public void ToRoman_MaxNumber3999_ReturnsCorrectSymbol()
        {
            Assert.That(MathUtils.ToRoman(3999), Is.EqualTo("MMMCMXCIX"));
        }

        // Проверка всех вычитающих комбинаций
        [TestCase(4, "IV")]
        [TestCase(9, "IX")]
        [TestCase(40, "XL")]
        [TestCase(90, "XC")]
        [TestCase(400, "CD")]
        [TestCase(900, "CM")]
        public void ToRoman_SubtractiveValues_ReturnsExpected(int input, string expected)
        {
            Assert.That(MathUtils.ToRoman(input), Is.EqualTo(expected));
        }

        // Ноль или отрицательное
        [TestCase(0)]
        [TestCase(-5)]
        public void ToRoman_LessThanOne_ThrowsArgumentOutOfRangeException(int input)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => MathUtils.ToRoman(input));
        }

        // Число больше 3999
        [Test]
        public void ToRoman_GreaterThan3999_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => MathUtils.ToRoman(4000));
        }
    }
}