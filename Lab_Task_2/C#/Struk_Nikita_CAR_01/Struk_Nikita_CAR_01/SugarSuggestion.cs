namespace Struk_Nikita_CAR_01
{
    internal class SugarSuggestion
    {
        /**
         * Метод, що пропонує користувачеві цукор.
         * Якщо користувач згоден, викликається метод CalculateSugarSpoonsQuantity().
         */
        public static bool IsSugarNeeded()
        {
            Console.WriteLine("Вам потрібен цукор?");
            Console.WriteLine("1 - Так; 0 - Ні");
            var isSugarNeededConfirmation = Convert.ToInt32(Console.ReadLine());
            return isSugarNeededConfirmation != 0;
        }
        /**
         * Метод, що викликається у разі, якщо користувач бажає цукру.
         * Додає певну кількість ложок цукру
         */
        public static int CalculateSugarSpoonsQuantity()
        {
            var teaSpoon = 1;
            var isThatEnough = false;
            while (!isThatEnough)
            {
                Console.WriteLine("До напою додано " + teaSpoon + " чайних ложок цукру.");
                Console.WriteLine("Більше цукру?");
                Console.WriteLine("1 - Так; 0 - Ні");
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
