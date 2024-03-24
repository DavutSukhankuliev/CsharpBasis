namespace Task_13._1___Building
{
    public sealed class MultiBuilding : Building
    {
        public int Floors { get; set; }

        public MultiBuilding(string address, double length, double width, double height, int floors) : base(address, length, width, height)
        {
            Floors = floors;
        }

        public new string Print()
        {
            string result = base.Print();
            result += $"\n\rЭтажей: {Floors}";
            return result;
        }
    }
}