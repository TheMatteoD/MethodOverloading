using System;

namespace MethodOverloading
{
    internal class Program
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static float Add(float a, float b)
        {
            return a + b;
        }
        public static string Add(int a, int b, bool isDollar)
        {
            if (isDollar)
            {
                if (a + b > 1 || a + b < -1)
                {
                    return $"{a + b} dollars";
                }
                else
                {
                    return $"{a + b} dollar";
                }
            }
            else
            {
                return $"{a + b}";
            }
        }
        static void Main(string[] args)
        {
            Add(1, 0, true);
        }
    }
}
