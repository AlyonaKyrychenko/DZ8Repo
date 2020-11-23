using System;

namespace CalculationLibrary
{
    public class Calculation
    {
        private double A, B, C, d, x, x1, x2;
        public Calculation(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        public void Calculate ()
        {
            d = this.B * this.B - 4 * this.A * this.C;


            if (d < 0)
            {
                Console.WriteLine("Дискриминант меньше нуля. Корней нет.");
                Console.WriteLine("\nНажмите enter чтобы продолжить.");
            }
            if (d == 0)
            {
                x = -this.B / 2 * this.A;
                Console.WriteLine($"Дискриминант равен нулю. Корень равен {x}");
                Console.WriteLine("\nНажмите enter чтобы продолжить.");
            }
            if (d > 0)
            {

                x1 = (-this.B - Math.Sqrt(d)) / 2 * this.A;
                x2 = (-this.B + Math.Sqrt(d)) / 2 * this.A;
                Console.WriteLine($"Дискриминант равен {d}. Первый корень равен {x1}. Второй корень равен {x2}.");
                Console.WriteLine("\nНажмите enter чтобы продолжить.");
            }
            Console.ReadLine();
        }
    }
}
