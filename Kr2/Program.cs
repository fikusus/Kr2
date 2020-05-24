using System;
using System.Collections.Generic;
using System.IO;


namespace Kr2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<IFigure> figures = new List<IFigure>();
            figures.Add(new Circle());
            figures.Add(new Rectangle());
            figures.Add(new Circle("Ciecle2", random.Next(-2, 10)));
            figures.Add(new Rectangle("Rectangle2", random.Next(-2, 10), random.Next(-2, 10)));
            Console.WriteLine("Все фигури до изменения");
            PrintAllList(figures);
            Console.WriteLine("\n Для " + (figures[0] as Circle).Name + " меняем параметри");
            (figures[0] as Circle).R = random.Next(10, 20);
            Console.WriteLine("\n Для " + (figures[1] as Rectangle).Name + " меняем параметри");
            (figures[1] as Rectangle).ASide = random.Next(10, 20);
            (figures[1] as Rectangle).BSide = random.Next(10, 20);
            Console.WriteLine("\nВсе фигури после изменения");
            PrintAllList(figures);
            SaveInFile(figures, "out.txt");
            Console.ReadKey();
        }


        static void PrintAllList(List<IFigure> figures)
        {
            foreach (IFigure item in figures)
            {
                Console.WriteLine(item + ". Периметр = " + item.CalculatePerimeter() + ", площадь = " + item.CalculateSquare());
            }
        }

        static void SaveInFile(List<IFigure> figures, String filename)
        {
            Console.WriteLine("Запись в файл");
            try
            {
                using (StreamWriter sw = new StreamWriter(filename, false, System.Text.Encoding.Default))
                {
                    foreach (IFigure item in figures)
                    {
                        sw.WriteLine(item + ". Периметр = " + item.CalculatePerimeter() + ", площадь = " + item.CalculateSquare());
                    }
                }

                Console.WriteLine("Запись выполнена");
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка записи");
            }
        }
    }
}
