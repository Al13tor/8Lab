using System;
using System.Text;
namespace ClassLibrary1
{
    public static class MathUtils
    {
         public static int[] Sort(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array), "Массив не может быть null");
            }

            int[] result = (int[])array.Clone();

            for (int i = 0; i < result.Length - 1; i++)
            {
                for (int j = 0; j < result.Length - 1 - i; j++)
                {
                    if (result[j] > result[j + 1])
                    {
                        int temp = result[j];
                        result[j] = result[j + 1];
                        result[j + 1] = temp;
                    }
                }
            }
            return result;
        }

        public static bool IsPalindrome(string text)
        {
            if (text == null)
            {
                throw new ArgumentNullException(nameof(text), "Строка не может быть null");
            }

            int left = 0;
            int right = text.Length - 1;

            while (left < right)
            {
                if (text[left] != text[right])
                {
                    return false;
                }

                left++;
                right--;
            }
            return true;
        }

        public static long Factorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(n), "Факториал отрицательного числа не определен");
            }

            if (n == 0 || n == 1)
            {
                return 1;
            }

            long result = 1;

            for (int i = 2; i <= n; i++)
            {
                checked
                {
                    result *= i;
                }
            }
            return result;
        }

        public static long Fibonacci(int position)
        {
            if (position < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(position), "Позиция не может быть отрицательной");
            }

            if (position == 0) return 0;
            if (position == 1) return 1;

            long a = 0;
            long b = 1;
            long result = 0;

            for (int i = 2; i <= position; i++)
            {
                checked
                {
                    result = a + b;
                    a = b;
                    b = result;
                }
            }
            return result;
        }
        public static int FindSubstring(string text, string pattern)
        {
            if (text == null) throw new ArgumentNullException(nameof(text));
            if (pattern == null) throw new ArgumentNullException(nameof(pattern));

            if (pattern.Length == 0) return 0;

            for (int i = 0; i <= text.Length - pattern.Length; i++)
            {
                bool isMatch = true;

                for (int j = 0; j < pattern.Length; j++)
                {
                    if (text[i + j] != pattern[j])
                    {
                        isMatch = false;
                        break;
                    }
                }
                if (isMatch)
                {
                    return i;
                }
            }
            return -1;
        }

        public static bool IsPrime(int n)
        {
            if (n <= 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            int boundary = (int)Math.Sqrt(n);

            for (int i = 3; i <= boundary; i += 2)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static int ReverseInt(int x)
        {
            long result = 0;

            while (x != 0)
            {
                int digit = x % 10;

                x = x / 10;

                result = result * 10 + digit;

                if (result > int.MaxValue || result < int.MinValue)
                {
                    return 0;
                }
            }
            return (int)result;
        }

        public static string ToRoman(int x)
        {
            if (x <= 0 || x > 3999)
            {
                throw new ArgumentOutOfRangeException(nameof(x), "Число должно быть в диапазоне от 1 до 3999");
            }

            int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] symbols = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < values.Length; i++)
            {
                while (x >= values[i])
                {
                    result.Append(symbols[i]);
                    x -= values[i];
                }
            }

            return result.ToString();
        }
    }
}