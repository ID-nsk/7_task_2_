using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Laba4
{
    class Program
    {
        // Метод для вычисления объема и площади поверхности куба по длине его ребра.
        static void CubeVS(double a)
        {
            double v = Math.Pow(a, 3);
            double s = (Math.Pow(a, 2)) * 6;
            Console.WriteLine($"Площадь куба = {s}");
            Console.WriteLine($"Объём куба = {v}");
        }
        static void Main(string[] args)
        {
            Console.Write("Введите значение ребра куба: ");
            double a = Convert.ToDouble(Console.ReadLine());
            CubeVS(a);
            Console.ReadKey();
        }
    }
}