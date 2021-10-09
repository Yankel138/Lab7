using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны двух треугольников(x,y,z):");
            Console.Write("x1 = ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1 = ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("z1 = ");
            double z1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x2 = ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2 = ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("z2 = ");
            double z2 = Convert.ToDouble(Console.ReadLine());

            double s1 = CalcSquare(x1, y1, z1);
            double s2 = CalcSquare(x2, y2, z2);


            if ((x1 + y1 <= z1) || (x1 + z1 <= y1) || (z1 + y1 <= x1))
            {
                Console.WriteLine("Ошибка. Ваш первый треугольник вовсе не треугольник!");
            }
            else if ((x2 + y2 <= z2) || (x2 + z2 <= y2) || (z2 + y2 <= x2))
            {
                Console.WriteLine("Ошибка. Ваш второй треугольник вовсе не треугольник!");
            }

            else if (s1 > s2)
            {
                Console.WriteLine("Площадь первого треугольника ({0:f2}) больше площади второго треугольника ({1:f2}).", s1, s2);
            }
            else if (s1 < s2)
            {
                Console.WriteLine("Площадь первого треугольника ({0:f2}) меньше площади второго треугольника ({1:f2}).", s1, s2);
            }
            else
            {
                Console.WriteLine("Площадь первого треугольника равна площади второго треугольника ({0})", s1);
            }
            Console.ReadKey();
        }

        static double CalcSquare(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return s;
        }


    }
}
