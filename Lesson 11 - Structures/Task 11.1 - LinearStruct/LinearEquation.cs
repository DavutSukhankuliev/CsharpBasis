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
            return (0 - B) / K;
        }
    }
}