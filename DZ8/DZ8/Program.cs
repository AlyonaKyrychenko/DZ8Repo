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
                userChoice = menu.DoMenu();

                switch (userChoice)
                {
                    case 1:
                        float a = menu.GetFload("Введите a: ");
                        float b = menu.GetFload("Введите b: ");
                        float c = menu.GetFload("Введите c: ");
                        Calculation calculation = new Calculation(a, b, c);
                        calculation.Calculate();
                        break;
                    case 0:
                        exitApp = true;
                        break;
                }
            }
        }
    }
}
