using Product;
namespace UI
{
    internal static class DrinkOrder
    {
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
            ShowOrderDetails(drink);
            BrewOrder(drink);
        }
        /**
         * Метод, що приховує делегування методу OrderShow класу Drink.
         * Виводить повну інформацію щодо замовлення.
         */
        public static void ShowOrderDetails(this Drink drink)
        {
            Console.WriteLine("Ваше замовлення");
            Console.WriteLine("-----------------------------------------------------------------");
            drink.OrderShow();
            Console.WriteLine("Очiкуйте на завершення приготування " + drink.GetDrinkName());
        }
        /**
         * Метод, що приховує делегування методу BrewOrder класу Drink.
         * Виконує процес приготування напою.
         */
        public static void BrewOrder(this Drink drink)
        {
            drink.Brewing();
        }
    }
}
