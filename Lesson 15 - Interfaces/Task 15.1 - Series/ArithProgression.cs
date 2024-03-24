namespace Task_15._1___Series
{
    public class ArithProgression : ISeries
    {
        private int _stepValue;
        
        public int StartValue { get; private set; }
        public int CurrentValue { get; private set; }
        public int Step
        {
            get => _stepValue == default ? 1 : _stepValue;
            private set => _stepValue = value;
        }

        public void SetStart(int x)
        {
            StartValue = x;
            CurrentValue = x;
        }

        public int GetNext()
        {
            CurrentValue += Step;
            return CurrentValue;
        }

        public void Reset()
        {
            CurrentValue = StartValue;
        }

        public void SetStep(int step)
        {
            Step = step;
        }
    }
}