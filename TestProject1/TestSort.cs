using NUnit.Framework;
using ClassLibrary1;
using System;

namespace TestProject1
{
    public class TestSort
    {
        [Test]
        public void Sort_Normal()
        {
            int[] input = { 5, 2, 9, 1, 5 };
            int[] expected = { 1, 2, 5, 5, 9 };
            int[] result = MathUtils.Sort(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Sort_Empty()
        {
            int[] input = new int[0];
            int[] result = MathUtils.Sort(input);
            Assert.That(result, Is.Empty);
        }

        [Test]
        public void Sort_Single()
        {
            int[] input = { 42 };
            int[] result = MathUtils.Sort(input);
            Assert.That(result, Is.EqualTo(new[] { 42 }));
        }

        [Test]
        public void Sort_Null()
        {
            Assert.Throws<ArgumentNullException>(() => MathUtils.Sort(null));
        }

        [Test]
        public void Sort_Already()
        {
            int[] input = { -10, -5, 0, 3, 8 };
            int[] result = MathUtils.Sort(input);
            Assert.That(result, Is.EqualTo(input));
        }
    }
}