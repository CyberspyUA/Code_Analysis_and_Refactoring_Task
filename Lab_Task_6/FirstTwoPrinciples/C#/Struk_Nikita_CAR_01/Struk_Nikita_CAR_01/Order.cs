using Product;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;

namespace UI
{
    internal static class Order
    {
        private static Hashtable? drinkOrders; // Хеш-таблиця, що мiстить пронумерованi замовлення, зробленi користувачем.
        private static int? totalOrders = 0; // Кількість незавершених замовлень користувача.
        private static int? completedOrders = 0; // Кількість завершених замовлень користувача.

        public static Hashtable? DrinkOrdersHashtable
        {
            get => drinkOrders;
            set => drinkOrders = value;
        }

        public static int? TotalOrders
        {
            get => totalOrders;
            set => totalOrders = value;
        }

        public static int CompletedOrders
        {
            get => (int)completedOrders!;
            set => completedOrders = value;
        }
        public static void RemoveElementAtKey(int key) // Видалення елементу за ключем у хеш-таблицi.
        {
            if (drinkOrders != null && drinkOrders.ContainsKey(key))
                drinkOrders.Remove(key);
        }

        public static void AddElement(int key, Drink drink) // Додання нового елементу до хеш-таблицi.
        {
            drinkOrders?.Add(key, drink);
        }
        public static Drink GetElementAtKey(int key) // Отримати значення за вiдповiдним ключем.
        {
            if(drinkOrders != null && drinkOrders.ContainsKey(key))
                return (Drink)drinkOrders[key];
            return null;
        }

        public static void OrderPreparation(int drinkTypeChoice, string drinkName, int cupSize, int sugarSpoons)
        {
            Drink drink;

            switch (drinkTypeChoice)
            {
                case 1:
                    drink = new Coffee(drinkName, cupSize, sugarSpoons);
                    break;
                case 2:
                    drink = new Tea(drinkName, cupSize, sugarSpoons);
                    break;
                case 3:
                    drink = new Cacao(drinkName, cupSize, sugarSpoons);
                    break;
                default:
                    Console.WriteLine("Вибачте, ця варiант є недоступним. Спробуйте ще раз.");
                    return;
            }
            DrinkOrdersHashtable ??= new Hashtable();
            AddElement(CompletedOrders, drink); //Додати новий елемент до хеш-таблиці. Використовуємо CompletedOrders як ключ, а drink як значення.
            CompletedOrders++;
            // Перевiрка умови на кiлькiсть незавершених замовлень,
            if (CompletedOrders < TotalOrders ) return; // якщо не всі замовлення оформлені - продовжуємо отримувати дані від користувача.
            ShowOrderDetails();
            BrewOrder();

        }
        /**
         * Метод, що приховує делегування методу OrderShow класу Drink.
         * Виводить повну iнформацiю щодо замовлення.
         */
        public static void ShowOrderDetails()
        {
            Console.WriteLine("Ваше замовлення");
            Console.WriteLine("-----------------------------------------------------------------");
            for (var indHashtable = 0; indHashtable < TotalOrders; indHashtable++)
            {
                Drink? drink = GetElementAtKey(indHashtable); // Отримати значення елементу за ключем.
                
                drink.OrderShow();
                Console.WriteLine("");
            }
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("Очiкуйте на завершення приготування замовлення!");
        }
        /**
         * Метод, що приховує делегування методу BrewOrder класу Drink.
         * Виконує процес приготування напою.
         */
        public static void BrewOrder()
        {
            for (var indHashtable = 0; indHashtable < TotalOrders; indHashtable++)
            {
                
                var drinkCopy = GetElementAtKey(indHashtable);
                drinkCopy.Brewing();
            }
            for (var indHashtable = 0; indHashtable < TotalOrders; indHashtable++)
                RemoveElementAtKey(indHashtable);
        }
    }
}
