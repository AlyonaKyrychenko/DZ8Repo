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

            Menu menu = new Menu();
            int userChoice;
            bool exitApp = false;

            while (!exitApp)
            {
                userChoice = menu.DoMenu(0);

                switch (userChoice)
                {
                    case 1:
                        double d, x, x1, x2;
                        double a = menu.GetDouble("Введите a: ");
                        double b = menu.GetDouble("Введите b: ");
                        double c = menu.GetDouble("Введите c: ");

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
                        break;

                    case 0:
                        exitApp = true;
                        break;
                }
            }
        }
    }
}
