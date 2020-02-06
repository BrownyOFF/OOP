using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x:");
            double x = double.Parse(Console.ReadLine());
            Console.Write("\nВведите y:");
            double y = double.Parse(Console.ReadLine());
            Console.Write("\nВведите z:");
            double z = double.Parse(Console.ReadLine());
            double s = (1 + Math.Sin(x + y)) / Math.Abs(z - (2 * x) / 1 + Math.Pow(x, 2) * Math.Pow(y, 2)) * Math.Pow(x, Math.Abs(y)) + Math.Tan(1 / z);
            Console.WriteLine("\nS = {0}", s);
            Console.ReadKey();
        }
    }
}