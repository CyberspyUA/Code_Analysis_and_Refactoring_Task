using Product;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;

namespace UI
{
    internal static class Order
    {
        private static List<Drink> drinks; // Однозв'язний список, що містить замовлення користувача.
        private static int? totalOrders = 0; // Кількість незавершених замовлень користувача.
        private static int? completedOrders = 0; // Кількість завершених замовлень користувача.

        public static List<Drink> Drinks
        {
            get => drinks;
            set
            {
                drinks = value;
                drinks = new List<Drink>();
            }
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
        public static void RemoveElement(int key) // Видалення елементу за ключем у список.
        {
            Drinks.RemoveAt(key);
        }

        public static void AddElement(Drink drink) // Додання нового елементу до списку.
        {
            Drinks.Add(drink);
        }

        public static void OrderPreparation(int drinkTypeChoice, string drinkName, int cupSize, int sugarSpoons)
        {
            Drink drink;
            DrinkData data = new DrinkData
            {
                DrinkName = drinkName,
                CupSize = cupSize,
                SugarTeaSpoonsQuantity = sugarSpoons
            };
            switch (drinkTypeChoice)
            {
                case 1:
                    drink = new Coffee(data);
                    break;
                case 2:
                    drink = new Tea(data);
                    break;
                case 3:
                    drink = new Cacao(data);
                    break;
                default:
                    Console.WriteLine("Вибачте, ця варiант є недоступним. Спробуйте ще раз.");
                    return;
            }
            if (Drinks == null)
                Drinks = new List<Drink>();
            AddElement(drink); //Додати новий елемент до списку. Використовуємо CompletedOrders як ключ, а drink як значення.
            CompletedOrders++;
            // Перевiрка умови на кiлькiсть незавершених замовлень,
            if (CompletedOrders < TotalOrders) return; // якщо не всі замовлення оформлені - продовжуємо отримувати дані від користувача.
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
            foreach (Drink drink in drinks)
            {
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
            foreach (Drink drink in drinks)
            {
                drink.Brewing();
            }
            for (var indOnewayList = 0; indOnewayList < Drinks.Count; indOnewayList++)
                RemoveElement(indOnewayList);
        }
    }
}