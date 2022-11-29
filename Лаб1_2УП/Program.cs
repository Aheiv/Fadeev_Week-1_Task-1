using System;

namespace Лаб1_2УП
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Введите двузначное число: ");
            while (!int.TryParse(Console.ReadLine(), out a) || a < 10 || a > 99)
                Console.WriteLine("Введённое значение не является числом или двузначным числом");
            int n = (a / 10 + a % 10);
            Console.WriteLine("Сумма цифр в этом числе: " + n);
            if (n % 2 != 0)
            Console.WriteLine("Является");
            else Console.WriteLine("Не является");
        }
    }
}
