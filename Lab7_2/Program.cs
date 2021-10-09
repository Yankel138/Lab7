using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ребро куба:");
            double rebro = Convert.ToDouble(Console.ReadLine());
            Cube(rebro);
            Console.ReadKey();
        }

        static void Cube(double a)
        {
            double V = Math.Pow(a, 3);   
            double S = (Math.Pow(a, 2))*6;
            Console.WriteLine("Объем куба: {0:f2};\nПлощадь поверхности куба: {1:f2}",V,S);

        }
    }
}
