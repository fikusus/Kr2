using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kr2
{
    class Rectangle : IFigure
    {
        public String Name { get;private set; }

        private double aSide;
        private double bSide;

        public Rectangle()
        {
            Name = "Rectangle";
            aSide = 0;
            bSide = 0;
        }

        public Rectangle(string name, double aSide, double bSide)
        {
            Name = name ?? "Rectangle";
            ASide = aSide;
            BSide = bSide;
        }

        public double ASide {
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Для фигури " + Name  + " Значение стороны a < 0, принято a = 0");
                    aSide = 0;
                }
                else
                {
                    aSide = value;
                }
            }
            get { return aSide; }
        }

        public double BSide
        {
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Для фигури " + Name + " Значение стороны b < 0, принято b = 0");
                    bSide = 0;
                }
                else
                {
                    bSide = value;
                }
            }
            get { return bSide; }
        }

        public double CalculatePerimeter()
        {
            return 2 * (aSide + bSide);
        }

        public double CalculateSquare()
        {
            return aSide * bSide;
        }

        public override string ToString()
        {
            return "Прямоугольник под именем:" + Name + " со стороной а:" + aSide + " b:" + bSide;
        }

    }
}
