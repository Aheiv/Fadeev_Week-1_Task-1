using System;

namespace Лаб1УП
{
    class Program
    {
        static void Main(string[] args)
        {
            double v;
            double a;
            Console.Write("v = ");
            while (!double.TryParse(Console.ReadLine(), out v) || v <= 0)
                Console.WriteLine("Введённое значение не является числом или <= 0");
            a = Math.Cbrt(v);
            Console.WriteLine("Ребро куба равно " + a);
        }
    }
}
