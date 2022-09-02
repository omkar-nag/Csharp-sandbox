using System;

namespace AreaCalculatorLibrary
{
    public class AreaCalculator
    {
        private const float pi = 3.14F;
        public static float Area(byte s)
        {
            return s * s;
        }

        public static float Area(byte l, byte h)
        {
            return l * h;
        }
        public static float Area(float r)
        {
            return pi * r * r;
        }

    }
}
