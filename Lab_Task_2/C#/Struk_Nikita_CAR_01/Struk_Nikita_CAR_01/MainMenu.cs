using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struk_Nikita_CAR_01
{
    internal class MainMenu
    {
        /**
         * Метод, що викликає основне меню.
         * Є відправною точкою у взаємодії між користувачем та автоматом.
         */
        public static bool ShowMainMenu(int choice)
        {
            switch (choice)
            {
                case 1:
                {
                    InputInformation.ChooseDrink();
                    return false;
                }
                case 2:
                {
                    Console.WriteLine("-----------------------------------------------------------------");
                    DisplayInformation.ShowCoffeeOptions();
                    Console.WriteLine("-----------------------------------------------------------------");
                    DisplayInformation.ShowTeaOptions();
                    Console.WriteLine("-----------------------------------------------------------------");
                    DisplayInformation.ShowCacaoOptions();
                    Console.WriteLine("-----------------------------------------------------------------");
                    return false;
                }

                case 3:
                {
                    DisplayInformation.ShowInstructionsOptions();
                    return false;
                }
                case 4:
                {

                    Console.WriteLine("Ви впевнені в тому, що бажаєте завершити роботу застосунку? \n 1 - Так; 0 - Ні \n");
                    Console.WriteLine("Введіть варіант відповіді:");
                    var quitChoice = Convert.ToInt32(Console.ReadLine());
                    switch (quitChoice)
                    {
                        case 0:
                            return false;
                        case 1:
                            return true;
                        default:
                            Console.WriteLine("Вибачте, ця варіант є недоступним. Спробуйте ще раз.");
                            return false;
                    }
                }
                default:
                {
                    Console.WriteLine("Вибачте, але цей вибір є недійсним, спробуйте ще раз.");
                    return false;
                }
            }
        }
    }
}
