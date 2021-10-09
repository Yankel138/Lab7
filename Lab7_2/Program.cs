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
            Cube();
        }

        static void Cube()
        {
            Console.Write("Введите ребро куба:");
            double a = Convert.ToDouble(Console.ReadLine());
            double V = Math.Pow(a, 3);
            double S = (Math.Pow(a, 2)) * 6;
            Console.WriteLine("Объем куба: {0:f2};\nПлощадь поверхности куба: {1:f2}", V, S);
            Console.ReadKey();
        }
    }
}
