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

                        double a = menu.GetDouble("Введите a: ");
                        double b = menu.GetDouble("Введите b: ");
                        double c = menu.GetDouble("Введите c: ");
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
