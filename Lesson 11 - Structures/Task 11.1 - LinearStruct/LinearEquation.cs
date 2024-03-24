using System;

namespace Task_11._1___LinearStruct
{
    public struct LinearEquation
    {
        public double K { get; }
        public double B { get; }

        public LinearEquation(double k, double b)
        {
            K = k;
            B = b;
        }

        public double Root()
        {
            if (K == 0 && B == 0)
            {
                Console.WriteLine("любой корень");
                return int.MaxValue;
            }
            else if (K == 0 && B != 0)
            {
                Console.WriteLine("Нет корней");
                return default;
            }
            else
            {
                return (0 - B) / K;
            }
        }
    }
}