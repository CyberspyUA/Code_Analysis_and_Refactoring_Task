namespace Struk_Nikita_CAR_01
{
    internal class DisplayInformation
    {
        /**
         * Метод, що показує доступні варіанти взаємодії між користувачем та автоматом.
         */
        public static void ShowOptionsToChooseFrom()
        {
            Console.WriteLine("\t Будь ласка, введіть з клавіатури число від 1 до 4.");
            Console.WriteLine("\t Доступні варіанти:");
            Console.WriteLine("1) Оберіть напій");
            Console.WriteLine("2) Показати всі напої");
            Console.WriteLine("3) Показати меню довідки");
            Console.WriteLine("4) Завершити роботу застосунку");
        }
        /**
         * Метод, що демонструє доступний вибір серед кавових напоїв.
         */
        public static void ShowCoffeeOptions()
        {
            Console.WriteLine("Кава:");
            Console.WriteLine("\t1. Еспрессо");
            Console.WriteLine("\t2. Американо");
            Console.WriteLine("\t3. Капучіно");
        }
        /**
         * Метод, що демонструє доступний вибір серед чайних напоїв.
         */
        public static void ShowTeaOptions()
        {
            Console.WriteLine("Чай: ");
            Console.WriteLine("\t1. Чорний чай");
            Console.WriteLine("\t2. Зелений чай");
            Console.WriteLine("\t3. Червоний чай");
        }
        /**
         * Метод, що демонструє доступний вибір серед какао напоїв.
         */
        public static void ShowCacaoOptions()
        {
            Console.WriteLine("3) Какао: ");
            Console.WriteLine("\t1. Звичайне какао");
            Console.WriteLine("\t2. Пряне какао");
            Console.WriteLine("\t3. Гарячий шоколад");
        }

        /**
         * Метод, що описує роботу автомата.
         */
        public static void ShowInstructionsOptions()
        {
            Console.WriteLine("\t\tВітаємо вас! ");
            Console.WriteLine("\t Це помічник торгового автомата Struk.corp.");
            Console.WriteLine("\t По-перше, ми надамо вам меню напоїв. Ви можете вибрати один з них або відмовитися.");
            Console.WriteLine("\t Коли обрете напій, нам необхідно трохи часу, щоб приготувати його.");
            Console.WriteLine("\t Це займає від 10 до 15 секунд.");
            Console.WriteLine("\t Додатково, ми пропонуємо цукор до замовлення.");
            Console.WriteLine("\t Якщо у вас залишилися питання, введіть 5 для повторного виведення цієї довідки.");
        }
        /**
         * Метод, що демонструє доступний вибір розміру стаканів.
         */
        public static void ShowCupSizeOptions()
        {
            Console.WriteLine("Оберіть серед запропонованих:");
            Console.WriteLine("1) 100 мл");
            Console.WriteLine("2) 200 мл");
            Console.WriteLine("3) 300 мл");
        }
    }
}
