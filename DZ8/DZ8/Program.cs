using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculationLibrary;

namespace DZ8
{
    class Program
    {
        static void Main(string[] args)
        {

            double a, b, c, d, x, x1, x2;

            Console.WriteLine("Введите a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите c: ");
            c = Convert.ToDouble(Console.ReadLine());

            d = b * b - 4 * a * c;


            if (d < 0)
            {
                Console.WriteLine("Дискриминант меньше нуля. Корней нет.");
                Console.WriteLine("\nНажмите enter чтобы продолжить.");
            }
            if (d == 0)
            {
                x = -b / 2 * a;
                Console.WriteLine($"Дискриминант равен нулю. Корень равен {x}");
                Console.WriteLine("\nНажмите enter чтобы продолжить.");
            }
            if (d > 0)
            {

                x1 = (-b - Math.Sqrt(d)) / 2 * a;
                x2 = (-b + Math.Sqrt(d)) / 2 * a;
                Console.WriteLine($"Дискриминант равен {d}. Первый корень равен {x1}. Второй корень равен {x2}.");
                Console.WriteLine("\nНажмите enter чтобы продолжить.");
            }
            Console.ReadLine();
        }
    }
}
