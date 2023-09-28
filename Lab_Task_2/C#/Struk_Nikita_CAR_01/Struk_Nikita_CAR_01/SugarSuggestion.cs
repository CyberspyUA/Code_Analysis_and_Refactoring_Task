namespace UI
{
    internal static class SugarSuggestion
    {
        /**
         * Метод, що пропонує користувачевi цукор.
         * Якщо користувач згоден, викликається метод CalculateSugarSpoonsQuantity().
         */
        public static bool IsSugarNeeded()
        {
            Console.WriteLine("Вам потрiбен цукор?");
            Console.WriteLine("1 - Так; 0 - Нi");
            var isSugarNeededConfirmation = Convert.ToInt32(Console.ReadLine());
            return isSugarNeededConfirmation != 0;
        }
        /**
         * Метод, що викликається у разi, якщо користувач бажає цукру.
         * Додає певну кiлькiсть ложок цукру
         */
        public static int CalculateSugarSpoonsQuantity()
        {
            var teaSpoon = 1;
            var isThatEnough = false;
            while (!isThatEnough)
            {
                Console.WriteLine("До напою додано " + teaSpoon + " чайних ложок цукру.");
                Console.WriteLine("Бiльше цукру?");
                Console.WriteLine("1 - Так; 0 - Нi");
                var moreSugarChoice = Convert.ToBoolean(Console.ReadLine());
                if (moreSugarChoice)
                {
                    teaSpoon++;
                }
                else
                {
                    isThatEnough = true;
                }
            }

            return teaSpoon;
        }
    }
}
