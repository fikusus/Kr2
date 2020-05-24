using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kr2
{
    class Circle:IFigure
    {
        public String Name { get; private set; }

        private double r;

        public Circle()
        {
            Name = "Circle";
            r = 0;
        }

        public Circle(string name, double r)
        {
            Name = name ?? "Circle";
            R = r;
        }

        public double R
        {
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Для фигури " + Name + " Значение радиуса < 0, принято r = 0");
                    r = 0;
                }
                else
                {
                    r = value;
                }
            }
            get { return r; }
        }


        public double CalculatePerimeter()
        {
            return 2 * Math.PI * r;
        }

        public double CalculateSquare()
        {
            return Math.PI * Math.Pow(r, 2);
        }

        public override string ToString()
        {
            return "Круг под именем:" + Name + " с радиусом:" + r ;
        }
    }
}
