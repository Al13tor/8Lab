using NUnit.Framework;
using ClassLibrary1;
using System;

namespace TestProject1
{
    public class TestPalindrome
    {
        [Test]
        public void IsPalindrome_ValidPalindrome_ReturnsTrue()
        {
            Assert.That(MathUtils.IsPalindrome("шалаш"), Is.True);
        }

        [Test]
        public void IsPalindrome_NotAPalindrome_ReturnsFalse()
        {
            Assert.That(MathUtils.IsPalindrome("привет"), Is.False);
        }

        [Test]
        public void IsPalindrome_EmptyString_ReturnsTrue()
        {
            Assert.That(MathUtils.IsPalindrome(""), Is.True);
        }

        [Test]
        public void IsPalindrome_SingleCharacter_ReturnsTrue()
        {
            Assert.That(MathUtils.IsPalindrome("a"), Is.True);
        }

        [Test]
        public void IsPalindrome_NullString_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => MathUtils.IsPalindrome(null));
        }
    }
}