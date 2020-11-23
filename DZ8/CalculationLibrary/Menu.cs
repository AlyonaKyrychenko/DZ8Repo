using System;

namespace CalculationLibrary
{
    public class Menu
    {
        public double GetDouble(string prompt)
        {
            string input;
            double result;
            Console.Clear();
            Console.Write(prompt);
            while (true)
            {
                input = Console.ReadLine();
                try
                {
                    result = Double.Parse(input);
                    break;
                }
                catch
                {
                    Console.WriteLine("Не удалось распознать введенное число. Повторите ввод.");
                }
            }
            return result;
        }
        public int DoMenu(int variant)
        {
            int result;
            Console.Clear();
            Console.WriteLine("Выбирите действие:");
            Console.WriteLine("1 - новый рассчет.");
            Console.WriteLine("0 - выйти из программы.");

            while (true)
            {
                string input = Console.ReadLine();
                try
                {
                    int minMenuValue = 0;
                    int maxMenuValue = 2;
                    result = Int32.Parse(input);
                    if (result >= minMenuValue && result <= maxMenuValue)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Не удалось распознать введенное число. Повторите ввод.");
                    }
                }
                catch
                {
                    Console.WriteLine("Не удалось распознать введенное число. Повторите ввод.");
                }
            }
            return result;
        }
    }
}
