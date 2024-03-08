using System;

namespace Task_10._1___DegreesAndRadians
{
    /*Угол задан с помощью целочисленных значений gradus - градусов, min - угловых минут, sec - угловых секунд.
     Реализовать класс, в котором указанные значения представлены в виде свойств.
     Для свойств предусмотреть проверку корректности данных.
     Класс должен содержать конструктор для установки начальных значений,
     а также метод ToRadians для перевода угла в радианы. Создать объект на основе разработанного класса.
     Осуществить использование объекта в программе.*/
    
    public class AngularDegree
    {
        private int _degree;
        private int _minute;
        private int _second;
        
        public AngularDegree(int degree, int minute, int second)
        {
            Degree = degree;
            Minute = minute;
            Second = second;
        }
        
        public int Degree
        {
            get => _degree;
            set => _degree = (value % 360 + 360) % 360;
        }

        public int Minute
        {
            get => _minute;
            set
            {
                Degree += value / 60;
                _minute = (value % 60 + 60) % 60;
            }
        }

        public int Second
        {
            get => _second;
            set
            {
                Minute += value / 60;
                _second = (value % 60 + 60) % 60;
            }
        }

        public double ToRadians()
        {
            return (Degree + (double)Minute / 60 + (double)Second / 360) * (Math.PI / 180);
        }
    }
}