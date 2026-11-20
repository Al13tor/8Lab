using NUnit.Framework;
using ClassLibrary1;
using System;

namespace TestProject1
{
    public class TestStrok
    {
        // Тест 1: Подстрока есть
        [Test]
        public void Found()
        {
            Assert.That(MathUtils.FindSubstring("привет мир", "мир"), Is.EqualTo(7));
        }

        // Тест 2: Подстрока не найдена
        [Test]
        public void NotFound()
        {
            Assert.That(MathUtils.FindSubstring("привет", "пока"), Is.EqualTo(-1));
        }

        // Тест 3: Пустая подстрока
        [Test]
        public void EmptyPattern()
        {
            Assert.That(MathUtils.FindSubstring("привет", ""), Is.EqualTo(0));
        }

        // Тест 4: Пустая строка
        [Test]
        public void FindSubstring_EmptyText_ReturnsMinusOne()
        {
            Assert.That(MathUtils.FindSubstring("", "a"), Is.EqualTo(-1));
        }

        // Тест 5: Подстрока длиннее исходной строки
        [Test]
        public void PatternLongerThanText()
        {
            Assert.That(MathUtils.FindSubstring("abc", "abcdef"), Is.EqualTo(-1));
        }

        // Тест 6: Передача null вместо строки
        [Test]
        public void NullText()
        {
            Assert.Throws<ArgumentNullException>(() => MathUtils.FindSubstring(null, "abc"));
        }

        // Тест 7: Передача null вместо подстроки (Негативный)
        [Test]
        public void NullPattern()
        {
            Assert.Throws<ArgumentNullException>(() => MathUtils.FindSubstring("abc", null));
        }
    }
}