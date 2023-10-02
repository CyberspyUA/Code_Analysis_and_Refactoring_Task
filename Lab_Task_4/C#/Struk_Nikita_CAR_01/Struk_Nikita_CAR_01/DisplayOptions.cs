namespace UI
{
    internal static class DisplayOptions
    {
        /**
         * Метод, що показує доступнi варiанти взаємодiї мiж користувачем та автоматом.
         */
        public static void ShowMainMenuOptions()
        {
            Console.WriteLine("\t Будь ласка, введiть з клавiатури число вiд 1 до 4.");
            Console.WriteLine("\t Доступнi варiанти:");
            Console.WriteLine("1) Оберiть напiй");
            Console.WriteLine("2) Показати всi напої");
            Console.WriteLine("3) Показати меню довiдки");
            Console.WriteLine("4) Завершити роботу застосунку");
        }
        /**
         * Метод, що демонструє доступний вибiр серед кавових напоїв.
         */
        public static void ShowCoffeeOptions()
        {
            Console.WriteLine("Кава:");
            Console.WriteLine("\t1. Еспрессо");
            Console.WriteLine("\t2. Американо");
            Console.WriteLine("\t3. Капучiно");
        }
        /**
         * Метод, що демонструє доступний вибiр серед чайних напоїв.
         */
        public static void ShowTeaOptions()
        {
            Console.WriteLine("Чай: ");
            Console.WriteLine("\t1. Чорний чай");
            Console.WriteLine("\t2. Зелений чай");
            Console.WriteLine("\t3. Червоний чай");
        }
        /**
         * Метод, що демонструє доступний вибiр серед какао напоїв.
         */
        public static void ShowCacaoOptions()
        {
            Console.WriteLine("3) Какао: ");
            Console.WriteLine("\t1. Звичайне какао");
            Console.WriteLine("\t2. Пряне какао");
            Console.WriteLine("\t3. Гарячий шоколад");
        }
        /**
         * Метод, що демонструє доступний вибiр розмiру стаканiв.
         */
        public static void ShowCupSizeOptions()
        {
            Console.WriteLine("Оберiть серед запропонованих:");
            Console.WriteLine("1) 100 мл");
            Console.WriteLine("2) 200 мл");
            Console.WriteLine("3) 300 мл");
        }
    }
}
