namespace Task_15._1___Series
{
    public class GeomProgression : ISeries
    {
        private int _ratioValue;
        
        public int CurrentValue { get; private set; }
        public int StartValue { get; private set; }

        public int Ratio
        {
            get => _ratioValue == default ? 2 : _ratioValue;
            private set => _ratioValue = value;
        }
        
        public void SetStart(int x)
        {
            StartValue = x;
            CurrentValue = x;
        }

        public int GetNext()
        {
            CurrentValue *= _ratioValue;
            return CurrentValue;
        }

        public void Reset()
        {
            CurrentValue = StartValue;
        }

        public void SetRatio(int ratio)
        {
            _ratioValue = ratio;
        }
    }
}