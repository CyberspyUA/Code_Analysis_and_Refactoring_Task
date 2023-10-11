namespace UI
{
    internal static class MainMenu
    {
        /**
         * Метод, що бере метод із класу-обгортки MainMenuExtensions
         */
        private static void ShowOptions()
        {
            MainMenuExtensions.DisplayOptions();
        }
        /**
         * Метод, що викликає основне меню.
         * Є вiдправною точкою у взаємодiї мiж користувачем та автоматом.
         */
        public static bool ShowMainMenu(int choice)
        {
            switch (choice)
            {
                case 1:
                {
                    DrinkInputInformation.ChooseDrink();
                    return false;
                }
                case 2:
                {
                    ShowOptions();
                    return false;
                }

                case 3:
                {
                    DisplayInfo.ShowInstructionsOptions();
                    return false;
                }
                case 4:
                {

                    Console.WriteLine("Ви впевненi в тому, що бажаєте завершити роботу застосунку? \n 1 - Так; 0 - Нi \n");
                    Console.WriteLine("Введiть варiант вiдповiдi:");
                    var quitChoice = Convert.ToInt32(Console.ReadLine());
                    switch (quitChoice)
                    {
                        case 0:
                            return false;
                        case 1:
                            return true;
                        default:
                            Console.WriteLine("Вибачте, ця варiант є недоступним. Спробуйте ще раз.");
                            return false;
                    }
                }
                default:
                {
                    Console.WriteLine("Вибачте, але цей вибiр є недiйсним, спробуйте ще раз.");
                    return false;
                }
            }
        }
    }
    public static class MainMenuExtensions
    {
        /**
         * Метод, що викликає доступні вибори напоїв на даний момент.
         */
        public static void DisplayOptions()
        {
            Console.WriteLine("-----------------------------------------------------------------");
            DisplayInfo.ShowCoffeeOptions();
            Console.WriteLine("-----------------------------------------------------------------");
            DisplayInfo.ShowTeaOptions();
            Console.WriteLine("-----------------------------------------------------------------");
            DisplayInfo.ShowCacaoOptions();
            Console.WriteLine("-----------------------------------------------------------------");
        }
    }
}
