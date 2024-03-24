namespace Task_13._1___Building
{
    public class Building
    {
        private double _length;
        private double _width;
        private double _height;
        public string Address { get; set; }

        public double Length
        {
            get => _length;
            set
            {
                if (value < 0)
                {
                    value = 0;
                }

                _length = value;
            }
        }

        public double Width
        {
            get => _width;
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                
                _width = value;
            }
        }

        public double Height
        {
            get => _height;
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                
                _height = value;
            }
        }

        public Building(string address, double length, double width, double height)
        {
            Address = address;
            Length = length;
            Width = width;
            Height = height;
        }

        public string Print()
        {
            return $"Адрес: {Address}" +
                   $"\n\rДлина здания: {Length}" +
                   $"\n\rШирина здания: {Width}" +
                   $"\n\rВысота здания: {Height}";
        }
    }
}